using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication5;

namespace WindowsFormsApplication5
{
    public partial class Form4 : Form
    {
        Form3 frm3;

        VarClass jose;
        public Form4()
        {

            InitializeComponent();
            frm3 = new Form3();

        }
    

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
     

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            fescribirNombreProf(frm3.tProfMat1, cListadoProfesores);
        }

        private void fescribirNombreProf(TextBox txb1, ComboBox cbx1)
        {

            // frm1.jose.fval = cbx1.Text;

        //    txb1.Text = jose.fval;
        //    frm3.Show();

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
 

