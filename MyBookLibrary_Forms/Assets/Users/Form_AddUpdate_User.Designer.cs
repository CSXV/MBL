namespace MyBookLibrary_Forms.Assets.Users {
  partial class Form_AddUpdate_User {
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
      this.lbUserName = new System.Windows.Forms.Label();
      this.tbUserName = new System.Windows.Forms.TextBox();
      this.ckIsActive = new System.Windows.Forms.CheckBox();
      this.lbUserID = new System.Windows.Forms.Label();
      this.lbID = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.lbPassword = new System.Windows.Forms.Label();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.tbConfirmPassword = new System.Windows.Forms.TextBox();
      this.lbConfirmPassword = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // lbUserName
      // 
      this.lbUserName.AutoSize = true;
      this.lbUserName.Location = new System.Drawing.Point(12, 10);
      this.lbUserName.Name = "lbUserName";
      this.lbUserName.Size = new System.Drawing.Size(120, 27);
      this.lbUserName.TabIndex = 0;
      this.lbUserName.Text = "User Name";
      // 
      // tbUserName
      // 
      this.tbUserName.Location = new System.Drawing.Point(209, 3);
      this.tbUserName.Name = "tbUserName";
      this.tbUserName.Size = new System.Drawing.Size(250, 33);
      this.tbUserName.TabIndex = 10;
      this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserName_Validating);
      // 
      // ckIsActive
      // 
      this.ckIsActive.AutoSize = true;
      this.ckIsActive.Location = new System.Drawing.Point(17, 121);
      this.ckIsActive.Name = "ckIsActive";
      this.ckIsActive.Size = new System.Drawing.Size(114, 31);
      this.ckIsActive.TabIndex = 40;
      this.ckIsActive.Text = "Is Active";
      this.ckIsActive.UseVisualStyleBackColor = true;
      // 
      // lbUserID
      // 
      this.lbUserID.AutoSize = true;
      this.lbUserID.Location = new System.Drawing.Point(12, 162);
      this.lbUserID.Name = "lbUserID";
      this.lbUserID.Size = new System.Drawing.Size(32, 27);
      this.lbUserID.TabIndex = 3;
      this.lbUserID.Text = "ID";
      // 
      // lbID
      // 
      this.lbID.AutoSize = true;
      this.lbID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Italic);
      this.lbID.Location = new System.Drawing.Point(204, 162);
      this.lbID.Name = "lbID";
      this.lbID.Size = new System.Drawing.Size(50, 27);
      this.lbID.TabIndex = 3;
      this.lbID.Text = "N/A";
      // 
      // btnSave
      // 
      this.btnSave.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.check_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnSave.Location = new System.Drawing.Point(403, 162);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(56, 56);
      this.btnSave.TabIndex = 50;
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // tbPassword
      // 
      this.tbPassword.Location = new System.Drawing.Point(209, 42);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.Size = new System.Drawing.Size(250, 33);
      this.tbPassword.TabIndex = 20;
      this.tbPassword.UseSystemPasswordChar = true;
      // 
      // lbPassword
      // 
      this.lbPassword.AutoSize = true;
      this.lbPassword.Location = new System.Drawing.Point(12, 45);
      this.lbPassword.Name = "lbPassword";
      this.lbPassword.Size = new System.Drawing.Size(109, 27);
      this.lbPassword.TabIndex = 0;
      this.lbPassword.Text = "Password";
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // tbConfirmPassword
      // 
      this.tbConfirmPassword.Location = new System.Drawing.Point(209, 81);
      this.tbConfirmPassword.Name = "tbConfirmPassword";
      this.tbConfirmPassword.Size = new System.Drawing.Size(250, 33);
      this.tbConfirmPassword.TabIndex = 30;
      this.tbConfirmPassword.UseSystemPasswordChar = true;
      this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
      // 
      // lbConfirmPassword
      // 
      this.lbConfirmPassword.AutoSize = true;
      this.lbConfirmPassword.Location = new System.Drawing.Point(12, 84);
      this.lbConfirmPassword.Name = "lbConfirmPassword";
      this.lbConfirmPassword.Size = new System.Drawing.Size(191, 27);
      this.lbConfirmPassword.TabIndex = 0;
      this.lbConfirmPassword.Text = "Confirm Password";
      // 
      // Form_AddUpdate_User
      // 
      this.AcceptButton = this.btnSave;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(480, 230);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.lbID);
      this.Controls.Add(this.lbUserID);
      this.Controls.Add(this.ckIsActive);
      this.Controls.Add(this.tbConfirmPassword);
      this.Controls.Add(this.tbPassword);
      this.Controls.Add(this.tbUserName);
      this.Controls.Add(this.lbConfirmPassword);
      this.Controls.Add(this.lbPassword);
      this.Controls.Add(this.lbUserName);
      this.Font = new System.Drawing.Font("Roboto", 16F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Form_AddUpdate_User";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Add/Update User";
      this.Load += new System.EventHandler(this.Form_AddUpdate_User_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbUserName;
    private System.Windows.Forms.TextBox tbUserName;
    private System.Windows.Forms.CheckBox ckIsActive;
    private System.Windows.Forms.Label lbUserID;
    private System.Windows.Forms.Label lbID;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox tbPassword;
    private System.Windows.Forms.Label lbPassword;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.TextBox tbConfirmPassword;
    private System.Windows.Forms.Label lbConfirmPassword;
  }
}