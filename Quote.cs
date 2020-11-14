using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress
{
    class Quote
    {
        private long id_quote;
        private DateTime creationDate;
        private long id_seller;
        private String clothing;
        private int units;
        private float totalPrice;


        //getters & setters
        public long Id_quote { get => id_quote; }
        public DateTime CreationDate { get => creationDate;}
        public long Id_seller { get => id_seller; }
        public string Clothing { get => clothing; }
        public int Units { get => units; }
        public float TotalPrice { get => totalPrice; }

        //cosntructors
        public Quote(long id_quote, DateTime creationDate, long id_seller, string clothing, int units, float totalPrice)
        {
            this.id_quote = id_quote;
            this.creationDate = creationDate;
            this.id_seller = id_seller;
            this.clothing = clothing;
            this.units = units;
            this.totalPrice = totalPrice;
        }




    }
}
