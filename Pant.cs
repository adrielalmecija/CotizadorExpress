using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress
{
    class Pant : Clothe
    {
        private Boolean common;

        public Pant(int quality, float price, long quantity, bool common) : base(quality,price,quantity)
        {
            this.Common = common;
        }

        public bool Common { get => common; set => common = value; }
        public int Quality { get => quality; }
        public float Price { get => price; }
        public long Quantity { get => quantity; }



    }
}
