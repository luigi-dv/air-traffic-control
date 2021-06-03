
namespace FormPrincipal
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.userNameLoginInput = new System.Windows.Forms.TextBox();
            this.userNameLoginLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pswLoginInput = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxShowPsw = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guestLink = new System.Windows.Forms.LinkLabel();
            this.helpLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLoginInput
            // 
            this.userNameLoginInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userNameLoginInput.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.userNameLoginInput, "userNameLoginInput");
            this.userNameLoginInput.Name = "userNameLoginInput";
            // 
            // userNameLoginLabel
            // 
            resources.ApplyResources(this.userNameLoginLabel, "userNameLoginLabel");
            this.userNameLoginLabel.ForeColor = System.Drawing.Color.Black;
            this.userNameLoginLabel.Name = "userNameLoginLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // pswLoginInput
            // 
            this.pswLoginInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pswLoginInput.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pswLoginInput, "pswLoginInput");
            this.pswLoginInput.Name = "pswLoginInput";
            this.pswLoginInput.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(174)))), ((int)(((byte)(79)))));
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // loginLabel
            // 
            resources.ApplyResources(this.loginLabel, "loginLabel");
            this.loginLabel.ForeColor = System.Drawing.Color.Black;
            this.loginLabel.Name = "loginLabel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxShowPsw
            // 
            resources.ApplyResources(this.checkBoxShowPsw, "checkBoxShowPsw");
            this.checkBoxShowPsw.Name = "checkBoxShowPsw";
            this.checkBoxShowPsw.UseVisualStyleBackColor = true;
            this.checkBoxShowPsw.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.helpLinkLabel);
            this.Controls.Add(this.guestLink);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBoxShowPsw);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pswLoginInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameLoginLabel);
            this.Controls.Add(this.userNameLoginInput);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameLoginInput;
        private System.Windows.Forms.Label userNameLoginLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pswLoginInput;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxShowPsw;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel guestLink;
        private System.Windows.Forms.LinkLabel helpLinkLabel;
    }
}