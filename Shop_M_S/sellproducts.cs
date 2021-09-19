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

namespace Shop_M_S
{
    public partial class sellproducts : Form
    {
        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }

        public sellproducts()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            button4.Visible = false;
            this.PopulateGridView();
        }
       
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void sellproducts_Load(object sender, EventArgs e)
        {
            

            string constr = @"Data Source=AYSH-STAR;Integrated Security=SSPI;Initial Catalog=A-shop";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Billingsl where Status='Active';"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        string currentno = sdr["Billingno"].ToString();
                        var newno= (Convert.ToInt16(currentno) +Convert.ToInt16(1)).ToString();
                        label8.Text = newno;
                        
                       
                    }
                    con.Close();
                }
            }





            this.PopulateGridView();

        }

        private void PopulateGridView(string sql = "select * from Product;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = this.Ds.Tables[0];
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Sql = @"select * from Product where Pno = ' " + this.textBox4.Text + " ' OR Pname = ' " + this.textBox4.Text + " ';";
            this.PopulateGridView(this.Sql);
        }

        private void dataGridView1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            label5.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "--" || label3.Text == "--" || label5.Text == "--")
            {
                MessageBox.Show("please select a product");
            }
            else
            {
                try
                {
                    /* this.Sql = @"CREATE TABLE [dbo].[Cart](
     [Sl] [varchar](50) NOT NULL,
     [ItemName] [varchar](50) NOT NULL,
     [Price] [varchar](50) NOT NULL,
  PRIMARY KEY(Sl)
  );";



                     int count = this.Da.ExecuteUpdateQuery(this.Sql);*/





                    this.Sql = @"insert into Allbills values ('"+ this.label2.Text +"','"+ this.label3.Text +"','"+
                           this.label5.Text +"','"+ this.label8.Text +"','"+ DateTime.Now +"');";
                    int count2 = this.Da.ExecuteUpdateQuery(this.Sql);



                    this.Sql = @"Update Billingsl set Billingno='" +label8.Text+ "' where Status='Active';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);


                    if (count2 == 1)
                    {
                        MessageBox.Show("Item added!!!");
                        button4.Visible = true;
                    }
                    else
                    { MessageBox.Show("Server Busy"); }

                    this.PopulateGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckOut co = new CheckOut(label8.Text);
            co.Visible = true;
            this.Visible = false;

        }
    }
}
