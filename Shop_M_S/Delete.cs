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
    public partial class Delete : Form
    {
        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }
        public Delete()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res.Equals(DialogResult.Yes))
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("value cannot faka ");
                }
                else
                {

                    this.Sql = "delete from Product where Pno = ' " + this.textBox1.Text + " ';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);

                    if (count == 1)
                        MessageBox.Show("Sl. no" + textBox1.Text + " has been deleted");
                    else
                        MessageBox.Show("Error while deleting data");



                }
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminP a = new AdminP();
            this.Visible = false;
            a.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
