using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shop_M_S.Presentation_Layer
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminP a = new AdminP();
            this.Visible = false;
            a.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("please select a product");
            }
            else
            {
                try
                {
                   
                    


                    this.Sql = @"Update Product set Pname='" + textBox2.Text + "', Prize='" + textBox3.Text + "' where Pno=' " + this.textBox1.Text + " ';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);


                    if (count == 1)
                    {
                        MessageBox.Show("Item Updated!!!");
                       
                    }
                    else
                    { MessageBox.Show("Please enter sl no"); }

                   
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {


                MessageBox.Show("please Enter Product SL No");


            }
            else
            {
                string constr = @"Data Source=desktop-k8o6se7\mssqlserver02;Initial Catalog=A-shop;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("Select * from Product where Pno = ' " + this.textBox1.Text + " ';"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                           

                                textBox2.Text = sdr["Pname"].ToString(); ;
                                textBox3.Text = sdr["Prize"].ToString(); ;
                            

                        }
                        con.Close();
                    }
                }
            }
        }
    }
}
