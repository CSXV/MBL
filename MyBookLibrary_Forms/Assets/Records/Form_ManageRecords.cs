using MyBookLibrary_BusinessLayer;
using System;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets.Records {
  public partial class Form_ManageRecords : Form {
    private BindingSource _source = new BindingSource();

    public Form_ManageRecords() {
      InitializeComponent();
    }

    private void Form_ManageRecords_Load(object sender, EventArgs e) {
      _ChangeColors();
      _LoadRecordsData();
      _ChangeColumnsSize();
    }

    private void _LoadRecordsData() {
      _source.DataSource = clsRecords.GetAllRecordsRecords(Globals.CurrentUser.ID);
      dgvRecords.DataSource = _source;
    }

    private void _ChangeColors() {
      this.BackColor = Globals.Theme.Surface;

      lbAuthors.BackColor = Globals.Theme.Surface;
      lbAuthors.ForeColor = Globals.Theme.OnSurface;

      btnAdd.BackColor = Globals.Theme.PrimaryContainer;
      btnAdd.ForeColor = Globals.Theme.OnPrimaryContainer;

      btnRefresh.BackColor = Globals.Theme.PrimaryContainer;
      btnRefresh.ForeColor = Globals.Theme.OnPrimaryContainer;

      dgvRecords.BackgroundColor = Globals.Theme.SurfaceContainerHighest;
      dgvRecords.ForeColor = Globals.Theme.OnSurface;
      dgvRecords.GridColor = Globals.Theme.OnSurface;

      dgvRecords.DefaultCellStyle.BackColor = Globals.Theme.Surface;
      dgvRecords.DefaultCellStyle.ForeColor = Globals.Theme.OnSurface;
      dgvRecords.ColumnHeadersDefaultCellStyle.ForeColor = Globals.Theme.Surface;
      dgvRecords.ColumnHeadersDefaultCellStyle.ForeColor = Globals.Theme.OnSurface;
      dgvRecords.RowHeadersDefaultCellStyle.ForeColor = Globals.Theme.Surface;
      dgvRecords.RowHeadersDefaultCellStyle.ForeColor = Globals.Theme.OnSurface;

      contextMenuStrip1.BackColor = Globals.Theme.PrimaryContainer;
      contextMenuStrip1.ForeColor = Globals.Theme.OnPrimaryContainer;
      updateToolStripMenuItem.BackColor = Globals.Theme.PrimaryContainer;
      updateToolStripMenuItem.ForeColor = Globals.Theme.OnPrimaryContainer;
      updateToolStripMenuItem.Image = null;
    }

    private void _ChangeColumnsSize() {
      dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
    }

    private void btnAdd_Click(object sender, EventArgs e) {
      Form_AddUpdate_Record addRecord = new Form_AddUpdate_Record(-1);
      addRecord.ShowDialog();

      _LoadRecordsData();
    }

    private void btnRefresh_Click(object sender, EventArgs e) {
      _LoadRecordsData();
    }

    private void updateToolStripMenuItem_Click(object sender, EventArgs e) {
      Form_AddUpdate_Record addRecord = new Form_AddUpdate_Record((int)dgvRecords.CurrentRow.Cells[0].Value);
      addRecord.ShowDialog();

      _LoadRecordsData();
    }

    private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
      int ID = (int)dgvRecords.CurrentRow.Cells[0].Value;

      if(MessageBox.Show("Are you sure you want to delete this Record?",
        "Record deletion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button1)
        == DialogResult.Yes) {
        if(clsRecords.DeleteARecord(ID)) {
          MessageBox.Show("Record Deleted successfully");
          _LoadRecordsData();
        } else {
          MessageBox.Show("Error deleting this Record");
        }
      }
    }
  }
}
