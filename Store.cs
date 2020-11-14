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
        private ArrayList shirts_stock = new ArrayList();
        private ArrayList pants_stock = new ArrayList();

        //getters & setters
        
        public string Store_adress { get => store_adress;}
        public string Store_name { get => store_name; }
        public ArrayList Pants_stock { get => pants_stock; }
        public ArrayList Shirts_stock { get => shirts_stock; }


        //constructor
        public Store()
        {
            stockGenerator();
        }

        //methods
        private void stockGenerator()
        {
            Shirt shirtShortMao = new Shirt(1, 1, 200, true, true);
            Shirts_stock.Add(shirtShortMao);

            Shirt shirtShortCommon = new Shirt(1, 1, 300, false, true);
            Shirts_stock.Add(shirtShortCommon);

            Shirt shirtLongMao = new Shirt(1, 1, 150, true, false);
            Shirts_stock.Add(shirtLongMao);

            Shirt shirtLongCommon = new Shirt(1, 1, 350, false, false);
            Shirts_stock.Add(shirtLongCommon);

            Pant pantCommon = new Pant(1, 1, 1500, false);
            Pants_stock.Add(pantCommon);

            Pant pantNotCommon = new Pant(1, 1, 500, true);
            Pants_stock.Add(pantNotCommon);
        }
    }


}
