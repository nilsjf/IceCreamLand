using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamLand
{
    class BestellPosition
    {
        private int anzahl;

        public int Anzahl
        {
            get { return anzahl; }
            set
            {
                if (value > 0) anzahl = value;
                else throw new ArgumentException("Anzahl muss mind. 1 sein!");
            }
        }

        public int PositionsNr { get; set; }

        public double ServiceKostenInEuro
        {
            get { return Anzahl * 0.5; }
        }

        public BestellPosition(int anzahl)
        {
            Anzahl = anzahl;
        }
    }
}
