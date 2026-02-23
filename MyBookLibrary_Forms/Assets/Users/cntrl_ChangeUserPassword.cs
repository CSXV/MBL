using MyBookLibrary_BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets.Users {
  public partial class cntrl_ChangeUserPassword : UserControl {
    private clsUser _User;

    public cntrl_ChangeUserPassword() {
      InitializeComponent();
    }

    public void SetID(int userID) {
      _User = clsUser.Find(userID);
      if(_User == null) {
        return;
      }
    }

    private void txCurrentPassword_Validating(object sender, CancelEventArgs e) {
      if(String.IsNullOrEmpty(txCurrentPassword.Text.Trim())) {
        e.Cancel = true;
        errorProvider1.SetError(txCurrentPassword, "Password cannot be empty");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txCurrentPassword, "");
      }

      if(clsUtilites.ComputeHash(txConfirmPassword.Text.Trim()) != _User.Password) {
        //if(txCurrentPassword.Text.Trim() != _User.Password) {
        e.Cancel = true;
        errorProvider1.SetError(txCurrentPassword, "Password is wrong");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txCurrentPassword, "");
      }
    }

    private void txConfirmPassword_Validating(object sender, CancelEventArgs e) {
      if(txCurrentPassword.Text.Trim() != txConfirmPassword.Text.Trim()) {
        e.Cancel = true;
        errorProvider1.SetError(txCurrentPassword, "Password dont match");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txCurrentPassword, "");
      }
    }

    private void cntrl_ChangeUserPassword_Load(object sender, System.EventArgs e) {
      _ChangeColors();
    }

    private void _ChangeColors() {
      this.BackColor = Globals.Theme.Surface;

      lbConfirmPassword.ForeColor = Globals.Theme.OnSurface;
      lbCurrentPassword.ForeColor = Globals.Theme.OnSurface;
      lbNewPassword.ForeColor = Globals.Theme.OnSurface;

      lbConfirmPassword.BackColor = Globals.Theme.Surface;
      lbCurrentPassword.BackColor = Globals.Theme.Surface;
      lbNewPassword.BackColor = Globals.Theme.Surface;

      txConfirmPassword.BackColor = Globals.Theme.SurfaceContainerHighest;
      txCurrentPassword.BackColor = Globals.Theme.SurfaceContainerHighest;
      txNewPassword.BackColor = Globals.Theme.SurfaceContainerHighest;

      txConfirmPassword.ForeColor = Globals.Theme.OnSurface;
      txCurrentPassword.ForeColor = Globals.Theme.OnSurface;
      txNewPassword.ForeColor = Globals.Theme.OnSurface;

      btnSave.ForeColor = Globals.Theme.OnPrimaryContainer;
      btnSave.BackColor = Globals.Theme.PrimaryContainer;

    }

    private void btnSave_Click(object sender, EventArgs e) {
      string np = clsUtilites.ComputeHash(txConfirmPassword.Text.Trim());

      _User.Password = np;

      if(_User.Save()) {
        MessageBox.Show("Password updated successfully");
      } else {
        MessageBox.Show("Error updating password");
      }
    }
  }
}
