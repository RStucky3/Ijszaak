using System;
using System.Collections.Generic;
using System.Text;

namespace IJscozaak
{
    class Bestellingen
    {
        int BolletjeOfHoorntje;
        int[] ijsbolKeuze;
        int toppings;

        //Bolletje of hoorntje
        public int getKeuzeBolletjeOfHoorntje()
        {
            return this.BolletjeOfHoorntje;
        }

        public void setKeuzeBolletjeOfHoorntje(int keuzeBolletjeOfHoorntje)
        {
            this.BolletjeOfHoorntje = keuzeBolletjeOfHoorntje;
        }

        //ijsbol keuze
        public int[] getIjsbolKeuze()
        {
            return this.ijsbolKeuze;
        }

        public void setIjsbolkeuze()
        {

        }

        //toppings keuze
        public int getToppingKeuze()
        {
            return this.toppings;
        }

        public void SetToppingsKeuze()
        {

        }
    }
}
