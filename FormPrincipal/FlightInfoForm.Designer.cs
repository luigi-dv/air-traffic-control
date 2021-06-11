
namespace FormPrincipal
{
    partial class FlightInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightInfoForm));
            this.flightPictureBox = new System.Windows.Forms.PictureBox();
            this.flightIDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flightID2Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flightProgress = new System.Windows.Forms.ProgressBar();
            this.flightCompanyLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flightOriginLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flightPositionLabel = new System.Windows.Forms.Label();
            this.flightDestinationLabel = new System.Windows.Forms.Label();
            this.flightCompanyEmailLabel = new System.Windows.Forms.Label();
            this.flightCompanyPhoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flightPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flightPictureBox
            // 
            this.flightPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flightPictureBox.Location = new System.Drawing.Point(33, 93);
            this.flightPictureBox.Name = "flightPictureBox";
            this.flightPictureBox.Size = new System.Drawing.Size(241, 122);
            this.flightPictureBox.TabIndex = 0;
            this.flightPictureBox.TabStop = false;
            // 
            // flightIDLabel
            // 
            this.flightIDLabel.AutoSize = true;
            this.flightIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.flightIDLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(192)))), ((int)(((byte)(35)))));
            this.flightIDLabel.Location = new System.Drawing.Point(103, 6);
            this.flightIDLabel.Name = "flightIDLabel";
            this.flightIDLabel.Size = new System.Drawing.Size(95, 34);
            this.flightIDLabel.TabIndex = 1;
            this.flightIDLabel.Text = "BIG ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de vuelo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.flightIDLabel);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 52);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(-2, 545);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 52);
            this.panel2.TabIndex = 4;
            // 
            // flightID2Label
            // 
            this.flightID2Label.AutoSize = true;
            this.flightID2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightID2Label.Location = new System.Drawing.Point(35, 260);
            this.flightID2Label.Name = "flightID2Label";
            this.flightID2Label.Size = new System.Drawing.Size(23, 16);
            this.flightID2Label.TabIndex = 5;
            this.flightID2Label.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Información Compañia";
            // 
            // flightProgress
            // 
            this.flightProgress.Location = new System.Drawing.Point(36, 503);
            this.flightProgress.Name = "flightProgress";
            this.flightProgress.Size = new System.Drawing.Size(238, 23);
            this.flightProgress.TabIndex = 7;
            // 
            // flightCompanyLabel
            // 
            this.flightCompanyLabel.AutoSize = true;
            this.flightCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightCompanyLabel.Location = new System.Drawing.Point(33, 309);
            this.flightCompanyLabel.Name = "flightCompanyLabel";
            this.flightCompanyLabel.Size = new System.Drawing.Size(73, 16);
            this.flightCompanyLabel.TabIndex = 8;
            this.flightCompanyLabel.Text = "Company";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Origen";
            // 
            // flightOriginLabel
            // 
            this.flightOriginLabel.AutoSize = true;
            this.flightOriginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightOriginLabel.Location = new System.Drawing.Point(36, 484);
            this.flightOriginLabel.Name = "flightOriginLabel";
            this.flightOriginLabel.Size = new System.Drawing.Size(32, 16);
            this.flightOriginLabel.TabIndex = 10;
            this.flightOriginLabel.Text = "(x,y)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Destino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Posición actual";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(35, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 2);
            this.label9.TabIndex = 13;
            // 
            // flightPositionLabel
            // 
            this.flightPositionLabel.AutoSize = true;
            this.flightPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightPositionLabel.Location = new System.Drawing.Point(36, 396);
            this.flightPositionLabel.Name = "flightPositionLabel";
            this.flightPositionLabel.Size = new System.Drawing.Size(37, 16);
            this.flightPositionLabel.TabIndex = 14;
            this.flightPositionLabel.Text = "(x,y)";
            // 
            // flightDestinationLabel
            // 
            this.flightDestinationLabel.AutoSize = true;
            this.flightDestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightDestinationLabel.Location = new System.Drawing.Point(211, 484);
            this.flightDestinationLabel.Name = "flightDestinationLabel";
            this.flightDestinationLabel.Size = new System.Drawing.Size(32, 16);
            this.flightDestinationLabel.TabIndex = 15;
            this.flightDestinationLabel.Text = "(x,y)";
            // 
            // flightCompanyEmailLabel
            // 
            this.flightCompanyEmailLabel.AutoSize = true;
            this.flightCompanyEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightCompanyEmailLabel.Location = new System.Drawing.Point(35, 336);
            this.flightCompanyEmailLabel.Name = "flightCompanyEmailLabel";
            this.flightCompanyEmailLabel.Size = new System.Drawing.Size(47, 16);
            this.flightCompanyEmailLabel.TabIndex = 16;
            this.flightCompanyEmailLabel.Text = "Email";
            // 
            // flightCompanyPhoneLabel
            // 
            this.flightCompanyPhoneLabel.AutoSize = true;
            this.flightCompanyPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightCompanyPhoneLabel.Location = new System.Drawing.Point(172, 309);
            this.flightCompanyPhoneLabel.Name = "flightCompanyPhoneLabel";
            this.flightCompanyPhoneLabel.Size = new System.Drawing.Size(52, 16);
            this.flightCompanyPhoneLabel.TabIndex = 17;
            this.flightCompanyPhoneLabel.Text = "Phone";
            // 
            // FlightInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(308, 595);
            this.Controls.Add(this.flightCompanyPhoneLabel);
            this.Controls.Add(this.flightCompanyEmailLabel);
            this.Controls.Add(this.flightDestinationLabel);
            this.Controls.Add(this.flightPositionLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flightOriginLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flightCompanyLabel);
            this.Controls.Add(this.flightProgress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flightID2Label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flightPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlightInfoForm";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flightPictureBox;
        private System.Windows.Forms.Label flightIDLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label flightID2Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar flightProgress;
        private System.Windows.Forms.Label flightCompanyLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label flightOriginLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label flightPositionLabel;
        private System.Windows.Forms.Label flightDestinationLabel;
        private System.Windows.Forms.Label flightCompanyEmailLabel;
        private System.Windows.Forms.Label flightCompanyPhoneLabel;
    }
}