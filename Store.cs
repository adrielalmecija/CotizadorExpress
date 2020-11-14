using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress
{
    class Store
    {
        private String store_name = "Clothes Master Race";
        private String store_adress = "San Martin 404 - Tyan";
        private ArrayList available_clothes = new ArrayList();

        //getters & setters
        public ArrayList Available_clothes { get => available_clothes;}
        public string Store_adress { get => store_adress;}
        public string Store_name { get => store_name; }


        //constructor
        public Store()
        {
            stockGenerator();
        }

        //methods
        private void stockGenerator()
        {
            Shirt shirtShortMao = new Shirt(1, 1, 200, true, true);
            available_clothes.Add(shirtShortMao);

            Shirt shirtShortCommon = new Shirt(1, 1, 300, false, true);
            available_clothes.Add(shirtShortCommon);

            Shirt shirtLongMao = new Shirt(1, 1, 150, true, false);
            available_clothes.Add(shirtLongMao);

            Shirt shirtLongCommon = new Shirt(1, 1, 350, false, false);
            available_clothes.Add(shirtLongCommon);

            Pant pantNotCommon = new Pant(1, 1, 1500, false);
            available_clothes.Add(pantNotCommon);

            Pant pantCommon = new Pant(1, 1, 500, true);
            available_clothes.Add(pantCommon);
        }
    }


}
