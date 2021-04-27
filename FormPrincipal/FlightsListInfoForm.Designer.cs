namespace FormPrincipal
{
    partial class FlightsListInfoForm
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
            this.sectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FlightListGrid = new System.Windows.Forms.DataGridView();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sectorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlightListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sectorBindingSource
            // 
            this.sectorBindingSource.DataSource = typeof(FlightsLib.Sector);
            // 
            // FlightListGrid
            // 
            this.FlightListGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlightListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightListGrid.Location = new System.Drawing.Point(12, 12);
            this.FlightListGrid.Name = "FlightListGrid";
            this.FlightListGrid.Size = new System.Drawing.Size(603, 406);
            this.FlightListGrid.TabIndex = 0;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(FormPrincipal.MainForm);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(FormPrincipal.MainForm);
            // 
            // FlightsListInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 430);
            this.Controls.Add(this.FlightListGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FlightsListInfoForm";
            this.Text = "Listado de Vuelos Activos";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sectorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlightListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sectorBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.DataGridView FlightListGrid;
    }
}