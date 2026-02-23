using MyBookLibrary_BusinessLayer;
using System;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets.Users {
  public partial class Form_ChangeUserPassword : Form {
    private clsUser _User;
    private int _UserID;

    public Form_ChangeUserPassword(clsUser User) {
      InitializeComponent();

      _User = User;
    }

    public Form_ChangeUserPassword(int UserID) {
      InitializeComponent();

      _UserID = UserID;
      _FindUser();
    }

    private void _FindUser() {
      _User = clsUser.Find(_UserID);
      if(_User == null) {
        return;
      }
    }

    private void Form_ChangeUserPassword_Load(object sender, EventArgs e) {
      _ChangeColors();

      cntrl_ChangeUserPassword1.SetID(_User.ID);

      lbID.Text = _User.ID.ToString();
      lbName.Text = _User.UserName;
    }

    private void _ChangeColors() {
      this.BackColor = Globals.Theme.Surface;

      lbID.BackColor = Globals.Theme.Surface;
      lbUserID.BackColor = Globals.Theme.Surface;
      lbUserName.BackColor = Globals.Theme.Surface;
      lbName.BackColor = Globals.Theme.Surface;

      lbID.ForeColor = Globals.Theme.OnSurface;
      lbUserID.ForeColor = Globals.Theme.OnSurface;
      lbUserName.ForeColor = Globals.Theme.OnSurface;
      lbName.ForeColor = Globals.Theme.OnSurface;
    }
  }
}
