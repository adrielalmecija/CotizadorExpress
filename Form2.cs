using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void AddRow(int ID_Quote)
        {
            dataGridView1.Rows.Add();
        }

        public void WriteCell(ArrayList QuotesList, string sellerFullName)
        {
            foreach (Quote q in QuotesList)
            {
                this.dataGridView1.Rows.Add(q.Id_quote, q.CreationDate, sellerFullName + " | " + q.Id_seller, q.Clothing , q.Units ,q.TotalPrice);

            }
        }
    }
}
