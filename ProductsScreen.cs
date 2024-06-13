using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    ToDo: 
    - Add a new form BillsScreen.cs (basically the same but with customerId(primary key), customerName, productId(foreign key), productName, productPrice, productAmount, totalPrice, billDate)
    - Make full row select in the DataGridView (now only productName text in DGV rows 0 are clickable)
    - Add a new table in the database for bills (customerId, customerName, productId, totalPrice, billDate)
    - Add a new table in the database for customers (customerId, customerName, customerAddress, customerEmail, customerPhone)
    - In the loading screen, add file selection dialogue / form to load a database and save the selection so user won't have to select the database every time (but can change it)
    - replace the database connection string (the path part of filename) with a variable that is set in the loading screen
 */


namespace ProNatur_Biomarkt_GmbH
{   
    public partial class ProductsScreen : Form
    {
        // Path to the database file
        private string databasePath = @"D:\PinkPixl\source\ProNatur-Biomarkt GmbH\Pro-Natur Biomarkt GmbH.mdf";

        // SQL connection to database, connection stuff to be moved to a separate class later
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\PinkPixl\source\ProNatur-Biomarkt GmbH\Pro-Natur Biomarkt GmbH.mdf;Integrated Security = True; Connect Timeout = 30");
        
        // Id(db) of the last selected product in the DataGridView
        private int lastSelectedProductKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsScreen"/> class.
        /// </summary>
        public ProductsScreen()
        {
            InitializeComponent();
            ShowProducts();
            ShowDbPath();
        }

        /// <summary>
        /// Displays the path to the database in the text box.
        /// </summary>
        private void ShowDbPath()
        {
            textBoxDbPath.Text = databasePath;  
        }

        /// <summary>
        /// Handles the click event of the save button to save the product to the database.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnProductSave_Click(object sender, EventArgs e)
        {
            ValidateInput();

            // get values from text boxes and combo boxes
            string productName = textBoxProductName.Text;
            string productBrand = textBoxProductBrand.Text;
            string productCategory = comboBoxProductCategory.Text;
            string productPrice = textBoxProductPrice.Text;

            // SQL query to insert new product into database
            string query = string.Format("INSERT INTO Products VALUES ('{0}', '{1}', '{2}', '{3}')", productName, productBrand, productCategory, productPrice);
            ExecuteQuery(query);

            ClearAllFields();
            ShowProducts();
        }

        /// <summary>
        /// Handles the click event of the edit button to edit the selected product details in the database.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0) // No product selected, so we can't delete anything
            {
                MessageBox.Show("Bitte zu editierendes Produkt auswählen.");
                return;
            }
            // get values from text boxes and combo boxes
            string productName = textBoxProductName.Text;
            string productBrand = textBoxProductBrand.Text;
            string productCategory = comboBoxProductCategory.Text;
            string productPrice = textBoxProductPrice.Text;

            // SQL query to update product in database
            string query = string.Format("UPDATE Products SET Name='{0}', Brand='{1}', Category='{2}', Price='{3}' WHERE Id={4}",
                productName, productBrand, productCategory, productPrice, lastSelectedProductKey);
            ExecuteQuery(query);

            ShowProducts();
        }

        /// <summary>
        /// Handles the click event of the clear button to clear all text boxes and combo boxes on the form.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        /// <summary>
        /// Handles the click event of the delete button to delete the selected product from the database.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0) // No product selected, so we can't delete anything
            {
                MessageBox.Show("Bitte wählen Sie ein Produkt aus, das Sie löschen möchten.");
                return;
            }
            // SQL query to delete product from database
            string query = string.Format("DELETE FROM Products WHERE Id={0}", lastSelectedProductKey);
            ExecuteQuery(query);

            ClearAllFields();
            ShowProducts();
        }

        /// <summary>
        /// Executes the specified SQL query on the database.
        /// </summary>
        /// <param name="query">The SQL query to execute.</param>
        private void ExecuteQuery(string query)
        {
            databaseConnection.Open();                                                      // OPEN database connection, NEVER forget to Close() it at some point
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);              // create SQL command with query and database connection
            sqlCommand.ExecuteNonQuery();                                                   // execute query
            databaseConnection.Close();                                                     // CLOSE database connection
        }

        /// <summary>
        /// Retrieves and displays all products from the database.
        /// </summary>
        private void ShowProducts()
        {
            databaseConnection.Open();                                                      // OPEN database connection, NEVER forget to Close() it at some point

            string query = "SELECT * FROM Products";                                        // SQL query to get all products from database
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);  // create data adapter

            DataSet dataSet = new DataSet();                                                // create data set
            sqlDataAdapter.Fill(dataSet);                                                   // fill data set with data from data adapter

            productsDGV.DataSource = dataSet.Tables[0];                                     // set data grid view data source to data set table
            productsDGV.Columns[0].Visible = false;                                         // hide first column (ID)

            databaseConnection.Close();                                                     // CLOSE database connection
        }

        /// <summary>
        /// Clears all input fields.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ClearAllFields()
        {
            textBoxProductName.Text = "";
            textBoxProductBrand.Text = "";
            textBoxProductPrice.Text = "";
            comboBoxProductCategory.Text = "";
            comboBoxProductCategory.SelectedItem = null;
        }

        /// <summary>
        /// Validates the input fields to ensure that they are not empty.
        /// </summary>
        private void ValidateInput()
        {
            if (textBoxProductName.Text == "" ||
                textBoxProductBrand.Text == "" ||
                textBoxProductPrice.Text == "" ||
                comboBoxProductCategory.Text == "")
            {
                MessageBox.Show("Bitte geben alle Felder ausfüllen.");                      // show message box
                return;                                                                     // return from method
            }
        }

        /// <summary>
        /// Handles the click event of the products data grid view to populate the text boxes and combo boxes with the selected product details. Also saves the key of the selected product.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void productsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        /*   Designer settings;
             MultiSelect is disabled and FullRowSelect is enabled in the designer,
             so we can safely assume that the first selected row is the one we want to edit.
             ReadOnly is enabled for all columns in the designer, so we can safely assume
             that the user can't edit the data in the DGV.
        */

            // Populate the text boxes and combo boxes with the selected product details
            textBoxProductName.Text = productsDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBoxProductBrand.Text = productsDGV.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxProductCategory.Text = productsDGV.SelectedRows[0].Cells[3].Value.ToString();
            textBoxProductPrice.Text = productsDGV.SelectedRows[0].Cells[4].Value.ToString();
            // Save the key of the selected product
            lastSelectedProductKey = (int)productsDGV.SelectedRows[0].Cells[0].Value;
        }
    }
}