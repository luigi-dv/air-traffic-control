
namespace FormPrincipal
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.LoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFlightList = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadSector = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowFlights = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadFile,
            this.SaveFlightList,
            this.LoadSector,
            this.ShowFlights});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "MenuPrincipal";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // LoadFile
            // 
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(92, 20);
            this.LoadFile.Text = "Cargar Vuelos";
            // 
            // SaveFlightList
            // 
            this.SaveFlightList.Name = "SaveFlightList";
            this.SaveFlightList.Size = new System.Drawing.Size(99, 20);
            this.SaveFlightList.Text = "Guardar Vuelos";
            // 
            // LoadSector
            // 
            this.LoadSector.Name = "LoadSector";
            this.LoadSector.Size = new System.Drawing.Size(90, 20);
            this.LoadSector.Text = "Cargar Sector";
            // 
            // ShowFlights
            // 
            this.ShowFlights.Name = "ShowFlights";
            this.ShowFlights.Size = new System.Drawing.Size(98, 20);
            this.ShowFlights.Text = "Mostrar Vuelos";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem LoadFile;
        private System.Windows.Forms.ToolStripMenuItem SaveFlightList;
        private System.Windows.Forms.ToolStripMenuItem LoadSector;
        private System.Windows.Forms.ToolStripMenuItem ShowFlights;
    }
}

