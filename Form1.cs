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
            Store my_store = new Store();
        public Form1()
        {
            InitializeComponent();
            shopName.Text = my_store.Store_name;
            shopAdress.Text = my_store.Store_adress;
            Seller my_seller = new Seller("Hideo", "Kojima");
            linkSeller.Text = my_seller.Seller_name + " " + my_seller.Seller_surname + "  |  Codigo: " + my_seller.Id_seller;
            
        }

        private void radioBtnShirt_CheckedChanged(object sender, EventArgs e)
        {
            labelStockAvailable.Text = stockQuantity(radioBtnShirt.Checked, 
                checkBoxShortSleeve.Checked, 
                checkBoxMao.Checked,
                checkBoxNotCommon.Checked);
            
        }

        private String stockQuantity(bool radioShirt, bool checkBoxShortSleeve, bool checkBoxMao, bool checkBoxNotCommon)
        {

            long stock = 0;
            if (radioShirt)
            {
                foreach(Shirt ClothesStock in my_store.Shirts_stock)
                {
                    
                    switch (my_store.Shirts_stock.IndexOf(ClothesStock))
                    {
                        case 0:
                            if (checkBoxShortSleeve && checkBoxMao)
                            {
                                stock += ClothesStock.Quantity;
                                Console.WriteLine(my_store.Shirts_stock.IndexOf(ClothesStock));
                            }
                            break;
                        case 1:
                            if (checkBoxShortSleeve && !checkBoxMao)
                            {
                                stock += ClothesStock.Quantity;
                                Console.WriteLine(my_store.Shirts_stock.IndexOf(ClothesStock));
                            }
                            break;
                        case 2:
                            if (checkBoxMao && !checkBoxShortSleeve)
                            {
                                stock += ClothesStock.Quantity;
                                Console.WriteLine(my_store.Shirts_stock.IndexOf(ClothesStock));
                            }
                            break;
                        case 3:
                            if (!checkBoxMao && !checkBoxShortSleeve )
                            {
                                stock += ClothesStock.Quantity;
                                Console.WriteLine(my_store.Shirts_stock.IndexOf(ClothesStock));
                            }
                            break;
                    }
                    
                }
            }else
            {
                foreach (Pant ClothesStock in my_store.Pants_stock)
                {
                    switch (my_store.Pants_stock.IndexOf(ClothesStock))
                    {
                        case 0:
                            if (!checkBoxNotCommon)
                            {
                                stock += ClothesStock.Quantity;
                            }
                            break;
                        case 1:
                            stock += ClothesStock.Quantity;
                            break;

                    }
                }
            }

            return stock.ToString();
        }

        private void checkBoxShortSleeve_CheckedChanged(object sender, EventArgs e)
        {
            labelStockAvailable.Text = stockQuantity(radioBtnShirt.Checked,
            checkBoxShortSleeve.Checked,
            checkBoxMao.Checked,
            checkBoxNotCommon.Checked);
        }

        private void checkBoxMao_CheckedChanged(object sender, EventArgs e)
        {
            labelStockAvailable.Text = stockQuantity(radioBtnShirt.Checked,
            checkBoxShortSleeve.Checked,
            checkBoxMao.Checked,
            checkBoxNotCommon.Checked);
        }

        private void checkBoxNotCommon_CheckedChanged(object sender, EventArgs e)
        {
            labelStockAvailable.Text = stockQuantity(radioBtnShirt.Checked,
            checkBoxShortSleeve.Checked,
            checkBoxMao.Checked,
            checkBoxNotCommon.Checked);
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {
            try
            {
                double price = Convert.ToDouble(textBoxPrice.Text);
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                double total = (price * quantity);

                if (checkBoxShortSleeve.Checked && radioBtnShirt.Checked)
                {
                    total *= 0.9;
                }
                if (checkBoxMao.Checked && radioBtnShirt.Checked)
                {
                    total *= 1.03;
                }
                if (checkBoxNotCommon.Checked && !radioBtnShirt.Checked)
                {
                    total *= 0.88;
                }

                if (radioBtnPremium.Checked)
                {
                    total *= 1.3;
                }

                labelQuote.Text = "$ " + total;
            }
            catch
            {
                MessageBox.Show("Por favor ingrese numeros validos");
            }

        }
    }
}
