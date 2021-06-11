
namespace FormPrincipal
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.loadFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarSectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaDeVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aerolineasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.reiniciarSimulaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMisDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.funcionalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.totalFlightsLabel = new System.Windows.Forms.Label();
            this.cycleTimeLabel = new System.Windows.Forms.Label();
            this.cycleNumLabel = new System.Windows.Forms.Label();
            this.cycleTimeInput = new System.Windows.Forms.TextBox();
            this.cycleNumInput = new System.Windows.Forms.TextBox();
            this.StartSimulation = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sesionBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sectorsDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInMenu,
            this.toolStripSeparator5,
            this.loadFlightsToolStripMenuItem,
            this.cargarSectorToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileToolStripMenuItem.Text = "&Archivo";
            // 
            // logInMenu
            // 
            this.logInMenu.Name = "logInMenu";
            this.logInMenu.Size = new System.Drawing.Size(190, 22);
            this.logInMenu.Text = "Iniciar Sesión";
            this.logInMenu.Click += new System.EventHandler(this.logInMenu_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(187, 6);
            // 
            // loadFlightsToolStripMenuItem
            // 
            this.loadFlightsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadFlightsToolStripMenuItem.Name = "loadFlightsToolStripMenuItem";
            this.loadFlightsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadFlightsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.loadFlightsToolStripMenuItem.Text = "Cargar Vuelos";
            this.loadFlightsToolStripMenuItem.Click += new System.EventHandler(this.LoadFlightsToolStripMenuItem_Click);
            // 
            // cargarSectorToolStripMenuItem
            // 
            this.cargarSectorToolStripMenuItem.Name = "cargarSectorToolStripMenuItem";
            this.cargarSectorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cargarSectorToolStripMenuItem.Text = "Cargar Sectores";
            this.cargarSectorToolStripMenuItem.Click += new System.EventHandler(this.CargarSectorToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(187, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveToolStripMenuItem.Text = "&Guardar";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListaDeVuelosToolStripMenuItem,
            this.aerolineasToolStripMenuItem,
            this.toolStripSeparator3,
            this.reiniciarSimulaciónToolStripMenuItem,
            this.verMisDatosToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.toolsToolStripMenuItem.Text = "&Herramientas";
            // 
            // ListaDeVuelosToolStripMenuItem
            // 
            this.ListaDeVuelosToolStripMenuItem.Name = "ListaDeVuelosToolStripMenuItem";
            this.ListaDeVuelosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.ListaDeVuelosToolStripMenuItem.Text = "Lista de Vuelos Activos";
            this.ListaDeVuelosToolStripMenuItem.Click += new System.EventHandler(this.ListaDeVuelosToolStripMenuItem_Click);
            // 
            // aerolineasToolStripMenuItem
            // 
            this.aerolineasToolStripMenuItem.Name = "aerolineasToolStripMenuItem";
            this.aerolineasToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.aerolineasToolStripMenuItem.Text = "Aerolineas";
            this.aerolineasToolStripMenuItem.Click += new System.EventHandler(this.aerolineasToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(208, 6);
            // 
            // reiniciarSimulaciónToolStripMenuItem
            // 
            this.reiniciarSimulaciónToolStripMenuItem.Name = "reiniciarSimulaciónToolStripMenuItem";
            this.reiniciarSimulaciónToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.reiniciarSimulaciónToolStripMenuItem.Text = "Reiniciar Simulación";
            this.reiniciarSimulaciónToolStripMenuItem.Click += new System.EventHandler(this.reiniciarSimulaciónToolStripMenuItem_Click);
            // 
            // verMisDatosToolStripMenuItem
            // 
            this.verMisDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myVuelosToolStripMenuItem});
            this.verMisDatosToolStripMenuItem.Name = "verMisDatosToolStripMenuItem";
            this.verMisDatosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.verMisDatosToolStripMenuItem.Text = "Ver Simulaciones antiguas";
            // 
            // myVuelosToolStripMenuItem
            // 
            this.myVuelosToolStripMenuItem.Name = "myVuelosToolStripMenuItem";
            this.myVuelosToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.myVuelosToolStripMenuItem.Text = "Vuelos";
            this.myVuelosToolStripMenuItem.Click += new System.EventHandler(this.vuelosToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator4,
            this.funcionalidadesToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.helpToolStripMenuItem.Text = "&Más";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gitHubToolStripMenuItem.Text = "Repositorio Github";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.GitHubToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca del grupo";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // funcionalidadesToolStripMenuItem
            // 
            this.funcionalidadesToolStripMenuItem.Name = "funcionalidadesToolStripMenuItem";
            this.funcionalidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionalidadesToolStripMenuItem.Text = "Funcionalidades";
            this.funcionalidadesToolStripMenuItem.Click += new System.EventHandler(this.funcionalidadesToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(662, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total de Vuelos:";
            // 
            // totalFlightsLabel
            // 
            this.totalFlightsLabel.AutoSize = true;
            this.totalFlightsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFlightsLabel.ForeColor = System.Drawing.Color.Black;
            this.totalFlightsLabel.Location = new System.Drawing.Point(791, 198);
            this.totalFlightsLabel.Name = "totalFlightsLabel";
            this.totalFlightsLabel.Size = new System.Drawing.Size(0, 16);
            this.totalFlightsLabel.TabIndex = 3;
            // 
            // cycleTimeLabel
            // 
            this.cycleTimeLabel.AutoSize = true;
            this.cycleTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.cycleTimeLabel.Location = new System.Drawing.Point(662, 421);
            this.cycleTimeLabel.Name = "cycleTimeLabel";
            this.cycleTimeLabel.Size = new System.Drawing.Size(125, 20);
            this.cycleTimeLabel.TabIndex = 6;
            this.cycleTimeLabel.Text = "Tiempo de Ciclo:";
            // 
            // cycleNumLabel
            // 
            this.cycleNumLabel.AutoSize = true;
            this.cycleNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleNumLabel.ForeColor = System.Drawing.Color.Black;
            this.cycleNumLabel.Location = new System.Drawing.Point(662, 454);
            this.cycleNumLabel.Name = "cycleNumLabel";
            this.cycleNumLabel.Size = new System.Drawing.Size(137, 20);
            this.cycleNumLabel.TabIndex = 7;
            this.cycleNumLabel.Text = "Número de Ciclos:";
            // 
            // cycleTimeInput
            // 
            this.cycleTimeInput.ForeColor = System.Drawing.Color.Black;
            this.cycleTimeInput.Location = new System.Drawing.Point(814, 423);
            this.cycleTimeInput.Name = "cycleTimeInput";
            this.cycleTimeInput.Size = new System.Drawing.Size(100, 20);
            this.cycleTimeInput.TabIndex = 9;
            this.cycleTimeInput.TextChanged += new System.EventHandler(this.cycleTimeInput_TextChanged);
            // 
            // cycleNumInput
            // 
            this.cycleNumInput.ForeColor = System.Drawing.Color.Black;
            this.cycleNumInput.Location = new System.Drawing.Point(814, 454);
            this.cycleNumInput.Name = "cycleNumInput";
            this.cycleNumInput.Size = new System.Drawing.Size(100, 20);
            this.cycleNumInput.TabIndex = 10;
            // 
            // StartSimulation
            // 
            this.StartSimulation.BackColor = System.Drawing.Color.LightGreen;
            this.StartSimulation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartSimulation.Location = new System.Drawing.Point(806, 575);
            this.StartSimulation.Name = "StartSimulation";
            this.StartSimulation.Size = new System.Drawing.Size(112, 33);
            this.StartSimulation.TabIndex = 11;
            this.StartSimulation.Text = "Start";
            this.StartSimulation.UseVisualStyleBackColor = false;
            this.StartSimulation.Click += new System.EventHandler(this.StartSimulation_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.WindowText;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(656, 575);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 33);
            this.button4.TabIndex = 13;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Back_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(660, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 43);
            this.button3.TabIndex = 14;
            this.button3.Text = "Avanzar un ciclo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.AvanzarSimulacion_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_tick);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("STXihei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(649, 53);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(210, 35);
            this.welcomeLabel.TabIndex = 15;
            this.welcomeLabel.Text = "Proyecto G6";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.Black;
            this.userNameLabel.Location = new System.Drawing.Point(728, 103);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(101, 20);
            this.userNameLabel.TabIndex = 16;
            this.userNameLabel.Text = "USERNAME";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(662, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 10);
            this.label9.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(664, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 10);
            this.label5.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(660, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Usuario:";
            // 
            // sesionBtn
            // 
            this.sesionBtn.BackColor = System.Drawing.Color.DarkRed;
            this.sesionBtn.ForeColor = System.Drawing.Color.White;
            this.sesionBtn.Location = new System.Drawing.Point(664, 126);
            this.sesionBtn.Name = "sesionBtn";
            this.sesionBtn.Size = new System.Drawing.Size(110, 40);
            this.sesionBtn.TabIndex = 22;
            this.sesionBtn.Text = "Cerrar Sesión";
            this.sesionBtn.UseVisualStyleBackColor = false;
            this.sesionBtn.Click += new System.EventHandler(this.sesionBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(656, 552);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Simulación automática:";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(660, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 13);
            this.label6.TabIndex = 24;
            // 
            // sectorsDGV
            // 
            this.sectorsDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.sectorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sectorsDGV.Location = new System.Drawing.Point(662, 268);
            this.sectorsDGV.Name = "sectorsDGV";
            this.sectorsDGV.Size = new System.Drawing.Size(248, 131);
            this.sectorsDGV.TabIndex = 25;
            this.sectorsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sectorsDGV_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(658, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Sectores";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.CausesValidation = false;
            this.panel1.Location = new System.Drawing.Point(13, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 555);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(980, 666);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sectorsDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sesionBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.StartSimulation);
            this.Controls.Add(this.cycleNumInput);
            this.Controls.Add(this.cycleTimeInput);
            this.Controls.Add(this.cycleNumLabel);
            this.Controls.Add(this.cycleTimeLabel);
            this.Controls.Add(this.totalFlightsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Simulador de vuelo - G6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListaDeVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem cargarSectorToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalFlightsLabel;
        private System.Windows.Forms.Label cycleTimeLabel;
        private System.Windows.Forms.Label cycleNumLabel;
        private System.Windows.Forms.TextBox cycleTimeInput;
        private System.Windows.Forms.TextBox cycleNumInput;
        private System.Windows.Forms.Button StartSimulation;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem logInMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sesionBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem verMisDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem funcionalidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aerolineasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarSimulaciónToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView sectorsDGV;
        private System.Windows.Forms.Label label3;
    }
}