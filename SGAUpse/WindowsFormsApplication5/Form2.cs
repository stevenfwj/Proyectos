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
using WindowsFormsApplication5;
using Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Collections;
using System.Collections.Generic;



namespace WindowsFormsApplication5
{
    public partial class Form2 : Form
    {
        Form1 frm1;
        Form3 frm3;


        public string nombre1;
        public string nombre2;
        public string apellido1;
        public string apellido2;
        public string cargo;
        public string cedula;
        public string Cedula, Nombre1, Nombre2, Apellido1, Apellido2, LuegarDeNacimiento, FechaDeNacimiento, CorreoElectronico, Telefono, TituloTercerNivel, RegistroSenescytTN, MayorNivel, TituloCuartoNivel, RegistroSenescytCN, OtrosTitulosCN, RegistroSenescytOtrosTCN, Dedicacion, CargaUniversitaria, Especificidad;
        Microsoft.Office.Interop.Excel.Application x = new Microsoft.Office.Interop.Excel.Application();
        Microsoft.Office.Interop.Excel.Application PROFESORES_MATERIAS_CREDITOS = new Microsoft.Office.Interop.Excel.Application();
        Microsoft.Office.Interop.Excel.Application PARALELO_MATERIA_PROFESOR = new Microsoft.Office.Interop.Excel.Application();
        Microsoft.Office.Interop.Excel.Application AULAS = new Microsoft.Office.Interop.Excel.Application();
        Microsoft.Office.Interop.Excel.Application FORMATO_HORARIO_PARALELOS = new Microsoft.Office.Interop.Excel.Application();
        Microsoft.Office.Interop.Excel.Application PROFESORES_USUARIOS_CLAVES = new Microsoft.Office.Interop.Excel.Application();



        public object SaveFileDialog1 { get; private set; }

        public Form2()

        {

            InitializeComponent();
            cargarSemestres(PARALELO_MATERIA_PROFESOR, ComboxSemestres);

            //  ComboxSemestres.Items.Add("PRIMER SEMESTRE");
            //ComboxSemestres.Items.Add("SEGUNDO SEMESTRE");
            //ComboxSemestres.Items.Add("TERCER SEMESTRE");
            //ComboxSemestres.Items.Add("CUARTO SEMESTRE");
            //ComboxSemestres.Items.Add("QUINTO SEMESTRE");
            //ComboxSemestres.Items.Add("SEXTO SEMESTRE");
            // ComboxSemestres.Items.Add("SEPTIMO SEMESTRE");
            //ComboxSemestres.Items.Add("OCTAVO SEMESTRE");
            //ComboxSemestres.Items.Add("NOVENO SEMESTRE");
            //ComboxSemestres.Items.Add("DECIMO SEMESTRE");



            EscribirBlock(tSemestre1, tParaleloS1, "1");
            EscribirBlock(tSemestre2, tParaleloS2, "2");
            EscribirBlock(tSemestre3, tParaleloS3, "3");
            EscribirBlock(tSemestre4, tParaleloS4, "4");
            EscribirBlock(tSemestre5, tParaleloS5, "5");
            EscribirBlock(tSemestre6, tParaleloS6, "6");
            EscribirBlock(tSemestre7, tParaleloS7, "7");
            EscribirBlock(tSemestre8, tParaleloS8, "8");
            EscribirBlock(tSemestre9, tParaleloS9, "9");
            EscribirBlock(tSemestre10, tParaleloS10, "10");
            tBapellido1.Text = "";
            tBapellido2.Text = "";
            tBcedula.Text = "";
            tBCorreoElectronico.Text = "";
            tBfechaDeNacimiento.Text = "";
            tBlugarDeNacimiento.Text = "";
            tBnombre1.Text = "";
            tBnombre2.Text = "";
            tBotrosTitulosCN.Text = "";
            tBregistroSenescytCN.Text = "";
            tBregistroSenescytOtrosTCN.Text = "";
            tBregistroSenescytTN.Text = "";
            tBtelefono.Text = "";
            tBtituloCuartoNivel.Text = "";
            tBtituloTercerNivel.Text = "";
            ActivarDesactivarBotones(false);
            LimpiarTextos();
            //    Microsoft.Office.Interop.Excel._Workbook PROFESORES_MATERIAS_CREDITOS;
            //Microsoft.Office.Interop.Excel.Application PROFESORES_MATERIAS_CREDITOS;
            //Microsoft.Office.Interop.Excel._Workbook PARALELO_MATERIA_PROFESOR;
           



            //  Microsoft.Office.Interop.Excel.Application x = new Microsoft.Office.Interop.Excel.Application();


            try
            {
                //   PROFESORES_MATERIAS_CREDITOS = x.Workbooks.Open("C:\\Users\\ECP\\Documents\\PROFESORES_MATERIAS_CREDITOS.xlsx");
                //   PARALELO_MATERIA_PROFESOR = x.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");


                //PROFESORES_MATERIAS_CREDITOS.Application.Workbooks.Add(true);
                PROFESORES_MATERIAS_CREDITOS.Workbooks.Open("C:\\Users\\ECP\\Documents\\PROFESORES_MATERIAS_CREDITOS.xlsx");
                PROFESORES_MATERIAS_CREDITOS.Quit();
                
            }
            catch
            {

                PROFESORES_MATERIAS_CREDITOS.Workbooks.Add(true);
                PROFESORES_MATERIAS_CREDITOS.ActiveWorkbook.SaveAs("C:\\Users\\ECP\\Documents\\PROFESORES_MATERIAS_CREDITOS.xlsx");

              //  PROFESORES_MATERIAS_CREDITOS.ActiveWorkbook.Save();
                PROFESORES_MATERIAS_CREDITOS.Quit();

            }


            try
            {
                //   PROFESORES_MATERIAS_CREDITOS = x.Workbooks.Open("C:\\Users\\ECP\\Documents\\PROFESORES_MATERIAS_CREDITOS.xlsx");
                //   PARALELO_MATERIA_PROFESOR = x.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");


                //PROFESORES_MATERIAS_CREDITOS.Application.Workbooks.Add(true);
                PROFESORES_USUARIOS_CLAVES.Workbooks.Open("C:\\Users\\ECP\\Documents\\PROFESORES_USUARIOS_CLAVES.xlsx");
                PROFESORES_USUARIOS_CLAVES.Quit();

            }
            catch
            {

                PROFESORES_USUARIOS_CLAVES.Workbooks.Add(true);
                PROFESORES_USUARIOS_CLAVES.ActiveWorkbook.SaveAs("C:\\Users\\ECP\\Documents\\PROFESORES_USUARIOS_CLAVES.xlsx");

                //PROFESORES_USUARIOS_CLAVES.ActiveWorkbook.Save();
                PROFESORES_USUARIOS_CLAVES.Quit();

            }

            // PROFESORES_MATERIAS_CREDITOS.ActiveSheet.name = "VILLEGAS ES UN GENIO_";
            // PROFESORES_MATERIAS_CREDITOS.Quit();
            //PARALELO_MATERIA_PROFESOR.Application.Workbooks.Add(true);
            try
            {
                PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");
                PARALELO_MATERIA_PROFESOR.Quit();
            }
            catch
            {
                PARALELO_MATERIA_PROFESOR.Workbooks.Add(true);
                PARALELO_MATERIA_PROFESOR.ActiveWorkbook.SaveAs("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");
                //PARALELO_MATERIA_PROFESOR.ActiveWorkbook.Save();

                PARALELO_MATERIA_PROFESOR.Quit();

            }

            try
            {
                AULAS.Workbooks.Open("C:\\Users\\ECP\\Documents\\AULAS_HORARIOS.xlsx");
                AULAS.Quit();

            }
            catch
            {
                AULAS.Workbooks.Add(true);
                AULAS.ActiveWorkbook.SaveAs("C:\\Users\\ECP\\Documents\\AULAS_HORARIOS.xlsx");
            //    AULAS.ActiveWorkbook.Save();

                AULAS.Quit();

            }

        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            frm3 = new Form3();

            cargarAulas(AULAS, cbHAulas);
            cargarSemestres(PARALELO_MATERIA_PROFESOR, cbhSemestre);
            cbAProfesor.Items.Clear();
            cargarPorfesores(cbAProfesor);

            if (e.Node.Text == "Asignar MATERIA-PROFESOR")
            {
                frm3.Show();
            }

            if (e.Node.Text == "Activar Usuario")
            {
                activarusuario();
            }
            if (e.Node.Text == "Administrar Paralelos")
            {
                panel3.Visible = true;
                cargarParalelosIniciales();

            }

        }

        private void cargarParalelosIniciales()
        {
            PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");
            PARALELO_MATERIA_PROFESOR.Application.ActiveWorkbook.Sheets[1].Activate();
            tParaleloS1.Text = PARALELO_MATERIA_PROFESOR.Cells[1, 2].Text;
            tParaleloS2.Text = PARALELO_MATERIA_PROFESOR.Cells[2, 2].Text;
            tParaleloS3.Text = PARALELO_MATERIA_PROFESOR.Cells[3, 2].Text;
            tParaleloS4.Text = PARALELO_MATERIA_PROFESOR.Cells[4, 2].Text;
            tParaleloS5.Text = PARALELO_MATERIA_PROFESOR.Cells[5, 2].Text;
            tParaleloS6.Text = PARALELO_MATERIA_PROFESOR.Cells[6, 2].Text;
            tParaleloS7.Text = PARALELO_MATERIA_PROFESOR.Cells[7, 2].Text;
            tParaleloS8.Text = PARALELO_MATERIA_PROFESOR.Cells[8, 2].Text;
            tParaleloS9.Text = PARALELO_MATERIA_PROFESOR.Cells[9, 2].Text;
            tParaleloS10.Text = PARALELO_MATERIA_PROFESOR.Cells[10, 2].Text;
            PARALELO_MATERIA_PROFESOR.Quit();

        }

        private void activarusuario()
        {

        }

        private void crearUsuarioProfesorContraseña(string nombre1, string nombre2, string apellido1, string apellido2, string claveInicial)
        {
            PROFESORES_USUARIOS_CLAVES.Workbooks.Open("C:\\Users\\ECP\\Documents\\PROFESORES_USUARIOS_CLAVES.xlsx");

            int fila = ComprobarNumeroDeRegistrados();
            PROFESORES_USUARIOS_CLAVES.Cells[fila, 1] =nombre1;
            PROFESORES_USUARIOS_CLAVES.Cells[fila, 2] =nombre2;
            PROFESORES_USUARIOS_CLAVES.Cells[fila, 3] =apellido1;
            PROFESORES_USUARIOS_CLAVES.Cells[fila, 4] =apellido2;
            PROFESORES_USUARIOS_CLAVES.Cells[fila, 5] = claveInicial;
            PROFESORES_USUARIOS_CLAVES.Cells[fila, 6] =claveInicial;
            PROFESORES_USUARIOS_CLAVES.ActiveWorkbook.Save();

            PROFESORES_USUARIOS_CLAVES.Quit();
        }

        private int ComprobarNumeroDeRegistrados()
        {
            int j = 0;
            for (int i = 1; i<= 150; i++) {
                
                if (PROFESORES_USUARIOS_CLAVES.Cells[i, 1].Text == "")
                {
                    j = i;
                    break;
                    
                }
            }

        


            return (j);
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void lBienvenidoNombre_Click(object sender, EventArgs e)
        {

        }

        private void accesosAutorizadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.loginDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'loginDataSet.ProfesoresRegistrados'. Você pode movê-la ou removê-la conforme necessário.
            //  this.profesoresRegistradosTableAdapter.Fill(this.loginDataSet.ProfesoresRegistrados);

            // TODO: This line of code loads data into the 'loginDataSet.AccesosAuto' table. You can move, or remove it, as needed.
            this.accesosAutoTableAdapter.Fill(this.loginDataSet.AccesosAuto);
            // TODO: This line of code loads data into the 'loginDataSet.AccesosAutorizados' table. You can move, or remove it, as needed.
            //     this.accesosAutorizadosTableAdapter.Fill(this.loginDataSet.AccesosAutorizados);

        }

        private void nombre1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAutorizar_Click(object sender, EventArgs e)
        {
            if ((tBcedula.Text != "") && (tBnombre1.Text != "") && (tBnombre2.Text != "") && (tBapellido1.Text != "") && (tBapellido2.Text != ""))
            {

                //   this.accesosAutorizadosTableAdapter.InsertarAutorizacion(tcedulaTextBox.Text, tnombre1TextBox.Text,tnombre2TextBox.Text, tapellido1TextBox.Text, tapellido2TextBox.Text, tcomboBox1.Text);

                try
                {
                    this.accesosAutoTableAdapter.AUTOACCESO(tBcedula.Text, tBnombre1.Text, tBnombre2.Text, tBapellido1.Text, tBapellido2.Text, tBcBoxCargaUniversitaria.Text);
                    MessageBox.Show("El usuario: " + tBnombre1.Text + " " + tBnombre2.Text + " " + tBapellido1.Text + " " + tBapellido2.Text + " ha sido registrado con éxtito", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.accesosAutoTableAdapter.Fill(this.loginDataSet.AccesosAuto);
                    tBcedula.Text = "";
                    tBnombre1.Text = "";
                    tBnombre2.Text = "";
                    tBapellido1.Text = "";
                    tBapellido2.Text = "";
                }
                catch {
                    MessageBox.Show("Usuario ya registrado", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            else
            {
                MessageBox.Show("Llenar todos los campos", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void accesosAutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accesosAutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.loginDataSet);

        }

        public void escribirenExcel(Microsoft.Office.Interop.Excel.Application j, string semestre, string npar)
        {
            // Microsoft.Office.Interop.Excel.Application x = new Microsoft.Office.Interop.Excel.Application();
            // x.Application.Workbooks.Add(true);
            //  j.Application.Workbooks.Add(true);
            int h = 0;
            for (int i = 1; i < 20; i++) {
                // j.Application.Worksheets.Add();
                // j.ActiveSheet.name = semestre +"par_"+ i.ToString();
                //x.Application.Worksheets.Add();

                if (i.ToString() == npar)
                {
                    h = i;
                    break;
                }
            }


            for (int i = h; i > 0; i--)
            {
                j.ActiveSheet.name = semestre + "_" + "par_" + i.ToString();
                j.Cells[1, 1] = "SEMESTRE:";
                j.Cells[1, 2] = semestre;
                j.Cells[2, 1] = "PARALELO:";
                j.Cells[2, 2] = i;
                //this.materiasCreditosSemestreTableAdapter1.GetDataBy(1).Select("1");

                EscribirMateriasCreditos(j, semestre,i);

                if (i > 1) {
                    j.Application.Worksheets.Add();
                }

                //x.Application.Worksheets.Add();

            }


            //x.ActiveSheet.name = "JOSE";
            //x.Application.Worksheets.Add();
            //x.ActiveSheet.name = "JOSE2";
            //x.Application.Worksheets.Add();
            //x.ActiveSheet.name = "KKKK";
            //x.Application.ActiveWorkbook.Sheets[2].Activate();
            //x.Worksheets.Application.ActiveSheet("JOSE");
            //   x.Application.Worksheets().Activate;
            //    x.Cells[1, 1] = text;
            //x.Cells[1, 2] = "SEMESTRE";
            //x.Cells[1, 3] = "PARALELO";
            //x.Cells[1, 4] = "MATERIA";
            //x.Cells[1, 5] = "CREDITOS";
            //x.Cells[2, 1] = "1";
            //x.Cells[3, 1] = "2";
            //x.Cells[4, 1] = "3";

            //    x.Visible = true;
            //   saveFileDialog1.DefaultExt = "*.xlsx";
            //   saveFileDialog1.FileName = "KKKK";
            //   saveFileDialog1.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            //   saveFileDialog1.ShowDialog();
            //x.ActiveWorkbook.SaveAs("C:\\Users\\ECP\\Documents\\MATERIAS_ASIGNADAS.xlsx");
            //x.GetSaveAsFilename(saveFileDialog1.FileName);
            //x.Quit();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EscribirBlock(System.Windows.Forms.TextBox TBox1, System.Windows.Forms.TextBox TBox2, string val)
        {
            string cnnstring = @"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=|DataDirectory|\\login.mdb;";
            int cartel = 0;
            try
            {
                OleDbConnection conection = new OleDbConnection(cnnstring);
                OleDbCommand selectName = new OleDbCommand("SELECT N, SEMESTRE, CREDITOS, PARALELOS From SemestresParalelos", conection);
                try
                {

                    conection.Open();
                    OleDbDataReader Lector = selectName.ExecuteReader();


                    cartel = 9;
                    while (Lector.Read())
                    {

                        if ((val == Lector.GetValue(0).ToString()))
                        {
                            TBox1.Text = Lector.GetValue(1).ToString();
                            TBox2.Text = Lector.GetValue(3).ToString();
                            TBox1.Enabled = false;
                            TBox2.Enabled = false;

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

        private void bRegistrarProf_Click(object sender, EventArgs e)
        {

            if (tBnombre1.Text != "" && tBnombre2.Text != "" && tBapellido1.Text != "" && tBapellido2.Text != "" && tBlugarDeNacimiento.Text != "" && tBfechaDeNacimiento.Text != "" && tBCorreoElectronico.Text != "" && tBtelefono.Text != "" && tBtituloTercerNivel.Text != "" && tBregistroSenescytTN.Text != "" && tBcboxMayorNivel.Text != "" && tBtituloCuartoNivel.Text != "" && tBregistroSenescytCN.Text != "" && tBotrosTitulosCN.Text != "" && tBregistroSenescytOtrosTCN.Text != "" && tBcBoxDedicacion.Text != "" && tBcBoxCargaUniversitaria.Text != "" && tBcBoxEspecificidad.Text != "")
            {
                if (VerificarAccesoProfesor(tBcedula.Text) == 1)
                {
                    this.profesoresRegistrados1TableAdapter1.InsertarNuevoProfesor(tBcedula.Text,
                    tBnombre1.Text,
                    tBnombre2.Text,
                    tBapellido1.Text,
                    tBapellido2.Text,
                    tBlugarDeNacimiento.Text,
                   tBfechaDeNacimiento.Value,
                    tBCorreoElectronico.Text,
                    tBtelefono.Text,
                    tBtituloTercerNivel.Text,
                    tBregistroSenescytTN.Text,
                   tBcboxMayorNivel.Text,
                    tBtituloCuartoNivel.Text,
                    tBregistroSenescytCN.Text,
                    tBotrosTitulosCN.Text,
                  tBregistroSenescytOtrosTCN.Text,
                    tBcBoxDedicacion.Text,
                    tBcBoxCargaUniversitaria.Text,
                     tBcBoxEspecificidad.Text);

                    MessageBox.Show("Profesor registrado con éxito", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CrearPaginaProf(tBnombre1.Text, tBnombre2.Text, tBapellido1.Text, tBapellido2.Text, tBcedula.Text);
                    ActivarDesactivarBotones(false);
                    bRegistrarProf.Enabled = false;

                    crearUsuarioProfesorContraseña(tBnombre1.Text,tBnombre2.Text,tBapellido1.Text,tBapellido2.Text,tBcedula.Text);


                }

            }
            else {

                MessageBox.Show("Favor llenar todos los campos", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }
        private void CrearPaginaProf(string name1, string name2, string ap1, string ap2, string ID) {
            // PROFESORES_MATERIAS_CREDITOS.Quit();
            PROFESORES_MATERIAS_CREDITOS.Workbooks.Open("C:\\Users\\ECP\\Documents\\PROFESORES_MATERIAS_CREDITOS.xlsx");
            PROFESORES_MATERIAS_CREDITOS.Application.Worksheets.Add();
            PROFESORES_MATERIAS_CREDITOS.ActiveSheet.name = ap1 + "_" + name1;
            PROFESORES_MATERIAS_CREDITOS.Cells[1, 2] = ap1 + " " + ap2 + " " + name1 + " " + name2;
            PROFESORES_MATERIAS_CREDITOS.Cells[1, 1] = "PROFESOR:";
            PROFESORES_MATERIAS_CREDITOS.Cells[1, 3] = "IDENTIFICACION:";
            PROFESORES_MATERIAS_CREDITOS.Cells[1, 4] = ID;


            PROFESORES_MATERIAS_CREDITOS.Cells[2, 1] = "MATERIAS";
            PROFESORES_MATERIAS_CREDITOS.Cells[2, 2] = "CREDITOS";
            PROFESORES_MATERIAS_CREDITOS.Cells[2, 3] = "SEMESTRE";
            PROFESORES_MATERIAS_CREDITOS.Cells[2, 4] = "PARALELO";
            PROFESORES_MATERIAS_CREDITOS.Cells[2, 5] = "AULA";


            PROFESORES_MATERIAS_CREDITOS.Cells[20, 1] = "HORARIO";
            PROFESORES_MATERIAS_CREDITOS.Cells[21, 1] = "07H30-08H30";
            PROFESORES_MATERIAS_CREDITOS.Cells[22, 1] = "08H30-09H30";
            PROFESORES_MATERIAS_CREDITOS.Cells[23, 1] = "10H00-11H00";
            PROFESORES_MATERIAS_CREDITOS.Cells[24, 1] = "11H00-12H00";
            PROFESORES_MATERIAS_CREDITOS.Cells[25, 1] = "12H00-13H00";
            PROFESORES_MATERIAS_CREDITOS.Cells[26, 1] = "14H00-15H00";
            PROFESORES_MATERIAS_CREDITOS.Cells[27, 1] = "15H00-16H00";
            PROFESORES_MATERIAS_CREDITOS.Cells[28, 1] = "16H00-17H00";
            PROFESORES_MATERIAS_CREDITOS.Cells[29, 1] = "17H00-18H00";
            PROFESORES_MATERIAS_CREDITOS.Cells[30, 1] = "18H00-19H00";
            PROFESORES_MATERIAS_CREDITOS.Cells[31, 1] = "19H00-20H00";
            PROFESORES_MATERIAS_CREDITOS.Cells[32, 1] = "20H00-21H00";

            PROFESORES_MATERIAS_CREDITOS.Cells[20, 2] = "LUNES";
            PROFESORES_MATERIAS_CREDITOS.Cells[20, 3] = "MARTES";
            PROFESORES_MATERIAS_CREDITOS.Cells[20, 4] = "MIERCOLES";
            PROFESORES_MATERIAS_CREDITOS.Cells[20, 5] = "JUEVES";
            PROFESORES_MATERIAS_CREDITOS.Cells[20, 6] = "VIERNES";
            PROFESORES_MATERIAS_CREDITOS.Cells[20, 7] = "SABADO";
            
            PROFESORES_MATERIAS_CREDITOS.ActiveWorkbook.Save();
            PROFESORES_MATERIAS_CREDITOS.Quit();
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

        private void button3_Click(object sender, EventArgs e)
        {

            ComboxParalelsParalelos.Items.Clear();
            
            
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
            cargarParalelos(PARALELO_MATERIA_PROFESOR, ComboxSemestres, ComboxParalelsParalelos);

        }

        private void button2_Click(object sender, EventArgs e)
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



            fllenarMaterias(ComboxSemestres.Text);

            //PARALELO_MATERIA_PROFESOR.Worksheets.Application.ActiveSheet();

            //  tProfMat1.Text = PARALELO_MATERIA_PROFESOR.Cells[4,6];
            //   tProfMat2.Text = PARALELO_MATERIA_PROFESOR.Cells[5, 6];
            //  tProfMat3.Text = PARALELO_MATERIA_PROFESOR.Cells[6, 6];
            //   tProfMat4.Text = PARALELO_MATERIA_PROFESOR.Cells[7, 6];
            //   tProfMat5.Text = PARALELO_MATERIA_PROFESOR.Cells[8, 6];
            //   tProfMat6.Text = PARALELO_MATERIA_PROFESOR.Cells[9, 6];
            //  PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");
            //  PARALELO_MATERIA_PROFESOR.Worksheets.Application.ActiveSheet("4_par_1");
            string buscador = devolvermateria(ComboxSemestres.Text) + "_par_" + ComboxParalelsParalelos.Text;
            LeerProfesoresdesdeExcel(buscador, PARALELO_MATERIA_PROFESOR);

        }
        private void LeerProfesoresdesdeExcel(string name, Microsoft.Office.Interop.Excel.Application k) {
            int val = 0;
            PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");

            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    k.Application.ActiveWorkbook.Sheets[i].Activate();


                    if (k.ActiveSheet.name == name)
                    {

                        val = i;
                        PARALELO_MATERIA_PROFESOR.Application.ActiveWorkbook.Sheets[i].Activate();
                        tProfMat1.Text = PARALELO_MATERIA_PROFESOR.Cells[4, 6].Value;
                        tProfMat2.Text = PARALELO_MATERIA_PROFESOR.Cells[5, 6].Value;
                        tProfMat3.Text = PARALELO_MATERIA_PROFESOR.Cells[6, 6].Value;
                        tProfMat4.Text = PARALELO_MATERIA_PROFESOR.Cells[7, 6].Value;
                        tProfMat5.Text = PARALELO_MATERIA_PROFESOR.Cells[8, 6].Value;
                        tProfMat6.Text = PARALELO_MATERIA_PROFESOR.Cells[9, 6].Value;


                        break;
                    }
                }
            }
            catch
            {
                tProfMat1.Text = "";
                tProfMat2.Text = "";
                tProfMat3.Text = "";
                tProfMat4.Text = "";
                tProfMat5.Text = "";
                tProfMat6.Text = "";


                MessageBox.Show("SEMESTRE-PARALELO NO EXISTE ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            PARALELO_MATERIA_PROFESOR.Quit();


        }

        private void AsignarMateriaAProfesorExcel(string name, Microsoft.Office.Interop.Excel.Application k, string mat, string creditos, string semestre, string paralelo)
        {
            int val = 0;
           
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    PROFESORES_MATERIAS_CREDITOS.Application.ActiveWorkbook.Sheets[i].Activate();


                    if (PROFESORES_MATERIAS_CREDITOS.Cells[1, 2].Text == name)
                    {

                        for (int j = 3; j <= 19; j++)
                        {
                            if (PROFESORES_MATERIAS_CREDITOS.Cells[j, 1].Text == "")
                            {
                                PROFESORES_MATERIAS_CREDITOS.Cells[j, 1] = mat;
                                PROFESORES_MATERIAS_CREDITOS.Cells[j, 2] = creditos;
                                PROFESORES_MATERIAS_CREDITOS.Cells[j, 3] = semestre;
                                PROFESORES_MATERIAS_CREDITOS.Cells[j, 4] = paralelo;
                                break;
                            }

                        }

                        break;
                    }
                }
            }
            catch
            {

            }
           

        }
        
        private string devolvermateria(string semestre)
        {
            string sem = "";
            if (semestre == "PRIMER SEMESTRE")
            {
                sem = "1";
            }
            if (semestre == "SEGUNDO SEMESTRE")
            {
                sem = "2";
            }
            if (semestre == "TERCER SEMESTRE")
            {
                sem = "3";
            }
            if (semestre == "CUARTO SEMESTRE")
            {
                sem = "4";
            }
            if (semestre == "QUINTO SEMESTRE")
            {
                sem = "5";
            }
            if (semestre == "SEXTO SEMESTRE")
            {
                sem = "6";
            }
            if (semestre == "SEPTIMO SEMESTRE")
            {
                sem = "7";
            }
            if (semestre == "OCTAVO SEMESTRE")
            {
                sem = "8";
            }
            if (semestre == "NOVENO SEMESTRE")
            {
                sem = "9";
            }
            if (semestre == "DECIMO SEMESTRE")
            {
                sem = "10";
            }

            return (sem);
        }
        private void fllenarMaterias(string semestre)
        {
            string cnnstring = @"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=|DataDirectory|\\login.mdb;";
            int cartel = 0;
            string sem = "";
            if (semestre == "PRIMER SEMESTRE") {
                sem = "1";
            }
            if (semestre == "SEGUNDO SEMESTRE")
            {
                sem = "2";
            }
            if (semestre == "TERCER SEMESTRE")
            {
                sem = "3";
            }
            if (semestre == "CUARTO SEMESTRE")
            {
                sem = "4";
            }
            if (semestre == "QUINTO SEMESTRE")
            {
                sem = "5";
            }
            if (semestre == "SEXTO SEMESTRE")
            {
                sem = "6";
            }
            if (semestre == "SEPTIMO SEMESTRE")
            {
                sem = "7";
            }
            if (semestre == "OCTAVO SEMESTRE")
            {
                sem = "8";
            }
            if (semestre == "NOVENO SEMESTRE")
            {
                sem = "9";
            }
            if (semestre == "DECIMO SEMESTRE")
            {
                sem = "10";
            }



            try
            {
                OleDbConnection conection = new OleDbConnection(cnnstring);
                OleDbCommand selectName = new OleDbCommand("SELECT Mat, MAT1, CREDMAT1,MAT2, CREDMAT2,MAT3, CREDMAT3,MAT4, CREDMAT4,MAT5, CREDMAT5,MAT6, CREDMAT6 From MateriasCreditosSemestre", conection);
                try
                {

                    conection.Open();
                    OleDbDataReader Lector = selectName.ExecuteReader();


                    cartel = 9;
                    while (Lector.Read())
                    {

                        if ((sem == Lector.GetValue(0).ToString()))
                        {
                            tMateria1.Text = Lector.GetValue(1).ToString();
                            tMateria1.Enabled = false;
                            tProfMat1.Enabled = false;
                            tCredMat1.Text = Lector.GetValue(2).ToString();
                            tCredMat1.Enabled = false;

                            tMateria2.Text = Lector.GetValue(3).ToString();
                            tMateria2.Enabled = false;
                            tProfMat2.Enabled = false;
                            tCredMat2.Text = Lector.GetValue(4).ToString();
                            tCredMat2.Enabled = false;

                            tMateria3.Text = Lector.GetValue(5).ToString();
                            tMateria3.Enabled = false;
                            tProfMat3.Enabled = false;
                            tCredMat3.Text = Lector.GetValue(6).ToString();
                            tCredMat3.Enabled = false;


                            tMateria4.Text = Lector.GetValue(7).ToString();
                            tMateria4.Enabled = false;
                            tProfMat4.Enabled = false;
                            tCredMat4.Text = Lector.GetValue(8).ToString();
                            tCredMat4.Enabled = false;

                            tMateria5.Text = Lector.GetValue(9).ToString();
                            tMateria5.Enabled = false;
                            tProfMat5.Enabled = false;
                            tCredMat5.Text = Lector.GetValue(10).ToString();
                            tCredMat5.Enabled = false;


                            tMateria6.Text = Lector.GetValue(11).ToString();
                            tMateria6.Enabled = false;
                            tProfMat6.Enabled = false;
                            tCredMat6.Text = Lector.GetValue(12).ToString();
                            tCredMat6.Enabled = false;



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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox92_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox102_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox84_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

            Crear_Aulas();
            bCrearAulas.Enabled = false;

        }
        public int convertirInt(string x) {
            int y = 0;
            if (x == "1") {
                y = 1;
            }
            if (x == "2")
            {
                y = 2;
            }
            if (x == "3")
            {
                y = 3;
            }
            if (x == "4")
            {
                y = 4;
            }
            if (x == "5")
            {
                y = 5;
            }
            if (x == "6")
            {
                y = 6;
            }
            if (x == "7")
            {
                y = 7;
            }
            if (x == "8")
            {
                y = 8;
            }
            if (x == "9")
            {
                y = 9;
            }
            if (x == "10")
            {
                y = 10;
            }
            if (x == "11")
            {
                y = 11;
            }
            if (x == "12")
            {
                y = 12;
            }
            if (x == "13")
            {
                y = 13;
            }
            if (x == "14")
            {
                y = 14;
            }
            if (x == "15")
            {
                y = 15;
            }
            if (x == "16")
            {
                y = 16;
            }
            if (x == "17")
            {
                y = 17;
            }
            if (x == "18")
            {
                y = 18;
            }
            if (x == "19")
            {
                y = 19;
            }
            if (x == "20")
            {
                y = 20;
            }


            return (y);
        }
        public void EscribirAulas(string Bloque, string Aulas) {
            int k = convertirInt(Aulas);

            for (int i = 1; i <= k; i++)
            {
                AULAS.Application.Worksheets.Add();
                AULAS.ActiveSheet.name = Bloque + "_" + i.ToString();

                AULAS.Cells[1, 1] = "AULA";
                AULAS.Cells[1, 2] = Bloque + "_" + i.ToString();


                AULAS.Cells[2, 1] = "MATERIAS";
                AULAS.Cells[2, 2] = "CREDITOS";
                AULAS.Cells[2, 3] = "SEMESTRE";
                AULAS.Cells[2, 4] = "PARALELO";
                AULAS.Cells[2, 5] = "PROFESOR";


                AULAS.Cells[20, 1] = "HORARIO";
                AULAS.Cells[21, 1] = "07H30-08H30";
                AULAS.Cells[22, 1] = "08H30-09H30";
                AULAS.Cells[23, 1] = "10H00-11H00";
                AULAS.Cells[24, 1] = "11H00-12H00";
                AULAS.Cells[25, 1] = "12H00-13H00";
                AULAS.Cells[26, 1] = "14H00-15H00";
                AULAS.Cells[27, 1] = "15H00-16H00";
                AULAS.Cells[28, 1] = "16H00-17H00";
                AULAS.Cells[29, 1] = "17H00-18H00";
                AULAS.Cells[30, 1] = "18H00-19H00";
                AULAS.Cells[31, 1] = "19H00-20H00";
                AULAS.Cells[32, 1] = "20H00-21H00";

                AULAS.Cells[20, 2] = "LUNES";
                AULAS.Cells[20, 3] = "MARTES";
                AULAS.Cells[20, 4] = "MIERCOLES";
                AULAS.Cells[20, 5] = "JUEVES";
                AULAS.Cells[20, 6] = "VIERNES";
                AULAS.Cells[20, 7] = "SABADO";



            }

        }
        private void Crear_Aulas()
        {
            AULAS.Workbooks.Open("C:\\Users\\ECP\\Documents\\AULAS_HORARIOS.xlsx");
            if ((tbbloque1.Text != "0" && tbAulas1.Text != "0") || (tbbloque1.Text != "" && tbAulas1.Text != "")) {
                EscribirAulas(tbbloque1.Text, tbAulas1.Text);
                tbbloque1.Enabled = false;
                tbAulas1.Enabled = false;
            }
            if ((tbbloque2.Text != "0" && tbAulas2.Text != "0") || (tbbloque2.Text != "" && tbAulas2.Text != ""))
            {
                EscribirAulas(tbbloque2.Text, tbAulas2.Text);
                tbbloque2.Enabled = false;
                tbAulas2.Enabled = false;
            }
            if ((tbbloque3.Text != "0" && tbAulas3.Text != "0") || (tbbloque3.Text != "" && tbAulas3.Text != ""))
            {
                EscribirAulas(tbbloque3.Text, tbAulas3.Text);
                tbbloque3.Enabled = false;
                tbAulas3.Enabled = false;
            }
            if ((tbbloque4.Text != "0" && tbAulas4.Text != "0") || (tbbloque4.Text != "" && tbAulas4.Text != ""))
            {
                EscribirAulas(tbbloque4.Text, tbAulas4.Text);
                tbbloque4.Enabled = false;
                tbAulas4.Enabled = false;
            }
            if ((tbbloque5.Text != "0" && tbAulas5.Text != "0") || (tbbloque5.Text != "" && tbAulas5.Text != ""))
            {
                EscribirAulas(tbbloque5.Text, tbAulas5.Text);
                tbbloque5.Enabled = false;
                tbAulas5.Enabled = false;
            }




            AULAS.ActiveWorkbook.Save();
            AULAS.Quit();

        }

        private void textBox137_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox134_TextChanged(object sender, EventArgs e)
        {

        }

        private void EscribirMateriasCreditos(Microsoft.Office.Interop.Excel.Application j, string val,int i)
        {
            string cnnstring = @"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=|DataDirectory|\\login.mdb;";
            int cartel = 0;
            try
            {
                OleDbConnection conection = new OleDbConnection(cnnstring);
                OleDbCommand selectName = new OleDbCommand("SELECT Mat, MAT1, CREDMAT1,MAT2, CREDMAT2,MAT3, CREDMAT3,MAT4, CREDMAT4,MAT5, CREDMAT5,MAT6, CREDMAT6 From MateriasCreditosSemestre", conection);
                try
                {

                    conection.Open();
                    OleDbDataReader Lector = selectName.ExecuteReader();


                    cartel = 9;
                    while (Lector.Read())
                    {

                        if ((val == Lector.GetValue(0).ToString()))
                        {

                            j.Cells[3, 2] = "MATERIA";
                            j.Cells[3, 3] = "CREDITOS";
                            j.Cells[3, 4] = "CREDITOS ASIGNADOS";
                            j.Cells[3, 5] = "CREDITOS POR ASIGNAR";
                            j.Cells[3, 6] = "PROFESOR";
                            j.Cells[3, 7] = "AULA";


                            j.Cells[20, 1] = "HORARIO";
                            j.Cells[21, 1] = "07H30-08H30";
                            j.Cells[22, 1] = "08H30-09H30";
                            j.Cells[23, 1] = "10H00-11H00";
                            j.Cells[24, 1] = "11H00-12H00";
                            j.Cells[25, 1] = "12H00-13H00";
                            j.Cells[26, 1] = "14H00-15H00";
                            j.Cells[27, 1] = "15H00-16H00";
                            j.Cells[28, 1] = "16H00-17H00";
                            j.Cells[29, 1] = "17H00-18H00";
                            j.Cells[30, 1] = "18H00-19H00";
                            j.Cells[31, 1] = "19H00-20H00";
                            j.Cells[32, 1] = "20H00-21H00";

                            j.Cells[20, 2] = "LUNES";
                            j.Cells[20, 3] = "MARTES";
                            j.Cells[20, 4] = "MIERCOLES";
                            j.Cells[20, 5] = "JUEVES";
                            j.Cells[20, 6] = "VIERNES";
                            j.Cells[20, 7] = "SABADO";

                            j.Cells[4, 2] = Lector.GetValue(1).ToString()+"-P"+i.ToString();
                            //    j.Cells[4, 3] = Int32.Parse(Lector.GetValue(2).ToString());
                            j.Cells[4, 3] = Lector.GetValue(2);
                            j.Cells[4, 4] = 0;
                            j.Cells[4, 5] = j.Cells[4, 3].Value - j.Cells[4, 4].Value;

                            j.Cells[5, 2] = Lector.GetValue(3).ToString() + "-P" + i.ToString();
                            j.Cells[5, 3] = Lector.GetValue(4);
                            j.Cells[5, 4] = 0;
                            j.Cells[5, 5] = j.Cells[5, 3].Value - j.Cells[5, 4].Value;

                            j.Cells[6, 2] = Lector.GetValue(5).ToString() + "-P" + i.ToString();
                            j.Cells[6, 3] = Lector.GetValue(6);
                            j.Cells[6, 4] = 0;
                            j.Cells[6, 5] = j.Cells[6, 3].Value - j.Cells[6, 4].Value;

                            j.Cells[7, 2] = Lector.GetValue(7).ToString() + "-P" + i.ToString();
                            j.Cells[7, 3] = Lector.GetValue(8);
                            j.Cells[7, 4] = 0;
                            j.Cells[7, 5] = j.Cells[7, 3].Value - j.Cells[7, 4].Value;

                            j.Cells[8, 2] = Lector.GetValue(9).ToString() + "-P" + i.ToString();
                            j.Cells[8, 3] = Lector.GetValue(10);
                            j.Cells[8, 4] = 0;
                            j.Cells[8, 5] = j.Cells[8, 3].Value - j.Cells[8, 4].Value;

                            j.Cells[9, 2] = Lector.GetValue(11).ToString() + "-P" + i.ToString();
                            j.Cells[9, 3] = Lector.GetValue(12);
                            j.Cells[9, 4] = 0;
                            j.Cells[9, 5] = j.Cells[9, 3].Value - j.Cells[9, 4].Value;


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

        private void button10_Click(object sender, EventArgs e)
        {
            EscribirAsignarProfesor(ComboxSemestres, ComboxParalelsParalelos, tMateria1, tCredMat1);
            //PROFESORES_MATERIAS_CREDITOS.Worksheets.Application.ActiveSheet("JOSE");

        }
        private void EscribirAsignarProfesor(System.Windows.Forms.ComboBox Semestre, System.Windows.Forms.ComboBox Paralelo, System.Windows.Forms.TextBox Materia, System.Windows.Forms.TextBox Creditos)
        {
            tBASemesre.Text = Semestre.Text;
            tBASemesre.Enabled = false;
            tbAParalelo.Text = Paralelo.Text;
            tbAParalelo.Enabled = false;
            tbAMateria.Text = Materia.Text;
            tbAMateria.Enabled = false;
            tbACreditos.Text = Creditos.Text;
            tbACreditos.Enabled = false;
            cbAProfesor.Items.Clear();
            cargarPorfesores(cbAProfesor);

        }


        private void cargarPorfesores(System.Windows.Forms.ComboBox Semestre)
        {


            string cnnstring = @"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=|DataDirectory|\\login.mdb;";
            try
            {
                OleDbConnection conection = new OleDbConnection(cnnstring);
                OleDbCommand selectName = new OleDbCommand("SELECT Nombre1, Nombre2, Apellido1, Apellido2 From ProfesoresRegistrados", conection);
                try
                {

                    conection.Open();
                    OleDbDataReader Lector = selectName.ExecuteReader();



                    while (Lector.Read())
                    {

                        Semestre.Items.Add(Lector.GetValue(2).ToString() + " " + Lector.GetValue(3).ToString() + " " + Lector.GetValue(0).ToString() + " " + Lector.GetValue(1).ToString());
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

        private void button4_Click(object sender, EventArgs e)
        {
            EscribirAsignarProfesor(ComboxSemestres, ComboxParalelsParalelos, tMateria2, tCredMat2);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            EscribirAsignarProfesor(ComboxSemestres, ComboxParalelsParalelos, tMateria3, tCredMat3);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            EscribirAsignarProfesor(ComboxSemestres, ComboxParalelsParalelos, tMateria4, tCredMat4);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            EscribirAsignarProfesor(ComboxSemestres, ComboxParalelsParalelos, tMateria5, tCredMat5);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            EscribirAsignarProfesor(ComboxSemestres, ComboxParalelsParalelos, tMateria6, tCredMat6);

        }
        private void eLIMINARPARACambiodeProfesor(string mater)
        {
            string profesor = "";
            string creditos = "";
            EliminarHorarioMateria(tbAMateria.Text + "-P" + tbAParalelo.Text);
            string helpAula="";
            string helpsemestre = "";
            string helpparalelo = "";
            int v = 0;
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    PARALELO_MATERIA_PROFESOR.Application.ActiveWorkbook.Sheets[i].Activate();
                    if (PARALELO_MATERIA_PROFESOR.ActiveSheet.name == devolvermateria(tBASemesre.Text) + "_par_" + tbAParalelo.Text)
                    {
                        for (int w = 3; w < 19; w++)
                        {
                            if (PARALELO_MATERIA_PROFESOR.Cells[w, 2].Text == tbAMateria.Text+"-P"+tbAParalelo.Text)
                            {
                                profesor = PARALELO_MATERIA_PROFESOR.Cells[w, 6].Text;
                                creditos = PARALELO_MATERIA_PROFESOR.Cells[w, 3].Text;

                                helpAula = cbHAulas.Text;
                                helpsemestre = cbhSemestre.Text;
                                helpparalelo = cbHParalelos.Text;

                                cbhSemestre.Text = PARALELO_MATERIA_PROFESOR.Cells[1, 2].Text;
                                cbHParalelos.Text= PARALELO_MATERIA_PROFESOR.Cells[2, 2].Text;
                                                             
                                cbHAulas.Text= PARALELO_MATERIA_PROFESOR.Cells[w, 7].Text;


                                PARALELO_MATERIA_PROFESOR.Cells[w, 5] = convertirInt(PARALELO_MATERIA_PROFESOR.Cells[w, 5].Text) + convertirInt(PARALELO_MATERIA_PROFESOR.Cells[w, 4].Text);
                                PARALELO_MATERIA_PROFESOR.Cells[w, 4] = convertirInt(PARALELO_MATERIA_PROFESOR.Cells[w, 3].Text) - convertirInt(PARALELO_MATERIA_PROFESOR.Cells[w, 5].Text);
                                PARALELO_MATERIA_PROFESOR.Cells[w, 6] = "";
                                PARALELO_MATERIA_PROFESOR.Cells[w, 7] = "";
                                //EliminarHorarioMateria(tbAMateria.Text + "-P" + tbAParalelo.Text);
                                v = 1;
                                break;
                            }
                        }
                    }
                    if (v == 1)
                    {
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR TIPO 1-A-3 ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            v = 0;


            try
            {
                for (int i = 1; i <= 100; i++)
                {

                    PROFESORES_MATERIAS_CREDITOS.Application.ActiveWorkbook.Sheets[i].Activate();
                    if (PROFESORES_MATERIAS_CREDITOS.Cells[1, 2].Text == profesor)
                    {
                        for (int w = 3; w < 19; w++)
                        {
                            if ((PROFESORES_MATERIAS_CREDITOS.Cells[w, 1].Text == tbAMateria.Text+"-P"+tbAParalelo.Text) && (PROFESORES_MATERIAS_CREDITOS.Cells[w, 4].Text == cbHParalelos.Text))
                            {
                                PROFESORES_MATERIAS_CREDITOS.Cells[w, 1] = "";
                                PROFESORES_MATERIAS_CREDITOS.Cells[w, 2] = "";
                                PROFESORES_MATERIAS_CREDITOS.Cells[w, 3] = "";
                                PROFESORES_MATERIAS_CREDITOS.Cells[w, 4] = "";
                                PROFESORES_MATERIAS_CREDITOS.Cells[w, 5] = "";
                                PROFESORES_MATERIAS_CREDITOS.Cells[w, 6] = "";
                                subirVacios(PROFESORES_MATERIAS_CREDITOS, 1);
                              //  EliminarHorarioMateria(tbAMateria.Text + "-P" + tbAParalelo.Text);
                                v = 1;
                                break;
                            }
                        }

                    }

                    if (v == 1)
                    {
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR TIPO 1-B-3 ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            v = 0;


            if (cbHAulas.Text != "") { 
            try
            {
                
                for (int i = 1; i <= 100; i++)
                {
                    
                    AULAS.Application.ActiveWorkbook.Sheets[i].Activate();

                    if (AULAS.ActiveSheet.name == cbHAulas.Text)
                    {
                        for (int w = 3; w < 19; w++)
                        {
                            if (AULAS.Cells[w, 1].Text == tbAMateria.Text+"-P"+tbAParalelo.Text)
                            {

                                AULAS.Cells[w, 2] = "";
                                AULAS.Cells[w, 3] = "";
                                AULAS.Cells[w, 4] = "";
                                AULAS.Cells[w, 5] = "";
                                AULAS.Cells[w, 1] = "";
                                subirVacios(AULAS, 1);
                                //EliminarHorarioMateria(tbAMateria.Text + "-P" + tbAParalelo.Text);
                                v = 1;
                                break;
                            }
                        }

                    }
                    if (v == 1)
                    {
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR TIPO 1-C-3 ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            }

             cbHAulas.Text=helpAula;
             cbhSemestre.Text=helpsemestre;
            cbHParalelos.Text = helpparalelo;

        }
        private void bAsignar_Click(object sender, EventArgs e)
        {

            cbhSemestre.Text = tBASemesre.Text;
            cbHParalelos.Text = tbAParalelo.Text;
            cbhMateriaEliminar.Text = tbAMateria.Text + "-P" + cbHParalelos.Text ;

            string name = devolvermateria(tBASemesre.Text) + "_par_" + tbAParalelo.Text;


            EscribirProfesoresdesdeExcel(name, PARALELO_MATERIA_PROFESOR);


            if (tMateria1.Text == tbAMateria.Text)
            {
                tProfMat1.Text = cbAProfesor.Text;
            }
            if (tMateria2.Text == tbAMateria.Text)
            {
                tProfMat2.Text = cbAProfesor.Text;
            }
            if (tMateria3.Text == tbAMateria.Text)
            {
                tProfMat3.Text = cbAProfesor.Text;
            }
            if (tMateria4.Text == tbAMateria.Text)
            {
                tProfMat4.Text = cbAProfesor.Text;
            }
            if (tMateria5.Text == tbAMateria.Text)
            {
                tProfMat5.Text = cbAProfesor.Text;
            }
            if (tMateria6.Text == tbAMateria.Text)
            {
                tProfMat6.Text = cbAProfesor.Text;
            }
            cbhSemestre.Text = "";
            cbHParalelos.Text = "";
            cbhMateriaEliminar.Text = "";
        }

        private void EscribirProfesoresdesdeExcel(string name, Microsoft.Office.Interop.Excel.Application k)
        {
            int val = 0;
            PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");
            PROFESORES_MATERIAS_CREDITOS.Workbooks.Open("C:\\Users\\ECP\\Documents\\PROFESORES_MATERIAS_CREDITOS.xlsx");
            AULAS.Workbooks.Open("C:\\Users\\ECP\\Documents\\AULAS_HORARIOS.xlsx");
         
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    k.Application.ActiveWorkbook.Sheets[i].Activate();


                    if (k.ActiveSheet.name == name)
                    {


                        if (tMateria1.Text == tbAMateria.Text)
                        {
                            if (PARALELO_MATERIA_PROFESOR.Cells[4, 6].Text == "")
                            {
                                PARALELO_MATERIA_PROFESOR.Cells[4, 6] = cbAProfesor.Text;
                                AsignarMateriaAProfesorExcel(cbAProfesor.Text, PROFESORES_MATERIAS_CREDITOS, tbAMateria.Text + "-P" + tbAParalelo.Text, tbACreditos.Text, tBASemesre.Text, tbAParalelo.Text);
                            }
                            else {
                                eLIMINARPARACambiodeProfesor(tbAMateria.Text);
                                PARALELO_MATERIA_PROFESOR.Cells[4, 6] = cbAProfesor.Text;
                                AsignarMateriaAProfesorExcel(cbAProfesor.Text, PROFESORES_MATERIAS_CREDITOS, tbAMateria.Text + "-P" + tbAParalelo.Text, tbACreditos.Text, tBASemesre.Text, tbAParalelo.Text);

                            }

                        }
                        if (tMateria2.Text == tbAMateria.Text)
                        {
                            if (PARALELO_MATERIA_PROFESOR.Cells[5, 6].Text == "")
                            {
                                PARALELO_MATERIA_PROFESOR.Cells[5, 6] = cbAProfesor.Text;
                                AsignarMateriaAProfesorExcel(cbAProfesor.Text, PROFESORES_MATERIAS_CREDITOS, tbAMateria.Text + "-P" + tbAParalelo.Text, tbACreditos.Text, tBASemesre.Text, tbAParalelo.Text);
                            }
                            else
                            {
                                eLIMINARPARACambiodeProfesor(tbAMateria.Text);
                                PARALELO_MATERIA_PROFESOR.Cells[5, 6] = cbAProfesor.Text;
                                AsignarMateriaAProfesorExcel(cbAProfesor.Text, PROFESORES_MATERIAS_CREDITOS, tbAMateria.Text + "-P" + tbAParalelo.Text, tbACreditos.Text, tBASemesre.Text, tbAParalelo.Text);

                            }
                        }
                        if (tMateria3.Text == tbAMateria.Text)
                        {
                            if (PARALELO_MATERIA_PROFESOR.Cells[6, 6].Text == "")
                            {
                                PARALELO_MATERIA_PROFESOR.Cells[6, 6] = cbAProfesor.Text;
                                AsignarMateriaAProfesorExcel(cbAProfesor.Text, PROFESORES_MATERIAS_CREDITOS, tbAMateria.Text + "-P" + tbAParalelo.Text, tbACreditos.Text, tBASemesre.Text, tbAParalelo.Text);
                            }
                            else
                            {
                                eLIMINARPARACambiodeProfesor(tbAMateria.Text);
                                PARALELO_MATERIA_PROFESOR.Cells[6, 6] = cbAProfesor.Text;
                                AsignarMateriaAProfesorExcel(cbAProfesor.Text, PROFESORES_MATERIAS_CREDITOS, tbAMateria.Text + "-P" + tbAParalelo.Text, tbACreditos.Text, tBASemesre.Text, tbAParalelo.Text);
                            }
                        }
                        if (tMateria4.Text == tbAMateria.Text)
                        {
                            if (PARALELO_MATERIA_PROFESOR.Cells[7, 6].Text == "")
                            {
                                PARALELO_MATERIA_PROFESOR.Cells[7, 6] = cbAProfesor.Text;
                                AsignarMateriaAProfesorExcel(cbAProfesor.Text, PROFESORES_MATERIAS_CREDITOS, tbAMateria.Text + "-P" + tbAParalelo.Text, tbACreditos.Text, tBASemesre.Text, tbAParalelo.Text);
                            }
                            else
                            {
                                eLIMINARPARACambiodeProfesor(tbAMateria.Text);
                                PARALELO_MATERIA_PROFESOR.Cells[7, 6] = cbAProfesor.Text;
                                AsignarMateriaAProfesorExcel(cbAProfesor.Text, PROFESORES_MATERIAS_CREDITOS, tbAMateria.Text + "-P" + tbAParalelo.Text, tbACreditos.Text, tBASemesre.Text, tbAParalelo.Text);

                            }
                        }
                        if (tMateria5.Text == tbAMateria.Text)
                        {
                            if (PARALELO_MATERIA_PROFESOR.Cells[8, 6].Text == "")
                            {
                                PARALELO_MATERIA_PROFESOR.Cells[8, 6] = cbAProfesor.Text;
                                AsignarMateriaAProfesorExcel(cbAProfesor.Text, PROFESORES_MATERIAS_CREDITOS, tbAMateria.Text + "-P" + tbAParalelo.Text, tbACreditos.Text, tBASemesre.Text, tbAParalelo.Text);
                            }
                            else
                            {
                                eLIMINARPARACambiodeProfesor(tbAMateria.Text);
                                PARALELO_MATERIA_PROFESOR.Cells[8, 6] = cbAProfesor.Text;
                                AsignarMateriaAProfesorExcel(cbAProfesor.Text, PROFESORES_MATERIAS_CREDITOS, tbAMateria.Text + "-P" + tbAParalelo.Text, tbACreditos.Text, tBASemesre.Text, tbAParalelo.Text);

                            }
                        }
                        if (tMateria6.Text == tbAMateria.Text)
                        {
                            if (PARALELO_MATERIA_PROFESOR.Cells[9, 6].Text == "")
                            {
                                PARALELO_MATERIA_PROFESOR.Cells[9, 6] = cbAProfesor.Text;
                                AsignarMateriaAProfesorExcel(cbAProfesor.Text, PROFESORES_MATERIAS_CREDITOS, tbAMateria.Text + "-P" + tbAParalelo.Text, tbACreditos.Text, tBASemesre.Text, tbAParalelo.Text);
                            }
                            else
                            {
                                eLIMINARPARACambiodeProfesor(tbAMateria.Text);
                                PARALELO_MATERIA_PROFESOR.Cells[9, 6] = cbAProfesor.Text;
                                AsignarMateriaAProfesorExcel(cbAProfesor.Text, PROFESORES_MATERIAS_CREDITOS, tbAMateria.Text + "-P" + tbAParalelo.Text, tbACreditos.Text, tBASemesre.Text, tbAParalelo.Text);

                            }
                        }

                        break;
                    }
                }
            }
            catch
            {

            }
            PARALELO_MATERIA_PROFESOR.ActiveWorkbook.Save();
            PROFESORES_MATERIAS_CREDITOS.ActiveWorkbook.Save();
            AULAS.ActiveWorkbook.Save();
            PARALELO_MATERIA_PROFESOR.Quit();
            PROFESORES_MATERIAS_CREDITOS.Quit();
            AULAS.Quit();


        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox76_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox75_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //verificacion_total_cruces("4_par_2", "A_1", "VILLEGAS SALABARRIA JOSE BALLARDO");
            if (cbHAulas.Text != "" && cbHMaterias.Text != "" && cbHParalelos.Text != "" && cbhSemestre.Text != "") {
                cbHAulas.Enabled = false;
                cbHParalelos.Enabled = false;
                cbhSemestre.Enabled = false;
                bHSeleccionar.Enabled = false;
                tbHDescripcion.Text = "Usted está modificando el horario de la materia: " + cbHMaterias.Text + " de: " + cbhSemestre.Text + " Paralelo: " + cbHParalelos.Text + " en el Aula: " + cbHAulas.Text + ". Para seleccionar el horario marque con una " + "x" + " el horario deseado y de click en Asignar ";
            }
            else
            {
                tbHDescripcion.Text = "Seleccione todos los parametros y de click en Seleccionar";
            }


        }

        private void cargarAulas(Microsoft.Office.Interop.Excel.Application j, System.Windows.Forms.ComboBox cbx) {

            cbx.Items.Clear();
            int val = 0;
            AULAS.Workbooks.Open("C:\\Users\\ECP\\Documents\\AULAS_HORARIOS.xlsx");

            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    j.Application.ActiveWorkbook.Sheets[i].Activate();
                    cbx.Items.Add(j.ActiveSheet.name);

                }
            }
            catch
            {

            }

            AULAS.Quit();
        }
        private void cargarSemestres(Microsoft.Office.Interop.Excel.Application j, System.Windows.Forms.ComboBox cbx)
        {

            cbx.Items.Clear();
            int val = 0;
            try
            {
                PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");


                j.Application.ActiveWorkbook.Sheets[1].Activate();
                for (int i = 10; i > 0; i--)
                {
                    if (j.Cells[i, 2].Text != "0")
                    {
                        cbx.Items.Add(j.Cells[i, 1].Text);
                    }
                }
                
            }
            catch {
            }
        }
        private void cargarParalelos(Microsoft.Office.Interop.Excel.Application j, System.Windows.Forms.ComboBox cbxSemestre, System.Windows.Forms.ComboBox cbx)
        {

            cbx.Items.Clear();
            int val = 0;
            PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");

            j.Application.ActiveWorkbook.Sheets[1].Activate();

            if (cbxSemestre.Text == PARALELO_MATERIA_PROFESOR.Cells[1, 1].Text) {
                for (int i = 1; i < 20; i++) {
                    cbx.Items.Add(i.ToString());
                    if (PARALELO_MATERIA_PROFESOR.Cells[1, 2].Text == i.ToString())
                    {
                                  break;

                    }

                }
            }


            if (cbxSemestre.Text == PARALELO_MATERIA_PROFESOR.Cells[2, 1].Text)
            {
                for (int i = 1; i < 20; i++)
                {
                    cbx.Items.Add(i.ToString());
                    if (PARALELO_MATERIA_PROFESOR.Cells[2, 2].Text == i.ToString())
                    {
                        break;
                    }

                }
            }

            if (cbxSemestre.Text == PARALELO_MATERIA_PROFESOR.Cells[3, 1].Text)
            {
                for (int i = 1; i < 20; i++)
                {
                    cbx.Items.Add(i.ToString());
                    if (PARALELO_MATERIA_PROFESOR.Cells[3, 2].Text == i.ToString())
                    {
                        break;
                    }
                }
            }

            if (cbxSemestre.Text == PARALELO_MATERIA_PROFESOR.Cells[4, 1].Text)
            {
                for (int i = 1; i < 20; i++)
                {
                    cbx.Items.Add(i.ToString());
                    if (PARALELO_MATERIA_PROFESOR.Cells[4, 2].Text == i.ToString())
                    {
                        break;
                    }
                }
            }

            if (cbxSemestre.Text == PARALELO_MATERIA_PROFESOR.Cells[5, 1].Text)
            {
                for (int i = 1; i < 20; i++)
                {
                    cbx.Items.Add(i.ToString());
                    if (PARALELO_MATERIA_PROFESOR.Cells[5, 2].Text == i.ToString())
                    {
                        break;
                    }
                }
            }



            if (cbxSemestre.Text == PARALELO_MATERIA_PROFESOR.Cells[6, 1].Text)
            {
                for (int i = 1; i < 20; i++)
                {
                    cbx.Items.Add(i.ToString());
                    if (PARALELO_MATERIA_PROFESOR.Cells[6, 2].Text == i.ToString())
                    {
                        break;
                    }
                }
            }


            if (cbxSemestre.Text == PARALELO_MATERIA_PROFESOR.Cells[7, 1].Text)
            {
                for (int i = 1; i < 20; i++)
                {
                    cbx.Items.Add(i.ToString());
                    if (PARALELO_MATERIA_PROFESOR.Cells[7, 2].Text == i.ToString())
                    {
                        break;
                    }
                }
            }

            if (cbxSemestre.Text == PARALELO_MATERIA_PROFESOR.Cells[8, 1].Text)
            {
                for (int i = 1; i < 20; i++)
                {
                    cbx.Items.Add(i.ToString());
                    if (PARALELO_MATERIA_PROFESOR.Cells[8, 2].Text == i.ToString())
                    {
                        break;
                    }
                }
            }

            if (cbxSemestre.Text == PARALELO_MATERIA_PROFESOR.Cells[9, 1].Text)
            {
                for (int i = 1; i < 20; i++)
                {
                    cbx.Items.Add(i.ToString());
                    if (PARALELO_MATERIA_PROFESOR.Cells[9, 2].Text == i.ToString())
                    {
                        break;
                    }
                }
            }

            if (cbxSemestre.Text == PARALELO_MATERIA_PROFESOR.Cells[10, 1].Text)
            {
                for (int i = 1; i < 20; i++)
                {
                    cbx.Items.Add(i.ToString());
                    if (PARALELO_MATERIA_PROFESOR.Cells[10, 2].Text == i.ToString())
                    {
                        break;
                    }
                }
            }

            PARALELO_MATERIA_PROFESOR.Quit();
        }

        private void cargarMateriasCreditos(string name) {

            PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");
            cbHMaterias.Items.Clear();
            cbhMateriaEliminar.Items.Clear();
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    PARALELO_MATERIA_PROFESOR.Application.ActiveWorkbook.Sheets[i].Activate();
                    if (PARALELO_MATERIA_PROFESOR.ActiveSheet.name == name)
                    {
                        cbHMaterias.Items.Add(PARALELO_MATERIA_PROFESOR.Cells[4, 2].Text);
                        cbHMaterias.Items.Add(PARALELO_MATERIA_PROFESOR.Cells[5, 2].Text);
                        cbHMaterias.Items.Add(PARALELO_MATERIA_PROFESOR.Cells[6, 2].Text);
                        cbHMaterias.Items.Add(PARALELO_MATERIA_PROFESOR.Cells[7, 2].Text);
                        cbHMaterias.Items.Add(PARALELO_MATERIA_PROFESOR.Cells[8, 2].Text);
                        cbHMaterias.Items.Add(PARALELO_MATERIA_PROFESOR.Cells[9, 2].Text);


                        cbhMateriaEliminar.Items.Add(PARALELO_MATERIA_PROFESOR.Cells[4, 2].Text);
                        cbhMateriaEliminar.Items.Add(PARALELO_MATERIA_PROFESOR.Cells[5, 2].Text);
                        cbhMateriaEliminar.Items.Add(PARALELO_MATERIA_PROFESOR.Cells[6, 2].Text);
                        cbhMateriaEliminar.Items.Add(PARALELO_MATERIA_PROFESOR.Cells[7, 2].Text);
                        cbhMateriaEliminar.Items.Add(PARALELO_MATERIA_PROFESOR.Cells[8, 2].Text);
                        cbhMateriaEliminar.Items.Add(PARALELO_MATERIA_PROFESOR.Cells[9, 2].Text);



                        tbHMat1.Text = PARALELO_MATERIA_PROFESOR.Cells[4, 2].Text;
                        tbHMat2.Text = PARALELO_MATERIA_PROFESOR.Cells[5, 2].Text;
                        tbHMat3.Text = PARALELO_MATERIA_PROFESOR.Cells[6, 2].Text;
                        tbHMat4.Text = PARALELO_MATERIA_PROFESOR.Cells[7, 2].Text;
                        tbHMat5.Text = PARALELO_MATERIA_PROFESOR.Cells[8, 2].Text;
                        tbHMat6.Text = PARALELO_MATERIA_PROFESOR.Cells[9, 2].Text;



                        tbHCM1.Text = PARALELO_MATERIA_PROFESOR.Cells[4, 3].Text;
                        tbHCM2.Text = PARALELO_MATERIA_PROFESOR.Cells[5, 3].Text;
                        tbHCM3.Text = PARALELO_MATERIA_PROFESOR.Cells[6, 3].Text;
                        tbHCM4.Text = PARALELO_MATERIA_PROFESOR.Cells[7, 3].Text;
                        tbHCM5.Text = PARALELO_MATERIA_PROFESOR.Cells[8, 3].Text;
                        tbHCM6.Text = PARALELO_MATERIA_PROFESOR.Cells[9, 3].Text;


                        tbHCAM1.Text = PARALELO_MATERIA_PROFESOR.Cells[4, 4].Text;
                        tbHCAM2.Text = PARALELO_MATERIA_PROFESOR.Cells[5, 4].Text;
                        tbHCAM3.Text = PARALELO_MATERIA_PROFESOR.Cells[6, 4].Text;
                        tbHCAM4.Text = PARALELO_MATERIA_PROFESOR.Cells[7, 4].Text;
                        tbHCAM5.Text = PARALELO_MATERIA_PROFESOR.Cells[8, 4].Text;
                        tbHCAM6.Text = PARALELO_MATERIA_PROFESOR.Cells[9, 4].Text;

                        tbHCPM1.Text = PARALELO_MATERIA_PROFESOR.Cells[4, 5].Text;
                        tbHCPM2.Text = PARALELO_MATERIA_PROFESOR.Cells[5, 5].Text;
                        tbHCPM3.Text = PARALELO_MATERIA_PROFESOR.Cells[6, 5].Text;
                        tbHCPM4.Text = PARALELO_MATERIA_PROFESOR.Cells[7, 5].Text;
                        tbHCPM5.Text = PARALELO_MATERIA_PROFESOR.Cells[8, 5].Text;
                        tbHCPM6.Text = PARALELO_MATERIA_PROFESOR.Cells[9, 5].Text;


                        if (tbHCM1.Text != tbHCAM1.Text)
                        {
                            tbEM1.BackColor = System.Drawing.Color.Red;
                        }
                        else {

                            tbEM1.BackColor = System.Drawing.Color.Green;
                        }



                        if (tbHCM2.Text != tbHCAM2.Text)
                        {
                            tbEM2.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {

                            tbEM2.BackColor = System.Drawing.Color.Green;
                        }



                        if (tbHCM3.Text != tbHCAM3.Text)
                        {
                            tbEM3.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {

                            tbEM3.BackColor = System.Drawing.Color.Green;
                        }

                        if (tbHCM4.Text != tbHCAM4.Text)
                        {
                            tbEM4.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {

                            tbEM4.BackColor = System.Drawing.Color.Green;
                        }

                        if (tbHCM5.Text != tbHCAM5.Text)
                        {
                            tbEM5.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {

                            tbEM5.BackColor = System.Drawing.Color.Green;
                        }

                        if (tbHCM6.Text != tbHCAM6.Text)
                        {
                            tbEM6.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {

                            tbEM6.BackColor = System.Drawing.Color.Green;
                        }



                    }
                }
            }
            catch
            {

            }
            PARALELO_MATERIA_PROFESOR.Quit();


        }

        private void IndividualAsignarMateria(Microsoft.Office.Interop.Excel.Application j, System.Windows.Forms.TextBox tx, int fila, int columna) {

            if (Verificar_x(tx) == 1) {
                j.Cells[fila, columna] = "materia";
            }

        }
        private void AsignarMateriasParaleloCOMPLETO(Microsoft.Office.Interop.Excel.Application j)
        {

            //Lunes
            IndividualAsignarMateria(j, tbHLunes730, 21, 2);
            IndividualAsignarMateria(j, tbHLunes830, 22, 2);
            IndividualAsignarMateria(j, tbHLunes10, 23, 2);
            IndividualAsignarMateria(j, tbHLunes11, 24, 2);
            IndividualAsignarMateria(j, tbHLunes12, 25, 2);
            IndividualAsignarMateria(j, tbHLunes14, 26, 2);
            IndividualAsignarMateria(j, tbHLunes15, 27, 2);
            IndividualAsignarMateria(j, tbHLunes16, 28, 2);
            IndividualAsignarMateria(j, tbHLunes17, 29, 2);
            IndividualAsignarMateria(j, tbHLunes18, 30, 2);
            IndividualAsignarMateria(j, tbHLunes19, 31, 2);
            IndividualAsignarMateria(j, tbHLunes20, 32, 2);


            //Martes
            IndividualAsignarMateria(j, tbHMartes730, 21, 3);
            IndividualAsignarMateria(j, tbHMartes830, 22, 3);
            IndividualAsignarMateria(j, tbHMartes10, 23, 3);
            IndividualAsignarMateria(j, tbHMartes11, 24, 3);
            IndividualAsignarMateria(j, tbHMartes12, 25, 3);
            IndividualAsignarMateria(j, tbHMartes14, 26, 3);
            IndividualAsignarMateria(j, tbHMartes15, 27, 3);
            IndividualAsignarMateria(j, tbHMartes16, 28, 3);
            IndividualAsignarMateria(j, tbHMartes17, 29, 3);
            IndividualAsignarMateria(j, tbHMartes18, 30, 3);
            IndividualAsignarMateria(j, tbHMartes19, 31, 3);
            IndividualAsignarMateria(j, tbHMartes20, 32, 3);

            //Miercoles
            IndividualAsignarMateria(j, tbHMiercoles730, 21, 4);
            IndividualAsignarMateria(j, tbHMiercoles830, 22, 4);
            IndividualAsignarMateria(j, tbHMiercoles10, 23, 4);
            IndividualAsignarMateria(j, tbHMiercoles11, 24, 4);
            IndividualAsignarMateria(j, tbHMiercoles12, 25, 4);
            IndividualAsignarMateria(j, tbHMiercoles14, 26, 4);
            IndividualAsignarMateria(j, tbHMiercoles15, 27, 4);
            IndividualAsignarMateria(j, tbHMiercoles16, 28, 4);
            IndividualAsignarMateria(j, tbHMiercoles17, 29, 4);
            IndividualAsignarMateria(j, tbHMiercoles18, 30, 4);
            IndividualAsignarMateria(j, tbHMiercoles19, 31, 4);
            IndividualAsignarMateria(j, tbHMiercoles20, 32, 4);

            //Jueves
            IndividualAsignarMateria(j, tbHJueves730, 21, 5);
            IndividualAsignarMateria(j, tbHJueves830, 22, 5);
            IndividualAsignarMateria(j, tbHJueves10, 23, 5);
            IndividualAsignarMateria(j, tbHJueves11, 24, 5);
            IndividualAsignarMateria(j, tbHJueves12, 25, 5);
            IndividualAsignarMateria(j, tbHJueves14, 26, 5);
            IndividualAsignarMateria(j, tbHJueves15, 27, 5);
            IndividualAsignarMateria(j, tbHJueves16, 38, 5);
            IndividualAsignarMateria(j, tbHJueves17, 29, 5);
            IndividualAsignarMateria(j, tbHJueves18, 30, 5);
            IndividualAsignarMateria(j, tbHJueves19, 31, 5);
            IndividualAsignarMateria(j, tbHJueves20, 32, 5);

            //Viernes
            IndividualAsignarMateria(j, tbHViernes730, 21, 6);
            IndividualAsignarMateria(j, tbHViernes830, 21, 6);
            IndividualAsignarMateria(j, tbHViernes10, 23, 6);
            IndividualAsignarMateria(j, tbHViernes11, 24, 6);
            IndividualAsignarMateria(j, tbHViernes12, 25, 6);
            IndividualAsignarMateria(j, tbHViernes14, 26, 6);
            IndividualAsignarMateria(j, tbHViernes15, 27, 6);
            IndividualAsignarMateria(j, tbHViernes16, 28, 6);
            IndividualAsignarMateria(j, tbHViernes17, 29, 6);
            IndividualAsignarMateria(j, tbHViernes18, 30, 6);
            IndividualAsignarMateria(j, tbHViernes19, 31, 6);
            IndividualAsignarMateria(j, tbHViernes20, 32, 6);


            //Sabado
            IndividualAsignarMateria(j, tbHSabado730, 21, 7);
            IndividualAsignarMateria(j, tbHSabado830, 22, 7);
            IndividualAsignarMateria(j, tbHSabado10, 23, 7);
            IndividualAsignarMateria(j, tbHSabado11, 24, 7);
            IndividualAsignarMateria(j, tbHSabado12, 25, 7);
            IndividualAsignarMateria(j, tbHSabado14, 26, 7);
            IndividualAsignarMateria(j, tbHSabado15, 27, 7);
            IndividualAsignarMateria(j, tbHSabado16, 28, 7);
            IndividualAsignarMateria(j, tbHSabado17, 29, 7);
            IndividualAsignarMateria(j, tbHSabado18, 30, 7);
            IndividualAsignarMateria(j, tbHSabado19, 31, 7);
            IndividualAsignarMateria(j, tbHSabado20, 32, 7);


        }


        private int Contar_x()
        {
            int j = 0;
            //Lunes
            j = j + Verificar_x(tbHLunes730);
            j = j + Verificar_x(tbHLunes830);
            j = j + Verificar_x(tbHLunes10);
            j = j + Verificar_x(tbHLunes11);
            j = j + Verificar_x(tbHLunes12);
            j = j + Verificar_x(tbHLunes14);
            j = j + Verificar_x(tbHLunes15);
            j = j + Verificar_x(tbHLunes16);
            j = j + Verificar_x(tbHLunes17);
            j = j + Verificar_x(tbHLunes18);
            j = j + Verificar_x(tbHLunes19);
            j = j + Verificar_x(tbHLunes20);


            //Martes
            j = j + Verificar_x(tbHMartes730);
            j = j + Verificar_x(tbHMartes830);
            j = j + Verificar_x(tbHMartes10);
            j = j + Verificar_x(tbHMartes11);
            j = j + Verificar_x(tbHMartes12);
            j = j + Verificar_x(tbHMartes14);
            j = j + Verificar_x(tbHMartes15);
            j = j + Verificar_x(tbHMartes16);
            j = j + Verificar_x(tbHMartes17);
            j = j + Verificar_x(tbHMartes18);
            j = j + Verificar_x(tbHMartes19);
            j = j + Verificar_x(tbHMartes20);

            //Miercoles
            j = j + Verificar_x(tbHMiercoles730);
            j = j + Verificar_x(tbHMiercoles830);
            j = j + Verificar_x(tbHMiercoles10);
            j = j + Verificar_x(tbHMiercoles11);
            j = j + Verificar_x(tbHMiercoles12);
            j = j + Verificar_x(tbHMiercoles14);
            j = j + Verificar_x(tbHMiercoles15);
            j = j + Verificar_x(tbHMiercoles16);
            j = j + Verificar_x(tbHMiercoles17);
            j = j + Verificar_x(tbHMiercoles18);
            j = j + Verificar_x(tbHMiercoles19);
            j = j + Verificar_x(tbHMiercoles20);

            //Jueves
            j = j + Verificar_x(tbHJueves730);
            j = j + Verificar_x(tbHJueves830);
            j = j + Verificar_x(tbHJueves10);
            j = j + Verificar_x(tbHJueves11);
            j = j + Verificar_x(tbHJueves12);
            j = j + Verificar_x(tbHJueves14);
            j = j + Verificar_x(tbHJueves15);
            j = j + Verificar_x(tbHJueves16);
            j = j + Verificar_x(tbHJueves17);
            j = j + Verificar_x(tbHJueves18);
            j = j + Verificar_x(tbHJueves19);
            j = j + Verificar_x(tbHJueves20);

            //Viernes
            j = j + Verificar_x(tbHViernes730);
            j = j + Verificar_x(tbHViernes830);
            j = j + Verificar_x(tbHViernes10);
            j = j + Verificar_x(tbHViernes11);
            j = j + Verificar_x(tbHViernes12);
            j = j + Verificar_x(tbHViernes14);
            j = j + Verificar_x(tbHViernes15);
            j = j + Verificar_x(tbHViernes16);
            j = j + Verificar_x(tbHViernes17);
            j = j + Verificar_x(tbHViernes18);
            j = j + Verificar_x(tbHViernes19);
            j = j + Verificar_x(tbHViernes20);


            //Sabado
            j = j + Verificar_x(tbHSabado730);
            j = j + Verificar_x(tbHSabado830);
            j = j + Verificar_x(tbHSabado10);
            j = j + Verificar_x(tbHSabado11);
            j = j + Verificar_x(tbHSabado12);
            j = j + Verificar_x(tbHSabado14);
            j = j + Verificar_x(tbHSabado15);
            j = j + Verificar_x(tbHSabado16);
            j = j + Verificar_x(tbHSabado17);
            j = j + Verificar_x(tbHSabado18);
            j = j + Verificar_x(tbHSabado19);
            j = j + Verificar_x(tbHSabado20);


            return (j);
        }
        private int Verificar_x(System.Windows.Forms.TextBox tx)
        {
            int r = 0;
            if (tx.Text == "x") {
                r = 1;
            }
            return (r);
        }

        private int Verificar_Cruce(Microsoft.Office.Interop.Excel.Application j, System.Windows.Forms.TextBox tx, int fila, int columna)
        {
            int h = 0;
            if (Verificar_x(tx) == 1)
            {
                if (j.Cells[fila, columna].Text != "")
                {
                    h = h + 1;
                }
            }
            return (h);
        }
        private int Contar_Cruce(Microsoft.Office.Interop.Excel.Application j)
        {
            int cruces = 0;
            //CrucesLunes
            cruces = cruces + Verificar_Cruce(j, tbHLunes730, 21, 2);


            //Lunes
            cruces = cruces + Verificar_Cruce(j, tbHLunes730, 21, 2);
            cruces = cruces + Verificar_Cruce(j, tbHLunes830, 22, 2);
            cruces = cruces + Verificar_Cruce(j, tbHLunes10, 23, 2);
            cruces = cruces + Verificar_Cruce(j, tbHLunes11, 24, 2);
            cruces = cruces + Verificar_Cruce(j, tbHLunes12, 25, 2);
            cruces = cruces + Verificar_Cruce(j, tbHLunes14, 26, 2);
            cruces = cruces + Verificar_Cruce(j, tbHLunes15, 27, 2);
            cruces = cruces + Verificar_Cruce(j, tbHLunes16, 28, 2);
            cruces = cruces + Verificar_Cruce(j, tbHLunes17, 29, 2);
            cruces = cruces + Verificar_Cruce(j, tbHLunes18, 30, 2);
            cruces = cruces + Verificar_Cruce(j, tbHLunes19, 31, 2);
            cruces = cruces + Verificar_Cruce(j, tbHLunes20, 32, 2);


            //Martes
            cruces = cruces + Verificar_Cruce(j, tbHMartes730, 21, 3);
            cruces = cruces + Verificar_Cruce(j, tbHMartes830, 22, 3);
            cruces = cruces + Verificar_Cruce(j, tbHMartes10, 23, 3);
            cruces = cruces + Verificar_Cruce(j, tbHMartes11, 24, 3);
            cruces = cruces + Verificar_Cruce(j, tbHMartes12, 25, 3);
            cruces = cruces + Verificar_Cruce(j, tbHMartes14, 26, 3);
            cruces = cruces + Verificar_Cruce(j, tbHMartes15, 27, 3);
            cruces = cruces + Verificar_Cruce(j, tbHMartes16, 28, 3);
            cruces = cruces + Verificar_Cruce(j, tbHMartes17, 29, 3);
            cruces = cruces + Verificar_Cruce(j, tbHMartes18, 30, 3);
            cruces = cruces + Verificar_Cruce(j, tbHMartes19, 31, 3);
            cruces = cruces + Verificar_Cruce(j, tbHMartes20, 32, 3);

            //Miercoles
            cruces = cruces + Verificar_Cruce(j, tbHMiercoles730, 21, 4);
            cruces = cruces + Verificar_Cruce(j, tbHMiercoles830, 22, 4);
            cruces = cruces + Verificar_Cruce(j, tbHMiercoles10, 23, 4);
            cruces = cruces + Verificar_Cruce(j, tbHMiercoles11, 24, 4);
            cruces = cruces + Verificar_Cruce(j, tbHMiercoles12, 25, 4);
            cruces = cruces + Verificar_Cruce(j, tbHMiercoles14, 26, 4);
            cruces = cruces + Verificar_Cruce(j, tbHMiercoles15, 27, 4);
            cruces = cruces + Verificar_Cruce(j, tbHMiercoles16, 28, 4);
            cruces = cruces + Verificar_Cruce(j, tbHMiercoles17, 29, 4);
            cruces = cruces + Verificar_Cruce(j, tbHMiercoles18, 30, 4);
            cruces = cruces + Verificar_Cruce(j, tbHMiercoles19, 31, 4);
            cruces = cruces + Verificar_Cruce(j, tbHMiercoles20, 32, 4);

            //Jueves
            cruces = cruces + Verificar_Cruce(j, tbHJueves730, 21, 5);
            cruces = cruces + Verificar_Cruce(j, tbHJueves830, 22, 5);
            cruces = cruces + Verificar_Cruce(j, tbHJueves10, 23, 5);
            cruces = cruces + Verificar_Cruce(j, tbHJueves11, 24, 5);
            cruces = cruces + Verificar_Cruce(j, tbHJueves12, 25, 5);
            cruces = cruces + Verificar_Cruce(j, tbHJueves14, 26, 5);
            cruces = cruces + Verificar_Cruce(j, tbHJueves15, 27, 5);
            cruces = cruces + Verificar_Cruce(j, tbHJueves16, 38, 5);
            cruces = cruces + Verificar_Cruce(j, tbHJueves17, 29, 5);
            cruces = cruces + Verificar_Cruce(j, tbHJueves18, 30, 5);
            cruces = cruces + Verificar_Cruce(j, tbHJueves19, 31, 5);
            cruces = cruces + Verificar_Cruce(j, tbHJueves20, 32, 5);

            //Viernes
            cruces = cruces + Verificar_Cruce(j, tbHViernes730, 21, 6);
            cruces = cruces + Verificar_Cruce(j, tbHViernes830, 21, 6);
            cruces = cruces + Verificar_Cruce(j, tbHViernes10, 23, 6);
            cruces = cruces + Verificar_Cruce(j, tbHViernes11, 24, 6);
            cruces = cruces + Verificar_Cruce(j, tbHViernes12, 25, 6);
            cruces = cruces + Verificar_Cruce(j, tbHViernes14, 26, 6);
            cruces = cruces + Verificar_Cruce(j, tbHViernes15, 27, 6);
            cruces = cruces + Verificar_Cruce(j, tbHViernes16, 28, 6);
            cruces = cruces + Verificar_Cruce(j, tbHViernes17, 29, 6);
            cruces = cruces + Verificar_Cruce(j, tbHViernes18, 30, 6);
            cruces = cruces + Verificar_Cruce(j, tbHViernes19, 31, 6);
            cruces = cruces + Verificar_Cruce(j, tbHViernes20, 32, 6);


            //Sabado
            cruces = cruces + Verificar_Cruce(j, tbHSabado730, 21, 7);
            cruces = cruces + Verificar_Cruce(j, tbHSabado830, 22, 7);
            cruces = cruces + Verificar_Cruce(j, tbHSabado10, 23, 7);
            cruces = cruces + Verificar_Cruce(j, tbHSabado11, 24, 7);
            cruces = cruces + Verificar_Cruce(j, tbHSabado12, 25, 7);
            cruces = cruces + Verificar_Cruce(j, tbHSabado14, 26, 7);
            cruces = cruces + Verificar_Cruce(j, tbHSabado15, 27, 7);
            cruces = cruces + Verificar_Cruce(j, tbHSabado16, 28, 7);
            cruces = cruces + Verificar_Cruce(j, tbHSabado17, 29, 7);
            cruces = cruces + Verificar_Cruce(j, tbHSabado18, 30, 7);
            cruces = cruces + Verificar_Cruce(j, tbHSabado19, 31, 7);
            cruces = cruces + Verificar_Cruce(j, tbHSabado20, 32, 7);



            return (cruces);
        }

        private int verificacion_total_cruces(string par, string aula, string prof) {
            int v = 0;

            PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");

            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    PARALELO_MATERIA_PROFESOR.Application.ActiveWorkbook.Sheets[i].Activate();
                    if (PARALELO_MATERIA_PROFESOR.ActiveSheet.name == par)
                    {
                        if (Contar_Cruce(PARALELO_MATERIA_PROFESOR) != 0)
                        {
                            MessageBox.Show("NO ASIGNADO: Cruce de Horario materias del paralelo.", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            v = v + 1;
                        }

                    }
                }
            }
            catch
            {

            }
            PARALELO_MATERIA_PROFESOR.Quit();


            PROFESORES_MATERIAS_CREDITOS.Workbooks.Open("C:\\Users\\ECP\\Documents\\PROFESORES_MATERIAS_CREDITOS.xlsx");
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    PROFESORES_MATERIAS_CREDITOS.Application.ActiveWorkbook.Sheets[i].Activate();
                    if (PROFESORES_MATERIAS_CREDITOS.Cells[1, 2].Text == prof)
                    {
                        if (Contar_Cruce(PROFESORES_MATERIAS_CREDITOS) != 0)
                        {
                            MessageBox.Show("NO ASIGNADO: Cruce de Horario del Profesor", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            v = v + 1;
                        }
                    }
                }
            }
            catch
            {

            }
            PROFESORES_MATERIAS_CREDITOS.Quit();


            AULAS.Workbooks.Open("C:\\Users\\ECP\\Documents\\AULAS_HORARIOS.xlsx");
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    AULAS.Application.ActiveWorkbook.Sheets[i].Activate();
                    if (AULAS.Application.ActiveWorkbook.Sheets[i].Text == aula)
                    {
                        if (Contar_Cruce(AULAS) != 0)
                        {
                            MessageBox.Show("NO ASIGNADO: Cruce de Horario en el Aula", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            v = v + 1;
                        }
                    }
                }
            }
            catch
            {

            }
            AULAS.Quit();

            return (v);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            // cbHMaterias.Text= Contar_x().ToString();
            tbHDescripcion.Clear();
            cargarMateriasCreditos(devolvermateria(cbhSemestre.Text) + "_par_" + cbHParalelos.Text);
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cbHParalelos.Items.Clear();
            cbHMaterias.Items.Clear();
            tbHDescripcion.Clear();
            cargarParalelos(PARALELO_MATERIA_PROFESOR, cbhSemestre, cbHParalelos);
            
            BloquearDesbloquearCeldasHorario(true);
            LeerHorarioExcel();
            BloquearDesbloquearCeldasHorario(false);

        }

        private void textBox95_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox118_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox121_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox125_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox112_TextChanged(object sender, EventArgs e)
        {

        }
        private string saberprofesormateria() {
            string profesor="";
            int v = 0;
            PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    PARALELO_MATERIA_PROFESOR.Application.ActiveWorkbook.Sheets[i].Activate();
                    if (PARALELO_MATERIA_PROFESOR.ActiveSheet.name == devolvermateria(cbhSemestre.Text) + "_par_" + cbHParalelos.Text)
                    {
                        for (int w = 3; w < 19; w++)
                        {
                            if (PARALELO_MATERIA_PROFESOR.Cells[w, 2].Text == cbHMaterias.Text)
                            {
                                profesor = PARALELO_MATERIA_PROFESOR.Cells[w, 6].Text;
                                
                                v = 1;
                                break;
                            }
                        }
                    }
                    if (v == 1)
                    {
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR TIPO 1-A ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            PARALELO_MATERIA_PROFESOR.Quit();
            return (profesor);
        }
        private void bHAsignar_Click(object sender, EventArgs e)
        {
            if(verificacion_total_cruces(devolvermateria(cbhSemestre.Text),cbHAulas.Text, saberprofesormateria()) ==0)
            if (verificarCreditosaAsignar() == 1) {
                AsignarMateriasEnExcelconX(cbHMaterias);
                BloquearDesbloquearCeldasHorario(true);
                LeerHorarioExcel();
                BloquearDesbloquearCeldasHorario(false);
            }
        }

        private void EliminarHorarioMateria( string cbx)
        {
           
            string profesor = "";
            string creditos = "";
         //   string helpAula = "";
           // string helpsemestre = "";
            //string helpparalelo = "";

            int v = 0;
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    PARALELO_MATERIA_PROFESOR.Application.ActiveWorkbook.Sheets[i].Activate();
                    if (PARALELO_MATERIA_PROFESOR.ActiveSheet.name == devolvermateria(cbhSemestre.Text) + "_par_" + cbHParalelos.Text)
                    {
                        for (int w = 3; w < 19; w++)
                        {
                            if (PARALELO_MATERIA_PROFESOR.Cells[w, 2].Text == cbx)
                            {
                                profesor = PARALELO_MATERIA_PROFESOR.Cells[w, 6].Text;
                                creditos = PARALELO_MATERIA_PROFESOR.Cells[w, 3].Text;
              //                  helpAula = cbHAulas.Text;
                                //helpsemestre = cbhSemestre.Text;
                //                helpparalelo = cbHParalelos.Text;


                              //  cbhSemestre.Text = PARALELO_MATERIA_PROFESOR.Cells[1, 2].Text;
                  //              cbHParalelos.Text = PARALELO_MATERIA_PROFESOR.Cells[2, 2].Text;

                    //            cbHAulas.Text = PARALELO_MATERIA_PROFESOR.Cells[w, 7].Text;

                                PARALELO_MATERIA_PROFESOR.Cells[w, 5] = convertirInt(PARALELO_MATERIA_PROFESOR.Cells[w, 5].Text) + convertirInt(PARALELO_MATERIA_PROFESOR.Cells[w, 4].Text);
                                PARALELO_MATERIA_PROFESOR.Cells[w, 4] = convertirInt(PARALELO_MATERIA_PROFESOR.Cells[w, 3].Text) - convertirInt(PARALELO_MATERIA_PROFESOR.Cells[w, 5].Text);
                                PARALELO_MATERIA_PROFESOR.Cells[w, 7] = "";
                                EliminarHorarioMateria2(PARALELO_MATERIA_PROFESOR, cbx);
                                v = 1;
                                break;
                            }
                        }
                    }
                    if (v == 1)
                    {
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR TIPO 1-A ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            v = 0;


            try
            {
                for (int i = 1; i <= 100; i++)
                {

                    PROFESORES_MATERIAS_CREDITOS.Application.ActiveWorkbook.Sheets[i].Activate();
                    if (PROFESORES_MATERIAS_CREDITOS.Cells[1, 2].Text == profesor)
                    {
                        for (int w = 3; w < 19; w++)
                        {
                            if ((PROFESORES_MATERIAS_CREDITOS.Cells[w, 1].Text == cbx) && (PROFESORES_MATERIAS_CREDITOS.Cells[w, 4].Text == cbHParalelos.Text))
                            {

                                PROFESORES_MATERIAS_CREDITOS.Cells[w, 5] = "";
                                EliminarHorarioMateria2(PROFESORES_MATERIAS_CREDITOS, cbx);
                                v = 1;
                                break;
                            }
                        }
                        
                    }

                    if (v == 1)
                    {
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR TIPO 1-B ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            v = 0;

            if (cbHAulas.Text != "") { 
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    AULAS.Application.ActiveWorkbook.Sheets[i].Activate();
                    if (AULAS.ActiveSheet.name == cbHAulas.Text)
                    {
                        for (int w = 3; w < 19; w++)
                        {
                            if (AULAS.Cells[w, 1].Text == cbx)
                            {
                                
                                AULAS.Cells[w, 2] = "";
                                AULAS.Cells[w, 3] = "";
                                AULAS.Cells[w, 4] = "";
                                AULAS.Cells[w, 5] = "";
                                AULAS.Cells[w, 1] = "";
                                subirVacios(AULAS,1);
                                EliminarHorarioMateria2(AULAS, cbx);
                                v = 1;
                                break;
                            }
                        }

                    }
                    if (v == 1)
                    {
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR TIPO 1-C-2 ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            }

      //      cbHAulas.Text = helpAula;
          //  cbhSemestre.Text = helpsemestre;
        //    cbHParalelos.Text = helpparalelo;


        }
        private void subirVacios(Microsoft.Office.Interop.Excel.Application j, int columna)
        {
            for (int i = 1; i <= 17; i++) {
                if (j.Cells[i, columna].Text == "") {
                    j.Cells[i, columna] = j.Cells[i+1, columna].Text;
                    j.Cells[i, columna+1] = j.Cells[i + 1, columna+1].Text;
                    j.Cells[i, columna+2] = j.Cells[i + 1, columna+2].Text;
                    j.Cells[i, columna+3] = j.Cells[i + 1, columna+3].Text;
                    j.Cells[i, columna+4] = j.Cells[i + 1, columna+4].Text;
                    j.Cells[i, columna + 5] = j.Cells[i + 1, columna + 5].Text;

                     j.Cells[i + 1, columna]="";
                     j.Cells[i + 1, columna + 1]="";
                     j.Cells[i + 1, columna + 2]="";
                     j.Cells[i + 1, columna + 3]="";
                     j.Cells[i + 1, columna + 4]="";
                     j.Cells[i + 1, columna + 5]="";


                }

            }


        }

        private void EliminarHorarioMateria2(Microsoft.Office.Interop.Excel.Application j, string materia)
        {
            for (int i = 21; i <= 32; i++)
            {
                for (int w = 2; w <= 7; w++)
                    if (j.Cells[i, w].Text == materia) {
                        j.Cells[i, w] = "";
                    }
            }

        }
        private void LeerHorarioExcel() {
            AULAS.Workbooks.Open("C:\\Users\\ECP\\Documents\\AULAS_HORARIOS.xlsx");
            for (int i = 1; i <= 100; i++)
            {
                AULAS.Application.ActiveWorkbook.Sheets[i].Activate();
                if (AULAS.ActiveSheet.name == cbHAulas.Text)
                {
                    break;
                }
            }

            //LUNES
            tbHLunes730.Text = AULAS.Cells[21, 2].Text;
            tbHLunes830.Text = AULAS.Cells[22, 2].Text;
            tbHLunes10.Text = AULAS.Cells[23, 2].Text;
            tbHLunes11.Text = AULAS.Cells[24, 2].Text;
            tbHLunes12.Text = AULAS.Cells[25, 2].Text;
            tbHLunes14.Text = AULAS.Cells[26, 2].Text;
            tbHLunes15.Text = AULAS.Cells[27, 2].Text;
            tbHLunes16.Text = AULAS.Cells[28, 2].Text;
            tbHLunes17.Text = AULAS.Cells[29, 2].Text;
            tbHLunes18.Text = AULAS.Cells[30, 2].Text;
            tbHLunes19.Text = AULAS.Cells[31, 2].Text;
            tbHLunes20.Text = AULAS.Cells[32, 2].Text;

            //MARTES
            tbHMartes730.Text = AULAS.Cells[21, 3].Text;
            tbHMartes830.Text = AULAS.Cells[22, 3].Text;
            tbHMartes10.Text = AULAS.Cells[23, 3].Text;
            tbHMartes11.Text = AULAS.Cells[24, 3].Text;
            tbHMartes12.Text = AULAS.Cells[25, 3].Text;
            tbHMartes14.Text = AULAS.Cells[26, 3].Text;
            tbHMartes15.Text = AULAS.Cells[27, 3].Text;
            tbHMartes16.Text = AULAS.Cells[28, 3].Text;
            tbHMartes17.Text = AULAS.Cells[29, 3].Text;
            tbHMartes18.Text = AULAS.Cells[30, 3].Text;
            tbHMartes19.Text = AULAS.Cells[31, 3].Text;
            tbHMartes20.Text = AULAS.Cells[32, 3].Text;

            //Miercoles
            tbHMiercoles730.Text = AULAS.Cells[21, 4].Text;
            tbHMiercoles830.Text = AULAS.Cells[22, 4].Text;
            tbHMiercoles10.Text = AULAS.Cells[23, 4].Text;
            tbHMiercoles11.Text = AULAS.Cells[24, 4].Text;
            tbHMiercoles12.Text = AULAS.Cells[25, 4].Text;
            tbHMiercoles14.Text = AULAS.Cells[26, 4].Text;
            tbHMiercoles15.Text = AULAS.Cells[27, 4].Text;
            tbHMiercoles16.Text = AULAS.Cells[28, 4].Text;
            tbHMiercoles17.Text = AULAS.Cells[29, 4].Text;
            tbHMiercoles18.Text = AULAS.Cells[30, 4].Text;
            tbHMiercoles19.Text = AULAS.Cells[31, 4].Text;
            tbHMiercoles20.Text = AULAS.Cells[32, 4].Text;


            //Jueves
            tbHJueves730.Text = AULAS.Cells[21, 5].Text;
            tbHJueves830.Text = AULAS.Cells[22, 5].Text;
            tbHJueves10.Text = AULAS.Cells[23, 5].Text;
            tbHJueves11.Text = AULAS.Cells[24, 5].Text;
            tbHJueves12.Text = AULAS.Cells[25, 5].Text;
            tbHJueves14.Text = AULAS.Cells[26, 5].Text;
            tbHJueves15.Text = AULAS.Cells[27, 5].Text;
            tbHJueves16.Text = AULAS.Cells[28, 5].Text;
            tbHJueves17.Text = AULAS.Cells[29, 5].Text;
            tbHJueves18.Text = AULAS.Cells[30, 5].Text;
            tbHJueves19.Text = AULAS.Cells[31, 5].Text;
            tbHJueves20.Text = AULAS.Cells[32, 5].Text;

            //Viernes
            tbHViernes730.Text = AULAS.Cells[21, 6].Text;
            tbHViernes830.Text = AULAS.Cells[22, 6].Text;
            tbHViernes10.Text = AULAS.Cells[23, 6].Text;
            tbHViernes11.Text = AULAS.Cells[24, 6].Text;
            tbHViernes12.Text = AULAS.Cells[25, 6].Text;
            tbHViernes14.Text = AULAS.Cells[26, 6].Text;
            tbHViernes15.Text = AULAS.Cells[27, 6].Text;
            tbHViernes16.Text = AULAS.Cells[28, 6].Text;
            tbHViernes17.Text = AULAS.Cells[29, 6].Text;
            tbHViernes18.Text = AULAS.Cells[30, 6].Text;
            tbHViernes19.Text = AULAS.Cells[31, 6].Text;
            tbHViernes20.Text = AULAS.Cells[32, 6].Text;

            //Sabado
            tbHSabado730.Text = AULAS.Cells[21, 7].Text;
            tbHSabado830.Text = AULAS.Cells[22, 7].Text;
            tbHSabado10.Text = AULAS.Cells[23, 7].Text;
            tbHSabado11.Text = AULAS.Cells[24, 7].Text;
            tbHSabado12.Text = AULAS.Cells[25, 7].Text;
            tbHSabado14.Text = AULAS.Cells[26, 7].Text;
            tbHSabado15.Text = AULAS.Cells[27, 7].Text;
            tbHSabado16.Text = AULAS.Cells[28, 7].Text;
            tbHSabado17.Text = AULAS.Cells[29, 7].Text;
            tbHSabado18.Text = AULAS.Cells[30, 7].Text;
            tbHSabado19.Text = AULAS.Cells[31, 7].Text;
            tbHSabado20.Text = AULAS.Cells[32, 7].Text;

            cargarMateriasCreditos(devolvermateria(cbhSemestre.Text)+"_par_"+cbHParalelos.Text);



            AULAS.Quit();
        }
        
        private void BloquearDesbloquearCeldasHorario(bool val) {
            //LUNES
            BloquearDesbloquearUnaCeldaLLena(tbHLunes730, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHLunes830, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHLunes10, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHLunes11, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHLunes12, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHLunes14, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHLunes15, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHLunes16, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHLunes17, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHLunes18, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHLunes19, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHLunes20, val); 

            //MARTES
            BloquearDesbloquearUnaCeldaLLena(tbHMartes730, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMartes830, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMartes10, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMartes11, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMartes12, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMartes14, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMartes15, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMartes16, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMartes17, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMartes18, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMartes19, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMartes20, val); 

            //Miercoles
            BloquearDesbloquearUnaCeldaLLena(tbHMiercoles730, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMiercoles830, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMiercoles10, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMiercoles11, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMiercoles12, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMiercoles14, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMiercoles15, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMiercoles16, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMiercoles17, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMiercoles18, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMiercoles19, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHMiercoles20, val);


            //Jueves
            BloquearDesbloquearUnaCeldaLLena(tbHJueves730, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHJueves830, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHJueves10, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHJueves11, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHJueves12, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHJueves14, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHJueves15, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHJueves16, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHJueves17, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHJueves18, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHJueves19, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHJueves20, val); 

            //Viernes
            BloquearDesbloquearUnaCeldaLLena(tbHViernes730, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHViernes830, val);
            BloquearDesbloquearUnaCeldaLLena(tbHViernes10, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHViernes11, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHViernes12, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHViernes14, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHViernes15, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHViernes16, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHViernes17, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHViernes18, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHViernes19, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHViernes20, val); 

            //Sabado
            BloquearDesbloquearUnaCeldaLLena(tbHSabado730, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHSabado830, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHSabado10, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHSabado11, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHSabado12, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHSabado14, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHSabado15, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHSabado16, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHSabado17, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHSabado18, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHSabado19, val); 
            BloquearDesbloquearUnaCeldaLLena(tbHSabado20, val); 

        }
        private void BloquearDesbloquearUnaCeldaLLena(System.Windows.Forms.TextBox tx,bool val){
            if (tx.Text != "") {
                tx.Enabled = val;
            }
        }
        private void AsignarMateriasEnExcelconX( System.Windows.Forms.ComboBox cbx) {
            PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");
            PROFESORES_MATERIAS_CREDITOS.Workbooks.Open("C:\\Users\\ECP\\Documents\\PROFESORES_MATERIAS_CREDITOS.xlsx");
            AULAS.Workbooks.Open("C:\\Users\\ECP\\Documents\\AULAS_HORARIOS.xlsx");
            string profesor = "";
            string creditos = "";
            int v = 0;
            try { 
            for (int i = 1; i <= 100; i++)
            {
                PARALELO_MATERIA_PROFESOR.Application.ActiveWorkbook.Sheets[i].Activate();
                if (PARALELO_MATERIA_PROFESOR.ActiveSheet.name == devolvermateria(cbhSemestre.Text)+"_par_"+cbHParalelos.Text)
                {
                    for (int w = 3; w < 19; w++)
                    {
                        if (PARALELO_MATERIA_PROFESOR.Cells[w, 2].Text == cbHMaterias.Text)
                        {
                            profesor = PARALELO_MATERIA_PROFESOR.Cells[w, 6].Text;
                            creditos= PARALELO_MATERIA_PROFESOR.Cells[w, 3].Text;
                            PARALELO_MATERIA_PROFESOR.Cells[w, 4] = convertirInt(PARALELO_MATERIA_PROFESOR.Cells[w, 4].Text) + Contar_x();
                            PARALELO_MATERIA_PROFESOR.Cells[w, 5] = convertirInt(PARALELO_MATERIA_PROFESOR.Cells[w, 5].Text) - Contar_x();
                            PARALELO_MATERIA_PROFESOR.Cells[w, 7] = cbHAulas.Text;
                            v = 1;
                            break;
                        }
                    }                        
                }
                if (v == 1) {
                    break;
                }
            }
            }
            catch
            {
                MessageBox.Show("ERROR TIPO 1-A ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            v = 0;


            try
            {
                for (int i = 1; i <= 100; i++)
                {

                    PROFESORES_MATERIAS_CREDITOS.Application.ActiveWorkbook.Sheets[i].Activate();
                    if (PROFESORES_MATERIAS_CREDITOS.Cells[1, 2].Text == profesor)
                    {
                        for (int w = 3; w < 19; w++)
                        {
                            if ((PROFESORES_MATERIAS_CREDITOS.Cells[w, 1].Text == cbHMaterias.Text) && (PROFESORES_MATERIAS_CREDITOS.Cells[w, 4].Text == cbHParalelos.Text))
                            {

                                PROFESORES_MATERIAS_CREDITOS.Cells[w, 5] = cbHAulas.Text;
                                v = 1;
                                break;
                            }
                        }

                 

                    }

                    if (v == 1)
                    {
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR TIPO 1-B ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            v = 0;
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    AULAS.Application.ActiveWorkbook.Sheets[i].Activate();
                    if (AULAS.ActiveSheet.name == cbHAulas.Text)
                    {
                        for (int w = 3; w < 19; w++)
                        {
                            if (AULAS.Cells[w, 1].Text == "")
                            {
                                AULAS.Cells[w, 1] = cbHMaterias.Text;
                                AULAS.Cells[w, 2] = creditos;
                                AULAS.Cells[w, 3] = cbhSemestre.Text;
                                AULAS.Cells[w, 4] = cbHParalelos.Text;
                                AULAS.Cells[w, 5] = profesor;
                                v = 1;
                                break;
                            }
                        }

                    }
                    if (v == 1)
                    {
                        break;
                    }
                }
            }
            catch {
                MessageBox.Show("ERROR TIPO 1-C ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            //LUNES
            escribirunaceldamateria( tbHLunes730, cbHMaterias, 21, 2);
            escribirunaceldamateria( tbHLunes830, cbHMaterias, 22, 2);
            escribirunaceldamateria( tbHLunes10, cbHMaterias, 23, 2);
            escribirunaceldamateria( tbHLunes11, cbHMaterias, 24, 2);
            escribirunaceldamateria( tbHLunes12, cbHMaterias, 25, 2);
            escribirunaceldamateria( tbHLunes14, cbHMaterias, 26, 2);
            escribirunaceldamateria( tbHLunes15, cbHMaterias, 27, 2);
            escribirunaceldamateria( tbHLunes16, cbHMaterias, 28, 2);
            escribirunaceldamateria( tbHLunes17, cbHMaterias, 29, 2);
            escribirunaceldamateria( tbHLunes18, cbHMaterias, 30, 2);
            escribirunaceldamateria( tbHLunes19, cbHMaterias, 31, 2);
            escribirunaceldamateria( tbHLunes20, cbHMaterias, 32, 2);


            //MARTES
            escribirunaceldamateria(tbHMartes730, cbHMaterias, 21, 3);
            escribirunaceldamateria(tbHMartes830, cbHMaterias, 22, 3);
            escribirunaceldamateria(tbHMartes10, cbHMaterias, 23, 3);
            escribirunaceldamateria(tbHMartes11, cbHMaterias, 24, 3);
            escribirunaceldamateria(tbHMartes12, cbHMaterias, 25, 3);
            escribirunaceldamateria(tbHMartes14, cbHMaterias, 26, 3);
            escribirunaceldamateria(tbHMartes15, cbHMaterias, 27, 3);
            escribirunaceldamateria(tbHMartes16, cbHMaterias, 28, 3);
            escribirunaceldamateria(tbHMartes17, cbHMaterias, 29, 3);
            escribirunaceldamateria(tbHMartes18, cbHMaterias, 30, 3);
            escribirunaceldamateria(tbHMartes19, cbHMaterias, 31, 3);
            escribirunaceldamateria(tbHMartes20, cbHMaterias, 32, 3);


            //MIERCOLES
            escribirunaceldamateria(tbHMiercoles730, cbHMaterias, 21, 4);
            escribirunaceldamateria(tbHMiercoles830, cbHMaterias, 22, 4);
            escribirunaceldamateria(tbHMiercoles10, cbHMaterias, 23, 4);
            escribirunaceldamateria(tbHMiercoles11, cbHMaterias, 24, 4);
            escribirunaceldamateria(tbHMiercoles12, cbHMaterias, 25, 4);
            escribirunaceldamateria(tbHMiercoles14, cbHMaterias, 26, 4);
            escribirunaceldamateria(tbHMiercoles15, cbHMaterias, 27, 4);
            escribirunaceldamateria(tbHMiercoles16, cbHMaterias, 28, 4);
            escribirunaceldamateria(tbHMiercoles17, cbHMaterias, 29, 4);
            escribirunaceldamateria(tbHMiercoles18, cbHMaterias, 30, 4);
            escribirunaceldamateria(tbHMiercoles19, cbHMaterias, 31, 4);
            escribirunaceldamateria(tbHMiercoles20, cbHMaterias, 32, 4);



            //JUEVES
            escribirunaceldamateria(tbHJueves730, cbHMaterias, 21, 5);
            escribirunaceldamateria(tbHJueves830, cbHMaterias, 22, 5);
            escribirunaceldamateria(tbHJueves10, cbHMaterias, 23, 5);
            escribirunaceldamateria(tbHJueves11, cbHMaterias, 24, 5);
            escribirunaceldamateria(tbHJueves12, cbHMaterias, 25, 5);
            escribirunaceldamateria(tbHJueves14, cbHMaterias, 26, 5);
            escribirunaceldamateria(tbHJueves15, cbHMaterias, 27, 5);
            escribirunaceldamateria(tbHJueves16, cbHMaterias, 28, 5);
            escribirunaceldamateria(tbHJueves17, cbHMaterias, 29, 5);
            escribirunaceldamateria(tbHJueves18, cbHMaterias, 30, 5);
            escribirunaceldamateria(tbHJueves19, cbHMaterias, 31, 5);
            escribirunaceldamateria(tbHJueves20, cbHMaterias, 32, 5);


            //VIERNES
            escribirunaceldamateria(tbHViernes730, cbHMaterias, 21, 6);
            escribirunaceldamateria(tbHViernes830, cbHMaterias, 22, 6);
            escribirunaceldamateria(tbHViernes10, cbHMaterias, 23, 6);
            escribirunaceldamateria(tbHViernes11, cbHMaterias, 24, 6);
            escribirunaceldamateria(tbHViernes12, cbHMaterias, 25, 6);
            escribirunaceldamateria(tbHViernes14, cbHMaterias, 26, 6);
            escribirunaceldamateria(tbHViernes15, cbHMaterias, 27, 6);
            escribirunaceldamateria(tbHViernes16, cbHMaterias, 28, 6);
            escribirunaceldamateria(tbHViernes17, cbHMaterias, 29, 6);
            escribirunaceldamateria(tbHViernes18, cbHMaterias, 30, 6);
            escribirunaceldamateria(tbHViernes19, cbHMaterias, 31, 6);
            escribirunaceldamateria(tbHViernes20, cbHMaterias, 32, 6);

            //SABADO
            escribirunaceldamateria(tbHSabado730, cbHMaterias, 21, 7);
            escribirunaceldamateria(tbHSabado830, cbHMaterias, 22, 7);
            escribirunaceldamateria(tbHSabado10, cbHMaterias, 23, 7);
            escribirunaceldamateria(tbHSabado11, cbHMaterias, 24, 7);
            escribirunaceldamateria(tbHSabado12, cbHMaterias, 25, 7);
            escribirunaceldamateria(tbHSabado14, cbHMaterias, 26, 7);
            escribirunaceldamateria(tbHSabado15, cbHMaterias, 27, 7);
            escribirunaceldamateria(tbHSabado16, cbHMaterias, 28, 7);
            escribirunaceldamateria(tbHSabado17, cbHMaterias, 29, 7);
            escribirunaceldamateria(tbHSabado18, cbHMaterias, 30, 7);
            escribirunaceldamateria(tbHSabado19, cbHMaterias, 31, 7);
            escribirunaceldamateria(tbHSabado20, cbHMaterias, 32, 7);

            PARALELO_MATERIA_PROFESOR.ActiveWorkbook.Save();
            PROFESORES_MATERIAS_CREDITOS.ActiveWorkbook.Save();
            AULAS.ActiveWorkbook.Save();
            PARALELO_MATERIA_PROFESOR.Quit();
            PROFESORES_MATERIAS_CREDITOS.Quit();
            AULAS.Quit();


        }
        private void escribirunaceldamateria(System.Windows.Forms.TextBox tx, System.Windows.Forms.ComboBox cbx, int fila,int columna) {
            if (tx.Text == "x")
            {
                PARALELO_MATERIA_PROFESOR.Cells[fila, columna] = cbx.Text;
                AULAS.Cells[fila, columna] = cbx.Text;
                PROFESORES_MATERIAS_CREDITOS.Cells[fila, columna] = cbx.Text;
            }
        }
        private int verificarCreditosaAsignar() {
            PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");
            int v = 0;
            int salir = 0;
            string name = devolvermateria(cbhSemestre.Text) + "_par_" + cbHParalelos.Text;
            try
            {
                for (int i = 1; i <= 100; i++)
                {
                    PARALELO_MATERIA_PROFESOR.Application.ActiveWorkbook.Sheets[i].Activate();
                    if (PARALELO_MATERIA_PROFESOR.ActiveSheet.name == name)
                    {
                        for (int w = 3; w < 19; w++)
                        {
                            if (PARALELO_MATERIA_PROFESOR.Cells[w, 2].Text == cbHMaterias.Text)
                            {
                                if ((convertirInt(PARALELO_MATERIA_PROFESOR.Cells[w, 5].Text) >= Contar_x()) && (Contar_x()>0) )
                                {
                                    v = 1;
                                    salir = 1;
                                    break;
                                }
                                else
                                {
                                    salir = 1;
                                    break;

                                }

                            }

                        }

                        if (salir == 1)
                        {
                            break;
                        }

                    }

                    if (salir == 1)
                    {
                        break;
                    }
                }
                 
            }
            catch
            {

            }
            
            PARALELO_MATERIA_PROFESOR.Quit();
            return (v);
        }
        private void bHLimpiar_Click(object sender, EventArgs e)
        {
            
            cbHAulas.Enabled = true;
            cbHMaterias.Text = "";
            cbHMaterias.Enabled = true;
           
            cbHParalelos.Enabled = true;
           
            cbhSemestre.Enabled = true;
            bHSeleccionar.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");
            PROFESORES_MATERIAS_CREDITOS.Workbooks.Open("C:\\Users\\ECP\\Documents\\PROFESORES_MATERIAS_CREDITOS.xlsx");
            AULAS.Workbooks.Open("C:\\Users\\ECP\\Documents\\AULAS_HORARIOS.xlsx");

            EliminarHorarioMateria(cbhMateriaEliminar.Text);

            PARALELO_MATERIA_PROFESOR.ActiveWorkbook.Save();
            PROFESORES_MATERIAS_CREDITOS.ActiveWorkbook.Save();
            AULAS.ActiveWorkbook.Save();

            PARALELO_MATERIA_PROFESOR.Quit();
            PROFESORES_MATERIAS_CREDITOS.Quit();
            AULAS.Quit();




            BloquearDesbloquearCeldasHorario(true);
            LeerHorarioExcel();
            BloquearDesbloquearCeldasHorario(false);


            
        }
        private void HparaleloconFORMATO() {
            FORMATO_HORARIO_PARALELOS.Workbooks.Open("C:\\Users\\ECP\\Documents\\FORMATO_HORARIO_PARALELOS.xlsx");
            PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");
            int q = PARALELO_MATERIA_PROFESOR.ActiveWorkbook.Sheets.Count;

            try
            {
                for (int i = 2; i <= q; i++)
                {

                    //FORMATO_HORARIO_PARALELOS.Worksheets.Add();
                    FORMATO_HORARIO_PARALELOS.Worksheets[i - 1].Copy(FORMATO_HORARIO_PARALELOS.Worksheets[1]);

                    PARALELO_MATERIA_PROFESOR.Worksheets[i].Activate();
                    FORMATO_HORARIO_PARALELOS.ActiveWorkbook.ActiveSheet.name = PARALELO_MATERIA_PROFESOR.ActiveWorkbook.ActiveSheet.name;

                    FORMATO_HORARIO_PARALELOS.Cells[6, 2] = "1S-2017";
                    FORMATO_HORARIO_PARALELOS.Cells[7, 2] = PARALELO_MATERIA_PROFESOR.Cells[1, 2];
                    FORMATO_HORARIO_PARALELOS.Cells[8, 2] = PARALELO_MATERIA_PROFESOR.Cells[2, 2];
                    FORMATO_HORARIO_PARALELOS.Cells[27, 1] = "Direccion de la Carrera de Ingenieria Civil";
                    FORMATO_HORARIO_PARALELOS.Cells[27, 3] = "Decanato";
                    FORMATO_HORARIO_PARALELOS.Cells[27, 5] = "SIGA-FCI-UPSE:" + System.DateTime.Now;

                    int XVAL = convertirInt(PARALELO_MATERIA_PROFESOR.Cells[4, 3].Text) + convertirInt(PARALELO_MATERIA_PROFESOR.Cells[5, 3].Text) + convertirInt(PARALELO_MATERIA_PROFESOR.Cells[6, 3].Text) + convertirInt(PARALELO_MATERIA_PROFESOR.Cells[7, 3].Text) + convertirInt(PARALELO_MATERIA_PROFESOR.Cells[8, 3].Text) + convertirInt(PARALELO_MATERIA_PROFESOR.Cells[9, 3].Text);
                    FORMATO_HORARIO_PARALELOS.Cells[9, 2] = XVAL.ToString();

                    for (int w = 4; w <= 9; w++)
                    {

                        FORMATO_HORARIO_PARALELOS.Cells[w + 3, 5] = PARALELO_MATERIA_PROFESOR.Cells[w, 7];
                        FORMATO_HORARIO_PARALELOS.Cells[w + 3, 6] = PARALELO_MATERIA_PROFESOR.Cells[w, 6];
                        FORMATO_HORARIO_PARALELOS.Cells[w + 3, 3] = PARALELO_MATERIA_PROFESOR.Cells[w, 2];

                    }



                    for (int j = 21; j <= 32; j++)
                    {
                        for (int k = 2; k <= 7; k++)
                        {
                            FORMATO_HORARIO_PARALELOS.Cells[j - 7, k] = PARALELO_MATERIA_PROFESOR.Cells[j, k];

                        }

                    }


                }



            }
            catch { }



            PARALELO_MATERIA_PROFESOR.ActiveWorkbook.Save();
            PARALELO_MATERIA_PROFESOR.Quit();


            FORMATO_HORARIO_PARALELOS.ActiveWorkbook.Save();
            FORMATO_HORARIO_PARALELOS.Quit();


        }
        private void label49_Click(object sender, EventArgs e)
        {
            HparaleloconFORMATO();        
        }

        private int VerificarAccesoProfesor(string text)
        {
            string cnnstring = @"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=|DataDirectory|\\login.mdb;";
            int cartel = 1;
            try
            {
                OleDbConnection conection = new OleDbConnection(cnnstring);
                OleDbCommand selectName = new OleDbCommand("SELECT Cedula, Nombre1, Nombre2, Apellido1, Apellido2, LugarDeNacimiento, FechaDeNacimiento, CorreoElectronico, Telefono, TituloTercerNivel, RegistroSenescytTN, MayorNivel, TituloCuartoNivel, RegistroSenescytCN, OtrosTitulosCN, RegistroSenescytOtrosTCN, Dedicacion, CargaUniversitaria, Especificidad From ProfesoresRegistrados", conection);
                try
                {

                    conection.Open();
                    OleDbDataReader Lector = selectName.ExecuteReader();


                    while (Lector.Read())
                    {

                        if ((text == Lector.GetValue(0).ToString()))
                        {

                            cartel = 0;
                            bRegistrarProf.Enabled = false;
                             
                            tBcedula.Text= Lector.GetValue(0).ToString();
                            tBnombre1.Text = Lector.GetValue(1).ToString();
                            tBnombre2.Text = Lector.GetValue(2).ToString();
                            tBapellido1.Text = Lector.GetValue(3).ToString();
                            tBapellido2.Text = Lector.GetValue(4).ToString();
                            tBlugarDeNacimiento.Text = Lector.GetValue(5).ToString();
                            tBfechaDeNacimiento.Text = Lector.GetValue(6).ToString();
                            tBCorreoElectronico.Text = Lector.GetValue(7).ToString();
                            tBtelefono.Text = Lector.GetValue(8).ToString();
                            tBtituloTercerNivel.Text = Lector.GetValue(9).ToString();
                            tBregistroSenescytTN.Text = Lector.GetValue(10).ToString();
                            tBcboxMayorNivel.Text = Lector.GetValue(11).ToString();
                            tBtituloCuartoNivel.Text = Lector.GetValue(12).ToString();
                            tBregistroSenescytCN.Text = Lector.GetValue(13).ToString();
                            tBotrosTitulosCN.Text = Lector.GetValue(14).ToString();
                            tBregistroSenescytOtrosTCN.Text = Lector.GetValue(15).ToString();
                            tBcBoxDedicacion.Text = Lector.GetValue(16).ToString();
                            tBcBoxCargaUniversitaria.Text = Lector.GetValue(17).ToString();
                            tBcBoxEspecificidad.Text = Lector.GetValue(18).ToString();
                            

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
            return (cartel);
        }

        private void bModificarS1_Click(object sender, EventArgs e)
        {
            tParaleloS1.Enabled = true;
            //escribirenExcel("villegas es un genio");
            // this.semestresParalelosTableAdapter1.ModificarSemestreParalelo("1","PRIMER SEMESTRE", "10",5, "1");
           // EscribirBlock(tSemestre1, tParaleloS1, "1");
        }

        private void bModificarS2_Click(object sender, EventArgs e)
        {
            tParaleloS2.Enabled = true;
            
        }

        private void bModificarS3_Click(object sender, EventArgs e)
        {
            tParaleloS3.Enabled = true;
        }

        private void bModificarS4_Click(object sender, EventArgs e)
        {
            tParaleloS4.Enabled = true;
        }

        private void bModificarS5_Click(object sender, EventArgs e)
        {
            tParaleloS5.Enabled = true;
        }

        private void bModificarS6_Click(object sender, EventArgs e)
        {
            tParaleloS6.Enabled = true;
        }

        private void bModificarS7_Click(object sender, EventArgs e)
        {
            tParaleloS7.Enabled = true;
        }

        private void bModificarS8_Click(object sender, EventArgs e)
        {
            tParaleloS8.Enabled = true;
        }

        private void bModificarS9_Click(object sender, EventArgs e)
        {
            tParaleloS9.Enabled = true;
        }

        private void bModificarS10_Click(object sender, EventArgs e)
        {
            tParaleloS10.Enabled = true;
            int jose;
            
            
        }

        public static int atoi(string str)
        {
            int sign = 1;
            int TheNumber = 0;
            int tmp = 0;
            int x = 0;
            int l = (str.Length) - 1;
            char[] c = str.ToCharArray();

            if ('-' == c[0]) { sign = -1; x = 1; }

            for (; x < l; x++)
            {
                if ((c[x] >= '0') && (c[x] <= '9'))
                {
                    tmp = (c[x] - '0');//0 is the 0 index
                    TheNumber = TheNumber * 10 + tmp; //to enlarge the number by *10 every time
                }
            }

            return (TheNumber * sign);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //  PARALELO_MATERIA_PROFESOR.Workbooks.Add(true);
            PARALELO_MATERIA_PROFESOR.Workbooks.Open("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");
            


            this.semestresParalelosTableAdapter1.ModificarSemestreParalelo("1", tSemestre1.Text, "10", tParaleloS1.Text, "1");

            escribirenExcel(PARALELO_MATERIA_PROFESOR, "1", tParaleloS1.Text);

            this.semestresParalelosTableAdapter1.ModificarSemestreParalelo("2", tSemestre2.Text, "10", tParaleloS2.Text, "2");
            if (tParaleloS2.Text != "0")
            {
                PARALELO_MATERIA_PROFESOR.Application.Worksheets.Add();
                escribirenExcel(PARALELO_MATERIA_PROFESOR, "2", tParaleloS2.Text);
            }
            this.semestresParalelosTableAdapter1.ModificarSemestreParalelo("3", tSemestre3.Text, "10", tParaleloS3.Text, "3");
            if (tParaleloS3.Text != "0"){
                PARALELO_MATERIA_PROFESOR.Application.Worksheets.Add();
                escribirenExcel(PARALELO_MATERIA_PROFESOR, "3", tParaleloS3.Text);
            }
           

            this.semestresParalelosTableAdapter1.ModificarSemestreParalelo("4", tSemestre4.Text, "10", tParaleloS4.Text, "4");
            if (tParaleloS4.Text != "0")
            {
                PARALELO_MATERIA_PROFESOR.Application.Worksheets.Add();
                escribirenExcel(PARALELO_MATERIA_PROFESOR, "4", tParaleloS4.Text);
            }
            this.semestresParalelosTableAdapter1.ModificarSemestreParalelo("5", tSemestre5.Text, "10", tParaleloS5.Text, "5");
            if (tParaleloS5.Text != "0")
            {
                PARALELO_MATERIA_PROFESOR.Application.Worksheets.Add();
                escribirenExcel(PARALELO_MATERIA_PROFESOR, "5", tParaleloS5.Text);
            }

            this.semestresParalelosTableAdapter1.ModificarSemestreParalelo("6", tSemestre6.Text, "10", tParaleloS6.Text, "6");
            if (tParaleloS6.Text != "0")
            {
                PARALELO_MATERIA_PROFESOR.Application.Worksheets.Add();
                escribirenExcel(PARALELO_MATERIA_PROFESOR, "6", tParaleloS6.Text);
            }

            this.semestresParalelosTableAdapter1.ModificarSemestreParalelo("7", tSemestre7.Text, "10", tParaleloS7.Text, "7");
            if (tParaleloS7.Text != "0")
            {
                PARALELO_MATERIA_PROFESOR.Application.Worksheets.Add();
                escribirenExcel(PARALELO_MATERIA_PROFESOR, "7", tParaleloS7.Text);
            }

            this.semestresParalelosTableAdapter1.ModificarSemestreParalelo("8", tSemestre8.Text, "10", tParaleloS8.Text, "8");
            if (tParaleloS8.Text != "0")
            {
                PARALELO_MATERIA_PROFESOR.Application.Worksheets.Add();
                escribirenExcel(PARALELO_MATERIA_PROFESOR, "8", tParaleloS8.Text);
            }

            this.semestresParalelosTableAdapter1.ModificarSemestreParalelo("9", tSemestre9.Text, "10", tParaleloS9.Text, "9");
            if (tParaleloS9.Text != "0")
            {
                PARALELO_MATERIA_PROFESOR.Application.Worksheets.Add();
                escribirenExcel(PARALELO_MATERIA_PROFESOR, "9", tParaleloS9.Text);
            }
            this.semestresParalelosTableAdapter1.ModificarSemestreParalelo("10", tSemestre10.Text, "10", tParaleloS10.Text, "10");
            if (tParaleloS10.Text != "0")
            {
                PARALELO_MATERIA_PROFESOR.Application.Worksheets.Add();
                escribirenExcel(PARALELO_MATERIA_PROFESOR, "10", tParaleloS10.Text);
            }


            EscribirBlock(tSemestre1, tParaleloS1, "1");
            EscribirBlock(tSemestre2, tParaleloS2, "2");
            EscribirBlock(tSemestre3, tParaleloS3, "3");
            EscribirBlock(tSemestre4, tParaleloS4, "4");
            EscribirBlock(tSemestre5, tParaleloS5, "5");
            EscribirBlock(tSemestre6, tParaleloS6, "6");
            EscribirBlock(tSemestre7, tParaleloS7, "7");
            EscribirBlock(tSemestre8, tParaleloS8, "8");
            EscribirBlock(tSemestre9, tParaleloS9, "9");
            EscribirBlock(tSemestre10, tParaleloS10, "10");
            // EscribirBlock(tSemestre1, tParaleloS1, "1");


            saveFileDialog1.DefaultExt = "*.xlsx";
            //   saveFileDialog1.FileName = "KKKK";
            //  saveFileDialog1.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            //   saveFileDialog1.ShowDialog();
            //PARALELO_MATERIA_PROFESOR.Visible = false;

            PARALELO_MATERIA_PROFESOR.Application.Worksheets.Add();
            try
            {
                PARALELO_MATERIA_PROFESOR.ActiveSheet.name = "SEMESTRES_PARALELOS";
                PARALELO_MATERIA_PROFESOR.Cells[1, 1] = tSemestre1.Text;
                PARALELO_MATERIA_PROFESOR.Cells[2, 1] = tSemestre2.Text;
                PARALELO_MATERIA_PROFESOR.Cells[3, 1] = tSemestre3.Text;
                PARALELO_MATERIA_PROFESOR.Cells[4, 1] = tSemestre4.Text;
                PARALELO_MATERIA_PROFESOR.Cells[5, 1] = tSemestre5.Text;
                PARALELO_MATERIA_PROFESOR.Cells[6, 1] = tSemestre6.Text;
                PARALELO_MATERIA_PROFESOR.Cells[7, 1] = tSemestre7.Text;
                PARALELO_MATERIA_PROFESOR.Cells[8, 1] = tSemestre8.Text;
                PARALELO_MATERIA_PROFESOR.Cells[9, 1] = tSemestre9.Text;
                PARALELO_MATERIA_PROFESOR.Cells[10, 1] = tSemestre10.Text;

                PARALELO_MATERIA_PROFESOR.Cells[1, 2] = tParaleloS1.Text;
                PARALELO_MATERIA_PROFESOR.Cells[2, 2] = tParaleloS2.Text;
                PARALELO_MATERIA_PROFESOR.Cells[3, 2] = tParaleloS3.Text;
                PARALELO_MATERIA_PROFESOR.Cells[4, 2] = tParaleloS4.Text;
                PARALELO_MATERIA_PROFESOR.Cells[5, 2] = tParaleloS5.Text;
                PARALELO_MATERIA_PROFESOR.Cells[6, 2] = tParaleloS6.Text;
                PARALELO_MATERIA_PROFESOR.Cells[7, 2] = tParaleloS7.Text;
                PARALELO_MATERIA_PROFESOR.Cells[8, 2] = tParaleloS8.Text;
                PARALELO_MATERIA_PROFESOR.Cells[9, 2] = tParaleloS9.Text;
                PARALELO_MATERIA_PROFESOR.Cells[10, 2] = tParaleloS10.Text;

            }
            catch {
                PARALELO_MATERIA_PROFESOR.Cells[1, 1] = tSemestre1.Text;
                PARALELO_MATERIA_PROFESOR.Cells[2, 1] = tSemestre2.Text;
                PARALELO_MATERIA_PROFESOR.Cells[3, 1] = tSemestre3.Text;
                PARALELO_MATERIA_PROFESOR.Cells[4, 1] = tSemestre4.Text;
                PARALELO_MATERIA_PROFESOR.Cells[5, 1] = tSemestre5.Text;
                PARALELO_MATERIA_PROFESOR.Cells[6, 1] = tSemestre6.Text;
                PARALELO_MATERIA_PROFESOR.Cells[7, 1] = tSemestre7.Text;
                PARALELO_MATERIA_PROFESOR.Cells[8, 1] = tSemestre8.Text;
                PARALELO_MATERIA_PROFESOR.Cells[9, 1] = tSemestre9.Text;
                PARALELO_MATERIA_PROFESOR.Cells[10, 1] = tSemestre10.Text;

                PARALELO_MATERIA_PROFESOR.Cells[1, 2] = tParaleloS1.Text;
                PARALELO_MATERIA_PROFESOR.Cells[2, 2] = tParaleloS2.Text;
                PARALELO_MATERIA_PROFESOR.Cells[3, 2] = tParaleloS3.Text;
                PARALELO_MATERIA_PROFESOR.Cells[4, 2] = tParaleloS4.Text;
                PARALELO_MATERIA_PROFESOR.Cells[5, 2] = tParaleloS5.Text;
                PARALELO_MATERIA_PROFESOR.Cells[6, 2] = tParaleloS6.Text;
                PARALELO_MATERIA_PROFESOR.Cells[7, 2] = tParaleloS7.Text;
                PARALELO_MATERIA_PROFESOR.Cells[8, 2] = tParaleloS8.Text;
                PARALELO_MATERIA_PROFESOR.Cells[9, 2] = tParaleloS9.Text;
                PARALELO_MATERIA_PROFESOR.Cells[10, 2] = tParaleloS10.Text;

            }





           // PARALELO_MATERIA_PROFESOR.ActiveWorkbook.SaveAs("C:\\Users\\ECP\\Documents\\PARALELO_MATERIA_PROFESOR.xlsx");
            PARALELO_MATERIA_PROFESOR.ActiveWorkbook.Save();

            //x.GetSaveAsFilename("C:\\Users\\ECP\\Documents\\MATERIAS_ASIGNADAS.xlsx");
            cargarSemestres(PARALELO_MATERIA_PROFESOR, ComboxSemestres);
            PARALELO_MATERIA_PROFESOR.Quit();
            // PARALELO_MATERIA_PROFESOR.ThisWorkbook(1);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void ActivarDesactivarBotones(bool val)
        {
            tBapellido1.Enabled = val;
            tBapellido2.Enabled = val;
            tBcBoxCargaUniversitaria.Enabled = val;
            tBcBoxDedicacion.Enabled = val;
            tBcBoxEspecificidad.Enabled = val;
            tBcboxMayorNivel.Enabled = val;
            tBCorreoElectronico.Enabled = val;
            tBfechaDeNacimiento.Enabled = val;
            tBlugarDeNacimiento.Enabled = val;
            tBnombre1.Enabled = val;
            tBnombre2.Enabled = val;
            tBotrosTitulosCN.Enabled = val;
            tBregistroSenescytCN.Enabled = val;
            tBregistroSenescytOtrosTCN.Enabled = val;
            tBregistroSenescytTN.Enabled = val;
            tBtelefono.Enabled = val;
            tBtituloCuartoNivel.Enabled = val;
            tBtituloTercerNivel.Enabled = val;
        }

        private void LimpiarTextos()
        {
            tBapellido1.Text = "";
            tBapellido2.Text = "";
            tBcBoxCargaUniversitaria.Text = "";
            tBcBoxDedicacion.Text = "";
            tBcBoxEspecificidad.Text = "";
            tBcboxMayorNivel.Text = "";
            tBCorreoElectronico.Text = "";
            tBfechaDeNacimiento.Text = "";
            tBlugarDeNacimiento.Text = "";
            tBnombre1.Text = "";
            tBnombre2.Text = "";
            tBotrosTitulosCN.Text = "";
            tBregistroSenescytCN.Text = "";
            tBregistroSenescytOtrosTCN.Text = "";
            tBregistroSenescytTN.Text = "";
            tBtelefono.Text = "";
            tBtituloCuartoNivel.Text = "";
            tBtituloTercerNivel.Text = "";
        }


        private void Materias_Creditos_Semestre(int semes)
        {
            if (semes == 1) {
                
            }
            if (semes == 1)
            {

            }
            if (semes == 1)
            {

            }
        }

        private void bVERIFICAR_Click(object sender, EventArgs e)
        {
            
         

            


            if (VerificarAccesoProfesor(tBcedula.Text)==1 )
            {
                if (tBcedula.Text != "")
                {
                    MessageBox.Show("Ingrese la Informacion del nuevo profesor ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTextos();
                    ActivarDesactivarBotones(true);
                    bRegistrarProf.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ingrese una identificacion válida ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else {
                MessageBox.Show("El profesor ya se encuentra registrado ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ActivarDesactivarBotones(false);
            }
        }


    
    }




}






