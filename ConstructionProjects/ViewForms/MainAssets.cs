using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using DataAccessLayer;
using System.Diagnostics;

namespace ViewForms
{
    public partial class MainAssets : Form
    {

        private OleDbConnection dbConnection;

        public MainAssets()
        {
            InitializeComponent();
        }

        private void btnContractor_Click(object sender, EventArgs e)
        {
            AddContractor addContractor = new AddContractor(DbConnection);
            addContractor.Show();

        }

        private void MainAssets_Load(object sender, EventArgs e)
        {

            DataLayer d = new DataLayer();
            string s = d.DbConnection();
            Console.WriteLine("Connection string is (0)", s);
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = s;
            this.DbConnection = connection;

            try
            {
                connection.Open();
                lbl_DbConnection.ForeColor = Color.Green;
                lbl_DbConnection.Text = "DB opened successfully";
                Debug.WriteLine("DB opened successfully");

            }
            catch (Exception ex)
            {
                Debug.WriteLine("there was a problem opening the file" + ex.Message);
            }
            connection.Close();
        }

        public OleDbConnection DbConnection
        {
            get
            {
                return dbConnection;
            }
            set
            {
                dbConnection = value;
            }


        }
    }
}
