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

namespace CafeManegementSystem
{
    public partial class meuCafe : Form
    {
        public meuCafe()
        {
            InitializeComponent();
            usernameTB.Focus();
        }

        private void extBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Asus\\Desktop\\VP Project\\VP Project\\CafeManegementSystem\\CafeManegementSystem\\loginDB.mdf\";Integrated Security=True;Connect Timeout=30");
                string Query = "SELECT COUNT(*) FROM Users " + " WHERE Username=@UserName AND Password=@PassWord";
                SqlCommand cmd = new SqlCommand(Query, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("@UserName", usernameTB.Text);
                cmd.Parameters.AddWithValue("@PassWord", passwordTB.Text);

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result > 0)
                {
                    menu m = new menu();
                    this.Hide();
                    m.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Username and Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTB.Text = "";
                    passwordTB.Text = "";
                    usernameTB.Focus();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameTB.Clear();
            passwordTB.Clear();
            usernameTB.Focus();
        }
    }
}
