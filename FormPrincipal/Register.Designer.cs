
namespace FormPrincipal
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registerLabel = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.checkBoxShowPsw = new System.Windows.Forms.CheckBox();
            this.pswRegisterInput = new System.Windows.Forms.TextBox();
            this.pswLabel = new System.Windows.Forms.Label();
            this.userNameLoginLabel = new System.Windows.Forms.Label();
            this.userNameRegisterInput = new System.Windows.Forms.TextBox();
            this.pswConfirmRegisterInput = new System.Windows.Forms.TextBox();
            this.pswConfirmLabel = new System.Windows.Forms.Label();
            this.emailRegisterLabel = new System.Windows.Forms.Label();
            this.emailRegisterInput = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guestLink = new System.Windows.Forms.LinkLabel();
            this.helpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.errorAlertPanel = new System.Windows.Forms.Panel();
            this.errorAlertLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.errorAlertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // registerLabel
            // 
            resources.ApplyResources(this.registerLabel, "registerLabel");
            this.registerLabel.Name = "registerLabel";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(174)))), ((int)(((byte)(79)))));
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // checkBoxShowPsw
            // 
            resources.ApplyResources(this.checkBoxShowPsw, "checkBoxShowPsw");
            this.checkBoxShowPsw.Name = "checkBoxShowPsw";
            this.checkBoxShowPsw.UseVisualStyleBackColor = true;
            this.checkBoxShowPsw.CheckedChanged += new System.EventHandler(this.checkBoxShowPsw_CheckedChanged);
            // 
            // pswRegisterInput
            // 
            this.pswRegisterInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pswRegisterInput.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pswRegisterInput, "pswRegisterInput");
            this.pswRegisterInput.Name = "pswRegisterInput";
            this.pswRegisterInput.UseSystemPasswordChar = true;
            // 
            // pswLabel
            // 
            resources.ApplyResources(this.pswLabel, "pswLabel");
            this.pswLabel.ForeColor = System.Drawing.Color.Black;
            this.pswLabel.Name = "pswLabel";
            // 
            // userNameLoginLabel
            // 
            resources.ApplyResources(this.userNameLoginLabel, "userNameLoginLabel");
            this.userNameLoginLabel.ForeColor = System.Drawing.Color.Black;
            this.userNameLoginLabel.Name = "userNameLoginLabel";
            // 
            // userNameRegisterInput
            // 
            this.userNameRegisterInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userNameRegisterInput.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.userNameRegisterInput, "userNameRegisterInput");
            this.userNameRegisterInput.Name = "userNameRegisterInput";
            // 
            // pswConfirmRegisterInput
            // 
            this.pswConfirmRegisterInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pswConfirmRegisterInput.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pswConfirmRegisterInput, "pswConfirmRegisterInput");
            this.pswConfirmRegisterInput.Name = "pswConfirmRegisterInput";
            this.pswConfirmRegisterInput.UseSystemPasswordChar = true;
            // 
            // pswConfirmLabel
            // 
            resources.ApplyResources(this.pswConfirmLabel, "pswConfirmLabel");
            this.pswConfirmLabel.ForeColor = System.Drawing.Color.Black;
            this.pswConfirmLabel.Name = "pswConfirmLabel";
            // 
            // emailRegisterLabel
            // 
            resources.ApplyResources(this.emailRegisterLabel, "emailRegisterLabel");
            this.emailRegisterLabel.ForeColor = System.Drawing.Color.Black;
            this.emailRegisterLabel.Name = "emailRegisterLabel";
            // 
            // emailRegisterInput
            // 
            this.emailRegisterInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailRegisterInput.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.emailRegisterInput, "emailRegisterInput");
            this.emailRegisterInput.Name = "emailRegisterInput";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // guestLink
            // 
            resources.ApplyResources(this.guestLink, "guestLink");
            this.guestLink.Name = "guestLink";
            this.guestLink.TabStop = true;
            this.guestLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.guestLink_LinkClicked);
            // 
            // helpLinkLabel
            // 
            resources.ApplyResources(this.helpLinkLabel, "helpLinkLabel");
            this.helpLinkLabel.Name = "helpLinkLabel";
            this.helpLinkLabel.TabStop = true;
            this.helpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helpLinkLabel_LinkClicked);
            // 
            // errorAlertPanel
            // 
            this.errorAlertPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.errorAlertPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorAlertPanel.Controls.Add(this.errorAlertLabel);
            resources.ApplyResources(this.errorAlertPanel, "errorAlertPanel");
            this.errorAlertPanel.Name = "errorAlertPanel";
            // 
            // errorAlertLabel
            // 
            resources.ApplyResources(this.errorAlertLabel, "errorAlertLabel");
            this.errorAlertLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorAlertLabel.Name = "errorAlertLabel";
            // 
            // Register
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.errorAlertPanel);
            this.Controls.Add(this.helpLinkLabel);
            this.Controls.Add(this.guestLink);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.emailRegisterLabel);
            this.Controls.Add(this.emailRegisterInput);
            this.Controls.Add(this.pswConfirmRegisterInput);
            this.Controls.Add(this.pswConfirmLabel);
            this.Controls.Add(this.checkBoxShowPsw);
            this.Controls.Add(this.pswRegisterInput);
            this.Controls.Add(this.pswLabel);
            this.Controls.Add(this.userNameLoginLabel);
            this.Controls.Add(this.userNameRegisterInput);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.errorAlertPanel.ResumeLayout(false);
            this.errorAlertPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox checkBoxShowPsw;
        private System.Windows.Forms.TextBox pswRegisterInput;
        private System.Windows.Forms.Label pswLabel;
        private System.Windows.Forms.Label userNameLoginLabel;
        private System.Windows.Forms.TextBox userNameRegisterInput;
        private System.Windows.Forms.TextBox pswConfirmRegisterInput;
        private System.Windows.Forms.Label pswConfirmLabel;
        private System.Windows.Forms.Label emailRegisterLabel;
        private System.Windows.Forms.TextBox emailRegisterInput;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel guestLink;
        private System.Windows.Forms.LinkLabel helpLinkLabel;
        private System.Windows.Forms.Panel errorAlertPanel;
        private System.Windows.Forms.Label errorAlertLabel;
    }
}