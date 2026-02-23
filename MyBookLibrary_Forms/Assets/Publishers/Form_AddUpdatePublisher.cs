using MyBookLibrary_BusinessLayer;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets.Publishers {
  public partial class Form_AddUpdatePublisher : Form {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    private int _pID;
    private clsPublisher _Publisher;

    public Form_AddUpdatePublisher(int pID) {
      InitializeComponent();

      _pID = pID;
      _Mode = (_pID != -1) ? enMode.Update : enMode.AddNew;
    }

    private void Form_AddUpdatePublisher_Load(object sender, System.EventArgs e) {
      _UpdateColors();
      _LoadData();
    }

    public void _LoadData() {
      if(_Mode == enMode.AddNew) {
        _Publisher = new clsPublisher();
        return;
      }

      _Publisher = clsPublisher.Find(_pID);

      lbID.Text = _Publisher.ID.ToString();
      txFirstName.Text = _Publisher.Name;
      txEmail.Text = _Publisher.Email;
      txPhoneNumber.Text = _Publisher.Phone;
      txWebSite.Text = _Publisher.Website;
    }

    private void btnSave_Click(object sender, System.EventArgs e) {
      _Publisher.Name = txFirstName.Text;

      if(txPhoneNumber.Text != "") {
        _Publisher.Phone = txPhoneNumber.Text;
      }
      if(txWebSite.Text != "") {
        _Publisher.Website = txWebSite.Text;
      }
      if(txEmail.Text != "") {
        _Publisher.Email = txEmail.Text;
      }

      if(_Publisher.Save()) {
        MessageBox.Show("Publisher saved successfully");
      } else {
        MessageBox.Show("Error saving Publisher");
      }

      _Mode = enMode.Update;
      lbID.Text = _Publisher.ID.ToString();
    }

    private void _UpdateColors() {
      this.BackColor = Globals.Theme.Surface;

      btnSave.BackColor = Globals.Theme.PrimaryContainer;
      btnSave.ForeColor = Globals.Theme.OnPrimaryContainer;

      lbEmail.BackColor = Globals.Theme.Surface;
      lbFirstName.BackColor = Globals.Theme.Surface;
      lbPhoneNumber.BackColor = Globals.Theme.Surface;
      lbWebSite.BackColor = Globals.Theme.Surface;
      lbAuthorID.BackColor = Globals.Theme.Surface;
      lbID.BackColor = Globals.Theme.Surface;

      lbEmail.ForeColor = Globals.Theme.OnSurface;
      lbFirstName.ForeColor = Globals.Theme.OnSurface;
      lbPhoneNumber.ForeColor = Globals.Theme.OnSurface;
      lbWebSite.ForeColor = Globals.Theme.OnSurface;
      lbID.ForeColor = Globals.Theme.OnSurface;
      lbAuthorID.ForeColor = Globals.Theme.OnSurface;

      txEmail.BackColor = Globals.Theme.SurfaceContainerHighest;
      txFirstName.BackColor = Globals.Theme.SurfaceContainerHighest;
      txPhoneNumber.BackColor = Globals.Theme.SurfaceContainerHighest;
      txWebSite.BackColor = Globals.Theme.SurfaceContainerHighest;

      txEmail.ForeColor = Globals.Theme.OnSurface;
      txFirstName.ForeColor = Globals.Theme.OnSurface;
      txPhoneNumber.ForeColor = Globals.Theme.OnSurface;
      txWebSite.ForeColor = Globals.Theme.OnSurface;
    }

    private void txFirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if(string.IsNullOrEmpty(txFirstName.Text.Trim())) {
        e.Cancel = true;
        errorProvider1.SetError(txFirstName, "Publisher's cannot be empty");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txFirstName, "");
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
