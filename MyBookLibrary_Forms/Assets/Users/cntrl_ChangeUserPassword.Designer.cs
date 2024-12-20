namespace MyBookLibrary_Forms.Assets.Users {
  partial class cntrl_ChangeUserPassword {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.lbCurrentPassword = new System.Windows.Forms.Label();
      this.lbConfirmPassword = new System.Windows.Forms.Label();
      this.lbNewPassword = new System.Windows.Forms.Label();
      this.txCurrentPassword = new System.Windows.Forms.TextBox();
      this.txConfirmPassword = new System.Windows.Forms.TextBox();
      this.txNewPassword = new System.Windows.Forms.TextBox();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.btnSave = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // lbCurrentPassword
      // 
      this.lbCurrentPassword.AutoSize = true;
      this.lbCurrentPassword.Location = new System.Drawing.Point(3, 3);
      this.lbCurrentPassword.Name = "lbCurrentPassword";
      this.lbCurrentPassword.Size = new System.Drawing.Size(185, 27);
      this.lbCurrentPassword.TabIndex = 0;
      this.lbCurrentPassword.Text = "Current Password";
      // 
      // lbConfirmPassword
      // 
      this.lbConfirmPassword.AutoSize = true;
      this.lbConfirmPassword.Location = new System.Drawing.Point(3, 81);
      this.lbConfirmPassword.Name = "lbConfirmPassword";
      this.lbConfirmPassword.Size = new System.Drawing.Size(191, 27);
      this.lbConfirmPassword.TabIndex = 0;
      this.lbConfirmPassword.Text = "Confirm Password";
      // 
      // lbNewPassword
      // 
      this.lbNewPassword.AutoSize = true;
      this.lbNewPassword.Location = new System.Drawing.Point(3, 42);
      this.lbNewPassword.Name = "lbNewPassword";
      this.lbNewPassword.Size = new System.Drawing.Size(159, 27);
      this.lbNewPassword.TabIndex = 0;
      this.lbNewPassword.Text = "New Password";
      // 
      // txCurrentPassword
      // 
      this.txCurrentPassword.Location = new System.Drawing.Point(210, 0);
      this.txCurrentPassword.Name = "txCurrentPassword";
      this.txCurrentPassword.Size = new System.Drawing.Size(250, 33);
      this.txCurrentPassword.TabIndex = 10;
      this.txCurrentPassword.UseSystemPasswordChar = true;
      this.txCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txCurrentPassword_Validating);
      // 
      // txConfirmPassword
      // 
      this.txConfirmPassword.Location = new System.Drawing.Point(210, 78);
      this.txConfirmPassword.Name = "txConfirmPassword";
      this.txConfirmPassword.Size = new System.Drawing.Size(250, 33);
      this.txConfirmPassword.TabIndex = 30;
      this.txConfirmPassword.UseSystemPasswordChar = true;
      this.txConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txConfirmPassword_Validating);
      // 
      // txNewPassword
      // 
      this.txNewPassword.Location = new System.Drawing.Point(210, 39);
      this.txNewPassword.Name = "txNewPassword";
      this.txNewPassword.Size = new System.Drawing.Size(250, 33);
      this.txNewPassword.TabIndex = 20;
      this.txNewPassword.UseSystemPasswordChar = true;
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // btnSave
      // 
      this.btnSave.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.check_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnSave.Location = new System.Drawing.Point(404, 117);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(56, 56);
      this.btnSave.TabIndex = 40;
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // cntrl_ChangeUserPassword
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txNewPassword);
      this.Controls.Add(this.txConfirmPassword);
      this.Controls.Add(this.txCurrentPassword);
      this.Controls.Add(this.lbNewPassword);
      this.Controls.Add(this.lbConfirmPassword);
      this.Controls.Add(this.lbCurrentPassword);
      this.Font = new System.Drawing.Font("Roboto", 16F);
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "cntrl_ChangeUserPassword";
      this.Size = new System.Drawing.Size(480, 177);
      this.Load += new System.EventHandler(this.cntrl_ChangeUserPassword_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbCurrentPassword;
    private System.Windows.Forms.Label lbConfirmPassword;
    private System.Windows.Forms.Label lbNewPassword;
    private System.Windows.Forms.TextBox txCurrentPassword;
    private System.Windows.Forms.TextBox txConfirmPassword;
    private System.Windows.Forms.TextBox txNewPassword;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.Button btnSave;
  }
}
