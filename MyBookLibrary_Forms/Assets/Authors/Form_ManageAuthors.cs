using MyBookLibrary_BusinessLayer;
using System;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets.Authors {
  public partial class Form_ManageAuthors : Form {
    private BindingSource _source = new BindingSource();

    public Form_ManageAuthors() {
      InitializeComponent();
    }

    private void Form_ManageAuthors_Load(object sender, EventArgs e) {
      _ChangeColors();
      _LoadAuthorsData();
      _ChangeColumnsSize();
    }

    private void _LoadAuthorsData() {
      _source.DataSource = clsAuthor.GetAllAuthors();
      dgvAuthors.DataSource = _source;
    }

    private void _ChangeColors() {
      this.BackColor = Globals.Theme.Surface;

      lbAuthors.BackColor = Globals.Theme.Surface;
      lbAuthors.ForeColor = Globals.Theme.OnSurface;

      btnAdd.BackColor = Globals.Theme.PrimaryContainer;
      btnAdd.ForeColor = Globals.Theme.OnPrimaryContainer;

      btnRefresh.BackColor = Globals.Theme.PrimaryContainer;
      btnRefresh.ForeColor = Globals.Theme.OnPrimaryContainer;

      dgvAuthors.BackgroundColor = Globals.Theme.SurfaceContainerHighest;
      dgvAuthors.ForeColor = Globals.Theme.OnSurface;
      dgvAuthors.GridColor = Globals.Theme.OnSurface;

      dgvAuthors.DefaultCellStyle.BackColor = Globals.Theme.Surface;
      dgvAuthors.DefaultCellStyle.ForeColor = Globals.Theme.OnSurface;
      dgvAuthors.ColumnHeadersDefaultCellStyle.ForeColor = Globals.Theme.Surface;
      dgvAuthors.ColumnHeadersDefaultCellStyle.ForeColor = Globals.Theme.OnSurface;
      dgvAuthors.RowHeadersDefaultCellStyle.ForeColor = Globals.Theme.Surface;
      dgvAuthors.RowHeadersDefaultCellStyle.ForeColor = Globals.Theme.OnSurface;

      contextMenuStrip1.BackColor = Globals.Theme.PrimaryContainer;
      contextMenuStrip1.ForeColor = Globals.Theme.OnPrimaryContainer;
      updateToolStripMenuItem.BackColor = Globals.Theme.PrimaryContainer;
      updateToolStripMenuItem.ForeColor = Globals.Theme.OnPrimaryContainer;
      updateToolStripMenuItem.Image = null;
    }

    private void _ChangeColumnsSize() {
      dgvAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }

    private void btnAdd_Click(object sender, EventArgs e) {
      Form_AddUpdateAuthor addAuthor = new Form_AddUpdateAuthor(-1);
      addAuthor.ShowDialog();
    }

    private void updateToolStripMenuItem_Click(object sender, EventArgs e) {
      Form_AddUpdateAuthor updateAuthor = new Form_AddUpdateAuthor((int)dgvAuthors.CurrentRow.Cells[0].Value);
      updateAuthor.ShowDialog();

      _LoadAuthorsData();
    }

    private void btnRefresh_Click(object sender, EventArgs e) {
      _LoadAuthorsData();
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
      int ID = (int)dgvAuthors.CurrentRow.Cells[0].Value;

      if(MessageBox.Show("Are you sure you want to delete this Author?",
        "Author deletion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1)
        == DialogResult.Yes) {
        if(clsAuthor.DeleteAuthor(ID)) {
          MessageBox.Show("Author Deleted successfully");
          _LoadAuthorsData();
        } else {
          MessageBox.Show("Error deleting this Author");
        }
      }
    }
  }
}
