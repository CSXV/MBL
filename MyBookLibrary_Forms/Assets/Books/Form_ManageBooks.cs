using MyBookLibrary_BusinessLayer;
using System;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets.Books {
  public partial class Form_ManageBooks : Form {
    private BindingSource _source = new BindingSource();

    public Form_ManageBooks() {
      InitializeComponent();
    }

    private void Form_ManageBooks_Load(object sender, EventArgs e) {
      _LoadBooksData();
      _ChangeColors();
      _ChangeColumnsSize();
    }

    private void _ChangeColumnsSize() {
      dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }

    private void _LoadBooksData() {
      _source.DataSource = clsBook.GetAllBooks();
      dgvBooks.DataSource = _source;
    }

    private void btnRefresh_Click(object sender, EventArgs e) {
      _LoadBooksData();
    }

    private void _ChangeColors() {
      this.BackColor = Globals.Theme.Surface;

      lbAuthors.BackColor = Globals.Theme.Surface;
      lbAuthors.ForeColor = Globals.Theme.OnSurface;

      btnAdd.BackColor = Globals.Theme.PrimaryContainer;
      btnAdd.ForeColor = Globals.Theme.OnPrimaryContainer;

      btnRefresh.BackColor = Globals.Theme.PrimaryContainer;
      btnRefresh.ForeColor = Globals.Theme.OnPrimaryContainer;

      dgvBooks.BackgroundColor = Globals.Theme.SurfaceContainerHighest;
      dgvBooks.ForeColor = Globals.Theme.OnSurface;
      dgvBooks.GridColor = Globals.Theme.OnSurface;

      dgvBooks.DefaultCellStyle.BackColor = Globals.Theme.Surface;
      dgvBooks.DefaultCellStyle.ForeColor = Globals.Theme.OnSurface;
      dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = Globals.Theme.Surface;
      dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = Globals.Theme.OnSurface;
      dgvBooks.RowHeadersDefaultCellStyle.ForeColor = Globals.Theme.Surface;
      dgvBooks.RowHeadersDefaultCellStyle.ForeColor = Globals.Theme.OnSurface;

      contextMenuStrip1.BackColor = Globals.Theme.PrimaryContainer;
      contextMenuStrip1.ForeColor = Globals.Theme.OnPrimaryContainer;
      updateToolStripMenuItem.BackColor = Globals.Theme.PrimaryContainer;
      updateToolStripMenuItem.ForeColor = Globals.Theme.OnPrimaryContainer;
      updateToolStripMenuItem.Image = null;
    }

    private void btnAdd_Click(object sender, EventArgs e) {
      Form_Add_Update_Book updateBook = new Form_Add_Update_Book(-1);
      updateBook.ShowDialog();

      _LoadBooksData();
    }

    private void updateToolStripMenuItem_Click(object sender, EventArgs e) {
      Form_Add_Update_Book updateBook = new Form_Add_Update_Book((int)dgvBooks.CurrentRow.Cells[0].Value);
      updateBook.ShowDialog();

      _LoadBooksData();
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
      int ID = (int)dgvBooks.CurrentRow.Cells[0].Value;

      if(MessageBox.Show("Are you sure you want to delete this book?",
        "Book deletion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1)
        == DialogResult.Yes) {
        if(clsBook.DeleteABook(ID)) {
          MessageBox.Show("Book Deleted successfully");
          _LoadBooksData();
        } else {
          MessageBox.Show("Error deleting this book");
        }
      }

    }

    private void infoToolStripMenuItem_Click(object sender, EventArgs e) {
      Form_InfoBook infoBook = new Form_InfoBook((int)dgvBooks.CurrentRow.Cells[0].Value);
      infoBook.ShowDialog();
    }
  }
}
