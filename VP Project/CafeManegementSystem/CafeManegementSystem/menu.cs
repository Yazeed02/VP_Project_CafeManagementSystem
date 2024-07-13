using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace CafeManegementSystem
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            lbDate.Text = DateTime.Now.ToLongDateString();
            lbTime.Text = DateTime.Now.ToLongTimeString();
            numericUpcap.Hide();
            numericUpEsp.Hide();
            numericUpDop.Hide();
            numericUpAmer.Hide();
            numericUpILat.Hide();
            numericUpLat.Hide();
            numericUpIMoch.Hide();
            numericUpDownMocha.Hide();
            numericUpMocacino.Hide();
            numericUpSpLate.Hide();
            numericUpDownMoh.Hide();
            numericUpDownFrap.Hide();
            numericUpDownBrez.Hide();
            numericUpIAmer.Hide();
            numericUpIspLat.Hide();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        bool autoChangedCap;
        private void numericUDcap_ValueChanged(object sender, EventArgs e)
        {
            autoChangedCap = false; 
        }
        bool autoChangedEsp;
        private void numericUpEsp_ValueChanged(object sender, EventArgs e)
        {
            autoChangedEsp = false;
        }
        bool autoChangedDop;
        private void numericUpDop_ValueChanged(object sender, EventArgs e)
        {
            autoChangedDop = false;
        }
        bool autoChangedAmer;
        private void numericUpAmer_ValueChanged(object sender, EventArgs e)
        {
            autoChangedAmer = false;
        }
        bool autoChangedLat;
        private void numericUpLat_ValueChanged(object sender, EventArgs e)
        {
            autoChangedLat = false;
        }
        bool autoChangedMocacino;
        private void numericUpMocacino_ValueChanged(object sender, EventArgs e)
        {
            autoChangedAmer = false;
        }
        bool autoChangedspLat;
        private void numericUpSpLate_ValueChanged(object sender, EventArgs e)
        {
            autoChangedspLat = false;
        }
        bool autoChangedFrap;
        private void numericUpDownFrap_ValueChanged(object sender, EventArgs e)
        {
            autoChangedFrap = false;
        }
        bool autoChangedMoch;
        private void numericUpDownMocha_ValueChanged(object sender, EventArgs e)
        {
           autoChangedMoch = false;
        }
        bool autoChangedMoh;
        private void numericUpDownMoh_ValueChanged(object sender, EventArgs e)
        {
            autoChangedMoh = false;
        }
        bool autoChangedBrez;
        private void numericUpDownBrez_ValueChanged(object sender, EventArgs e)
        {
            autoChangedBrez = false;
        }
        bool autoChangedIAme;
        private void numericUpIAmer_ValueChanged(object sender, EventArgs e)
        {
            autoChangedIAme = false;
        }
        bool autoChangedILat;
        private void numericUpILat_ValueChanged(object sender, EventArgs e)
        {
            autoChangedILat = false;
        }
        bool autoChangedISpLat;
        private void numericUpIspLat_ValueChanged(object sender, EventArgs e)
        {
            autoChangedISpLat = false;
        }
        bool autoChangedIMoch;
        private void numericUpIMoch_ValueChanged(object sender, EventArgs e)
        {
            autoChangedIMoch = false;
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure You Want to Logout?" , "Logout Message" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) 
            {
                meuCafe m = new meuCafe();
                this.Hide();
                m.ShowDialog();
                this.Close();
            }
        }
        string name;
        double price;
        double total;
        double sum;
        const double TAX = 0.16;
        double subTotal;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cappCB.Checked)
            {
                name = "Cappuccino";
                int qty = (int)numericUpcap.Value;
                price = 2.00;
                total = qty * price;
                
                if (!autoChangedCap)
                {
                    if(numericUpcap.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedCap = true;
            }

            if (espCB.Checked)
            {
                name = "Espresso";
                int qty = (int)numericUpEsp.Value;
                price = 2.00;
                total = qty * price;
                if (!autoChangedEsp)
                {
                    if (numericUpEsp.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedEsp = true;
            }

            if (dopCB.Checked)
            {
                name = "Dopio";
                int qty = (int)numericUpDop.Value;
                price = 3.00;
                total = qty * price;
                if (!autoChangedDop)
                {
                    if (numericUpDop.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedDop = true;
            }

            if (amerCB.Checked)
            {
                name = "Americano";
                int qty = (int)numericUpAmer.Value;
                price = 2.50;
                total = qty * price;
                if (!autoChangedAmer)
                {
                    if (numericUpAmer.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedAmer = true;
            }

            if (latCB.Checked)
            {
                name = "Latte";
                int qty = (int)numericUpLat.Value;
                price = 3.25;
                total = qty * price;
                if (!autoChangedLat)
                {
                    if (numericUpLat.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedLat = true;
            }

            if (mocacinoCb.Checked)
            {
                name = "Mocaccino";
                int qty = (int)numericUpMocacino.Value;
                price = 3.50;
                total = qty * price;
                if (!autoChangedMocacino)
                {
                    if (numericUpMocacino.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedMocacino = true;
            }

            if (spLatCB.Checked)
            {
                name = "Spanish Latte";
                int qty = (int)numericUpSpLate.Value;
                price = 3.75;
                total = qty * price;
                if (!autoChangedspLat)
                {
                    if (numericUpSpLate.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedspLat = true;
            }

            if (frapCB.Checked)
            {
                name = "Frappe";
                int qty = (int)numericUpDownFrap.Value;
                price = 4.00;
                total = qty * price;
                if (!autoChangedFrap)
                {
                    if (numericUpDownFrap.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedFrap = true;
            }

            if (mochCB.Checked)
            {
                name = "Mocha";
                int qty = (int)numericUpDownMocha.Value;
                total = qty * price;
                if (!autoChangedMoch)
                {
                    if (numericUpDownMocha.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedMoch = true;
            }

            if (mohCB.Checked)
            {
                name = "Mohito";
                int qty = (int)numericUpDownMoh.Value;
                price = 3.00;
                total = qty * price;
                if (!autoChangedMoh)
                {
                    if (numericUpDownMoh.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedMoh = true;
            }

            if (brezCB.Checked)
            {
                name = "Lemon Breez";
                int qty = (int)numericUpDownBrez.Value;
                price = 3.50;
                total = qty * price;
                if (!autoChangedBrez)
                {
                    if (numericUpDownBrez.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedBrez = true;

            }

            if (iAmeCB.Checked)
            {
                name = "Iced American";
                int qty = (int)numericUpIAmer.Value;
                price = 3.00;
                total = qty * price;
                if (!autoChangedIAme)
                {
                    if (numericUpIAmer.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedIAme = true;
            }

            if (iLatCB.Checked)
            {
                name = "Iced Latte";
                int qty = (int)numericUpILat.Value;
                price = 3.75;
                total = qty * price;
                if (!autoChangedILat)
                {
                    if (numericUpILat.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedILat = true;

            }

            if (iSpLatCB.Checked)
            {
                name = "Iced Spanish Latte";
                int qty = (int)numericUpIspLat.Value;
                price = 4.25;
                total = qty * price;
                if (!autoChangedISpLat)
                {
                    if (numericUpIspLat.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedISpLat = true;
            }
            
            if (iMochCB.Checked)
            {
                name = "Iced Mocha";
                int qty = (int)numericUpIMoch.Value;
                price = 3.50;
                total = qty * price;
                if (!autoChangedIMoch)
                {
                    if (numericUpIMoch.Value > 0)
                    {
                        sum = sum + total;
                        this.dataGridView1.Rows.Add(name, price.ToString("c"), qty, total.ToString("c"));
                    }
                }
                autoChangedIMoch = true;
            }
           
            totalLb.Text = sum.ToString("c");
            subTotal = sum * TAX;
            TaxLb.Text = subTotal.ToString("c");
            sTotallb.Text = (sum + subTotal).ToString("c");
            /* double sum = 0.0;
             int tot =0;
             for(int i = 0; i < dataGridView1.Rows.Count; i++)
             {
                 Int32.TryParse(dataGridView1.Rows[i].Cells[3].Value, tot);
                 sum += tot;
             }
             totalLb.Text = sum.ToString("c");
             */
        }

        private void cappCB_CheckedChanged(object sender, EventArgs e)
        {
            if (cappCB.Checked)
            {
                numericUpcap.Value = 1;
                numericUpcap.Show();
            }
            else
            {
                numericUpcap.Hide();
            }
        }

        private void espCB_CheckedChanged(object sender, EventArgs e)
        {
            if (espCB.Checked)
            {
                numericUpEsp.Value = 1;
                numericUpEsp.Show();
            }
            else
            {
                numericUpEsp.Hide();
            }
        }

        private void dopCB_CheckedChanged(object sender, EventArgs e)
        {
            if (dopCB.Checked)
            {
                numericUpDop.Value = 1;
                numericUpDop.Show();
            }
            else
            {
                numericUpDop.Hide();
            }
        }

        private void amerCB_CheckedChanged(object sender, EventArgs e)
        {

            if (amerCB.Checked)
            {
                numericUpAmer.Value = 1;
                numericUpAmer.Show();
            }
            else
            {
                numericUpAmer.Hide();
            }
        }

        private void latCB_CheckedChanged(object sender, EventArgs e)
        {

            if (latCB.Checked)
            {
                numericUpLat.Value = 1;
                numericUpLat.Show();
            }
            else
            {
                numericUpLat.Hide();
            }
        }

        private void mocacinoCb_CheckedChanged(object sender, EventArgs e)
        {

            if (mocacinoCb.Checked)
            {
                numericUpMocacino.Value = 1;
                numericUpMocacino.Show();
            }
            else
            {
                numericUpMocacino.Hide();
            }
        }

        private void spLatCB_CheckedChanged(object sender, EventArgs e)
        {

            if (spLatCB.Checked)
            {
                numericUpSpLate.Value = 1;
                numericUpSpLate.Show();
            }
            else
            {
                numericUpSpLate.Hide();
            }
        }
        private void frapCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (frapCB.Checked)
            {
                numericUpDownFrap.Value = 1;
                numericUpDownFrap.Show();
            }
            else
            {
                numericUpDownFrap.Hide();
            }
        }

        private void mochCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (mochCB.Checked)
            {
                numericUpDownMocha.Value = 1;
                numericUpDownMocha.Show();
            }
            else
            {
                numericUpDownMocha.Hide();
            }
        }

        private void mohCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (mohCB.Checked)
            {
                numericUpDownMoh.Value = 1;
                numericUpDownMoh.Show();
            }
            else
            {
                numericUpDownMoh.Hide();
            }
        }

        private void brezCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (brezCB.Checked)
            {
                numericUpDownBrez.Value = 1;
                numericUpDownBrez.Show();
            }
            else
            {
                numericUpDownBrez.Hide();
            }
        }

        private void iAmeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (iAmeCB.Checked)
            {
                numericUpIAmer.Value = 1;
                numericUpIAmer.Show();
            }
            else
            {
                numericUpIAmer.Hide();
            }
        }

        private void iLatCB_CheckedChanged(object sender, EventArgs e)
        {
            if (iLatCB.Checked)
            {
                numericUpILat.Value = 1;
                numericUpILat.Show();
            }
            else
            {
               numericUpILat.Hide();
            }
        }

        private void iSpLatCB_CheckedChanged(object sender, EventArgs e)
        {
            if (iSpLatCB.Checked)
            {
                numericUpIspLat.Value = 1;
                numericUpIspLat.Show();
            }
            else
            {
                numericUpIspLat.Hide();
            }
        }

        private void iMochCB_CheckedChanged(object sender, EventArgs e)
        {
            if (iMochCB.Checked)
            {
                numericUpIMoch.Value = 1;
                numericUpIMoch.Show();
            }
            else
            {
                numericUpIMoch.Hide();
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            totalLb.Text = "";
            total = 0;
            sum = 0;
            subTotal = 0;
            sTotallb.Text = "";
            TaxLb.Text = "";
            cappCB.Checked = false;
            espCB.Checked = false;
            dopCB.Checked = false;
            amerCB.Checked = false;
            latCB.Checked = false;
            mocacinoCb.Checked = false;
            spLatCB.Checked = false;
            frapCB.Checked = false;
            mochCB.Checked = false;
            mohCB.Checked = false;
            brezCB.Checked = false;
            iAmeCB.Checked = false;
            iLatCB.Checked = false;
            iSpLatCB.Checked = false;
            iMochCB.Checked = false;
            dataGridView1.Rows.Clear();
            autoChangedCap = false;
            autoChangedEsp = false;
            autoChangedLat = false;
            autoChangedDop = false;
            autoChangedAmer = false;
            autoChangedBrez = false;
            autoChangedMocacino = false;
            autoChangedISpLat = false;
            autoChangedFrap = false;
            autoChangedMoch = false;
            autoChangedIMoch = false;
            autoChangedMoh = false;
            autoChangedIAme = false;
            autoChangedILat = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpFrap_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void printBtn_Click(object sender, EventArgs e)
        {
            StreamWriter tw = File.CreateText("Receipt.txt");
            tw.WriteLine("            MEU Cafe");
            tw.WriteLine(" ");
            tw.WriteLine("Item     Price     Quantity     Total");
            tw.WriteLine("");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        tw.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + "   ");
                    }
                tw.WriteLine(" "); 
            }
            tw.WriteLine(" ");
            tw.WriteLine(" ");
            tw.WriteLine("        Total : " + totalLb.Text);
            tw.WriteLine("        Tax : " + TaxLb.Text);
            tw.WriteLine("        Subtotal : " + sTotallb.Text);
            tw.Close();
            
            
            /*StreamWriter s = File.CreateText("Receipt.txt");
            for(int i = 0; i < dataGridView1.)
            s.WriteLine("Total = " + totalLb.Text);
            s.WriteLine("Tax = " + TaxLb.Text);
            s.WriteLine("Subtotal = " + sTotallb.Text);
            s.Close();
            */
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
