using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;



namespace WindowsFormsApplication5
{
    
    
   
    public partial class Form1 : Form
    {
        Form2 frm2;
        string nombre1;
        string nombre2;
        string apellido1;
        string apellido2;
        string cargo;
        string cedula;
        string fpregunta1;
        string frespuesta1;
        string fpregunta2;
        string frespuesta2;
        string fpregunta3;
        string frespuesta3;
        public static string jose;
        Microsoft.Office.Interop.Excel.Application PROFESORES_USUARIOS_CLAVES = new Microsoft.Office.Interop.Excel.Application();
        int faciertos=0;
        int fpreg = 0;
        bool QIsAdmin = false;
        public Form1()
        {
            InitializeComponent();
           
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            try
            {
                //   PROFESORES_MATERIAS_CREDITOS = x.Workbooks.Open("C:\\Users\\ECP\\Documents\\PROFESORES_MATERIAS_CREDITOS.xlsx");
                //   PARALELO_MATERIA_PROFESOR = x.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");


                //PROFESORES_MATERIAS_CREDITOS.Application.Workbooks.Add(true);
                PROFESORES_USUARIOS_CLAVES.Workbooks.Open("C:\\Users\\ECP\\Documents\\PROFESORES_MATERIAS_CREDITOS.xlsx");
                PROFESORES_USUARIOS_CLAVES.Quit();

            }
            catch
            {

                PROFESORES_USUARIOS_CLAVES.Workbooks.Add(true);
                PROFESORES_USUARIOS_CLAVES.ActiveWorkbook.SaveAs("C:\\Users\\ECP\\Documents\\PROFESORES_MATERIAS_CREDITOS.xlsx");
                PROFESORES_USUARIOS_CLAVES.Quit();

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void bIngresar_Click(object sender, EventArgs e)
        {

            if(fvalidarUsuarioyClave(tUsuario, tClave) == 1)
            {
                frm2 = new Form2();
                frm2.lBienvenidoCool.Text = "Bienvenido/a: " + nombre1+" "+ nombre2 + " " + apellido1+" "+apellido2+ " ( "+cargo+" )";
                frm2.Show();
                frm2.cargo = cargo;
                if (cargo != "Administrador")
                {
                    frm2.PanelControl.Nodes.RemoveAt(2);

                }



                this.Hide();

                }
            
    
            

        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private int fvalidarUsuarioyClave(TextBox fUserVerificador, TextBox fClaveVerificador)
        {
            string cnnstring = @"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=|DataDirectory|\\login.mdb;";
            int cartel = 0;
            try
            {
                OleDbConnection conection = new OleDbConnection(cnnstring);
                OleDbCommand selectName = new OleDbCommand("SELECT Usuarios, Claves, Nombre1, Nombre2, Apellido1, Apellido2, Cargo From Accesos", conection);
                try
                {
                    
                    
                    conection.Open();
                    OleDbDataReader Lector = selectName.ExecuteReader();

                    if ((fUserVerificador.Text != "") && (fClaveVerificador.Text != ""))
                    {
                        cartel = 9;
                        while (Lector.Read())
                        {

                            if ((fUserVerificador.Text == Lector.GetValue(0).ToString() && (fClaveVerificador.Text == Lector.GetValue(1).ToString())))
                            {
                                cartel = 1;
                                nombre1 = Lector.GetValue(2).ToString();
                                nombre2 = Lector.GetValue(3).ToString();
                                apellido1 = Lector.GetValue(4).ToString();
                                apellido2 = Lector.GetValue(5).ToString();
                                cargo = Lector.GetValue(6).ToString();


                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Ingrese Usuario y contrasena", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (cartel != 1)
            {
                MessageBox.Show("usuario o contrasena incorrectos", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            return (cartel);
    }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frecuperarUsuarioClave();

        }

        private int frecuperarUsuarioClave()
        {

            panel1.Visible = false;
            
            panel2.Visible = true;

            panel3.Visible = false;

            return (0);
        }

        private int fBuscarDatos(string tipo,object tomar)
        {
            
            return (0);
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("SIGA-FCI-UPSE, Software de Gestion Academica desarrollado por LABSIM UPSE. Creditos: José Villegas S., Jorge Ordonez A.", "Informacion SIGA-FCI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lRecPregunta.Visible = true;
            tRecRespuestaPrg.Visible = true;
            bRecNext.Visible = true;
            fEncontrarPregyRes(tRecUser);
            lRecPregunta.Text = "Pregunta 1: " + fpregunta1;
            bRecPreguntas.Enabled = false;
            fpreg = 1;
            
        }


        private void fEncontrarPregyRes(TextBox jp)
        {

            string cnnstring = @"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=|DataDirectory|\\login.mdb;";
            int cartel = 0;
            try
            {
                OleDbConnection conection = new OleDbConnection(cnnstring);
                OleDbCommand selectName = new OleDbCommand("SELECT Usuarios, Pregunta1, Respuesta1, Pregunta2, Respuesta2, Pregunta3, Respuesta3 From PreguntasSecretas", conection);
                try
                {


                    conection.Open();
                    OleDbDataReader Lector = selectName.ExecuteReader();

                    if ((jp.Text != "") )
                    {
                        cartel = 9;
                        while (Lector.Read())
                        {

                            if ((jp.Text == Lector.GetValue(0).ToString() ))
                            {
                                cartel = 1;
                               
                                 fpregunta1= Lector.GetValue(1).ToString();
                                 frespuesta1= Lector.GetValue(2).ToString();
                                 fpregunta2 = Lector.GetValue(3).ToString();
                                 frespuesta2 = Lector.GetValue(4).ToString();
                                 fpregunta3 = Lector.GetValue(5).ToString();
                                 frespuesta3 = Lector.GetValue(6).ToString();


                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Error indeterminado, contactar al administrador", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (cartel != 1)
            {
                MessageBox.Show("usuario o contrasena incorrectos", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }





            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataSet.Accesos' table. You can move, or remove it, as needed.
            //this.accesosTableAdapter.Fill(this.loginDataSet.Accesos);


            // TODO: This line of code loads data into the 'loginDataSet.Accesos' table. You can move, or remove it, as needed.
            //  this.accesosTableAdapter.Fill(this.loginDataSet.Accesos);
            // TODO: This line of code loads data into the 'loginDataSet.Accesos' table. You can move, or remove it, as needed.
            //  this.accesosTableAdapter.Fill(this.loginDataSet.Accesos);
            //  this.accesosTableAdapter.AC("0802495069", "9009", "0802495069");
            //       this.accesosTableAdapter.ACN("0802495069", "9009", "0802495069");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cnnstring = @"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=|DataDirectory|\\login.mdb;";
            int cartel = 0;
            try
            {
                OleDbConnection conection = new OleDbConnection(cnnstring);
                OleDbCommand selectName = new OleDbCommand("SELECT Usuarios,Cedula, Claves, Nombre1, Nombre2, Apellido1, Apellido2, Cargo From Accesos", conection);
                try
                {


                    conection.Open();
                    OleDbDataReader Lector = selectName.ExecuteReader();

                    if ((tRecCed.Text != "") )
                    {
                        cartel = 9;
                        while (Lector.Read())
                        {

                            if ((tRecCed.Text == Lector.GetValue(1).ToString() ))
                            {
                                cartel = 1;
                                cedula = Lector.GetValue(1).ToString();
                                
                                tRecUser.Text= Lector.GetValue(0).ToString();



                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Ingrese un número de cédula", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (cartel != 1)
            {
                MessageBox.Show("usuario o contrasena incorrectos", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bRecOk_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            tUsuario.Text = tRecUser.Text;
        }

        private void bRecNext_Click(object sender, EventArgs e)
        {
            if (fpreg == 1)
            {
                fvalidarPreguntasRespuestas(tRecRespuestaPrg, frespuesta1);
                lRecPregunta.Text = "Pregunta 2: " + fpregunta2;
                tRecRespuestaPrg.Clear();

            }

            if (fpreg == 2)
            {
               
                fvalidarPreguntasRespuestas(tRecRespuestaPrg, frespuesta2);
                lRecPregunta.Text = "Pregunta 3: " + fpregunta3;
                bRecNext.Text = "Finalizar";
                tRecRespuestaPrg.Clear();
            }
            if (fpreg == 3)
            {
             
                fvalidarPreguntasRespuestas(tRecRespuestaPrg, frespuesta3);
                tRecRespuestaPrg.Clear();
                
                
           
            }

            fpreg = fpreg + 1;
            if (fpreg == 4)
            {
                if (faciertos >= 2)
                    {

                    panel2.Visible = false;
                    panel3.Visible = true;
                }

                else
                {
                    MessageBox.Show("Respuestas no coinciden con las registradas en el sistema", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    faciertos = 0;
                    fpreg = 0;
                    panel1.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    tRecCed.Clear();
                    tRecUser.Clear();
                    bRecPreguntas.Enabled = true;
                    
                   
                    lRecPregunta.Visible = false;
                    bRecNext.Text = "Siguiente";
                    bRecNext.Visible = false;
                    tRecRespuestaPrg.Visible = false;
                    tUsuario.Clear();
                    tClave.Clear();
                }


            }



        }

        private void fvalidarPreguntasRespuestas(TextBox jp, string respuesta)
        {
            if (jp.Text != "")
            {
                if (jp.Text == respuesta)
                {
                    faciertos = faciertos + 1;
                    
                }
                
            }
            else
            {
                MessageBox.Show("Ingrese una respuesta válida", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tNewClave.Text == tNewConfimClave.Text)
            {

                this.accesosTableAdapter.ACTUA("0802495069", tNewClave.Text, "0802495069");
                MessageBox.Show("Cambio de clave realizado con exito", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel3.Visible = false;
                panel1.Visible = true;


            }
            else
            {
                MessageBox.Show("Los campos de clave y verificacion no coinciden", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

   

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
             //   this.preguntasGeneralesTableAdapter.FillBy(this.loginDataSet.PreguntasGenerales);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void accesosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accesosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDataSet);

        }

        private void lAyuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void crearUsuarioProfesorContraseña(string nombre1, string nombre2, string apellido1, string apellido2, string claveInicial)
        {

            int fila = ComprobarNumeroDeRegistrados() + 1;
            PROFESORES_USUARIOS_CLAVES.Cells[fila, 1] = nombre1;
            PROFESORES_USUARIOS_CLAVES.Cells[fila, 2] = nombre2;
            PROFESORES_USUARIOS_CLAVES.Cells[fila, 3] = apellido1;
            PROFESORES_USUARIOS_CLAVES.Cells[fila, 4] = apellido2;
            PROFESORES_USUARIOS_CLAVES.Cells[fila, 5] = claveInicial;


        }

        private int ComprobarNumeroDeRegistrados()
        {
            int j = 0;
            for (int i = 1; i <= 150; i++)
            {
                if (PROFESORES_USUARIOS_CLAVES.Cells[i, 1] == "")
                {
                    j = i;
                    break;

                }
            }




            return (j);
        }



    }

}






