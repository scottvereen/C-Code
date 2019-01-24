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
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();
            temp.Show();
        }

        private void searchPerson_Click(object sender, EventArgs e)
        {
            PersonSearch temp = new PersonSearch();
            temp.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblfeedback.Text = "";
            int intLevel = EmployeeLogin(txtUName.Text, txtPW.Text);
            if(intLevel<=5 && intLevel !=0)
            {
                pnlControls.Enabled = true;
                pnlControls.Visible = true;

                pnlLogin.Enabled = false;
                pnlLogin.Enabled = false;
            }
            else
            {
                pnlControls.Enabled = false;
                pnlControls.Visible = false;

                pnlLogin.Enabled = true;
                pnlLogin.Visible = true;

                lblfeedback.Text = "WRONG";
            }
        }

        private int EmployeeLogin(string strUName, string strPW)
        {
            int intAdminLevel = 0;

            SqlDataReader dr;

            SqlCommand comm = new SqlCommand();
            string strSQL = "SELECT MyLevel FROM MyLogin WHERE (UName = @UName AND PW= @PW)";

            comm.Parameters.AddWithValue("@UName", strUName);
            comm.Parameters.AddWithValue("@PW", strPW);

            SqlConnection conn = new SqlConnection();

            string strConn = @MyUtilities.GetConnectionString();

            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = strSQL;

            conn.Open();
            dr = comm.ExecuteReader();

            while (dr.Read())
            {
                intAdminLevel = Convert.ToInt16(dr["MyLevel"].ToString());

            }
            conn.Close();

            return intAdminLevel;

            

        }
    }

}
