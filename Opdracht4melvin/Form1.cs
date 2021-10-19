using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Collections.Generic;

namespace Opdracht4melvin
{
    public partial class Form1 : Form
    {
        public delegate void Toon(Object list);

        Stapel<TeDoen> list = new Stapel<TeDoen>();
        private List<System.Timers.Timer> Timers = new List<System.Timers.Timer>();
        private List<TeDoen> getimed = new List<TeDoen>();
        private List<DateTime> TimeOnly = new List<DateTime>();
        System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
        }


        private void tijdchexbox_CheckedChanged(object sender, EventArgs e)
        {
            if (tijdchexbox.Checked == true)
            {
                dateTimePicker.Visible = true;
            }
            else
            {
                dateTimePicker.Visible = false;
            }
        }

        private void opslaan_Click(object sender, EventArgs e)
        {
            if (tijdchexbox.Checked == true)
            {
                if (dateTimePicker.Value > DateTime.Now)
                {
                    TeDoen teDoen = new TeDoen(dateTimePicker.Value, title.Text, inhoud.Lines);
                    getimed.Add(teDoen);
                    TimeOnly.Add(dateTimePicker.Value);
                    InitTimer();
                    title.Text = "";
                    inhoud.Text = "";
                }
                else
                {
                    MessageBox.Show("ERROR!!!! JOUW INGEGEVEN DATUM IS KLIJNER DAN GEVRAAGD!!!!");
                }
            }
            else
            {
                list.Toevoegen(new TeDoen(title.Text, inhoud.Lines));
                title.Text = "";
                inhoud.Text = "";
            }
            dateTimePicker.Value = DateTime.Now;
        }

        public void InitTimer()
        {
            timer = new System.Timers.Timer(DoeWachttijd());
            timer.Elapsed += needed_Tick;
            timer.AutoReset = false;
            timer.Start();
            Timers.Add(timer);
        }

        private void needed_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < getimed.Count; i++)
            {
                if (TimeOnly[i] <= DateTime.Now)
                {
                    list.ToonMij(getimed[i]);
                    getimed.RemoveAt(i);
                    TimeOnly.RemoveAt(i);
                }
            }
        }

        public int DoeWachttijd()
        {
            TimeSpan wachttijd = dateTimePicker.Value - DateTime.Now;
            System.Threading.Thread.Sleep((int) wachttijd.TotalMinutes);
            return (int) wachttijd.TotalMilliseconds;
        }

        private void volgendeTaak_Click(object sender, EventArgs e)
        {
            string toon = list.Toon();
            if (toon != "")
            {
                MessageBox.Show(toon);
            }
        }

        private void verwijderTaak_Click(object sender, EventArgs e)
        {
             list.Verwijderen();
        }

        private void zetAchteraan_Click(object sender, EventArgs e)
        {
            list.ZetAchteraan();
            string toon = list.Toon();
        }

        public void ToonInMessage(Object lijst)
        {
            MessageBox.Show(lijst.ToString());
        }

        public void ToonInInfo(Object lijst)
        {
            eventueleMededeling.Text = lijst.ToString();
        }

        private void messageBox_Click(object sender, EventArgs e)
        {
            if (messageBox.Text == "ON")
            {
                messageBox.Text = "OFF";
                messageBox.BackColor = System.Drawing.Color.Red;
                list.listAndersGetoond -= new Toon(ToonInMessage);
            }
            else
            {
                messageBox.Text = "ON";
                messageBox.BackColor = System.Drawing.Color.Green;
                list.listAndersGetoond += new Toon(ToonInMessage);
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            if (info.Text == "ON")
            {
                info.Text = "OFF";
                info.BackColor = System.Drawing.Color.Red;
                eventueleMededeling.Text = "";
                list.listAndersGetoond -= new Toon(ToonInInfo);
            }
            else
            {
                info.Text = "ON";
                info.BackColor = System.Drawing.Color.Green;
                list.listAndersGetoond += new Toon(ToonInInfo);
            }
        }
    }
}
