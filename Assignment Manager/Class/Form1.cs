using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Class
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
            
            btnUpdate.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Visible = false;
            btnDelete.Enabled = false;
            FillStates();
           
           
            

        }

        

        public Form1(Int32 intPerson_ID)
        {
            InitializeComponent();

            

            
            btnSubmit.Visible = false;
            btnSubmit.Enabled = false;

            
            Person temp = new Person();
            SqlDataReader dr = temp.FindOnePerson(intPerson_ID);

            
            while (dr.Read())
            {
               
                txtFirst.Text = dr["FName"].ToString();
                txtLast.Text = dr["MName"].ToString();
                txtMiddle.Text = dr["LName"].ToString();
                
                lblPerson_ID.Text = dr["Person_ID"].ToString();

                
                cmbState.SelectedItem = dr["state"].ToString();

                bool blnFound = false;
                int intIndex = 0;
                while (blnFound == false)
                {
                    if (((ComcoBoxItem)cmbState.Items[intIndex]).Value == intPerson_ID)
                    {
                        blnFound = true;
                        cmbState.SelectedItem = intIndex;
                    }
                    intIndex++;
                }

            }

            btnDelete.Visible = true;
            btnSubmit.Visible = false;
            btnUpdate.Visible = true;

        }

        
        

        
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            
            Person temp; 
            
            temp = new Person();
            

            Person Pa = new Person();


            


            Pa.FName = txtFirst.Text;
            Pa.MName = txtMiddle.Text;
            Pa.LName = txtLast.Text;
            Pa.Street1 = txtStreet1.Text;
            Pa.Street2 = txtStreet2.Text;
            Pa.City = txtCity.Text;
            Pa.State = txtState.Text;
            Pa.Phone = txtPhone.Text;
            Pa.Email = txtEmail.Text;
            Pa.Zip = txtZip.Text;
            Pa.Bday = dtpbday.Value;
            

            Pa.AddContact();

           


            
            if (Pa.Feedback.Contains("Error:"))
            {
                
                lblFeedback.Text = Pa.Feedback;
            }
            else 
            {
                FillLabel(Pa);
            }

            
            
            if (Pa.Feedback.Contains("Error: State"))
            {
                txtPhone.BackColor = Color.Yellow;
            }
            
               
           if (Pa.Feedback.Contains("Error: Email"))
            {
                txtEmail.BackColor = Color.Yellow;
            }


        }

        
        private void DisplayInfo(Person temp)
        {

            lblFeedback.Text = temp.FName + " " + temp.MName + " " + temp.LName;


        }


        private void DisplayInfo()
        {
            lblFeedback.Text = "Unknown Person....Lack of Data";

        }

        public void FillLabel(Person temp)
        {
            lblFeedback.Text += temp.FName + "\n";
            lblFeedback.Text += temp.MName + "\n";
            lblFeedback.Text += temp.LName + "\n";
            lblFeedback.Text += temp.City + "\n";
            lblFeedback.Text += temp.State + "\n";
            lblFeedback.Text += temp.Street1 + "\n";
            lblFeedback.Text += temp.Street2 + "\n";
            lblFeedback.Text += temp.Phone + "\n";
            lblFeedback.Text += temp.Email + "\n";
            lblFeedback.Text += temp.Bday + "\n";
            
           
            
            


        }
        private void FillStates()
        {
            
            SqlDataReader dr = @MyUtilities.GetMyStates();
            
            while (dr.Read())
            {
                
                cmbState.Items.Add(dr["State"].ToString());

            }

            dr.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                
            Person temp = new Person();

           
            Int32 intPerson_ID = Convert.ToInt32(lblPerson_ID.Text);

            Int32 intRecords = temp.DeleteOnePerson(intPerson_ID);

            
            lblFeedback.Text = intRecords.ToString() + " Records Deleted.";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                      
            Person temp = new Person();

           
            temp.FName = txtFirst.Text;
            temp.MName = txtMiddle.Text;
            temp.LName = txtLast.Text;
            temp.State = cmbState.SelectedItem.ToString();
            temp.Person_ID = Convert.ToInt32(lblPerson_ID.Text);

            

            if (temp.feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.feedback;
            }
            else if (temp.FName.Length > 0 && temp.LName.Length > 0)
            {
                DisplayInfo(temp);
                
                Int32 intRecords = temp.UpdateAContact();
                
                lblFeedback.Text = intRecords.ToString() + " Records Updated.";

            }
            else
            {
                DisplayInfo();
            }

        }



    }


}
