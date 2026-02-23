using MyBookLibrary_BusinessLayer;
using System;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets.Users {
  public partial class Form_ManagePublishers : Form {
    private BindingSource _source = new BindingSource();

    public Form_ManagePublishers() {
      InitializeComponent();
    }

    private void Form_ManageUsers_Load(object sender, EventArgs e) {
      _ChangeColors();
      _LoadUsersData();
      _ChangeColumnsSize();
    }

    private void _LoadUsersData() {
      _source.DataSource = clsUser.GetAllUsers();
      dgvUsers.DataSource = _source;
    }

    private void _ChangeColors() {
      this.BackColor = Globals.Theme.Surface;

      lbAuthors.BackColor = Globals.Theme.Surface;
      lbAuthors.ForeColor = Globals.Theme.OnSurface;

      btnAdd.BackColor = Globals.Theme.PrimaryContainer;
      btnAdd.ForeColor = Globals.Theme.OnPrimaryContainer;

      btnRefresh.BackColor = Globals.Theme.PrimaryContainer;
      btnRefresh.ForeColor = Globals.Theme.OnPrimaryContainer;

      dgvUsers.BackgroundColor = Globals.Theme.SurfaceContainerHighest;
      dgvUsers.ForeColor = Globals.Theme.OnSurface;
      dgvUsers.GridColor = Globals.Theme.OnSurface;

      dgvUsers.DefaultCellStyle.BackColor = Globals.Theme.Surface;
      dgvUsers.DefaultCellStyle.ForeColor = Globals.Theme.OnSurface;
      dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Globals.Theme.Surface;
      dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Globals.Theme.OnSurface;
      dgvUsers.RowHeadersDefaultCellStyle.ForeColor = Globals.Theme.Surface;
      dgvUsers.RowHeadersDefaultCellStyle.ForeColor = Globals.Theme.OnSurface;

      contextMenuStrip1.BackColor = Globals.Theme.PrimaryContainer;
      contextMenuStrip1.ForeColor = Globals.Theme.OnPrimaryContainer;
      updateToolStripMenuItem.BackColor = Globals.Theme.PrimaryContainer;
      updateToolStripMenuItem.ForeColor = Globals.Theme.OnPrimaryContainer;
      updateToolStripMenuItem.Image = null;
    }

    private void _ChangeColumnsSize() {
      dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }

    private void btnAdd_Click(object sender, EventArgs e) {
      Form_AddUpdate_User addp = new Form_AddUpdate_User(-1);
      addp.ShowDialog();
    }

    private void updateToolStripMenuItem_Click(object sender, EventArgs e) {
      Form_AddUpdate_User updateP = new Form_AddUpdate_User((int)dgvUsers.CurrentRow.Cells[0].Value);
      updateP.ShowDialog();

      _LoadUsersData();
    }

    private void updateToolStripMenuItem_Click_1(object sender, EventArgs e) {
      Form_AddUpdate_User UpdateUser = new Form_AddUpdate_User((int)dgvUsers.CurrentRow.Cells[0].Value);
      UpdateUser.ShowDialog();
    }

    private void btnAdd_Click_1(object sender, EventArgs e) {
      Form_AddUpdate_User addUser = new Form_AddUpdate_User(-1);
      addUser.ShowDialog();
    }

    private void btnRefresh_Click_1(object sender, EventArgs e) {
      _LoadUsersData();
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
      int ID = (int)dgvUsers.CurrentRow.Cells[0].Value;

      if(ID == Globals.CurrentUser.ID) {
        MessageBox.Show("cannot delete this user, because its currently logged in");
        return;
      }

      if(MessageBox.Show("Are you sure you want to delete this User?",
        "User deletion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1)
        == DialogResult.Yes) {
        if(clsUser.DeleteUser(ID)) {
          MessageBox.Show("User Deleted successfully");
          _LoadUsersData();
        } else {
          MessageBox.Show("Error deleting this User");
        }
      }

    }

  }
}
