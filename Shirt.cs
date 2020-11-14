using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorExpress
{
    class Shirt : Clothe
    {
        private Boolean mao;
        private Boolean short_sleeve;

        public Shirt(int quality, float price, long quantity, bool mao, bool short_sleeve) : base(quality, price, quantity)
        {
            this.Mao = mao;
            this.Short_sleeve = short_sleeve;
        }

        public bool Mao { get => mao; set => mao = value; }
        public bool Short_sleeve { get => short_sleeve; set => short_sleeve = value; }
        public int Quality { get => quality; }
        public float Price { get => price; }
        public long Quantity { get => quantity; }
    }
}
