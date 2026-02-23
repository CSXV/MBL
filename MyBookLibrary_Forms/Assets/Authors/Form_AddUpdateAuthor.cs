using MyBookLibrary_BusinessLayer;
using System;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets.Authors {
  public partial class Form_AddUpdateAuthor : Form {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    private int _AuthorID;
    private clsAuthor _Author;

    public Form_AddUpdateAuthor(int AuthorID) {
      InitializeComponent();

      _AuthorID = AuthorID;
      _Mode = (_AuthorID != -1) ? enMode.Update : enMode.AddNew;
    }

    private void Form_AddUpdateAuthor_Load(object sender, EventArgs e) {
      _UpdateColors();
      _LoadData();
    }

    public void _LoadData() {
      if(_Mode == enMode.AddNew) {
        _Author = new clsAuthor();
        return;
      }

      _Author = clsAuthor.Find(_AuthorID);

      lbID.Text = _Author.ID.ToString();
      txFirstName.Text = _Author.FirstName;
      txLastName.Text = _Author.LastName;
      txEmail.Text = _Author.Email;
      txPhoneNumber.Text = _Author.Phone;
      txWebSite.Text = _Author.Website;
    }

    private void _UpdateColors() {
      this.BackColor = Globals.Theme.Surface;

      btnSave.BackColor = Globals.Theme.PrimaryContainer;
      btnSave.ForeColor = Globals.Theme.OnPrimaryContainer;

      lbEmail.BackColor = Globals.Theme.Surface;
      lbFirstName.BackColor = Globals.Theme.Surface;
      lbLastName.BackColor = Globals.Theme.Surface;
      lbPhoneNumber.BackColor = Globals.Theme.Surface;
      lbWebSite.BackColor = Globals.Theme.Surface;
      lbAuthorID.BackColor = Globals.Theme.Surface;
      lbID.BackColor = Globals.Theme.Surface;

      lbEmail.ForeColor = Globals.Theme.OnSurface;
      lbFirstName.ForeColor = Globals.Theme.OnSurface;
      lbLastName.ForeColor = Globals.Theme.OnSurface;
      lbPhoneNumber.ForeColor = Globals.Theme.OnSurface;
      lbWebSite.ForeColor = Globals.Theme.OnSurface;
      lbID.ForeColor = Globals.Theme.OnSurface;
      lbAuthorID.ForeColor = Globals.Theme.OnSurface;

      txEmail.BackColor = Globals.Theme.SurfaceContainerHighest;
      txFirstName.BackColor = Globals.Theme.SurfaceContainerHighest;
      txLastName.BackColor = Globals.Theme.SurfaceContainerHighest;
      txPhoneNumber.BackColor = Globals.Theme.SurfaceContainerHighest;
      txWebSite.BackColor = Globals.Theme.SurfaceContainerHighest;

      txEmail.ForeColor = Globals.Theme.OnSurface;
      txFirstName.ForeColor = Globals.Theme.OnSurface;
      txLastName.ForeColor = Globals.Theme.OnSurface;
      txPhoneNumber.ForeColor = Globals.Theme.OnSurface;
      txWebSite.ForeColor = Globals.Theme.OnSurface;
    }

    private void btnSave_Click(object sender, EventArgs e) {
      _Author.FirstName = txFirstName.Text;
      _Author.LastName = txLastName.Text;
      if(txPhoneNumber.Text != "") {
        _Author.Phone = txPhoneNumber.Text;
      }
      if(txWebSite.Text != "") {
        _Author.Website = txWebSite.Text;
      }
      if(txEmail.Text != "") {
        _Author.Email = txEmail.Text;
      }

      if(_Author.Save()) {
        MessageBox.Show("Author saved successfully");
      } else {
        MessageBox.Show("Error saving Author");
      }

      _Mode = enMode.Update;
      lbID.Text = _Author.ID.ToString();
    }

    private void txFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if(String.IsNullOrEmpty(txFirstName.Text.Trim())) {
        e.Cancel = true;
        errorProvider1.SetError(txFirstName, "First name cannot be empty");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txFirstName, "");
      }
    }

    private void txLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if(String.IsNullOrEmpty(txLastName.Text.Trim())) {
        e.Cancel = true;
        errorProvider1.SetError(txLastName, "Last name cannot be empty");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txLastName, "");
      }
    }

    private void txEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if(!clsUtilites.EmailValidation(txEmail.Text.Trim())) {
        e.Cancel = true;
        errorProvider1.SetError(txEmail, "Email is not valid");

      } else {
        e.Cancel = false;
        errorProvider1.SetError(txEmail, "");
      }
    }
  }
}
