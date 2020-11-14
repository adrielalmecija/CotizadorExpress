using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress
{
    class Seller
    {
        private long id_seller;
        private String seller_name;
        private String seller_surname;

        //getters & setters
        public long Id_seller { get => id_seller; }
        public string Seller_name { get => seller_name; }
        public string Seller_surname { get => seller_surname; }


        //constructor
        public Seller(string seller_name, string seller_surname)
        {
            this.id_seller = 1; //hardcoded in this case
            this.seller_name = seller_name;
            this.seller_surname = seller_surname;
        }

    }
}
