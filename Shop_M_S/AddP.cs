using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shop_M_S.Presentation_Layer
{
    public partial class AddP : Form
    {
        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }

        public AddP()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
      
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminP a = new AdminP();
            this.Visible = false;
            a.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("please select a product");
            }
            else
            {
                try
                {
                    




                    this.Sql = @"insert into Product values ('" +  this.textBox1.Text + "','" + this.textBox2.Text + "','" +
                           this.textBox3.Text + "');";
                    int count2 = this.Da.ExecuteUpdateQuery(this.Sql);



                   

                    if (count2 == 1)
                    {
                        MessageBox.Show("Item added!!!");
                       
                    }
                    else
                    { MessageBox.Show("Server Busy"); }

                   
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddP_Load(object sender, EventArgs e)
        {

        }
    }
}
