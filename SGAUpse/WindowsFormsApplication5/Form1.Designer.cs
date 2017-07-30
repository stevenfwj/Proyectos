namespace WindowsFormsApplication5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lHaOlvidadoSuClave = new System.Windows.Forms.LinkLabel();
            this.lSolicitarAcceso = new System.Windows.Forms.LinkLabel();
            this.lAyuda = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.tClave = new System.Windows.Forms.TextBox();
            this.bIngresar = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lClave = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bRecNext = new System.Windows.Forms.Button();
            this.tRecRespuestaPrg = new System.Windows.Forms.TextBox();
            this.lRecPregunta = new System.Windows.Forms.Label();
            this.bRecOk = new System.Windows.Forms.Button();
            this.bRecPreguntas = new System.Windows.Forms.Button();
            this.tRecUser = new System.Windows.Forms.TextBox();
            this.lRecUser = new System.Windows.Forms.Label();
            this.bRecCedula = new System.Windows.Forms.Button();
            this.tRecCed = new System.Windows.Forms.TextBox();
            this.lRecCed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.tNewConfimClave = new System.Windows.Forms.TextBox();
            this.lNewConfirmarClave = new System.Windows.Forms.Label();
            this.tNewClave = new System.Windows.Forms.TextBox();
            this.lNewClave = new System.Windows.Forms.Label();
            this.loginDataSet = new WindowsFormsApplication5.loginDataSet();
            this.accesosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accesosTableAdapter = new WindowsFormsApplication5.loginDataSetTableAdapters.AccesosTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication5.loginDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accesosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "FACULTAD DE CIENCIAS DE LA INGENIERIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "UPSE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(61, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "SISTEMA DE GESTIÓN ACADEMICA";
            // 
            // lHaOlvidadoSuClave
            // 
            this.lHaOlvidadoSuClave.AutoSize = true;
            this.lHaOlvidadoSuClave.Location = new System.Drawing.Point(225, 131);
            this.lHaOlvidadoSuClave.Name = "lHaOlvidadoSuClave";
            this.lHaOlvidadoSuClave.Size = new System.Drawing.Size(185, 13);
            this.lHaOlvidadoSuClave.TabIndex = 9;
            this.lHaOlvidadoSuClave.TabStop = true;
            this.lHaOlvidadoSuClave.Text = "¿Ha olvidado su usuario/contraseña?";
            this.lHaOlvidadoSuClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lSolicitarAcceso
            // 
            this.lSolicitarAcceso.AutoSize = true;
            this.lSolicitarAcceso.Location = new System.Drawing.Point(226, 145);
            this.lSolicitarAcceso.Name = "lSolicitarAcceso";
            this.lSolicitarAcceso.Size = new System.Drawing.Size(82, 13);
            this.lSolicitarAcceso.TabIndex = 10;
            this.lSolicitarAcceso.TabStop = true;
            this.lSolicitarAcceso.Text = "Solicitar acceso";
            this.lSolicitarAcceso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lAyuda
            // 
            this.lAyuda.AutoSize = true;
            this.lAyuda.Location = new System.Drawing.Point(225, 160);
            this.lAyuda.Name = "lAyuda";
            this.lAyuda.Size = new System.Drawing.Size(37, 13);
            this.lAyuda.TabIndex = 11;
            this.lAyuda.TabStop = true;
            this.lAyuda.Text = "Ayuda";
            this.lAyuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lAyuda_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 52);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(140, 22);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(178, 20);
            this.tUsuario.TabIndex = 0;
            // 
            // tClave
            // 
            this.tClave.Location = new System.Drawing.Point(140, 48);
            this.tClave.Name = "tClave";
            this.tClave.Size = new System.Drawing.Size(178, 20);
            this.tClave.TabIndex = 1;
            this.tClave.UseSystemPasswordChar = true;
            // 
            // bIngresar
            // 
            this.bIngresar.Location = new System.Drawing.Point(140, 83);
            this.bIngresar.Name = "bIngresar";
            this.bIngresar.Size = new System.Drawing.Size(75, 23);
            this.bIngresar.TabIndex = 2;
            this.bIngresar.Text = "INGRESAR";
            this.bIngresar.UseVisualStyleBackColor = true;
            this.bIngresar.Click += new System.EventHandler(this.bIngresar_Click);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(243, 83);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 3;
            this.bSalir.Text = "SALIR";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Location = new System.Drawing.Point(62, 25);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(46, 13);
            this.lUsuario.TabIndex = 4;
            this.lUsuario.Text = "Usuario:";
            // 
            // lClave
            // 
            this.lClave.AutoSize = true;
            this.lClave.Location = new System.Drawing.Point(62, 51);
            this.lClave.Name = "lClave";
            this.lClave.Size = new System.Drawing.Size(37, 13);
            this.lClave.TabIndex = 5;
            this.lClave.Text = "Clave:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.lAyuda);
            this.panel1.Controls.Add(this.lSolicitarAcceso);
            this.panel1.Controls.Add(this.lHaOlvidadoSuClave);
            this.panel1.Controls.Add(this.lClave);
            this.panel1.Controls.Add(this.lUsuario);
            this.panel1.Controls.Add(this.bSalir);
            this.panel1.Controls.Add(this.bIngresar);
            this.panel1.Controls.Add(this.tClave);
            this.panel1.Controls.Add(this.tUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 192);
            this.panel1.TabIndex = 14;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(225, 174);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Infromacion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bRecNext);
            this.panel2.Controls.Add(this.tRecRespuestaPrg);
            this.panel2.Controls.Add(this.lRecPregunta);
            this.panel2.Controls.Add(this.bRecOk);
            this.panel2.Controls.Add(this.bRecPreguntas);
            this.panel2.Controls.Add(this.tRecUser);
            this.panel2.Controls.Add(this.lRecUser);
            this.panel2.Controls.Add(this.bRecCedula);
            this.panel2.Controls.Add(this.tRecCed);
            this.panel2.Controls.Add(this.lRecCed);
            this.panel2.Location = new System.Drawing.Point(469, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 192);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bRecNext
            // 
            this.bRecNext.Location = new System.Drawing.Point(324, 107);
            this.bRecNext.Name = "bRecNext";
            this.bRecNext.Size = new System.Drawing.Size(75, 23);
            this.bRecNext.TabIndex = 10;
            this.bRecNext.Text = "Siguiente";
            this.bRecNext.UseVisualStyleBackColor = true;
            this.bRecNext.Visible = false;
            this.bRecNext.Click += new System.EventHandler(this.bRecNext_Click);
            // 
            // tRecRespuestaPrg
            // 
            this.tRecRespuestaPrg.Location = new System.Drawing.Point(12, 109);
            this.tRecRespuestaPrg.Name = "tRecRespuestaPrg";
            this.tRecRespuestaPrg.Size = new System.Drawing.Size(299, 20);
            this.tRecRespuestaPrg.TabIndex = 9;
            this.tRecRespuestaPrg.Visible = false;
            // 
            // lRecPregunta
            // 
            this.lRecPregunta.AutoSize = true;
            this.lRecPregunta.Location = new System.Drawing.Point(9, 93);
            this.lRecPregunta.Name = "lRecPregunta";
            this.lRecPregunta.Size = new System.Drawing.Size(46, 13);
            this.lRecPregunta.TabIndex = 8;
            this.lRecPregunta.Text = "Usuario:";
            this.lRecPregunta.Visible = false;
            // 
            // bRecOk
            // 
            this.bRecOk.Location = new System.Drawing.Point(324, 155);
            this.bRecOk.Name = "bRecOk";
            this.bRecOk.Size = new System.Drawing.Size(75, 23);
            this.bRecOk.TabIndex = 7;
            this.bRecOk.Text = "OK";
            this.bRecOk.UseVisualStyleBackColor = true;
            this.bRecOk.Click += new System.EventHandler(this.bRecOk_Click);
            // 
            // bRecPreguntas
            // 
            this.bRecPreguntas.Location = new System.Drawing.Point(200, 49);
            this.bRecPreguntas.Name = "bRecPreguntas";
            this.bRecPreguntas.Size = new System.Drawing.Size(108, 23);
            this.bRecPreguntas.TabIndex = 5;
            this.bRecPreguntas.Text = "Recuperar Clave";
            this.bRecPreguntas.UseVisualStyleBackColor = true;
            this.bRecPreguntas.Click += new System.EventHandler(this.button2_Click);
            // 
            // tRecUser
            // 
            this.tRecUser.Enabled = false;
            this.tRecUser.Location = new System.Drawing.Point(61, 48);
            this.tRecUser.Name = "tRecUser";
            this.tRecUser.Size = new System.Drawing.Size(121, 20);
            this.tRecUser.TabIndex = 4;
            // 
            // lRecUser
            // 
            this.lRecUser.AutoSize = true;
            this.lRecUser.Location = new System.Drawing.Point(9, 51);
            this.lRecUser.Name = "lRecUser";
            this.lRecUser.Size = new System.Drawing.Size(46, 13);
            this.lRecUser.TabIndex = 3;
            this.lRecUser.Text = "Usuario:";
            // 
            // bRecCedula
            // 
            this.bRecCedula.Location = new System.Drawing.Point(200, 18);
            this.bRecCedula.Name = "bRecCedula";
            this.bRecCedula.Size = new System.Drawing.Size(108, 23);
            this.bRecCedula.TabIndex = 2;
            this.bRecCedula.Text = "Validar";
            this.bRecCedula.UseVisualStyleBackColor = true;
            this.bRecCedula.Click += new System.EventHandler(this.button1_Click);
            // 
            // tRecCed
            // 
            this.tRecCed.Location = new System.Drawing.Point(61, 20);
            this.tRecCed.Name = "tRecCed";
            this.tRecCed.Size = new System.Drawing.Size(121, 20);
            this.tRecCed.TabIndex = 1;
            // 
            // lRecCed
            // 
            this.lRecCed.AutoSize = true;
            this.lRecCed.Location = new System.Drawing.Point(9, 25);
            this.lRecCed.Name = "lRecCed";
            this.lRecCed.Size = new System.Drawing.Size(43, 13);
            this.lRecCed.TabIndex = 0;
            this.lRecCed.Text = "Cédula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(177, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "SIGA";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.tNewConfimClave);
            this.panel3.Controls.Add(this.lNewConfirmarClave);
            this.panel3.Controls.Add(this.tNewClave);
            this.panel3.Controls.Add(this.lNewClave);
            this.panel3.Location = new System.Drawing.Point(3, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 192);
            this.panel3.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Recuperar Clave";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tNewConfimClave
            // 
            this.tNewConfimClave.Location = new System.Drawing.Point(135, 48);
            this.tNewConfimClave.Name = "tNewConfimClave";
            this.tNewConfimClave.Size = new System.Drawing.Size(170, 20);
            this.tNewConfimClave.TabIndex = 4;
            this.tNewConfimClave.UseSystemPasswordChar = true;
            // 
            // lNewConfirmarClave
            // 
            this.lNewConfirmarClave.AutoSize = true;
            this.lNewConfirmarClave.Location = new System.Drawing.Point(9, 51);
            this.lNewConfirmarClave.Name = "lNewConfirmarClave";
            this.lNewConfirmarClave.Size = new System.Drawing.Size(111, 13);
            this.lNewConfirmarClave.TabIndex = 3;
            this.lNewConfirmarClave.Text = "Confirmar Contraseña:";
            // 
            // tNewClave
            // 
            this.tNewClave.Location = new System.Drawing.Point(135, 23);
            this.tNewClave.Name = "tNewClave";
            this.tNewClave.Size = new System.Drawing.Size(170, 20);
            this.tNewClave.TabIndex = 1;
            this.tNewClave.UseSystemPasswordChar = true;
            // 
            // lNewClave
            // 
            this.lNewClave.AutoSize = true;
            this.lNewClave.Location = new System.Drawing.Point(9, 25);
            this.lNewClave.Name = "lNewClave";
            this.lNewClave.Size = new System.Drawing.Size(99, 13);
            this.lNewClave.TabIndex = 0;
            this.lNewClave.Text = "Nueva Contraseña:";
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "loginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accesosBindingSource
            // 
            this.accesosBindingSource.DataMember = "Accesos";
            this.accesosBindingSource.DataSource = this.loginDataSet;
            // 
            // accesosTableAdapter
            // 
            this.accesosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccesosAutoTableAdapter = null;
            this.tableAdapterManager.AccesosTableAdapter = this.accesosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bTableAdapter = null;
            this.tableAdapterManager.cTableAdapter = null;
            this.tableAdapterManager.dTableAdapter = null;
            this.tableAdapterManager.eTableAdapter = null;
            this.tableAdapterManager.fTableAdapter = null;
            this.tableAdapterManager.gTableAdapter = null;
            this.tableAdapterManager.MateriasCreditosSemestreTableAdapter = null;
            this.tableAdapterManager.PreguntasGeneralesTableAdapter = null;
            this.tableAdapterManager.PreguntasSecretasTableAdapter = null;
            this.tableAdapterManager.ProfesoresRegistrados1TableAdapter = null;
            this.tableAdapterManager.ProfesoresRegistradosTableAdapter = null;
            this.tableAdapterManager.SemestresParalelosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication5.loginDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 569);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SISTEMA FCI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accesosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lHaOlvidadoSuClave;
        private System.Windows.Forms.LinkLabel lSolicitarAcceso;
        private System.Windows.Forms.LinkLabel lAyuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.TextBox tClave;
        private System.Windows.Forms.Button bIngresar;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lClave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tRecCed;
        private System.Windows.Forms.Label lRecCed;
        private System.Windows.Forms.Button bRecPreguntas;
        private System.Windows.Forms.TextBox tRecUser;
        private System.Windows.Forms.Label lRecUser;
        private System.Windows.Forms.Button bRecCedula;
        private System.Windows.Forms.Button bRecOk;
        private System.Windows.Forms.Button bRecNext;
        private System.Windows.Forms.TextBox tRecRespuestaPrg;
        private System.Windows.Forms.Label lRecPregunta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tNewConfimClave;
        private System.Windows.Forms.Label lNewConfirmarClave;
        private System.Windows.Forms.TextBox tNewClave;
        private System.Windows.Forms.Label lNewClave;
        private loginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource accesosBindingSource;
        private loginDataSetTableAdapters.AccesosTableAdapter accesosTableAdapter;
        private loginDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

