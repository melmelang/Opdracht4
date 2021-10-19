using System;
using System.Collections.Generic;
using static Opdracht4melvin.Form1;

namespace Opdracht4melvin
{
    

    internal class Stapel<T>
    {
        private List<T> List = new();
        private List<T> ListCopy = new();
        private static int counter;
        public event Toon listAndersGetoond;

        public void ToonMij(Object lijst)
        {

            if (listAndersGetoond != null)
                listAndersGetoond(lijst);

        }

        public void Toevoegen(T ToeTeVoegen)
        {
            List.Add(ToeTeVoegen);
            ToonMij(ToeTeVoegen);
        }

        public void Verwijderen()
        {
            if (List.Count <= 0)
            {
                throw new ArgumentNullException();
            }
            
            T dingen = List[0];
            List.RemoveAt(0);

            if (counter > 0)
            {
                counter--;
            }

            ToonMij(dingen);
        }

        public void ZetAchteraan()
        {
            if (List.Count <= 0)
            {
                throw new ArgumentNullException();
            }

            T dingen = List[counter - 1];
            List.RemoveAt(counter - 1);
            List.Add(dingen);
            counter--;

            ToonMij(dingen);
        }

        public string Toon()
        {
            
            if (List.Count > 0 && List.Count > counter)
            {
                counter++;
                ToonMij(List[counter - 1]);
                return "";
            }
            else if (List.Count < counter)
            {
                return "Einde van de list";
            }
            else
            {
                return "De list is leeg.";
            }
            
        }

        public void Leegmaken()
        {
            List.Clear();
        }

        public override string ToString()
        {
            string Listing = "";
            foreach (T t in List)
            {
                Listing += t.ToString() + "; ";
            }

            return Listing;
        }

        public bool IsEmpty(T TeZoeken)
        {
            if (List == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<T> StapelCopy()
        {
            ListCopy = List.GetRange(0, List.Count); ;
            return ListCopy;
        }
    }

    internal class TeDoen
    {
        private int Id { get; set; }
        private static int counter;
        private DateTime? Tijdsstip { get; set; }
        private string Title { get; set; }
        private string[] Informatie;
        public event Toon look;

        public TeDoen(DateTime tijdsstip, string title, string[] beschrijving)
        {
            counter++;
            Id = counter;
            if (tijdsstip >= DateTime.Now)
            {
                Tijdsstip = tijdsstip;
            }
            else
            {
                Tijdsstip = null;
            }

            Title = title;
            Informatie = beschrijving;
        }

        public TeDoen(string title, string[] beschrijving)
        {
            counter++;
            Id = counter;
            Tijdsstip = null;
            Title = title;
            Informatie = beschrijving;
        }
        public TeDoen()
        {
        }

        public override string ToString()
        {
            string info = "";
            foreach (string s in Informatie)
                info += "    -" + s.ToString() + "\n";

            if (Tijdsstip != null)
            {
                return "Id: " + Id + "\n | Tijdsstip: " + Tijdsstip + "\n | Title: " + Title + "\n | Informatie: \n" + info;
            }
            else
            {
                return "Id: " + Id +  "\n | Title: " + Title + "\n | Informatie: \n" + info;
            }
            
        }

        

    }

}
