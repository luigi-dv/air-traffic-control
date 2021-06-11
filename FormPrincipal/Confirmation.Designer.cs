
namespace FormPrincipal
{
    partial class Confirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmation));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmationCodeInput = new System.Windows.Forms.TextBox();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.helpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.emailConfirmationSend = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(70, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de confirmación";
            // 
            // confirmationCodeInput
            // 
            this.confirmationCodeInput.Location = new System.Drawing.Point(29, 211);
            this.confirmationCodeInput.Name = "confirmationCodeInput";
            this.confirmationCodeInput.Size = new System.Drawing.Size(207, 20);
            this.confirmationCodeInput.TabIndex = 3;
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(174)))), ((int)(((byte)(79)))));
            this.btnSendCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSendCode.Location = new System.Drawing.Point(29, 252);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(207, 32);
            this.btnSendCode.TabIndex = 7;
            this.btnSendCode.Text = "Confirmar Email";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // helpLinkLabel
            // 
            this.helpLinkLabel.AutoSize = true;
            this.helpLinkLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.helpLinkLabel.Location = new System.Drawing.Point(199, 428);
            this.helpLinkLabel.Name = "helpLinkLabel";
            this.helpLinkLabel.Size = new System.Drawing.Size(37, 13);
            this.helpLinkLabel.TabIndex = 21;
            this.helpLinkLabel.TabStop = true;
            this.helpLinkLabel.Text = "Ayuda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "* Le hemos enviado un mensaje \r\nde confirmación a su email:\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailConfirmationSend
            // 
            this.emailConfirmationSend.AutoSize = true;
            this.emailConfirmationSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailConfirmationSend.Location = new System.Drawing.Point(67, 338);
            this.emailConfirmationSend.Name = "emailConfirmationSend";
            this.emailConfirmationSend.Size = new System.Drawing.Size(39, 13);
            this.emailConfirmationSend.TabIndex = 23;
            this.emailConfirmationSend.Text = "EMAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Por favor introduzca el código que ha \r\nrecibido, en la casilla de abajo.\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(256, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailConfirmationSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.helpLinkLabel);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.confirmationCodeInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Confirmation";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Confirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmationCodeInput;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.LinkLabel helpLinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label emailConfirmationSend;
        private System.Windows.Forms.Label label3;
    }
}