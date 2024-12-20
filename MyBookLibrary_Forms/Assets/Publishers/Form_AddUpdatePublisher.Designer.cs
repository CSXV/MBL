namespace MyBookLibrary_Forms.Assets.Publishers {
  partial class Form_AddUpdatePublisher {
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
      this.txWebSite = new System.Windows.Forms.TextBox();
      this.txEmail = new System.Windows.Forms.TextBox();
      this.lbFirstName = new System.Windows.Forms.Label();
      this.lbID = new System.Windows.Forms.Label();
      this.lbAuthorID = new System.Windows.Forms.Label();
      this.lbWebSite = new System.Windows.Forms.Label();
      this.lbPhoneNumber = new System.Windows.Forms.Label();
      this.lbEmail = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // txFirstName
      // 
      this.txFirstName.Font = new System.Drawing.Font("Roboto", 16F);
      this.txFirstName.Location = new System.Drawing.Point(189, 6);
      this.txFirstName.Name = "txFirstName";
      this.txFirstName.Size = new System.Drawing.Size(250, 33);
      this.txFirstName.TabIndex = 61;
      this.txFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txFirstName_Validating);
      // 
      // txPhoneNumber
      // 
      this.txPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F);
      this.txPhoneNumber.Location = new System.Drawing.Point(189, 45);
      this.txPhoneNumber.Name = "txPhoneNumber";
      this.txPhoneNumber.Size = new System.Drawing.Size(250, 33);
      this.txPhoneNumber.TabIndex = 63;
      // 
      // txWebSite
      // 
      this.txWebSite.Font = new System.Drawing.Font("Roboto", 16F);
      this.txWebSite.Location = new System.Drawing.Point(189, 123);
      this.txWebSite.Name = "txWebSite";
      this.txWebSite.Size = new System.Drawing.Size(250, 33);
      this.txWebSite.TabIndex = 72;
      // 
      // txEmail
      // 
      this.txEmail.Font = new System.Drawing.Font("Roboto", 16F);
      this.txEmail.Location = new System.Drawing.Point(189, 84);
      this.txEmail.Name = "txEmail";
      this.txEmail.Size = new System.Drawing.Size(250, 33);
      this.txEmail.TabIndex = 71;
      this.txEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txEmail_Validating);
      // 
      // lbFirstName
      // 
      this.lbFirstName.AutoSize = true;
      this.lbFirstName.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbFirstName.Location = new System.Drawing.Point(12, 9);
      this.lbFirstName.Name = "lbFirstName";
      this.lbFirstName.Size = new System.Drawing.Size(166, 27);
      this.lbFirstName.TabIndex = 65;
      this.lbFirstName.Text = "Publisher Name";
      // 
      // lbID
      // 
      this.lbID.AutoSize = true;
      this.lbID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Italic);
      this.lbID.Location = new System.Drawing.Point(184, 162);
      this.lbID.Name = "lbID";
      this.lbID.Size = new System.Drawing.Size(50, 27);
      this.lbID.TabIndex = 67;
      this.lbID.Text = "N/A";
      // 
      // lbAuthorID
      // 
      this.lbAuthorID.AutoSize = true;
      this.lbAuthorID.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbAuthorID.Location = new System.Drawing.Point(12, 162);
      this.lbAuthorID.Name = "lbAuthorID";
      this.lbAuthorID.Size = new System.Drawing.Size(32, 27);
      this.lbAuthorID.TabIndex = 68;
      this.lbAuthorID.Text = "ID";
      // 
      // lbWebSite
      // 
      this.lbWebSite.AutoSize = true;
      this.lbWebSite.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbWebSite.Location = new System.Drawing.Point(12, 126);
      this.lbWebSite.Name = "lbWebSite";
      this.lbWebSite.Size = new System.Drawing.Size(91, 27);
      this.lbWebSite.TabIndex = 69;
      this.lbWebSite.Text = "Website";
      // 
      // lbPhoneNumber
      // 
      this.lbPhoneNumber.AutoSize = true;
      this.lbPhoneNumber.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbPhoneNumber.Location = new System.Drawing.Point(12, 48);
      this.lbPhoneNumber.Name = "lbPhoneNumber";
      this.lbPhoneNumber.Size = new System.Drawing.Size(154, 27);
      this.lbPhoneNumber.TabIndex = 66;
      this.lbPhoneNumber.Text = "Phone number";
      // 
      // lbEmail
      // 
      this.lbEmail.AutoSize = true;
      this.lbEmail.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbEmail.Location = new System.Drawing.Point(12, 87);
      this.lbEmail.Name = "lbEmail";
      this.lbEmail.Size = new System.Drawing.Size(72, 27);
      this.lbEmail.TabIndex = 70;
      this.lbEmail.Text = "E-Mail";
      // 
      // btnSave
      // 
      this.btnSave.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.check_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnSave.Location = new System.Drawing.Point(383, 162);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(56, 56);
      this.btnSave.TabIndex = 73;
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // Form_AddUpdatePublisher
      // 
      this.AcceptButton = this.btnSave;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(459, 226);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txFirstName);
      this.Controls.Add(this.txPhoneNumber);
      this.Controls.Add(this.txWebSite);
      this.Controls.Add(this.txEmail);
      this.Controls.Add(this.lbFirstName);
      this.Controls.Add(this.lbID);
      this.Controls.Add(this.lbAuthorID);
      this.Controls.Add(this.lbWebSite);
      this.Controls.Add(this.lbPhoneNumber);
      this.Controls.Add(this.lbEmail);
      this.Font = new System.Drawing.Font("Roboto", 16F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Form_AddUpdatePublisher";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Add/Update Publisher";
      this.Load += new System.EventHandler(this.Form_AddUpdatePublisher_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox txFirstName;
    private System.Windows.Forms.TextBox txPhoneNumber;
    private System.Windows.Forms.TextBox txWebSite;
    private System.Windows.Forms.TextBox txEmail;
    private System.Windows.Forms.Label lbFirstName;
    private System.Windows.Forms.Label lbID;
    private System.Windows.Forms.Label lbAuthorID;
    private System.Windows.Forms.Label lbWebSite;
    private System.Windows.Forms.Label lbPhoneNumber;
    private System.Windows.Forms.Label lbEmail;
    private System.Windows.Forms.ErrorProvider errorProvider1;
  }
}