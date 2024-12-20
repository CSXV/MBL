using MyBookLibrary_Forms.Assets;
using MyBookLibrary_Forms.Assets.Authors;
using MyBookLibrary_Forms.Assets.Books;
using MyBookLibrary_Forms.Assets.Publishers;
using MyBookLibrary_Forms.Assets.Records;
using MyBookLibrary_Forms.Assets.Users;
using System;
using System.Windows.Forms;

namespace MyBookLibrary_Forms {
  public partial class Form_MainMenu : Form {

    public Form_MainMenu() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      _UpdateColors();
    }

    private void _UpdateColors() {
      this.BackColor = Globals.Theme.Surface;

      btnYourRecords.BackColor = Globals.Theme.Tertiary;
      btnYourRecords.ForeColor = Globals.Theme.OnTertiary;

      btnBooksList.BackColor = Globals.Theme.Secondary;
      btnBooksList.ForeColor = Globals.Theme.OnSecondary;

      btnAddbook.BackColor = Globals.Theme.Secondary;
      btnAddbook.ForeColor = Globals.Theme.OnSecondary;

      btnChangeTheme.BackColor = Globals.Theme.Secondary;
      btnChangeTheme.ForeColor = Globals.Theme.OnSecondary;

      menuStrip1.BackColor = Globals.Theme.Surface;
      menuStrip1.ForeColor = Globals.Theme.OnSurface;

      usersToolStripMenuItem.BackColor = Globals.Theme.Surface;
      usersToolStripMenuItem.ForeColor = Globals.Theme.OnSurface;

      booksToolStripMenuItem.BackColor = Globals.Theme.Surface;
      booksToolStripMenuItem.ForeColor = Globals.Theme.OnSurface;

      settingsToolStripMenuItem.BackColor = Globals.Theme.Surface;
      settingsToolStripMenuItem.ForeColor = Globals.Theme.OnSurface;

      publishersToolStripMenuItem.BackColor = Globals.Theme.Surface;
      publishersToolStripMenuItem.ForeColor = Globals.Theme.OnSurface;

      authorsToolStripMenuItem.BackColor = Globals.Theme.Surface;
      authorsToolStripMenuItem.ForeColor = Globals.Theme.OnSurface;

    }

    private void btnChangeTheme_Click(object sender, EventArgs e) {
      colorDialog1.ShowDialog();

      Globals.UpdateTheme(colorDialog1.Color);

      _UpdateColors();
    }

    private void changeThemeToolStripMenuItem_Click(object sender, EventArgs e) {
      colorDialog1.ShowDialog();

      Globals.UpdateTheme(colorDialog1.Color);

      _UpdateColors();
    }

    private void btnAddbook_Click(object sender, EventArgs e) {
      Form_Add_Update_Book form_AddNewBook = new Form_Add_Update_Book(-1);
      form_AddNewBook.ShowDialog();
    }

    private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e) {
      Form_ChangeUserPassword form_ChangeUserPassword = new Form_ChangeUserPassword(Globals.CurrentUser);
      form_ChangeUserPassword.ShowDialog();
    }

    private void Form_MainMenu_FormClosing(object sender, FormClosingEventArgs e) {
      Application.Exit();
    }

    private void addNewToolStripMenuItem1_Click(object sender, EventArgs e) {
      Form_AddUpdateAuthor addAuthor = new Form_AddUpdateAuthor(-1);
      addAuthor.ShowDialog();
    }

    private void manageToolStripMenuItem2_Click(object sender, EventArgs e) {
      Form_ManageAuthors manageAuthors = new Form_ManageAuthors();
      manageAuthors.ShowDialog();
    }

    private void addNewToolStripMenuItem_Click(object sender, EventArgs e) {
      Form_AddUpdatePublisher addPublisher = new Form_AddUpdatePublisher(-1);
      addPublisher.ShowDialog();
    }

    private void manageToolStripMenuItem3_Click(object sender, EventArgs e) {
      Form_ManagePublishers manageUsers = new Form_ManagePublishers();
      manageUsers.ShowDialog();
    }

    private void manageToolStripMenuItem1_Click(object sender, EventArgs e) {
      Form_Manage_publishers managePublishers = new Form_Manage_publishers();
      managePublishers.ShowDialog();
    }

    private void addNewToolStripMenuItem2_Click(object sender, EventArgs e) {
      Form_AddUpdate_User addUser = new Form_AddUpdate_User(-1);
      addUser.ShowDialog();
    }

    private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e) {
      Form_Add_Update_Book addBook = new Form_Add_Update_Book(-1);
      addBook.ShowDialog();
    }

    private void infoToolStripMenuItem_Click(object sender, EventArgs e) {
      Form_About about = new Form_About();
      about.ShowDialog();
    }

    private void manageToolStripMenuItem_Click(object sender, EventArgs e) {
      Form_ManageBooks manageBooks = new Form_ManageBooks();
      manageBooks.ShowDialog();
    }

    private void btnBooksList_Click(object sender, EventArgs e) {
      Form_ManageBooks form_ManageBooks = new Form_ManageBooks();
      form_ManageBooks.ShowDialog();
    }

    private void btnYourRecords_Click(object sender, EventArgs e) {
      Form_ManageRecords manageRecords = new Form_ManageRecords();
      manageRecords.ShowDialog();
    }

    private void manageToolStripMenuItem4_Click(object sender, EventArgs e) {
      Form_ManageRecords manageRecords = new Form_ManageRecords();
      manageRecords.ShowDialog();
    }

    private void addNewToolStripMenuItem3_Click(object sender, EventArgs e) {
      Form_AddUpdate_Record addRecord = new Form_AddUpdate_Record(-1);
      addRecord.ShowDialog();
    }
  }
}
