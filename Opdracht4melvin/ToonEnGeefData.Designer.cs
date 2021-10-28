using System.Windows.Forms;

namespace Opdracht4melvin
{
    partial class ToonEnGeefData
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tijdchexbox = new System.Windows.Forms.CheckBox();
            this.title = new System.Windows.Forms.TextBox();
            this.inhoud = new System.Windows.Forms.TextBox();
            this.opslaan = new System.Windows.Forms.Button();
            this.volgendeTaak = new System.Windows.Forms.Button();
            this.verwijderTaak = new System.Windows.Forms.Button();
            this.zetAchteraan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.eventueleMededeling = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.needed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "inhoud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(51, 306);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(220, 27);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Visible = false;
            // 
            // tijdchexbox
            // 
            this.tijdchexbox.AutoSize = true;
            this.tijdchexbox.Location = new System.Drawing.Point(138, 273);
            this.tijdchexbox.Name = "tijdchexbox";
            this.tijdchexbox.Size = new System.Drawing.Size(53, 24);
            this.tijdchexbox.TabIndex = 5;
            this.tijdchexbox.Text = "tijd";
            this.tijdchexbox.UseVisualStyleBackColor = true;
            this.tijdchexbox.CheckedChanged += new System.EventHandler(this.tijdchexbox_CheckedChanged);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(51, 131);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(220, 27);
            this.title.TabIndex = 6;
            // 
            // inhoud
            // 
            this.inhoud.Location = new System.Drawing.Point(51, 194);
            this.inhoud.Multiline = true;
            this.inhoud.Name = "inhoud";
            this.inhoud.Size = new System.Drawing.Size(220, 73);
            this.inhoud.TabIndex = 7;
            // 
            // opslaan
            // 
            this.opslaan.Location = new System.Drawing.Point(111, 372);
            this.opslaan.Name = "opslaan";
            this.opslaan.Size = new System.Drawing.Size(94, 29);
            this.opslaan.TabIndex = 8;
            this.opslaan.Text = "opslaan";
            this.opslaan.UseVisualStyleBackColor = true;
            this.opslaan.Click += new System.EventHandler(this.opslaan_Click);
            // 
            // volgendeTaak
            // 
            this.volgendeTaak.Location = new System.Drawing.Point(378, 317);
            this.volgendeTaak.Name = "volgendeTaak";
            this.volgendeTaak.Size = new System.Drawing.Size(145, 29);
            this.volgendeTaak.TabIndex = 9;
            this.volgendeTaak.Text = "volgende taak";
            this.volgendeTaak.UseVisualStyleBackColor = true;
            this.volgendeTaak.Click += new System.EventHandler(this.volgendeTaak_Click);
            // 
            // verwijderTaak
            // 
            this.verwijderTaak.Location = new System.Drawing.Point(587, 317);
            this.verwijderTaak.Name = "verwijderTaak";
            this.verwijderTaak.Size = new System.Drawing.Size(145, 29);
            this.verwijderTaak.TabIndex = 10;
            this.verwijderTaak.Text = "verwijder taak";
            this.verwijderTaak.UseVisualStyleBackColor = true;
            this.verwijderTaak.Click += new System.EventHandler(this.verwijderTaak_Click);
            // 
            // zetAchteraan
            // 
            this.zetAchteraan.Location = new System.Drawing.Point(790, 317);
            this.zetAchteraan.Name = "zetAchteraan";
            this.zetAchteraan.Size = new System.Drawing.Size(145, 29);
            this.zetAchteraan.TabIndex = 11;
            this.zetAchteraan.Text = "zet achteraan";
            this.zetAchteraan.UseVisualStyleBackColor = true;
            this.zetAchteraan.Click += new System.EventHandler(this.zetAchteraan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "informatie venster";
            // 
            // eventueleMededeling
            // 
            this.eventueleMededeling.Location = new System.Drawing.Point(378, 131);
            this.eventueleMededeling.Multiline = true;
            this.eventueleMededeling.Name = "eventueleMededeling";
            this.eventueleMededeling.Size = new System.Drawing.Size(557, 161);
            this.eventueleMededeling.TabIndex = 13;
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.Red;
            this.messageBox.Location = new System.Drawing.Point(479, 368);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(81, 29);
            this.messageBox.TabIndex = 14;
            this.messageBox.Text = "OFF";
            this.messageBox.UseVisualStyleBackColor = false;
            this.messageBox.Click += new System.EventHandler(this.messageBox_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Red;
            this.info.Location = new System.Drawing.Point(773, 368);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(81, 29);
            this.info.TabIndex = 15;
            this.info.Text = "OFF";
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "message box";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(638, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "informatie venster";
            // 
            // needed
            // 
            this.needed.AutoSize = true;
            this.needed.Location = new System.Drawing.Point(452, 41);
            this.needed.Name = "needed";
            this.needed.Size = new System.Drawing.Size(0, 20);
            this.needed.TabIndex = 18;
            this.needed.Click += new System.EventHandler(this.needed_Tick);
            // 
            // ToonEnGeefData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 454);
            this.Controls.Add(this.needed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.info);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.eventueleMededeling);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zetAchteraan);
            this.Controls.Add(this.verwijderTaak);
            this.Controls.Add(this.volgendeTaak);
            this.Controls.Add(this.opslaan);
            this.Controls.Add(this.inhoud);
            this.Controls.Add(this.title);
            this.Controls.Add(this.tijdchexbox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ToonEnGeefData";
            this.Text = "ToonEnGeefData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox tijdchexbox;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox inhoud;
        private System.Windows.Forms.Button opslaan;
        private System.Windows.Forms.Button volgendeTaak;
        private System.Windows.Forms.Button verwijderTaak;
        private System.Windows.Forms.Button zetAchteraan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eventueleMededeling;
        private System.Windows.Forms.Button messageBox;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private Label needed;
    }
}

