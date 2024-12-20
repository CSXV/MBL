namespace MyBookLibrary_Forms {
  partial class Form_MainMenu {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainMenu));
      this.btnYourRecords = new System.Windows.Forms.Button();
      this.btnBooksList = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.publishersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.manageToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.btnChangeTheme = new System.Windows.Forms.Button();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.btnAddbook = new System.Windows.Forms.Button();
      this.changeThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.manageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.addNewToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.manageToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.addNewToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.manageToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnYourRecords
      // 
      this.btnYourRecords.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnYourRecords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnYourRecords.Font = new System.Drawing.Font("Roboto", 25F);
      this.btnYourRecords.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btnYourRecords.Location = new System.Drawing.Point(12, 38);
      this.btnYourRecords.Name = "btnYourRecords";
      this.btnYourRecords.Size = new System.Drawing.Size(320, 250);
      this.btnYourRecords.TabIndex = 1;
      this.btnYourRecords.Text = "Your Records";
      this.btnYourRecords.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btnYourRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnYourRecords.UseVisualStyleBackColor = true;
      this.btnYourRecords.Click += new System.EventHandler(this.btnYourRecords_Click);
      // 
      // btnBooksList
      // 
      this.btnBooksList.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnBooksList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnBooksList.Font = new System.Drawing.Font("Roboto", 25F);
      this.btnBooksList.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btnBooksList.Location = new System.Drawing.Point(338, 38);
      this.btnBooksList.Name = "btnBooksList";
      this.btnBooksList.Size = new System.Drawing.Size(320, 250);
      this.btnBooksList.TabIndex = 1;
      this.btnBooksList.Text = "Books List";
      this.btnBooksList.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btnBooksList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnBooksList.UseVisualStyleBackColor = true;
      this.btnBooksList.Click += new System.EventHandler(this.btnBooksList_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Font = new System.Drawing.Font("Roboto", 16F);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.publishersToolStripMenuItem,
            this.authorsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.recordsToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(668, 35);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // settingsToolStripMenuItem
      // 
      this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeThemeToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.infoToolStripMenuItem});
      this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
      this.settingsToolStripMenuItem.Size = new System.Drawing.Size(103, 31);
      this.settingsToolStripMenuItem.Text = "Settings";
      // 
      // booksToolStripMenuItem
      // 
      this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.manageToolStripMenuItem});
      this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
      this.booksToolStripMenuItem.Size = new System.Drawing.Size(86, 31);
      this.booksToolStripMenuItem.Text = "Books";
      // 
      // publishersToolStripMenuItem
      // 
      this.publishersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.manageToolStripMenuItem1});
      this.publishersToolStripMenuItem.Name = "publishersToolStripMenuItem";
      this.publishersToolStripMenuItem.Size = new System.Drawing.Size(125, 31);
      this.publishersToolStripMenuItem.Text = "Publishers";
      // 
      // authorsToolStripMenuItem
      // 
      this.authorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.manageToolStripMenuItem2});
      this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
      this.authorsToolStripMenuItem.Size = new System.Drawing.Size(100, 31);
      this.authorsToolStripMenuItem.Text = "Authors";
      // 
      // manageToolStripMenuItem2
      // 
      this.manageToolStripMenuItem2.Image = global::MyBookLibrary_Forms.Properties.Resources.database_16dp_000000_FILL0_wght400_GRAD0_opsz20;
      this.manageToolStripMenuItem2.Name = "manageToolStripMenuItem2";
      this.manageToolStripMenuItem2.Size = new System.Drawing.Size(180, 32);
      this.manageToolStripMenuItem2.Text = "Manage";
      this.manageToolStripMenuItem2.Click += new System.EventHandler(this.manageToolStripMenuItem2_Click);
      // 
      // usersToolStripMenuItem
      // 
      this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem2,
            this.manageToolStripMenuItem3});
      this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
      this.usersToolStripMenuItem.Size = new System.Drawing.Size(79, 31);
      this.usersToolStripMenuItem.Text = "Users";
      // 
      // recordsToolStripMenuItem
      // 
      this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem3,
            this.manageToolStripMenuItem4});
      this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
      this.recordsToolStripMenuItem.Size = new System.Drawing.Size(105, 31);
      this.recordsToolStripMenuItem.Text = "Records";
      // 
      // btnChangeTheme
      // 
      this.btnChangeTheme.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnChangeTheme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnChangeTheme.Font = new System.Drawing.Font("Roboto", 25F);
      this.btnChangeTheme.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btnChangeTheme.Location = new System.Drawing.Point(338, 294);
      this.btnChangeTheme.Name = "btnChangeTheme";
      this.btnChangeTheme.Size = new System.Drawing.Size(320, 250);
      this.btnChangeTheme.TabIndex = 1;
      this.btnChangeTheme.Text = "Change Theme";
      this.btnChangeTheme.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btnChangeTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnChangeTheme.UseVisualStyleBackColor = true;
      this.btnChangeTheme.Click += new System.EventHandler(this.btnChangeTheme_Click);
      // 
      // btnAddbook
      // 
      this.btnAddbook.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnAddbook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnAddbook.Font = new System.Drawing.Font("Roboto", 25F);
      this.btnAddbook.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btnAddbook.Location = new System.Drawing.Point(12, 294);
      this.btnAddbook.Name = "btnAddbook";
      this.btnAddbook.Size = new System.Drawing.Size(320, 250);
      this.btnAddbook.TabIndex = 1;
      this.btnAddbook.Text = "Add new book";
      this.btnAddbook.TextAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btnAddbook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnAddbook.UseVisualStyleBackColor = true;
      this.btnAddbook.Click += new System.EventHandler(this.btnAddbook_Click);
      // 
      // changeThemeToolStripMenuItem
      // 
      this.changeThemeToolStripMenuItem.Image = global::MyBookLibrary_Forms.Properties.Resources.palette_16dp_000000_FILL0_wght400_GRAD0_opsz20;
      this.changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
      this.changeThemeToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
      this.changeThemeToolStripMenuItem.Text = "Change Theme";
      this.changeThemeToolStripMenuItem.Click += new System.EventHandler(this.changeThemeToolStripMenuItem_Click);
      // 
      // changePasswordToolStripMenuItem
      // 
      this.changePasswordToolStripMenuItem.Image = global::MyBookLibrary_Forms.Properties.Resources.password_16dp_000000_FILL0_wght400_GRAD0_opsz20;
      this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
      this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
      this.changePasswordToolStripMenuItem.Text = "Change Password";
      this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
      // 
      // infoToolStripMenuItem
      // 
      this.infoToolStripMenuItem.Image = global::MyBookLibrary_Forms.Properties.Resources.info_16dp_000000_FILL0_wght400_GRAD0_opsz20;
      this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
      this.infoToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
      this.infoToolStripMenuItem.Text = "About";
      this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
      // 
      // addNewBookToolStripMenuItem
      // 
      this.addNewBookToolStripMenuItem.Image = global::MyBookLibrary_Forms.Properties.Resources.add_16dp_000000_FILL0_wght400_GRAD0_opsz20;
      this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
      this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
      this.addNewBookToolStripMenuItem.Text = "Add New";
      this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
      // 
      // manageToolStripMenuItem
      // 
      this.manageToolStripMenuItem.Image = global::MyBookLibrary_Forms.Properties.Resources.library_books_16dp_000000_FILL0_wght400_GRAD0_opsz20;
      this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
      this.manageToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
      this.manageToolStripMenuItem.Text = "Manage";
      this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
      // 
      // addNewToolStripMenuItem
      // 
      this.addNewToolStripMenuItem.Image = global::MyBookLibrary_Forms.Properties.Resources.add_16dp_000000_FILL0_wght400_GRAD0_opsz20;
      this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
      this.addNewToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
      this.addNewToolStripMenuItem.Text = "Add new";
      this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
      // 
      // manageToolStripMenuItem1
      // 
      this.manageToolStripMenuItem1.Image = global::MyBookLibrary_Forms.Properties.Resources.database_16dp_000000_FILL0_wght400_GRAD0_opsz20;
      this.manageToolStripMenuItem1.Name = "manageToolStripMenuItem1";
      this.manageToolStripMenuItem1.Size = new System.Drawing.Size(180, 32);
      this.manageToolStripMenuItem1.Text = "Manage";
      this.manageToolStripMenuItem1.Click += new System.EventHandler(this.manageToolStripMenuItem1_Click);
      // 
      // addNewToolStripMenuItem1
      // 
      this.addNewToolStripMenuItem1.Image = global::MyBookLibrary_Forms.Properties.Resources.add_16dp_000000_FILL0_wght400_GRAD0_opsz20;
      this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
      this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(180, 32);
      this.addNewToolStripMenuItem1.Text = "Add new";
      this.addNewToolStripMenuItem1.Click += new System.EventHandler(this.addNewToolStripMenuItem1_Click);
      // 
      // addNewToolStripMenuItem2
      // 
      this.addNewToolStripMenuItem2.Image = global::MyBookLibrary_Forms.Properties.Resources.add_16dp_000000_FILL0_wght400_GRAD0_opsz20;
      this.addNewToolStripMenuItem2.Name = "addNewToolStripMenuItem2";
      this.addNewToolStripMenuItem2.Size = new System.Drawing.Size(180, 32);
      this.addNewToolStripMenuItem2.Text = "Add new";
      this.addNewToolStripMenuItem2.Click += new System.EventHandler(this.addNewToolStripMenuItem2_Click);
      // 
      // manageToolStripMenuItem3
      // 
      this.manageToolStripMenuItem3.Image = global::MyBookLibrary_Forms.Properties.Resources.manage_accounts_16dp_000000_FILL0_wght400_GRAD0_opsz20;
      this.manageToolStripMenuItem3.Name = "manageToolStripMenuItem3";
      this.manageToolStripMenuItem3.Size = new System.Drawing.Size(180, 32);
      this.manageToolStripMenuItem3.Text = "Manage";
      this.manageToolStripMenuItem3.Click += new System.EventHandler(this.manageToolStripMenuItem3_Click);
      // 
      // addNewToolStripMenuItem3
      // 
      this.addNewToolStripMenuItem3.Image = global::MyBookLibrary_Forms.Properties.Resources.add_16dp_000000_FILL0_wght400_GRAD0_opsz20;
      this.addNewToolStripMenuItem3.Name = "addNewToolStripMenuItem3";
      this.addNewToolStripMenuItem3.Size = new System.Drawing.Size(180, 32);
      this.addNewToolStripMenuItem3.Text = "Add New";
      this.addNewToolStripMenuItem3.Click += new System.EventHandler(this.addNewToolStripMenuItem3_Click);
      // 
      // manageToolStripMenuItem4
      // 
      this.manageToolStripMenuItem4.Image = global::MyBookLibrary_Forms.Properties.Resources.receipt_long_16dp_000000_FILL0_wght400_GRAD0_opsz20;
      this.manageToolStripMenuItem4.Name = "manageToolStripMenuItem4";
      this.manageToolStripMenuItem4.Size = new System.Drawing.Size(180, 32);
      this.manageToolStripMenuItem4.Text = "Manage";
      this.manageToolStripMenuItem4.Click += new System.EventHandler(this.manageToolStripMenuItem4_Click);
      // 
      // Form_MainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(668, 553);
      this.Controls.Add(this.btnAddbook);
      this.Controls.Add(this.btnChangeTheme);
      this.Controls.Add(this.btnBooksList);
      this.Controls.Add(this.btnYourRecords);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form_MainMenu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Main Menu";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_MainMenu_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnYourRecords;
    private System.Windows.Forms.Button btnBooksList;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem publishersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem3;
    private System.Windows.Forms.Button btnChangeTheme;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Button btnAddbook;
    private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem changeThemeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem4;
  }
}

