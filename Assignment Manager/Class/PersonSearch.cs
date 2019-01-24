using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class PersonSearch : Form
    {
        public PersonSearch()
        {
            InitializeComponent();
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
   
            Person temp = new Person();

            
            DataSet ds = temp.SearchContacts(txtfName.Text, txtlName.Text);

            gvResults.DataSource = ds; 
            gvResults.DataMember = ds.Tables["Person"].ToString();

        }

        private void gvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
            string strPerson_ID =
                gvResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            MessageBox.Show(strPerson_ID);

           
            int intPerson_ID = Convert.ToInt32(strPerson_ID);


            
            Form1 Editor = new Form1(intPerson_ID);
            Editor.ShowDialog();
             
        }
    }
}
