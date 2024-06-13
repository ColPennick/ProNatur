using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class MainMenuScreen : Form
    {
        public MainMenuScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the "Products" button click. Will open the Products screen.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsScreen productsScreen = new ProductsScreen();
            productsScreen.Show();

            this.Hide();
        }

        /// <summary>
        /// Event handler for the "Bill" button click. Will open the Bills screen.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnBill_Click(object sender, EventArgs e)
        {
            BillsScreen billsScreen = new BillsScreen();
            billsScreen.Show();

            this.Hide();
        }
    }
}
