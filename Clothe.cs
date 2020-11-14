using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress
{
    abstract class Clothe
    {
        protected int quality;
        protected float price;
        protected long quantity;

        protected Clothe(int quality, float price, long quantity)
        {
            this.quality = quality;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
