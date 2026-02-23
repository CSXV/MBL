namespace MyBookLibrary_Forms.Assets.Authors {
  partial class Form_AddUpdateAuthor {
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
      this.txFirstName = new System.Windows.Forms.TextBox();
      this.txPhoneNumber = new System.Windows.Forms.TextBox();
      this.txEmail = new System.Windows.Forms.TextBox();
      this.lbFirstName = new System.Windows.Forms.Label();
      this.lbPhoneNumber = new System.Windows.Forms.Label();
      this.lbEmail = new System.Windows.Forms.Label();
      this.lbLastName = new System.Windows.Forms.Label();
      this.txLastName = new System.Windows.Forms.TextBox();
      this.lbWebSite = new System.Windows.Forms.Label();
      this.txWebSite = new System.Windows.Forms.TextBox();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.lbAuthorID = new System.Windows.Forms.Label();
      this.lbID = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // txFirstName
      // 
      this.txFirstName.Font = new System.Drawing.Font("Roboto", 16F);
      this.txFirstName.Location = new System.Drawing.Point(189, 6);
      this.txFirstName.Name = "txFirstName";
      this.txFirstName.Size = new System.Drawing.Size(250, 33);
      this.txFirstName.TabIndex = 10;
      this.txFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txFirstName_Validating);
      // 
      // txPhoneNumber
      // 
      this.txPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F);
      this.txPhoneNumber.Location = new System.Drawing.Point(189, 84);
      this.txPhoneNumber.Name = "txPhoneNumber";
      this.txPhoneNumber.Size = new System.Drawing.Size(250, 33);
      this.txPhoneNumber.TabIndex = 30;
      // 
      // txEmail
      // 
      this.txEmail.Font = new System.Drawing.Font("Roboto", 16F);
      this.txEmail.Location = new System.Drawing.Point(189, 123);
      this.txEmail.Name = "txEmail";
      this.txEmail.Size = new System.Drawing.Size(250, 33);
      this.txEmail.TabIndex = 40;
      this.txEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txEmail_Validating);
      // 
      // lbFirstName
      // 
      this.lbFirstName.AutoSize = true;
      this.lbFirstName.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbFirstName.Location = new System.Drawing.Point(12, 9);
      this.lbFirstName.Name = "lbFirstName";
      this.lbFirstName.Size = new System.Drawing.Size(118, 27);
      this.lbFirstName.TabIndex = 31;
      this.lbFirstName.Text = "First Name";
      // 
      // lbPhoneNumber
      // 
      this.lbPhoneNumber.AutoSize = true;
      this.lbPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbPhoneNumber.Location = new System.Drawing.Point(12, 87);
      this.lbPhoneNumber.Name = "lbPhoneNumber";
      this.lbPhoneNumber.Size = new System.Drawing.Size(154, 27);
      this.lbPhoneNumber.TabIndex = 32;
      this.lbPhoneNumber.Text = "Phone number";
      // 
      // lbEmail
      // 
      this.lbEmail.AutoSize = true;
      this.lbEmail.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbEmail.Location = new System.Drawing.Point(12, 126);
      this.lbEmail.Name = "lbEmail";
      this.lbEmail.Size = new System.Drawing.Size(72, 27);
      this.lbEmail.TabIndex = 33;
      this.lbEmail.Text = "E-Mail";
      // 
      // lbLastName
      // 
      this.lbLastName.AutoSize = true;
      this.lbLastName.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbLastName.Location = new System.Drawing.Point(12, 48);
      this.lbLastName.Name = "lbLastName";
      this.lbLastName.Size = new System.Drawing.Size(118, 27);
      this.lbLastName.TabIndex = 31;
      this.lbLastName.Text = "Last Name";
      // 
      // txLastName
      // 
      this.txLastName.Font = new System.Drawing.Font("Roboto", 16F);
      this.txLastName.Location = new System.Drawing.Point(189, 45);
      this.txLastName.Name = "txLastName";
      this.txLastName.Size = new System.Drawing.Size(250, 33);
      this.txLastName.TabIndex = 20;
      this.txLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txLastName_Validating);
      // 
      // lbWebSite
      // 
      this.lbWebSite.AutoSize = true;
      this.lbWebSite.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbWebSite.Location = new System.Drawing.Point(12, 165);
      this.lbWebSite.Name = "lbWebSite";
      this.lbWebSite.Size = new System.Drawing.Size(91, 27);
      this.lbWebSite.TabIndex = 33;
      this.lbWebSite.Text = "Website";
      // 
      // txWebSite
      // 
      this.txWebSite.Font = new System.Drawing.Font("Roboto", 16F);
      this.txWebSite.Location = new System.Drawing.Point(189, 162);
      this.txWebSite.Name = "txWebSite";
      this.txWebSite.Size = new System.Drawing.Size(250, 33);
      this.txWebSite.TabIndex = 50;
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // lbAuthorID
      // 
      this.lbAuthorID.AutoSize = true;
      this.lbAuthorID.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbAuthorID.Location = new System.Drawing.Point(12, 201);
      this.lbAuthorID.Name = "lbAuthorID";
      this.lbAuthorID.Size = new System.Drawing.Size(32, 27);
      this.lbAuthorID.TabIndex = 33;
      this.lbAuthorID.Text = "ID";
      // 
      // lbID
      // 
      this.lbID.AutoSize = true;
      this.lbID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Italic);
      this.lbID.Location = new System.Drawing.Point(184, 201);
      this.lbID.Name = "lbID";
      this.lbID.Size = new System.Drawing.Size(50, 27);
      this.lbID.TabIndex = 33;
      this.lbID.Text = "N/A";
      // 
      // btnSave
      // 
      this.btnSave.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.check_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnSave.Location = new System.Drawing.Point(383, 201);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(56, 56);
      this.btnSave.TabIndex = 60;
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // Form_AddUpdateAuthor
      // 
      this.AcceptButton = this.btnSave;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(461, 269);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txLastName);
      this.Controls.Add(this.txFirstName);
      this.Controls.Add(this.txPhoneNumber);
      this.Controls.Add(this.txWebSite);
      this.Controls.Add(this.txEmail);
      this.Controls.Add(this.lbLastName);
      this.Controls.Add(this.lbFirstName);
      this.Controls.Add(this.lbID);
      this.Controls.Add(this.lbAuthorID);
      this.Controls.Add(this.lbWebSite);
      this.Controls.Add(this.lbPhoneNumber);
      this.Controls.Add(this.lbEmail);
      this.Font = new System.Drawing.Font("Roboto", 16F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Form_AddUpdateAuthor";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Add/Update Author";
      this.Load += new System.EventHandler(this.Form_AddUpdateAuthor_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txFirstName;
    private System.Windows.Forms.TextBox txPhoneNumber;
    private System.Windows.Forms.TextBox txEmail;
    private System.Windows.Forms.Label lbFirstName;
    private System.Windows.Forms.Label lbPhoneNumber;
    private System.Windows.Forms.Label lbEmail;
    private System.Windows.Forms.Label lbLastName;
    private System.Windows.Forms.TextBox txLastName;
    private System.Windows.Forms.Label lbWebSite;
    private System.Windows.Forms.TextBox txWebSite;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label lbID;
    private System.Windows.Forms.Label lbAuthorID;
  }
}