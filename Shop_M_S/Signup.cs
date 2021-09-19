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
    
    public partial class Signup : Form
    {
        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }
        public Signup()
        {
            this.Da = new DataAccess();
            InitializeComponent();
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "--" || textBox2.Text == "--" || textBox3.Text == ""|| textBox4.Text == ""|| comboBox1.Text == "")
            {
                MessageBox.Show("Fill all the value");
            }
            else
            {
                try
                {
                   



             

                    this.Sql = @"insert into ResLogin values ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" +
                           this.comboBox1.Text + "','" + this.textBox4.Text + "','" + this.textBox3.Text + "');";
                    int count2 = this.Da.ExecuteUpdateQuery(this.Sql);



                   


                    if (count2 == 1)
                    {
                        MessageBox.Show("Employee added!!!");
                       
                    }
                    else
                    { MessageBox.Show("Server Busy"); }

                   
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }

            string constr = @"Data Source=desktop-k8o6se7\mssqlserver02;Initial Catalog=A-shop;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from ResLogin where Phone='" + this.textBox4.Text + "';"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        string currentno = sdr["UserId"].ToString();
                        
                        label3.Text = currentno;


                    }
                    con.Close();
                }
            }




        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminP a = new AdminP();
            this.Visible = false;
            a.Visible = true;
        }
    }
}
