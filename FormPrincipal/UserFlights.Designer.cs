
namespace FormPrincipal
{
    partial class UserFlights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFlights));
            this.userFlightsInfoDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userFlightsInfoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // userFlightsInfoDGV
            // 
            this.userFlightsInfoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userFlightsInfoDGV.Location = new System.Drawing.Point(12, 12);
            this.userFlightsInfoDGV.Name = "userFlightsInfoDGV";
            this.userFlightsInfoDGV.Size = new System.Drawing.Size(776, 426);
            this.userFlightsInfoDGV.TabIndex = 0;
            // 
            // UserFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userFlightsInfoDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserFlights";
            this.Text = "Vuelos Almacenados";
            this.Load += new System.EventHandler(this.UserFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userFlightsInfoDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userFlightsInfoDGV;
    }
}