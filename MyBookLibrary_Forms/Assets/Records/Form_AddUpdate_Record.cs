using MyBookLibrary_BusinessLayer;
using System;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets.Records {
  public partial class Form_AddUpdate_Record : Form {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    private int _RecordID;
    private clsRecords _Record;

    public Form_AddUpdate_Record(int RecordID) {
      InitializeComponent();

      _RecordID = RecordID;
      _Mode = (_RecordID != -1) ? enMode.Update : enMode.AddNew;
    }

    private void Form_AddUpdate_Record_Load(object sender, EventArgs e) {
      _UpdateColors();
      _LoadData();
    }

    public void _LoadData() {
      if(_Mode == enMode.AddNew) {
        _Record = new clsRecords();
        lbUserIDText.Text = Globals.CurrentUser.ID.ToString() + ", " + Globals.CurrentUser.UserName;
        return;
      }

      _Record = clsRecords.Find(_RecordID);

      btnSearch.Enabled = false;
      txBookID.Enabled = false;
      lbID.Text = _Record.RecordID.ToString();
      lbUserIDText.Text = _Record.UserInfo.ID.ToString() + ", " + _Record.UserInfo.UserName;
      txBookID.Text = _Record.BookInfo.ID.ToString();
      lbBookTitleText.Text = _Record.BookInfo.Title;
      txRating.Text = _Record.Rating.ToString();
      txReadingDuration.Text = _Record.ReadingDuration.ToString();
      txFinishDate.Text = _Record.FinishDate.ToString();
      txComments.Text = _Record.Comments.ToString();
      cbState.SelectedIndex = _Record.State;
      cbDifficulty.SelectedIndex = _Record.Difficulty;
    }

    private void _UpdateColors() {
      this.BackColor = Globals.Theme.Surface;

      btnSave.BackColor = Globals.Theme.PrimaryContainer;
      btnSave.ForeColor = Globals.Theme.OnPrimaryContainer;
      btnSearch.BackColor = Globals.Theme.PrimaryContainer;
      btnSearch.ForeColor = Globals.Theme.OnPrimaryContainer;

      cbDifficulty.ForeColor = Globals.Theme.OnSurface;
      cbState.ForeColor = Globals.Theme.OnSurface;

      cbDifficulty.BackColor = Globals.Theme.SurfaceContainerHighest;
      cbState.BackColor = Globals.Theme.SurfaceContainerHighest;

      lbRating.BackColor = Globals.Theme.Surface;
      lbState.BackColor = Globals.Theme.Surface;
      lbDifficulty.BackColor = Globals.Theme.Surface;
      lbReadingDuration.BackColor = Globals.Theme.Surface;
      lbBookID.BackColor = Globals.Theme.Surface;
      lbRecordID.BackColor = Globals.Theme.Surface;
      lbID.BackColor = Globals.Theme.Surface;
      lbUser.BackColor = Globals.Theme.Surface;
      lbUserIDText.BackColor = Globals.Theme.Surface;
      lbComments.BackColor = Globals.Theme.Surface;
      lbFinishDate.BackColor = Globals.Theme.Surface;
      lbDays.BackColor = Globals.Theme.Surface;
      lbBookTitleText.BackColor = Globals.Theme.Surface;

      lbRating.ForeColor = Globals.Theme.OnSurface;
      lbState.ForeColor = Globals.Theme.OnSurface;
      lbDifficulty.ForeColor = Globals.Theme.OnSurface;
      lbReadingDuration.ForeColor = Globals.Theme.OnSurface;
      lbBookID.ForeColor = Globals.Theme.OnSurface;
      lbRecordID.ForeColor = Globals.Theme.OnSurface;
      lbID.ForeColor = Globals.Theme.OnSurface;
      lbUser.ForeColor = Globals.Theme.OnSurface;
      lbUserIDText.ForeColor = Globals.Theme.OnSurface;
      lbComments.ForeColor = Globals.Theme.OnSurface;
      lbFinishDate.ForeColor = Globals.Theme.OnSurface;
      lbDays.ForeColor = Globals.Theme.OnSurface;
      lbBookTitleText.ForeColor = Globals.Theme.OnSurface;

      txRating.BackColor = Globals.Theme.SurfaceContainerHighest;
      txBookID.BackColor = Globals.Theme.SurfaceContainerHighest;
      txReadingDuration.BackColor = Globals.Theme.SurfaceContainerHighest;
      txFinishDate.BackColor = Globals.Theme.SurfaceContainerHighest;
      txComments.BackColor = Globals.Theme.SurfaceContainerHighest;

      txRating.ForeColor = Globals.Theme.OnSurface;
      txBookID.ForeColor = Globals.Theme.OnSurface;
      txReadingDuration.ForeColor = Globals.Theme.OnSurface;
      txFinishDate.ForeColor = Globals.Theme.OnSurface;
      txComments.ForeColor = Globals.Theme.OnSurface;
    }

    private void btnSave_Click(object sender, EventArgs e) {
      _Record.BookID = Convert.ToInt32(txBookID.Text);

      if(txReadingDuration.Text != "") {
        _Record.ReadingDuration = Convert.ToInt32(txReadingDuration.Text);
      }
      if(txRating.Text != null) {
        _Record.Rating = Convert.ToByte(txRating.Text);
      }
      if(txComments.Text != "") {
        _Record.Comments = txComments.Text;
      }
      if(txFinishDate.Text != "") {
        _Record.FinishDate = DateTime.Parse(txFinishDate.Text);
      }

      _Record.UserID = Globals.CurrentUser.ID;
      _Record.State = (byte)cbState.SelectedIndex;
      _Record.Difficulty = (byte)cbDifficulty.SelectedIndex;

      /*switch(cbState.SelectedItem.ToString()) {
        case "Waiting":
        _Record.State = 0;
        break;
        case "Reading":
        _Record.State = 1;
        break;
        case "Finished":
        _Record.State = 2;
        break;
        case "Dropped":
        _Record.State = 3;
        break;
        default:
        _Record.State = 0;
        break;
      }*/

      /*switch(cbDifficulty.SelectedItem.ToString()) {
        case "Easy":
        _Record.Difficulty = 0;
        break;
        case "Medium":
        _Record.Difficulty = 2;
        break;
        case "Hard":
        _Record.Difficulty = 3;
        break;
        default:
        _Record.Difficulty = 0;
        break;
      }*/

      if(_Record.Save()) {
        MessageBox.Show("Record saved successfully");
      } else {
        MessageBox.Show("Error saving Record");
      }

      _Mode = enMode.Update;
      lbID.Text = _Record.RecordID.ToString();
    }

    private void txBookID_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if(String.IsNullOrEmpty(txBookID.Text.Trim())) {
        e.Cancel = true;
        errorProvider1.SetError(txBookID, "Book ID cannot be empty");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txBookID, "");
      }
    }

    private void txFinishDate_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      DateTime pd;
      bool isValidDate = DateTime.TryParse(txFinishDate.Text.Trim(), out pd);

      if(!isValidDate) {
        e.Cancel = true;
        errorProvider1.SetError(txFinishDate, "Date is not valid");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txFinishDate, "");
      }

      if(pd > DateTime.Now.AddMinutes(5)) {
        e.Cancel = true;
        errorProvider1.SetError(txFinishDate, "Date is out of range");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txFinishDate, "");
      }
      //
    }

    private void txReadingDuration_KeyPress(object sender, KeyPressEventArgs e) {
      if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private void txRating_KeyPress(object sender, KeyPressEventArgs e) {
      if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private void txBookID_KeyPress(object sender, KeyPressEventArgs e) {
      if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private void txRating_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      int value;

      if(!int.TryParse(txRating.Text, out value)) {
        e.Cancel = true;
        errorProvider1.SetError(txRating, "Please enter a valid integer.");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txRating, "");
      }

      if(value > 5) {
        e.Cancel = true;
        errorProvider1.SetError(txRating, "Please enter a value less than or equal to 5.");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txRating, "");
      }
    }

    private void btnSearch_Click(object sender, EventArgs e) {
      clsBook b = clsBook.Find(Convert.ToInt32(txBookID.Text.Trim()));

      if(b == null) {
        MessageBox.Show("Book not found",
          "Error",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error,
          MessageBoxDefaultButton.Button1);
        txBookID.Focus();
        return;
      }

      lbBookTitleText.Text = b.Title;
    }
  }
}
