namespace MyBookLibrary_Forms.Assets {
  partial class Form_Login {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
      this.lbTitle = new System.Windows.Forms.Label();
      this.txUser = new System.Windows.Forms.TextBox();
      this.lbUser = new System.Windows.Forms.Label();
      this.txPassword = new System.Windows.Forms.TextBox();
      this.lbPassword = new System.Windows.Forms.Label();
      this.btnLogin = new System.Windows.Forms.Button();
      this.ckRememberMe = new System.Windows.Forms.CheckBox();
      this.pbUser = new System.Windows.Forms.PictureBox();
      this.pbPassword = new System.Windows.Forms.PictureBox();
      this.pbPasswordRemove = new System.Windows.Forms.PictureBox();
      this.pbUserRemove = new System.Windows.Forms.PictureBox();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbPasswordRemove)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbUserRemove)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // lbTitle
      // 
      this.lbTitle.AutoSize = true;
      this.lbTitle.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold);
      this.lbTitle.Location = new System.Drawing.Point(199, 9);
      this.lbTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.lbTitle.Name = "lbTitle";
      this.lbTitle.Size = new System.Drawing.Size(388, 58);
      this.lbTitle.TabIndex = 0;
      this.lbTitle.Text = "Welcome aboard";
      // 
      // txUser
      // 
      this.txUser.Location = new System.Drawing.Point(262, 206);
      this.txUser.Name = "txUser";
      this.txUser.Size = new System.Drawing.Size(256, 33);
      this.txUser.TabIndex = 10;
      this.txUser.TextChanged += new System.EventHandler(this.txUser_TextChanged);
      this.txUser.Validating += new System.ComponentModel.CancelEventHandler(this.txUser_Validating);
      // 
      // lbUser
      // 
      this.lbUser.AutoSize = true;
      this.lbUser.Location = new System.Drawing.Point(147, 209);
      this.lbUser.Name = "lbUser";
      this.lbUser.Size = new System.Drawing.Size(56, 27);
      this.lbUser.TabIndex = 2;
      this.lbUser.Text = "User";
      // 
      // txPassword
      // 
      this.txPassword.Location = new System.Drawing.Point(262, 245);
      this.txPassword.Name = "txPassword";
      this.txPassword.Size = new System.Drawing.Size(256, 33);
      this.txPassword.TabIndex = 20;
      this.txPassword.UseSystemPasswordChar = true;
      this.txPassword.TextChanged += new System.EventHandler(this.txPassword_TextChanged);
      this.txPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txPassword_Validating);
      // 
      // lbPassword
      // 
      this.lbPassword.AutoSize = true;
      this.lbPassword.Location = new System.Drawing.Point(147, 248);
      this.lbPassword.Name = "lbPassword";
      this.lbPassword.Size = new System.Drawing.Size(109, 27);
      this.lbPassword.TabIndex = 2;
      this.lbPassword.Text = "Password";
      // 
      // btnLogin
      // 
      this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnLogin.Location = new System.Drawing.Point(262, 321);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(256, 43);
      this.btnLogin.TabIndex = 40;
      this.btnLogin.Text = "Login";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // ckRememberMe
      // 
      this.ckRememberMe.AutoSize = true;
      this.ckRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ckRememberMe.Location = new System.Drawing.Point(262, 284);
      this.ckRememberMe.Name = "ckRememberMe";
      this.ckRememberMe.Size = new System.Drawing.Size(174, 31);
      this.ckRememberMe.TabIndex = 30;
      this.ckRememberMe.Text = "Remember Me";
      this.ckRememberMe.UseVisualStyleBackColor = true;
      // 
      // pbUser
      // 
      this.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pbUser.Image = global::MyBookLibrary_Forms.Properties.Resources.account_circle_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.pbUser.Location = new System.Drawing.Point(117, 212);
      this.pbUser.Name = "pbUser";
      this.pbUser.Size = new System.Drawing.Size(24, 24);
      this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbUser.TabIndex = 4;
      this.pbUser.TabStop = false;
      // 
      // pbPassword
      // 
      this.pbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pbPassword.Image = global::MyBookLibrary_Forms.Properties.Resources.password_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.pbPassword.Location = new System.Drawing.Point(117, 251);
      this.pbPassword.Name = "pbPassword";
      this.pbPassword.Size = new System.Drawing.Size(24, 24);
      this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbPassword.TabIndex = 4;
      this.pbPassword.TabStop = false;
      // 
      // pbPasswordRemove
      // 
      this.pbPasswordRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPasswordRemove.BackgroundImage")));
      this.pbPasswordRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pbPasswordRemove.Cursor = System.Windows.Forms.Cursors.Hand;
      this.pbPasswordRemove.Location = new System.Drawing.Point(524, 248);
      this.pbPasswordRemove.Name = "pbPasswordRemove";
      this.pbPasswordRemove.Size = new System.Drawing.Size(24, 24);
      this.pbPasswordRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbPasswordRemove.TabIndex = 4;
      this.pbPasswordRemove.TabStop = false;
      this.pbPasswordRemove.Visible = false;
      this.pbPasswordRemove.Click += new System.EventHandler(this.pbPasswordRemove_Click);
      // 
      // pbUserRemove
      // 
      this.pbUserRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbUserRemove.BackgroundImage")));
      this.pbUserRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pbUserRemove.Cursor = System.Windows.Forms.Cursors.Hand;
      this.pbUserRemove.Location = new System.Drawing.Point(524, 209);
      this.pbUserRemove.Name = "pbUserRemove";
      this.pbUserRemove.Size = new System.Drawing.Size(24, 24);
      this.pbUserRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbUserRemove.TabIndex = 4;
      this.pbUserRemove.TabStop = false;
      this.pbUserRemove.Visible = false;
      this.pbUserRemove.Click += new System.EventHandler(this.pbUserRemove_Click);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // Form_Login
      // 
      this.AcceptButton = this.btnLogin;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(786, 497);
      this.Controls.Add(this.ckRememberMe);
      this.Controls.Add(this.pbUser);
      this.Controls.Add(this.pbPassword);
      this.Controls.Add(this.pbPasswordRemove);
      this.Controls.Add(this.pbUserRemove);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.lbPassword);
      this.Controls.Add(this.txPassword);
      this.Controls.Add(this.lbUser);
      this.Controls.Add(this.txUser);
      this.Controls.Add(this.lbTitle);
      this.Font = new System.Drawing.Font("Roboto", 16F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Form_Login";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.Load += new System.EventHandler(this.Form_Login_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbPasswordRemove)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbUserRemove)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbTitle;
    private System.Windows.Forms.TextBox txUser;
    private System.Windows.Forms.Label lbUser;
    private System.Windows.Forms.TextBox txPassword;
    private System.Windows.Forms.Label lbPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.PictureBox pbUserRemove;
    private System.Windows.Forms.CheckBox ckRememberMe;
    private System.Windows.Forms.PictureBox pbPasswordRemove;
    private System.Windows.Forms.PictureBox pbPassword;
    private System.Windows.Forms.PictureBox pbUser;
    private System.Windows.Forms.ErrorProvider errorProvider1;
  }
}