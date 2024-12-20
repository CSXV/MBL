using MyBookLibrary_BusinessLayer;
using System;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets.Users {
  public partial class Form_AddUpdate_User : Form {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    private int _UserID;
    private clsUser _User;

    public Form_AddUpdate_User(int UserID) {
      InitializeComponent();

      _UserID = UserID;
      _Mode = (_UserID != -1) ? enMode.Update : enMode.AddNew;
    }

    private void Form_AddUpdate_User_Load(object sender, EventArgs e) {
      _LoadData();
      _UpdateColors();
    }

    public void _LoadData() {
      _UpdateColors();

      if(_Mode == enMode.AddNew) {
        _User = new clsUser();
        ckIsActive.Checked = true;
        return;
      }

      _User = clsUser.Find(_UserID);
      tbConfirmPassword.Visible = false;
      tbPassword.Visible = false;
      lbPassword.Visible = false;
      lbConfirmPassword.Visible = false;

      lbID.Text = _User.ID.ToString();
      tbUserName.Text = _User.UserName;
      tbPassword.Text = _User.Password;

      if(_User.IsActive) {
        ckIsActive.Checked = true;
      } else {
        ckIsActive.Checked = false;
      }
    }

    private void _UpdateColors() {
      this.BackColor = Globals.Theme.Surface;

      btnSave.BackColor = Globals.Theme.PrimaryContainer;
      btnSave.ForeColor = Globals.Theme.OnPrimaryContainer;

      ckIsActive.ForeColor = Globals.Theme.OnSurface;
      ckIsActive.BackColor = Globals.Theme.Surface;

      lbUserID.BackColor = Globals.Theme.Surface;
      lbID.BackColor = Globals.Theme.Surface;
      lbUserName.BackColor = Globals.Theme.Surface;
      lbPassword.BackColor = Globals.Theme.Surface;
      lbConfirmPassword.BackColor = Globals.Theme.Surface;

      lbUserName.ForeColor = Globals.Theme.OnSurface;
      lbUserID.ForeColor = Globals.Theme.OnSurface;
      lbID.ForeColor = Globals.Theme.OnSurface;
      lbPassword.ForeColor = Globals.Theme.OnSurface;
      lbConfirmPassword.ForeColor = Globals.Theme.OnSurface;

      tbPassword.BackColor = Globals.Theme.SurfaceContainerHighest;
      tbConfirmPassword.BackColor = Globals.Theme.SurfaceContainerHighest;
      tbUserName.BackColor = Globals.Theme.SurfaceContainerHighest;

      tbUserName.ForeColor = Globals.Theme.OnSurface;
      tbPassword.ForeColor = Globals.Theme.OnSurface;
      tbConfirmPassword.ForeColor = Globals.Theme.OnSurface;
    }

    private void btnSave_Click(object sender, EventArgs e) {
      string password = clsUtilites.ComputeHash(tbConfirmPassword.Text.Trim());

      _User.UserName = tbUserName.Text.Trim();
      if(_User == null) {
        _User.Password = password;
      }
      if(ckIsActive.Checked) {
        _User.IsActive = true;
      } else {
        _User.IsActive = false;
      }

      if(_User.Save()) {
        MessageBox.Show("User saved successfully");
      } else {
        MessageBox.Show("Error saving User");
      }

      _Mode = enMode.Update;
      lbID.Text = _User.ID.ToString();
    }

    private void tbUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if(String.IsNullOrEmpty(tbUserName.Text.Trim())) {
        e.Cancel = true;
        errorProvider1.SetError(tbUserName, "User name cannot be empty");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(tbUserName, "");
      }

      if(clsUser.IsUserExist(tbUserName.Text.Trim())) {
        e.Cancel = true;
        errorProvider1.SetError(tbUserName, "User name already exist, choose another one");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(tbUserName, "");
      }
    }

    private void tbConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if(tbPassword.Text.Trim() != tbConfirmPassword.Text.Trim()) {
        e.Cancel = true;
        errorProvider1.SetError(tbConfirmPassword, "Password is not matched");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(tbConfirmPassword, "");
      }
    }
  }
}
