using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class BillsScreen : Form
    {
        // Path to the database file
        private string databasePath = @"D:\PinkPixl\source\ProNatur-Biomarkt GmbH\Pro-Natur Biomarkt GmbH.mdf";

        // SQL connection to database, connection stuff to be moved to a separate class later
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\PinkPixl\source\ProNatur-Biomarkt GmbH\Pro-Natur Biomarkt GmbH.mdf;Integrated Security = True; Connect Timeout = 30");

        // Id(db) of the last selected product in the DataGridView
        private int lastSelectedProductKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="BillsScreen"/> class.
        /// </summary>
        public BillsScreen()
        {
            InitializeComponent();
            ShowBills();
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
        /// Retrieves and displays the bills from the database.
        /// </summary>
        private void ShowBills()
        {
            databaseConnection.Open();

            string query = "SELECT * FROM Bills";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            billsDGV.DataSource = dataSet.Tables[0];
            //billsDGV.Columns[0].Visible = false; // hide the first column (Id)

            databaseConnection.Close();
        }

        /// <summary>
        /// Validates the input fields to ensure that they are not empty.
        /// </summary>
        private void ValidateInput()
        {
            if (textBoxBillRecipient.Text == "" ||
                textBoxBillDescription.Text == "" ||
                textBoxBillTotalPrice.Text == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen.");
                return;
            }
        }

        /// <summary>
        ///  Handles the click event of the save button to save the bill to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBillSave_Click(object sender, EventArgs e)
        {
            ValidateInput();

            string billRecipient = textBoxBillRecipient.Text;
            string billDescription = textBoxBillDescription.Text;
            string billTotalPrice = textBoxBillTotalPrice.Text;

            string query = string.Format("INSERT INTO BillS VALUES ('{0}', '{1}', '{2}')", billRecipient, billDescription, billTotalPrice);
            ExecuteQuery(query);

            ClearAllFields();
            ShowBills();
        }

        /// <summary>
        /// Clears all input fields.
        /// </summary>
        private void ClearAllFields()
        {
            textBoxBillId.Text = "";
            textBoxBillRecipient.Text = "";
            textBoxBillDescription.Text = "";
            textBoxBillTotalPrice.Text = "";
        }

        /// <summary>
        /// Executes the specified SQL query on the database.
        /// </summary>
        /// <param name="query"></param>
        private void ExecuteQuery(string query)
        {
            databaseConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();

            databaseConnection.Close();
        }

        /// <summary>
        /// Handles the click event of the edit button to edit the selected bill in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBillEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte zu editierende Rechnung auswählen.");
                return;
            }

            string billRecipient = textBoxBillRecipient.Text;
            string billDescription = textBoxBillDescription.Text;
            string billTotalPrice = textBoxBillTotalPrice.Text;

            string query = string.Format("UPDATE Bills SET Recipient = '{0}', Description = '{1}', TotalPrice = '{2}' WHERE Id = {3}",
                billRecipient, billDescription, billTotalPrice, lastSelectedProductKey);
            ExecuteQuery(query);

            ShowBills();
        }

        /// <summary>
        /// Handles the click event of the clear button to clear all input fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBillClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        /// <summary>
        /// Handles the click event of the delete button to delete the selected bill from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBillDelete_Click(object sender, EventArgs e)
        {
            if ( lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wählen Sie eine Rechnung aus.");
                return;
            }

            string query = string.Format("DELETE FROM Bills WHERE Id = {0}", lastSelectedProductKey);
            ExecuteQuery(query);

            ClearAllFields();
            ShowBills();
        }

        /// <summary>
        /// Handles the click event of the DataGridView to display the selected bill in the input fields. Also sets the last selected product key.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void billsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxBillId.Text = billsDGV.SelectedRows[0].Cells[0].Value.ToString();
            textBoxBillRecipient.Text = billsDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBoxBillDescription.Text = billsDGV.SelectedRows[0].Cells[2].Value.ToString();
            textBoxBillTotalPrice.Text = billsDGV.SelectedRows[0].Cells[3].Value.ToString();

            lastSelectedProductKey = (int)billsDGV.SelectedRows[0].Cells[0].Value;
        }
    }
}
