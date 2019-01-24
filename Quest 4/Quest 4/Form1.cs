using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quest_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //adding information in combo "status" box
            //All states i have lived in
            cmbState.Items.Add("Michigan");
            cmbState.Items.Add("South Carolina");
            cmbState.Items.Add("Florida");
            cmbState.Items.Add("California");
            cmbState.Items.Add("Rhode Island");
            cmbState.Items.Add("Georgia");

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            //String to hold all output
            //string result = "";

            //Find where the "@" is:
            //int intAtLocation = txtEmail.Text.IndexOf("@", 0);

            //Find the position of the last character (unknown)
            //int intLastPosition = txtEmail.Text.Length - 1;

            //(1st way)Get the domain portion of the email address
            //string strDomain = txtEmail.Text.Substring(intAtLocation+1);

            //(2nd way)Get the domain portion of the email adress
            //substring(a start index, a length)
            //string strDomain = txtEmail.Text.Substring(intAtLocation + 1, ((intLastPosition) - intAtLocation));

            //Get the person's email without domain (spacific user)
            //string email = txtEmail.Text;
            //string strPerson = email.Substring(0, intAtLocation);

            //Calculate output
            //result += "\nDomain: " + strDomain;
            //result += "\nPerson: " + strPerson;

            //display output
            //txtOutput.Text = result;
            //Output of information
            
            
            txtOutput.Text = dtpdate.Value.ToString();

            

            txtOutput.Text = txtOutput.Text + txtName + "," + cmbState.GetItemText(cmbState.SelectedItem);

            //Censor output
            //txtNotes.Text = Censor(txtNotes.Text);

        }
    }
}
