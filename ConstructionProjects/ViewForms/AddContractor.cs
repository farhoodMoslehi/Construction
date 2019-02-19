using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;


namespace ViewForms
{
    public partial class AddContractor : Form
    {
        //public MainAssets mainAssetts;

        public OleDbConnection addContractorDbConnection;
        //public OleDbCommand cmd = new OleDbCommand();


        public AddContractor(OleDbConnection AddContractorsDbConnection)
        {
            InitializeComponent();
            addContractorDbConnection = AddContractorsDbConnection;
            
        }

        private void AddContractor_Load(object sender, EventArgs e)
        {

            //OleDbConnection conn = new OleDbConnection();
            //conn = mainAssetts.DbConnection;
            //addContractorDbConnection.Open();



        }

        private void btnContractorSubmit_Click(object sender, EventArgs e)
        {
            if (txtContractorName.Text != "" && txtContractorAddress.Text != "")
            {
                addContractorDbConnection.Open();
                string sSql = @"INSERT INTO Contractor (contractorName, contractorAddress, Notes) Values ('" + txtContractorName.Text + "','" + txtContractorAddress.Text +"','" + txtNotes.Text +"')";
                Debug.WriteLine("if statement");
                OleDbCommand cmd = new OleDbCommand(sSql, addContractorDbConnection);
                cmd.ExecuteNonQuery();
                txtContractorName.Text = "";
                txtContractorAddress.Text = "";
                txtNotes.Text = "";
                addContractorDbConnection.Close();

            }
            else
            {
                Debug.WriteLine("else statement");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            addContractorDbConnection.Close();
            this.Close();
        }
    }
}
