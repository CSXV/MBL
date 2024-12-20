using MyBookLibrary_BusinessLayer;
using System;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets.Publishers {
  public partial class Form_Manage_publishers : Form {
    private BindingSource _source = new BindingSource();

    public Form_Manage_publishers() {
      InitializeComponent();
    }

    private void Form_Manage_publishers_Load(object sender, EventArgs e) {
      _ChangeColors();
      _LoadPublishersData();
      _ChangeColumnsSize();
    }

    private void _LoadPublishersData() {
      _source.DataSource = clsPublisher.GetAllPublishers();
      dgvPublishers.DataSource = _source;
    }

    private void _ChangeColors() {
      this.BackColor = Globals.Theme.Surface;

      lbAuthors.BackColor = Globals.Theme.Surface;
      lbAuthors.ForeColor = Globals.Theme.OnSurface;

      btnAdd.BackColor = Globals.Theme.PrimaryContainer;
      btnAdd.ForeColor = Globals.Theme.OnPrimaryContainer;

      btnRefresh.BackColor = Globals.Theme.PrimaryContainer;
      btnRefresh.ForeColor = Globals.Theme.OnPrimaryContainer;

      dgvPublishers.BackgroundColor = Globals.Theme.SurfaceContainerHighest;
      dgvPublishers.ForeColor = Globals.Theme.OnSurface;
      dgvPublishers.GridColor = Globals.Theme.OnSurface;

      dgvPublishers.DefaultCellStyle.BackColor = Globals.Theme.Surface;
      dgvPublishers.DefaultCellStyle.ForeColor = Globals.Theme.OnSurface;
      dgvPublishers.ColumnHeadersDefaultCellStyle.ForeColor = Globals.Theme.Surface;
      dgvPublishers.ColumnHeadersDefaultCellStyle.ForeColor = Globals.Theme.OnSurface;
      dgvPublishers.RowHeadersDefaultCellStyle.ForeColor = Globals.Theme.Surface;
      dgvPublishers.RowHeadersDefaultCellStyle.ForeColor = Globals.Theme.OnSurface;

      contextMenuStrip1.BackColor = Globals.Theme.PrimaryContainer;
      contextMenuStrip1.ForeColor = Globals.Theme.OnPrimaryContainer;
      updateToolStripMenuItem.BackColor = Globals.Theme.PrimaryContainer;
      updateToolStripMenuItem.ForeColor = Globals.Theme.OnPrimaryContainer;
      updateToolStripMenuItem.Image = null;
    }

    private void _ChangeColumnsSize() {
      dgvPublishers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }

    private void btnAdd_Click(object sender, EventArgs e) {
      Form_AddUpdatePublisher addPublisher = new Form_AddUpdatePublisher(-1);
      addPublisher.ShowDialog();
    }

    private void btnRefresh_Click(object sender, EventArgs e) {
      _LoadPublishersData();
    }

    private void updateToolStripMenuItem_Click(object sender, EventArgs e) {
      Form_AddUpdatePublisher updatePublisher = new Form_AddUpdatePublisher((int)dgvPublishers.CurrentRow.Cells[0].Value);
      updatePublisher.ShowDialog();
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
      int ID = (int)dgvPublishers.CurrentRow.Cells[0].Value;

      if(MessageBox.Show("Are you sure you want to delete this Publisher?",
        "Publisher deletion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1)
        == DialogResult.Yes) {
        if(clsPublisher.DeletePublisher(ID)) {
          MessageBox.Show("Publisher Deleted successfully");
          _LoadPublishersData();
        } else {
          MessageBox.Show("Error deleting this Publisher");
        }
      }
    }
  }
}
