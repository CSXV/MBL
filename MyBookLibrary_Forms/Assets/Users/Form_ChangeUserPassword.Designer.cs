namespace MyBookLibrary_Forms.Assets.Users {
  partial class Form_ChangeUserPassword {
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
      this.lbUserID = new System.Windows.Forms.Label();
      this.lbID = new System.Windows.Forms.Label();
      this.lbUserName = new System.Windows.Forms.Label();
      this.lbName = new System.Windows.Forms.Label();
      this.cntrl_ChangeUserPassword1 = new MyBookLibrary_Forms.Assets.Users.cntrl_ChangeUserPassword();
      this.SuspendLayout();
      // 
      // lbUserID
      // 
      this.lbUserID.AutoSize = true;
      this.lbUserID.Location = new System.Drawing.Point(19, 15);
      this.lbUserID.Name = "lbUserID";
      this.lbUserID.Size = new System.Drawing.Size(81, 27);
      this.lbUserID.TabIndex = 1;
      this.lbUserID.Text = "User ID";
      // 
      // lbID
      // 
      this.lbID.AutoSize = true;
      this.lbID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Italic);
      this.lbID.Location = new System.Drawing.Point(225, 15);
      this.lbID.Name = "lbID";
      this.lbID.Size = new System.Drawing.Size(50, 27);
      this.lbID.TabIndex = 2;
      this.lbID.Text = "N/A";
      // 
      // lbUserName
      // 
      this.lbUserName.AutoSize = true;
      this.lbUserName.Location = new System.Drawing.Point(19, 54);
      this.lbUserName.Name = "lbUserName";
      this.lbUserName.Size = new System.Drawing.Size(120, 27);
      this.lbUserName.TabIndex = 1;
      this.lbUserName.Text = "User Name";
      // 
      // lbName
      // 
      this.lbName.AutoSize = true;
      this.lbName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Italic);
      this.lbName.Location = new System.Drawing.Point(225, 54);
      this.lbName.Name = "lbName";
      this.lbName.Size = new System.Drawing.Size(50, 27);
      this.lbName.TabIndex = 2;
      this.lbName.Text = "N/A";
      // 
      // cntrl_ChangeUserPassword1
      // 
      this.cntrl_ChangeUserPassword1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(22)))));
      this.cntrl_ChangeUserPassword1.Font = new System.Drawing.Font("Roboto", 16F);
      this.cntrl_ChangeUserPassword1.Location = new System.Drawing.Point(15, 93);
      this.cntrl_ChangeUserPassword1.Margin = new System.Windows.Forms.Padding(6);
      this.cntrl_ChangeUserPassword1.Name = "cntrl_ChangeUserPassword1";
      this.cntrl_ChangeUserPassword1.Size = new System.Drawing.Size(484, 175);
      this.cntrl_ChangeUserPassword1.TabIndex = 0;
      // 
      // Form_ChangeUserPassword
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(500, 276);
      this.Controls.Add(this.lbName);
      this.Controls.Add(this.lbID);
      this.Controls.Add(this.lbUserName);
      this.Controls.Add(this.lbUserID);
      this.Controls.Add(this.cntrl_ChangeUserPassword1);
      this.Font = new System.Drawing.Font("Roboto", 16F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Form_ChangeUserPassword";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Change User Password";
      this.Load += new System.EventHandler(this.Form_ChangeUserPassword_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private cntrl_ChangeUserPassword cntrl_ChangeUserPassword1;
    private System.Windows.Forms.Label lbUserID;
    private System.Windows.Forms.Label lbID;
    private System.Windows.Forms.Label lbUserName;
    private System.Windows.Forms.Label lbName;
  }
}