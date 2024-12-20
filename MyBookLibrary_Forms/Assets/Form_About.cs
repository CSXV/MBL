using System;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets {
  public partial class Form_About : Form {
    public Form_About() {
      InitializeComponent();
    }

    private void Form_About_Load(object sender, EventArgs e) {
      _UpdateColors();
    }

    private void _UpdateColors() {
      this.BackColor = Globals.Theme.Surface;

      lbInfo.BackColor = Globals.Theme.Surface;
      lbTechnology.BackColor = Globals.Theme.Surface;

      lbInfo.ForeColor = Globals.Theme.OnSurface;
      lbTechnology.ForeColor = Globals.Theme.OnSurface;
    }

  }
}
