using Shop_M_S.Presentation_Layer;
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
    public partial class Login : Form
    {
        internal DataAccess Da { get; set; }
        internal DataSet Ds { get; set; }

        Boolean path = false;
        public Login()
        {
            InitializeComponent();

            textBox2.PasswordChar = '#';
            textBox2.MaxLength = 10;
            this.Da = new DataAccess();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text =="" || textBox2.Text =="")
            {
                MessageBox.Show("TextBox cannot be empty");
            }
            else
            { if (path == false)
                {
                    string sql = @"select * from Login where UserId = '" + this.textBox1.Text + "' and Password = '" + this.textBox2.Text + "';";
                    this.Ds = this.Da.ExecuteQuery(sql);

                    if (this.Ds.Tables[0].Rows.Count == 1)
                    {
                        path = true;
                        AdminP ap = new AdminP();
                        this.Visible = false;
                        ap.Visible = true;
                    }

                    else
                    {
                        path = false;
                    }
                }

                if(path==false)
                {
                    string sql = @"select * from ResLogin where UserId = '" + this.textBox1.Text + "' and Password = '" + this.textBox2.Text + "';";
                    this.Ds = this.Da.ExecuteQuery(sql);

                    if (this.Ds.Tables[0].Rows.Count == 1)
                    {
                        path = true;
                        sellproducts ap = new sellproducts();
                        this.Visible = false;
                        ap.Visible = true;
                    }

                    else
                    {
                        path = false;
                    }

                }

                if (path==false)
                {
                    string sql = @"select * from Login where UserId = '" + this.textBox1.Text + "' and Password = '" + this.textBox2.Text + "';";
                    this.Ds = this.Da.ExecuteQuery(sql);

                    if (this.Ds.Tables[0].Rows.Count == 1)
                    {
                        path = true;
                        AdminP ap = new AdminP();
                        this.Visible = false;
                        ap.Visible = true;
                    }

                    else
                    {
                        path = false;
                    }
                }

                if(path==false)
                {
                    MessageBox.Show("Wrong Username Or Password");

                }
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup acc = new Signup();
            this.Visible = false;
            acc.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch)&&ch != 8 && ch !=46)
            { e.Handled = true; }
        }
    }
}
