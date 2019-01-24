using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Structure1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Int32 intPerson_ID)
        {
            InitializeComponent();

            //Gather Info
            Person temp = new Person();
            OleDbDataReader dr = temp.FindOnePerson(intPerson_ID);

            //use that info
            while (dr.Read())
            {
                txtFName.Text = dr["FName"].ToString();
                txtMName.Text = dr["MName"].ToString();
                txtLName.Text = dr["LName"].ToString();
                
            }
        }

        private void btnSubmit_Click(object sender, System.EventArgs e)
        {
            Person temp;     // declares a new variable
            temp = new Person(); // creates the framework

            temp.FName = txtFName.Text;
            temp.MName = txtMName.Text;
            temp.LName = txtLName.Text;
            temp.Street1 = txtStr1.Text;
            temp.Street2 = txtStr2.Text;
            temp.City = txtCity.Text;
            temp.State = txtState.Text;
            temp.Zip = txtZip.Text;
            temp.Phone = txtNBR.Text;
            temp.Email = txtEmail.Text;

            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {

                lblFeedback.Text = temp.FName + " " + temp.MName + " " + temp.LName + " " + temp.Street1 + " " + temp.Street2 + " " + temp.City + " " + temp.State + " " + temp.Zip + " " + 
                    temp.Phone + " " + temp.Email + " ";

            }
        }

        public void FillLabel(Person Temp)
        {
            lblFeedback.Text = Temp.FName + "Poopy" + "\n"; // puts everything in the feedback label
            lblFeedback.Text += Temp.MName + "\n";
            lblFeedback.Text += Temp.LName + "\n";
            lblFeedback.Text += Temp.Street1 + "\n";
            lblFeedback.Text += Temp.Street2 + "\n";
            lblFeedback.Text += Temp.City + "\n";
            lblFeedback.Text += Temp.State + "\n";
            lblFeedback.Text += Temp.Zip + "\n";
            lblFeedback.Text += Temp.Phone + "\n";
            lblFeedback.Text += Temp.Email + "\n";
        }

       
    }
}
