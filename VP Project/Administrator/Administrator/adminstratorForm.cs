using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class adminstratorForm : Form
    {
        public adminstratorForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDBDataSet);

        }

        private void adminstratorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.loginDBDataSet.Users);

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
