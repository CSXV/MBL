using Microsoft.Win32;
using MyBookLibrary_BusinessLayer;
using System;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets {
  public partial class Form_Login : Form {
    public Form_Login() {
      InitializeComponent();
    }

    private void Form_Login_Load(object sender, EventArgs e) {
      string NameValue = "";
      string PasswordValue = "";
      string ColorValue = "";

      if(CheckStoredCredi(ref NameValue, ref PasswordValue, ref ColorValue)) {
        txUser.Text = NameValue;
        txPassword.Text = PasswordValue;
        ckRememberMe.Checked = true;

        // theme engine colors
        if(!String.IsNullOrEmpty(ColorValue)) {
          uint c = uint.Parse(ColorValue);
          Globals.color = c;
          Globals.UpdateTheme(c);
        }
      }

      _LoadColors();
    }

    private void _LoadColors() {
      this.BackColor = Globals.Theme.Surface;
      btnLogin.BackColor = Globals.Theme.PrimaryContainer;
      btnLogin.ForeColor = Globals.Theme.OnPrimaryContainer;

      txUser.BackColor = Globals.Theme.SurfaceContainerHighest;
      txUser.ForeColor = Globals.Theme.OnSurface;
      lbUser.BackColor = Globals.Theme.Surface;
      lbUser.ForeColor = Globals.Theme.OnSurface;

      txPassword.BackColor = Globals.Theme.SurfaceContainerHighest;
      txPassword.ForeColor = Globals.Theme.OnSurface;
      lbPassword.BackColor = Globals.Theme.Surface;
      lbPassword.ForeColor = Globals.Theme.OnSurface;

      pbPassword.BackColor = Globals.Theme.Surface;
      pbUser.BackColor = Globals.Theme.Surface;
      pbPasswordRemove.BackColor = Globals.Theme.Surface;
      pbUserRemove.BackColor = Globals.Theme.Surface;

      ckRememberMe.BackColor = Globals.Theme.Surface;
      ckRememberMe.ForeColor = Globals.Theme.OnSurface;

      lbTitle.BackColor = Globals.Theme.Surface;
      lbTitle.ForeColor = Globals.Theme.OnSurface;
    }

    private void txUser_TextChanged(object sender, EventArgs e) {
      if(!String.IsNullOrEmpty(txUser.Text)) {
        pbUserRemove.Visible = true;
      }
    }

    private void pbUserRemove_Click(object sender, EventArgs e) {
      txUser.Text = "";
      pbUserRemove.Visible = false;
    }

    private void pbPasswordRemove_Click(object sender, EventArgs e) {
      txPassword.Text = "";
      pbPasswordRemove.Visible = false;
    }

    private void txPassword_TextChanged(object sender, EventArgs e) {
      if(!String.IsNullOrEmpty(txPassword.Text)) {
        pbPasswordRemove.Visible = true;
      }
    }

    private void btnLogin_Click(object sender, EventArgs e) {
      string Password = clsUtilites.ComputeHash(txPassword.Text.Trim());

      clsUser user = clsUser.Find(txUser.Text.Trim());

      if(user != null) {
        if(user.Password == Password) {
          if(user.IsActive) {
            if(ckRememberMe.Checked) {
              SaveToRegistry(txUser.Text.Trim(), txPassword.Text.Trim());
            } else {
              DeleteRegistry();
            }

            Globals.CurrentUser = user;
            this.Hide();
            Form_MainMenu frm = new Form_MainMenu();
            frm.ShowDialog();
          } else {
            MessageBox.Show("User is not active");
          }

        } else {
          MessageBox.Show("Wrong password");
          txPassword.Focus();
        }

      } else {
        MessageBox.Show("User not found");
        txUser.Focus();
      }
    }

    private void DeleteRegistry() {
      SaveToRegistry("", "");
    }

    private bool SaveToRegistry(string userName, string password) {
      string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\MyBookLibrary";

      try {
        Registry.SetValue(keyPath, "User Name", userName, RegistryValueKind.String);
        Registry.SetValue(keyPath, "Password", password, RegistryValueKind.String);
        Registry.SetValue(keyPath, "Theme Color", Globals.color, RegistryValueKind.String);

        return true;
      } catch(Exception ex) {
        Console.WriteLine("Error:" + ex.Message);

        return false;
      }
    }

    private bool CheckStoredCredi(ref string NameValue, ref string PasswordValue, ref string ColorValue) {
      string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\MyBookLibrary";
      string UserName = "User Name";
      string Password = "Password";
      string themeColor = "Theme Color";

      try {
        NameValue = Registry.GetValue(keyPath, UserName, null) as string;
        PasswordValue = Registry.GetValue(keyPath, Password, null) as string;
        ColorValue = Registry.GetValue(keyPath, themeColor, null) as string;

        if(!string.IsNullOrEmpty(NameValue) && !string.IsNullOrEmpty(PasswordValue)) {
          return true;
        } else {
          return false;
        }
      } catch(Exception ex) {
        Globals.LogError(ex);
        return false;
      }
    }

    private void txPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if(String.IsNullOrEmpty(txPassword.Text)) {
        e.Cancel = true;
        errorProvider1.SetError(txPassword, "Password cannot be empty");
        return;
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txPassword, "");
      }
    }

    private void txUser_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if(String.IsNullOrEmpty(txUser.Text)) {
        e.Cancel = true;
        errorProvider1.SetError(txUser, "User name cannot be empty");
        return;
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txUser, "");
      }
    }
  }
}
