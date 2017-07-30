using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using WindowsFormsApplication5;
using System.Windows.Forms;


namespace WindowsFormsApplication5
{
    public partial class Form3 : Form
    {
        Form4 frm4;
   
        public Form3()
        {
            
            InitializeComponent();
           

            ComboxSemestres.Items.Add("PRIMER SEMESTRE");
            ComboxSemestres.Items.Add("SEGUNDO SEMESTRE");
            ComboxSemestres.Items.Add("TERCER SEMESTRE");
            ComboxSemestres.Items.Add("CUARTO SEMESTRE");
            ComboxSemestres.Items.Add("QUINTO SEMESTRE");
            ComboxSemestres.Items.Add("SEXTO SEMESTRE");
            ComboxSemestres.Items.Add("SEPTIMO SEMESTRE");
            ComboxSemestres.Items.Add("OCTAVO SEMESTRE");
            ComboxSemestres.Items.Add("NOVENO SEMESTRE");
            ComboxSemestres.Items.Add("DECIMO SEMESTRE");
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fMateriaAsignar(tMateria1);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tMateria1.Text = "";
            tMateria1.Enabled = false;

            tMateria2.Text = "";
            tMateria2.Enabled = false;

            tMateria3.Text = "";
            tMateria3.Enabled = false;

            tMateria4.Text = "";
            tMateria4.Enabled = false;

            tMateria5.Text = "";
            tMateria5.Enabled = false;

            tMateria6.Text = "";
            tMateria6.Enabled = false;
            fRevisarParalelos(ComboxSemestres);
           
            
        }

        private void fRevisarParalelos(ComboBox combi)
        {
            ComboxParalelsParalelos.Items.Clear();
            ComboxParalelsParalelos.Text = "Paralelo";
            string cnnstring = @"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=|DataDirectory|\\login.mdb;";
            try
            {
                OleDbConnection conection = new OleDbConnection(cnnstring);
                OleDbCommand selectName = new OleDbCommand("SELECT N, SEMESTRE, CREDITOS, PARALELOS From SemestresParalelos", conection);
                try
                {

                    conection.Open();
                    OleDbDataReader Lector = selectName.ExecuteReader();

                    while (Lector.Read())
                    {

                        if ((combi.Text == Lector.GetValue(1).ToString()))
                        {
                            ComboxParalelsParalelos.Items.Clear();
                            if ((Lector.GetValue(3).ToString() != "0"))
                            {
                                ComboxParalelsParalelos.Items.Add("1");
                                if ((Lector.GetValue(3).ToString() != "1"))
                            {
                                ComboxParalelsParalelos.Items.Add("2");

                                if ((Lector.GetValue(3).ToString() != "2"))
                                {
                                    ComboxParalelsParalelos.Items.Add("3");
                                    if ((Lector.GetValue(3).ToString() != "3"))
                                    {
                                        ComboxParalelsParalelos.Items.Add("4");
                                        if ((Lector.GetValue(3).ToString() != "4"))
                                        {
                                            ComboxParalelsParalelos.Items.Add("5");
                                            if ((Lector.GetValue(3).ToString() != "5"))
                                            {
                                                ComboxParalelsParalelos.Items.Add("6");

                                        
                                                if ((Lector.GetValue(3).ToString() != "6"))
                                                {
                                                    ComboxParalelsParalelos.Items.Add("7");
                                                    }
                                                }
                                            }

                                    }

                                }
                               }

                            }
                           
                        }
                    }



                }
                catch
                {
                    MessageBox.Show("no conection 1 ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch
            {
                MessageBox.Show("no conection 2 ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            tMateria1.Text = "" ;
            tMateria1.Enabled = false;

            tMateria2.Text = "";
            tMateria2.Enabled = false;

            tMateria3.Text = "" ;
            tMateria3.Enabled = false;

            tMateria4.Text = "" ;
            tMateria4.Enabled = false;

            tMateria5.Text = "" ;
            tMateria5.Enabled = false;

            tMateria6.Text = "" ;
            tMateria6.Enabled = false;

            //primer Semestre
            if (ComboxSemestres.Text=="PRIMER SEMESTRE")
            { 
               tMateria1.Text= "ANALISIS MATEMATICO I" + Environment.NewLine + "CREDITOS:  6";
        
                tMateria1.Enabled = false;

           tMateria2.Text = "GEOMETRÍA GENERAL I" + Environment.NewLine + "CREDITOS:  3";
                tMateria2.Enabled = false;
               
           tMateria3.Text = "FISICA I" + Environment.NewLine + "CREDITOS:  6";
                tMateria3.Enabled = false;
           
           tMateria4.Text = "QUIMICA GENERAL" + Environment.NewLine + "CREDITOS:  3";
                tMateria4.Enabled = false;
               
           tMateria5.Text = "DIBUJO TECNICO I" + Environment.NewLine + "CREDITOS:  2";
                tMateria5.Enabled = false;
              
          tMateria6.Text = "TEC.DE EXP. ORAL Y ESCRITA" + Environment.NewLine + "CREDITOS:  2";
                tMateria6.Enabled = false;
                

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Archivos Creados con EXITO en la carpeta especificada", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            fMateriaAsignar(tMateria2);
        }

        private void fMateriaAsignar(TextBox T1)
        {
            frm4 = new Form4();
            frm4.tMateriaMod.Text = T1.Text;
            frm4.tMateriaMod.Enabled = false;
            frm4.cListadoProfesores.Items.Add("JOSE BALLARDO VILLEGAS SALABARRIA");
            frm4.cListadoProfesores.Items.Add("JORGE PAUL ORDOÑEZ ANDRADE");
            frm4.cListadoProfesores.Items.Add("WALTER ENRIQUE BARBERAN MACIAS");
            frm4.cListadoProfesores.Items.Add("CARLOS ANDRES RIVAS MURILLO");
            frm4.cListadoProfesores.Items.Add("MAYRA DE LOURDES MEJIA RUIZ");
            frm4.cListadoProfesores.Items.Add("CARLOS ALBERTO PROTILLA LAZO");
          //  tProfMat1.Text= frm4.jose.fval;
            frm4.Show();
       //     tProfMat1.Text = frm4.jose.fval;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fMateriaAsignar(tMateria3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fMateriaAsignar(tMateria4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fMateriaAsignar(tMateria5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fMateriaAsignar(tMateria6);
        }
    }
}
