using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizadorExpress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Store my_store = new Store();
            shopName.Text = my_store.Store_name;
            shopAdress.Text = my_store.Store_adress;
            Seller my_seller = new Seller("Hideo", "Kojima");
            linkSeller.Text = my_seller.Seller_name + " " + my_seller.Seller_surname + "  |  Codigo: " + my_seller.Id_seller;
            
        }


    }
}
