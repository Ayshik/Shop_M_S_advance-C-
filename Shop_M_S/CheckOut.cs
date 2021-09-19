using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_M_S
{
    public partial class CheckOut : Form
    {

       


        public CheckOut(string billid)
        {
            InitializeComponent();
            label55.Text = billid;
             this.Da = new DataAccess();
        }
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }
        private void CheckOut_Load(object sender, EventArgs e)
        {
            string sql = @"select * from Allbills where Billingno = '" + this.label55.Text + "';";
            this.Ds = this.Da.ExecuteQuery(sql);

            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                label4.Text = Ds.Tables[0].Rows[0][0].ToString();
                label5.Text = Ds.Tables[0].Rows[0][1].ToString();
                label7.Text = Ds.Tables[0].Rows[0][2].ToString();
            }
                if (this.Ds.Tables[0].Rows.Count == 2)
                {
                label4.Text = Ds.Tables[0].Rows[0][0].ToString();
                label5.Text = Ds.Tables[0].Rows[0][1].ToString();
                label7.Text = Ds.Tables[0].Rows[0][2].ToString();


                    label24.Text = Ds.Tables[0].Rows[1][0].ToString();
                    label23.Text = Ds.Tables[0].Rows[1][1].ToString();
                    label22.Text = Ds.Tables[0].Rows[1][2].ToString();
                }
            if (this.Ds.Tables[0].Rows.Count == 3)
            {
                label4.Text = Ds.Tables[0].Rows[0][0].ToString();
                label5.Text = Ds.Tables[0].Rows[0][1].ToString();
                label7.Text = Ds.Tables[0].Rows[0][2].ToString();


                label24.Text = Ds.Tables[0].Rows[1][0].ToString();
                label23.Text = Ds.Tables[0].Rows[1][1].ToString();
                label22.Text = Ds.Tables[0].Rows[1][2].ToString();

                label29.Text = Ds.Tables[0].Rows[2][0].ToString();
                label28.Text = Ds.Tables[0].Rows[2][1].ToString();
                label27.Text = Ds.Tables[0].Rows[2][2].ToString();
            }

            if (this.Ds.Tables[0].Rows.Count == 4)
            {
                label4.Text = Ds.Tables[0].Rows[0][0].ToString();
                label5.Text = Ds.Tables[0].Rows[0][1].ToString();
                label7.Text = Ds.Tables[0].Rows[0][2].ToString();


                label24.Text = Ds.Tables[0].Rows[1][0].ToString();
                label23.Text = Ds.Tables[0].Rows[1][1].ToString();
                label22.Text = Ds.Tables[0].Rows[1][2].ToString();

                label29.Text = Ds.Tables[0].Rows[2][0].ToString();
                label28.Text = Ds.Tables[0].Rows[2][1].ToString();
                label27.Text = Ds.Tables[0].Rows[2][2].ToString();

                label34.Text = Ds.Tables[0].Rows[3][0].ToString();
                label33.Text = Ds.Tables[0].Rows[3][1].ToString();
                label32.Text = Ds.Tables[0].Rows[3][2].ToString();
            }

            if (this.Ds.Tables[0].Rows.Count == 5)
            {
                label4.Text = Ds.Tables[0].Rows[0][0].ToString();
                label5.Text = Ds.Tables[0].Rows[0][1].ToString();
                label7.Text = Ds.Tables[0].Rows[0][2].ToString();


                label24.Text = Ds.Tables[0].Rows[1][0].ToString();
                label23.Text = Ds.Tables[0].Rows[1][1].ToString();
                label22.Text = Ds.Tables[0].Rows[1][2].ToString();

                label29.Text = Ds.Tables[0].Rows[2][0].ToString();
                label28.Text = Ds.Tables[0].Rows[2][1].ToString();
                label27.Text = Ds.Tables[0].Rows[2][2].ToString();

                label34.Text = Ds.Tables[0].Rows[3][0].ToString();
                label33.Text = Ds.Tables[0].Rows[3][1].ToString();
                label32.Text = Ds.Tables[0].Rows[3][2].ToString();

                label54.Text = Ds.Tables[0].Rows[4][0].ToString();
                label53.Text = Ds.Tables[0].Rows[4][1].ToString();
                label52.Text = Ds.Tables[0].Rows[4][2].ToString();
            }

            if (this.Ds.Tables[0].Rows.Count == 6)
            {
                label4.Text = Ds.Tables[0].Rows[0][0].ToString();
                label5.Text = Ds.Tables[0].Rows[0][1].ToString();
                label7.Text = Ds.Tables[0].Rows[0][2].ToString();


                label24.Text = Ds.Tables[0].Rows[1][0].ToString();
                label23.Text = Ds.Tables[0].Rows[1][1].ToString();
                label22.Text = Ds.Tables[0].Rows[1][2].ToString();

                label29.Text = Ds.Tables[0].Rows[2][0].ToString();
                label28.Text = Ds.Tables[0].Rows[2][1].ToString();
                label27.Text = Ds.Tables[0].Rows[2][2].ToString();

                label34.Text = Ds.Tables[0].Rows[3][0].ToString();
                label33.Text = Ds.Tables[0].Rows[3][1].ToString();
                label32.Text = Ds.Tables[0].Rows[3][2].ToString();

                label54.Text = Ds.Tables[0].Rows[4][0].ToString();
                label53.Text = Ds.Tables[0].Rows[4][1].ToString();
                label52.Text = Ds.Tables[0].Rows[4][2].ToString();

                label49.Text = Ds.Tables[0].Rows[5][0].ToString();
                label48.Text = Ds.Tables[0].Rows[5][1].ToString();
                label47.Text = Ds.Tables[0].Rows[5][2].ToString();
            }
            if (this.Ds.Tables[0].Rows.Count == 7)
            {
                label4.Text = Ds.Tables[0].Rows[0][0].ToString();
                label5.Text = Ds.Tables[0].Rows[0][1].ToString();
                label7.Text = Ds.Tables[0].Rows[0][2].ToString();


                label24.Text = Ds.Tables[0].Rows[1][0].ToString();
                label23.Text = Ds.Tables[0].Rows[1][1].ToString();
                label22.Text = Ds.Tables[0].Rows[1][2].ToString();

                label29.Text = Ds.Tables[0].Rows[2][0].ToString();
                label28.Text = Ds.Tables[0].Rows[2][1].ToString();
                label27.Text = Ds.Tables[0].Rows[2][2].ToString();

                label34.Text = Ds.Tables[0].Rows[3][0].ToString();
                label33.Text = Ds.Tables[0].Rows[3][1].ToString();
                label32.Text = Ds.Tables[0].Rows[3][2].ToString();

                label54.Text = Ds.Tables[0].Rows[4][0].ToString();
                label53.Text = Ds.Tables[0].Rows[4][1].ToString();
                label52.Text = Ds.Tables[0].Rows[4][2].ToString();

                label49.Text = Ds.Tables[0].Rows[5][0].ToString();
                label48.Text = Ds.Tables[0].Rows[5][1].ToString();
                label47.Text = Ds.Tables[0].Rows[5][2].ToString();

                label44.Text = Ds.Tables[0].Rows[6][0].ToString();
                label43.Text = Ds.Tables[0].Rows[6][1].ToString();
                label42.Text = Ds.Tables[0].Rows[6][2].ToString();
            }
            if (this.Ds.Tables[0].Rows.Count == 8)
            {
                label4.Text = Ds.Tables[0].Rows[0][0].ToString();
                label5.Text = Ds.Tables[0].Rows[0][1].ToString();
                label7.Text = Ds.Tables[0].Rows[0][2].ToString();


                label24.Text = Ds.Tables[0].Rows[1][0].ToString();
                label23.Text = Ds.Tables[0].Rows[1][1].ToString();
                label22.Text = Ds.Tables[0].Rows[1][2].ToString();

                label29.Text = Ds.Tables[0].Rows[2][0].ToString();
                label28.Text = Ds.Tables[0].Rows[2][1].ToString();
                label27.Text = Ds.Tables[0].Rows[2][2].ToString();

                label34.Text = Ds.Tables[0].Rows[3][0].ToString();
                label33.Text = Ds.Tables[0].Rows[3][1].ToString();
                label32.Text = Ds.Tables[0].Rows[3][2].ToString();

                label54.Text = Ds.Tables[0].Rows[4][0].ToString();
                label53.Text = Ds.Tables[0].Rows[4][1].ToString();
                label52.Text = Ds.Tables[0].Rows[4][2].ToString();

                label49.Text = Ds.Tables[0].Rows[5][0].ToString();
                label48.Text = Ds.Tables[0].Rows[5][1].ToString();
                label47.Text = Ds.Tables[0].Rows[5][2].ToString();

                label44.Text = Ds.Tables[0].Rows[6][0].ToString();
                label43.Text = Ds.Tables[0].Rows[6][1].ToString();
                label42.Text = Ds.Tables[0].Rows[6][2].ToString();

                label39.Text = Ds.Tables[0].Rows[7][0].ToString();
                label38.Text = Ds.Tables[0].Rows[7][1].ToString();
                label37.Text = Ds.Tables[0].Rows[7][2].ToString();

            }



        }

        private void domainUpDown1_TextChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.Text.Length > 0)
            {
                label17.Text = (Convert.ToInt16(domainUpDown1.Text) * Convert.ToInt16(label7.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Quantity cannot be null or 0");
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown2_TextChanged(object sender, EventArgs e)
        {
            if (domainUpDown2.Text.Length > 0)
            {
                label20.Text = (Convert.ToInt16(domainUpDown2.Text) * Convert.ToInt16(label22.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Quantity cannot be null or 0");
            }
        }

        private void domainUpDown3_TextChanged(object sender, EventArgs e)
        {
            if (domainUpDown3.Text.Length > 0)
            {
                label25.Text = (Convert.ToInt16(domainUpDown3.Text) * Convert.ToInt16(label27.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Quantity cannot be null or 0");
            }
        }

        private void domainUpDown4_TextChanged(object sender, EventArgs e)
        {
            if (domainUpDown4.Text.Length > 0)
            {
                label30.Text = (Convert.ToInt16(domainUpDown4.Text) * Convert.ToInt16(label32.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Quantity cannot be null or 0");
            }
        }

        private void domainUpDown8_TextChanged(object sender, EventArgs e)
        {
            if (domainUpDown8.Text.Length > 0)
            {
                label50.Text = (Convert.ToInt16(domainUpDown8.Text) * Convert.ToInt16(label52.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Quantity cannot be null or 0");
            }
        }

        private void domainUpDown7_TextChanged(object sender, EventArgs e)
        {
            if (domainUpDown7.Text.Length > 0)
            {
                label45.Text = (Convert.ToInt16(domainUpDown7.Text) * Convert.ToInt16(label47.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Quantity cannot be null or 0");
            }
        }

        private void domainUpDown6_TextChanged(object sender, EventArgs e)
        {
            if (domainUpDown6.Text.Length > 0)
            {
                label40.Text = (Convert.ToInt16(domainUpDown6.Text) * Convert.ToInt16(label42.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Quantity cannot be null or 0");
            }
        }

        private void domainUpDown5_TextChanged(object sender, EventArgs e)
        {
            {
                label35.Text = (Convert.ToInt16(domainUpDown5.Text) * Convert.ToInt16(label37.Text)).ToString();
            }
        }

        private void label17_TextChanged(object sender, EventArgs e)
        {
            label13.Text= (Convert.ToInt16(label17.Text) + Convert.ToInt16(label20.Text) + Convert.ToInt16(label25.Text) + Convert.ToInt16(label30.Text) + Convert.ToInt16(label50.Text) + Convert.ToInt16(label45.Text)+ Convert.ToInt16(label40.Text) + Convert.ToInt16(label35.Text)).ToString();
        }

        private void label20_TextChanged(object sender, EventArgs e)
        {
            label13.Text = (Convert.ToInt16(label17.Text) + Convert.ToInt16(label20.Text) + Convert.ToInt16(label25.Text) + Convert.ToInt16(label30.Text) + Convert.ToInt16(label50.Text) + Convert.ToInt16(label45.Text) + Convert.ToInt16(label40.Text) + Convert.ToInt16(label35.Text)).ToString();
        }

        private void label25_TextChanged(object sender, EventArgs e)
        {
            label13.Text = (Convert.ToInt16(label17.Text) + Convert.ToInt16(label20.Text) + Convert.ToInt16(label25.Text) + Convert.ToInt16(label30.Text) + Convert.ToInt16(label50.Text) + Convert.ToInt16(label45.Text) + Convert.ToInt16(label40.Text) + Convert.ToInt16(label35.Text)).ToString();
        }

        private void label30_TextChanged(object sender, EventArgs e)
        {
            label13.Text = (Convert.ToInt16(label17.Text) + Convert.ToInt16(label20.Text) + Convert.ToInt16(label25.Text) + Convert.ToInt16(label30.Text) + Convert.ToInt16(label50.Text) + Convert.ToInt16(label45.Text) + Convert.ToInt16(label40.Text) + Convert.ToInt16(label35.Text)).ToString();
        }

        private void label50_TextChanged(object sender, EventArgs e)
        {
            label13.Text = (Convert.ToInt16(label17.Text) + Convert.ToInt16(label20.Text) + Convert.ToInt16(label25.Text) + Convert.ToInt16(label30.Text) + Convert.ToInt16(label50.Text) + Convert.ToInt16(label45.Text) + Convert.ToInt16(label40.Text) + Convert.ToInt16(label35.Text)).ToString();
        }

        private void label45_TextChanged(object sender, EventArgs e)
        {
            label13.Text = (Convert.ToInt16(label17.Text) + Convert.ToInt16(label20.Text) + Convert.ToInt16(label25.Text) + Convert.ToInt16(label30.Text) + Convert.ToInt16(label50.Text) + Convert.ToInt16(label45.Text) + Convert.ToInt16(label40.Text) + Convert.ToInt16(label35.Text)).ToString();
        }

        private void label40_TextChanged(object sender, EventArgs e)
        {
            label13.Text = (Convert.ToInt16(label17.Text) + Convert.ToInt16(label20.Text) + Convert.ToInt16(label25.Text) + Convert.ToInt16(label30.Text) + Convert.ToInt16(label50.Text) + Convert.ToInt16(label45.Text) + Convert.ToInt16(label40.Text) + Convert.ToInt16(label35.Text)).ToString();
        }

        private void label35_TextChanged(object sender, EventArgs e)
        {
            label13.Text = (Convert.ToInt16(label17.Text) + Convert.ToInt16(label20.Text) + Convert.ToInt16(label25.Text) + Convert.ToInt16(label30.Text) + Convert.ToInt16(label50.Text) + Convert.ToInt16(label45.Text) + Convert.ToInt16(label40.Text) + Convert.ToInt16(label35.Text)).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length >= label13.Text.Length)
            {
                label10.Text = (Convert.ToInt16(textBox3.Text) - Convert.ToInt16(label13.Text)).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Make sure to enter Name and paid money");
            }
            else
            {
                printPreview.Document = printD;
                printPreview.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Make sure to enter Name and paid money");
            }
            else
            {
                printD.Print();
            }
        }

        private void printD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.Screenshot__24_;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);

            e.Graphics.DrawString("Customer Name:  " + textBox4.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 150));

            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 12), Brushes.Black, new Point(25, 180));

            e.Graphics.DrawString("Bill ID: " + label55.Text, new Font("Arial", 12), Brushes.Black, new Point(700, 180));

            e.Graphics.DrawString(Dash.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 200));

            e.Graphics.DrawString("Product Description", new Font("Arial", 12), Brushes.Black, new Point(25, 220));
            e.Graphics.DrawString("Quantity", new Font("Arial", 12), Brushes.Black, new Point(500, 220));
            e.Graphics.DrawString("Price", new Font("Arial", 12), Brushes.Black, new Point(700, 220));

            e.Graphics.DrawString(Dash.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 240));

            //1st left side er jonno
            e.Graphics.DrawString(label4.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 260));
            e.Graphics.DrawString(label5.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 280));

            //2nd left side er jonno
            e.Graphics.DrawString(label24.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 310));
            e.Graphics.DrawString(label23.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 330));

            //3nd left side er jonno
            e.Graphics.DrawString(label29.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 360));
            e.Graphics.DrawString(label28.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 380));

            //4nd left side er jonno
            e.Graphics.DrawString(label34.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 410));
            e.Graphics.DrawString(label33.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 430));

            //5nd left side er jonno
            e.Graphics.DrawString(label54.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 460));
            e.Graphics.DrawString(label53.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 480));

            //6nd left side er jonno
            e.Graphics.DrawString(label49.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 510));
            e.Graphics.DrawString(label48.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 530));

            //7nd left side er jonno
            e.Graphics.DrawString(label44.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 560));
            e.Graphics.DrawString(label43.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 580));


            //8nd left side er jonno
            e.Graphics.DrawString(label39.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 610));
            e.Graphics.DrawString(label38.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 630));

            //1st Right side er jonno 1 line dif hobe 700 +50 kore
            e.Graphics.DrawString("Total :" + label17.Text + "TK", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 280));
           
            //2nd Right side er jonno 1 line dif hobe 700 +50 kore
            e.Graphics.DrawString("Total :" + label20.Text + "TK", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 330));

            //3rd Right side er jonno 1 line dif hobe 700 +50 kore
            e.Graphics.DrawString("Total :" + label25.Text + "TK", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 380));

            //4rd Right side er jonno 1 line dif hobe 700 +50 kore
            e.Graphics.DrawString("Total :" + label30.Text + "TK", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 430));

            //5rd Right side er jonno 1 line dif hobe 700 +50 kore
            e.Graphics.DrawString("Total :" + label50.Text + "TK", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 480));

            //6rd Right side er jonno 1 line dif hobe 700 +50 kore
            e.Graphics.DrawString("Total :" + label45.Text + "TK", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 530));

            //7rd Right side er jonno 1 line dif hobe 700 +50 kore
            e.Graphics.DrawString("Total :" + label40.Text + "TK", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 580));

            //3rd Right side er jonno 1 line dif hobe 700 +50 kore
            e.Graphics.DrawString("Total :" + label35.Text + "TK", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 630));


            //1st mid  510 ar 50 add
            e.Graphics.DrawString(domainUpDown1.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 280));

            //2st mid 
            e.Graphics.DrawString(domainUpDown2.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 330));

            //3st mid 
            e.Graphics.DrawString(domainUpDown3.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 380));

            //4st mid 
            e.Graphics.DrawString(domainUpDown4.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 430));

            //5st mid 
            e.Graphics.DrawString(domainUpDown5.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 480));

            //6st mid 
            e.Graphics.DrawString(domainUpDown6.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 530));

            //7st mid 
            e.Graphics.DrawString(domainUpDown7.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 580));

            //8st mid 
            e.Graphics.DrawString(domainUpDown8.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(510, 630));

            


            e.Graphics.DrawString(Dash.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 680));
            e.Graphics.DrawString("Total Cost :" + label13.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 700));

            e.Graphics.DrawString(Dash.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 720));

            e.Graphics.DrawString("Paid Money :" + textBox3.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 740));

            e.Graphics.DrawString(Dash.Text, new Font("Arial", 12), Brushes.Black, new Point(25, 760));

            e.Graphics.DrawString("Return Money :" + label10.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 790));

            e.Graphics.DrawString("Thank You ! Come Again", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 820));

        }
    }
}
