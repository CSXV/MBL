namespace MyBookLibrary_Forms.Assets.Records {
  partial class Form_AddUpdate_Record {
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
      this.txBookID = new System.Windows.Forms.TextBox();
      this.txReadingDuration = new System.Windows.Forms.TextBox();
      this.txRating = new System.Windows.Forms.TextBox();
      this.lbState = new System.Windows.Forms.Label();
      this.lbBookID = new System.Windows.Forms.Label();
      this.lbID = new System.Windows.Forms.Label();
      this.lbRecordID = new System.Windows.Forms.Label();
      this.lbReadingDuration = new System.Windows.Forms.Label();
      this.lbDifficulty = new System.Windows.Forms.Label();
      this.lbRating = new System.Windows.Forms.Label();
      this.lbFinishDate = new System.Windows.Forms.Label();
      this.txFinishDate = new System.Windows.Forms.TextBox();
      this.lbComments = new System.Windows.Forms.Label();
      this.txComments = new System.Windows.Forms.TextBox();
      this.lbUser = new System.Windows.Forms.Label();
      this.lbUserIDText = new System.Windows.Forms.Label();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.cbState = new System.Windows.Forms.ComboBox();
      this.cbDifficulty = new System.Windows.Forms.ComboBox();
      this.lbDays = new System.Windows.Forms.Label();
      this.lbBookTitleText = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnSearch = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // txBookID
      // 
      this.txBookID.Font = new System.Drawing.Font("Roboto", 16F);
      this.txBookID.Location = new System.Drawing.Point(196, 6);
      this.txBookID.Name = "txBookID";
      this.txBookID.Size = new System.Drawing.Size(211, 33);
      this.txBookID.TabIndex = 10;
      this.txBookID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBookID_KeyPress);
      this.txBookID.Validating += new System.ComponentModel.CancelEventHandler(this.txBookID_Validating);
      // 
      // txReadingDuration
      // 
      this.txReadingDuration.Font = new System.Drawing.Font("Roboto", 16F);
      this.txReadingDuration.Location = new System.Drawing.Point(196, 201);
      this.txReadingDuration.Name = "txReadingDuration";
      this.txReadingDuration.Size = new System.Drawing.Size(185, 33);
      this.txReadingDuration.TabIndex = 60;
      this.txReadingDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txReadingDuration_KeyPress);
      // 
      // txRating
      // 
      this.txRating.Font = new System.Drawing.Font("Roboto", 16F);
      this.txRating.Location = new System.Drawing.Point(196, 123);
      this.txRating.Name = "txRating";
      this.txRating.Size = new System.Drawing.Size(250, 33);
      this.txRating.TabIndex = 40;
      this.txRating.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txRating_KeyPress);
      this.txRating.Validating += new System.ComponentModel.CancelEventHandler(this.txRating_Validating);
      // 
      // lbState
      // 
      this.lbState.AutoSize = true;
      this.lbState.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbState.Location = new System.Drawing.Point(12, 48);
      this.lbState.Name = "lbState";
      this.lbState.Size = new System.Drawing.Size(63, 27);
      this.lbState.TabIndex = 64;
      this.lbState.Text = "State";
      // 
      // lbBookID
      // 
      this.lbBookID.AutoSize = true;
      this.lbBookID.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbBookID.Location = new System.Drawing.Point(12, 9);
      this.lbBookID.Name = "lbBookID";
      this.lbBookID.Size = new System.Drawing.Size(83, 27);
      this.lbBookID.TabIndex = 65;
      this.lbBookID.Text = "BookID";
      // 
      // lbID
      // 
      this.lbID.AutoSize = true;
      this.lbID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Italic);
      this.lbID.Location = new System.Drawing.Point(191, 285);
      this.lbID.Name = "lbID";
      this.lbID.Size = new System.Drawing.Size(50, 27);
      this.lbID.TabIndex = 67;
      this.lbID.Text = "N/A";
      // 
      // lbRecordID
      // 
      this.lbRecordID.AutoSize = true;
      this.lbRecordID.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbRecordID.Location = new System.Drawing.Point(12, 285);
      this.lbRecordID.Name = "lbRecordID";
      this.lbRecordID.Size = new System.Drawing.Size(107, 27);
      this.lbRecordID.TabIndex = 68;
      this.lbRecordID.Text = "Record ID";
      // 
      // lbReadingDuration
      // 
      this.lbReadingDuration.AutoSize = true;
      this.lbReadingDuration.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbReadingDuration.Location = new System.Drawing.Point(12, 204);
      this.lbReadingDuration.Name = "lbReadingDuration";
      this.lbReadingDuration.Size = new System.Drawing.Size(178, 27);
      this.lbReadingDuration.TabIndex = 69;
      this.lbReadingDuration.Text = "Reading Duration";
      // 
      // lbDifficulty
      // 
      this.lbDifficulty.AutoSize = true;
      this.lbDifficulty.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbDifficulty.Location = new System.Drawing.Point(12, 87);
      this.lbDifficulty.Name = "lbDifficulty";
      this.lbDifficulty.Size = new System.Drawing.Size(96, 27);
      this.lbDifficulty.TabIndex = 66;
      this.lbDifficulty.Text = "Difficulty";
      // 
      // lbRating
      // 
      this.lbRating.AutoSize = true;
      this.lbRating.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbRating.Location = new System.Drawing.Point(12, 126);
      this.lbRating.Name = "lbRating";
      this.lbRating.Size = new System.Drawing.Size(74, 27);
      this.lbRating.TabIndex = 70;
      this.lbRating.Text = "Rating";
      // 
      // lbFinishDate
      // 
      this.lbFinishDate.AutoSize = true;
      this.lbFinishDate.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbFinishDate.Location = new System.Drawing.Point(12, 162);
      this.lbFinishDate.Name = "lbFinishDate";
      this.lbFinishDate.Size = new System.Drawing.Size(119, 27);
      this.lbFinishDate.TabIndex = 69;
      this.lbFinishDate.Text = "Finish Date";
      // 
      // txFinishDate
      // 
      this.txFinishDate.Font = new System.Drawing.Font("Roboto", 16F);
      this.txFinishDate.Location = new System.Drawing.Point(196, 162);
      this.txFinishDate.Name = "txFinishDate";
      this.txFinishDate.Size = new System.Drawing.Size(250, 33);
      this.txFinishDate.TabIndex = 50;
      this.txFinishDate.Validating += new System.ComponentModel.CancelEventHandler(this.txFinishDate_Validating);
      // 
      // lbComments
      // 
      this.lbComments.AutoSize = true;
      this.lbComments.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbComments.Location = new System.Drawing.Point(483, 48);
      this.lbComments.Name = "lbComments";
      this.lbComments.Size = new System.Drawing.Size(119, 27);
      this.lbComments.TabIndex = 69;
      this.lbComments.Text = "Comments";
      // 
      // txComments
      // 
      this.txComments.Font = new System.Drawing.Font("Roboto", 10F);
      this.txComments.Location = new System.Drawing.Point(488, 84);
      this.txComments.Multiline = true;
      this.txComments.Name = "txComments";
      this.txComments.Size = new System.Drawing.Size(486, 228);
      this.txComments.TabIndex = 70;
      // 
      // lbUser
      // 
      this.lbUser.AutoSize = true;
      this.lbUser.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbUser.Location = new System.Drawing.Point(12, 246);
      this.lbUser.Name = "lbUser";
      this.lbUser.Size = new System.Drawing.Size(56, 27);
      this.lbUser.TabIndex = 68;
      this.lbUser.Text = "User";
      // 
      // lbUserIDText
      // 
      this.lbUserIDText.AutoSize = true;
      this.lbUserIDText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Italic);
      this.lbUserIDText.Location = new System.Drawing.Point(191, 246);
      this.lbUserIDText.Name = "lbUserIDText";
      this.lbUserIDText.Size = new System.Drawing.Size(50, 27);
      this.lbUserIDText.TabIndex = 67;
      this.lbUserIDText.Text = "N/A";
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // cbState
      // 
      this.cbState.FormattingEnabled = true;
      this.cbState.Items.AddRange(new object[] {
            "Waiting",
            "Reading",
            "Finished",
            "Dropped"});
      this.cbState.Location = new System.Drawing.Point(196, 45);
      this.cbState.Name = "cbState";
      this.cbState.Size = new System.Drawing.Size(250, 33);
      this.cbState.TabIndex = 20;
      // 
      // cbDifficulty
      // 
      this.cbDifficulty.FormattingEnabled = true;
      this.cbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
      this.cbDifficulty.Location = new System.Drawing.Point(196, 84);
      this.cbDifficulty.Name = "cbDifficulty";
      this.cbDifficulty.Size = new System.Drawing.Size(250, 33);
      this.cbDifficulty.TabIndex = 30;
      // 
      // lbDays
      // 
      this.lbDays.AutoSize = true;
      this.lbDays.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbDays.Location = new System.Drawing.Point(387, 204);
      this.lbDays.Name = "lbDays";
      this.lbDays.Size = new System.Drawing.Size(59, 27);
      this.lbDays.TabIndex = 69;
      this.lbDays.Text = "Days";
      // 
      // lbBookTitleText
      // 
      this.lbBookTitleText.AutoSize = true;
      this.lbBookTitleText.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbBookTitleText.Location = new System.Drawing.Point(483, 9);
      this.lbBookTitleText.Name = "lbBookTitleText";
      this.lbBookTitleText.Size = new System.Drawing.Size(51, 27);
      this.lbBookTitleText.TabIndex = 65;
      this.lbBookTitleText.Text = "N/A";
      // 
      // btnSave
      // 
      this.btnSave.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.check_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnSave.Location = new System.Drawing.Point(390, 256);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(56, 56);
      this.btnSave.TabIndex = 80;
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnSearch
      // 
      this.btnSearch.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.search_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnSearch.Location = new System.Drawing.Point(413, 6);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(33, 33);
      this.btnSearch.TabIndex = 25;
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // Form_AddUpdate_Record
      // 
      this.AcceptButton = this.btnSave;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(986, 325);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.cbDifficulty);
      this.Controls.Add(this.cbState);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txBookID);
      this.Controls.Add(this.txComments);
      this.Controls.Add(this.txFinishDate);
      this.Controls.Add(this.txReadingDuration);
      this.Controls.Add(this.txRating);
      this.Controls.Add(this.lbState);
      this.Controls.Add(this.lbBookTitleText);
      this.Controls.Add(this.lbBookID);
      this.Controls.Add(this.lbComments);
      this.Controls.Add(this.lbUserIDText);
      this.Controls.Add(this.lbID);
      this.Controls.Add(this.lbFinishDate);
      this.Controls.Add(this.lbUser);
      this.Controls.Add(this.lbRecordID);
      this.Controls.Add(this.lbDays);
      this.Controls.Add(this.lbReadingDuration);
      this.Controls.Add(this.lbDifficulty);
      this.Controls.Add(this.lbRating);
      this.Font = new System.Drawing.Font("Roboto", 16F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Form_AddUpdate_Record";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Add/Update Record";
      this.Load += new System.EventHandler(this.Form_AddUpdate_Record_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox txBookID;
    private System.Windows.Forms.TextBox txReadingDuration;
    private System.Windows.Forms.TextBox txRating;
    private System.Windows.Forms.Label lbState;
    private System.Windows.Forms.Label lbBookID;
    private System.Windows.Forms.Label lbID;
    private System.Windows.Forms.Label lbRecordID;
    private System.Windows.Forms.Label lbReadingDuration;
    private System.Windows.Forms.Label lbDifficulty;
    private System.Windows.Forms.Label lbRating;
    private System.Windows.Forms.Label lbFinishDate;
    private System.Windows.Forms.TextBox txFinishDate;
    private System.Windows.Forms.Label lbComments;
    private System.Windows.Forms.TextBox txComments;
    private System.Windows.Forms.Label lbUser;
    private System.Windows.Forms.Label lbUserIDText;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.ComboBox cbDifficulty;
    private System.Windows.Forms.ComboBox cbState;
    private System.Windows.Forms.Label lbDays;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Label lbBookTitleText;
  }
}