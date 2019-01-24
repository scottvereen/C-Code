using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structure1
{
    public partial class PersonSearch : Form
    {
        public PersonSearch()
        {
            InitializeComponent();
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strPerson_ID = dataGridView1.Rows(e.RowIndex).Cells[0].Value.ToString();
            
            //MessageBox.Show("Got Here");

            int intPerson, _ID = Convert.ToInt32(strPerson_ID);

            // creates the editor
            Form1 Editor = new Form1(intPerson_ID);
            Editor.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Person temp = new Person();

            DataSet ds = temp.SearchContacts(txtFName.Text, txtLName.Text);

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables["Persons"].ToString();
        }
    }
}
