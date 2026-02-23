using MyBookLibrary_BusinessLayer;
using System;
using System.IO;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets.Books {
  public partial class Form_Add_Update_Book : Form {
    private enum enMode { AddNew = 0, Update = 1 }
    private enMode _Mode;

    private int _BookID;
    private clsBook _Book;

    public Form_Add_Update_Book(int BookID) {
      InitializeComponent();
      _BookID = BookID;
      _Mode = (_BookID != -1) ? enMode.Update : enMode.AddNew;
    }

    private void Form_Add_Update_Book_Load(object sender, EventArgs e) {
      _LoadData();
      _UpdateColors();
    }

    private void _UpdateColors() {
      this.BackColor = Globals.Theme.Surface;
      btnAddCover.BackColor = Globals.Theme.SecondaryContainer;
      btnAddCover.ForeColor = Globals.Theme.OnSecondaryContainer;

      btnRemoveCover.BackColor = Globals.Theme.SecondaryContainer;
      btnRemoveCover.ForeColor = Globals.Theme.OnSecondaryContainer;

      btnSave.BackColor = Globals.Theme.PrimaryContainer;
      btnSave.ForeColor = Globals.Theme.OnPrimaryContainer;

      btnSearchAuthor.BackColor = Globals.Theme.PrimaryContainer;
      btnSearchAuthor.ForeColor = Globals.Theme.OnPrimaryContainer;

      btnSearchPublisher.BackColor = Globals.Theme.PrimaryContainer;
      btnSearchPublisher.ForeColor = Globals.Theme.OnPrimaryContainer;

      txTitle.BackColor = Globals.Theme.SurfaceContainerHighest;
      txTitle.ForeColor = Globals.Theme.OnSurface;
      lbTitle.BackColor = Globals.Theme.Surface;
      lbTitle.ForeColor = Globals.Theme.OnSurface;

      txPublisher.BackColor = Globals.Theme.SurfaceContainerHighest;
      txPublisher.ForeColor = Globals.Theme.OnSurface;
      lbPublisher.BackColor = Globals.Theme.Surface;
      lbPublisherText.BackColor = Globals.Theme.Surface;
      lbPublisher.ForeColor = Globals.Theme.OnSurface;
      lbPublisherText.ForeColor = Globals.Theme.OnSurface;

      txAuthor.BackColor = Globals.Theme.SurfaceContainerHighest;
      txAuthor.ForeColor = Globals.Theme.OnSurface;
      lbAuthor.BackColor = Globals.Theme.Surface;
      lbAuthorText.BackColor = Globals.Theme.Surface;
      lbAuthor.ForeColor = Globals.Theme.OnSurface;
      lbAuthorText.ForeColor = Globals.Theme.OnSurface;

      txISBN.BackColor = Globals.Theme.SurfaceContainerHighest;
      txISBN.ForeColor = Globals.Theme.OnSurface;
      lbISBN.BackColor = Globals.Theme.Surface;
      lbISBN.ForeColor = Globals.Theme.OnSurface;

      txEdition.BackColor = Globals.Theme.SurfaceContainerHighest;
      txEdition.ForeColor = Globals.Theme.OnSurface;
      lbEdition.BackColor = Globals.Theme.Surface;
      lbEdition.ForeColor = Globals.Theme.OnSurface;

      txPublicationDate.BackColor = Globals.Theme.SurfaceContainerHighest;
      txPublicationDate.ForeColor = Globals.Theme.OnSurface;
      lbPublicationDate.BackColor = Globals.Theme.Surface;
      lbPublicationDate.ForeColor = Globals.Theme.OnSurface;

      txLanguage.BackColor = Globals.Theme.SurfaceContainerHighest;
      txLanguage.ForeColor = Globals.Theme.OnSurface;
      lbLanguage.BackColor = Globals.Theme.Surface;
      lbLanguage.ForeColor = Globals.Theme.OnSurface;

      txTopic.BackColor = Globals.Theme.SurfaceContainerHighest;
      txTopic.ForeColor = Globals.Theme.OnSurface;
      lbTopic.BackColor = Globals.Theme.Surface;
      lbTopic.ForeColor = Globals.Theme.OnSurface;

      txPages.BackColor = Globals.Theme.SurfaceContainerHighest;
      txPages.ForeColor = Globals.Theme.OnSurface;
      lbPages.BackColor = Globals.Theme.Surface;
      lbPages.ForeColor = Globals.Theme.OnSurface;

      txTags.BackColor = Globals.Theme.SurfaceContainerHighest;
      txTags.ForeColor = Globals.Theme.OnSurface;
      lbTags.BackColor = Globals.Theme.Surface;
      lbTags.ForeColor = Globals.Theme.OnSurface;

      txDescription.BackColor = Globals.Theme.SurfaceContainerHighest;
      txDescription.ForeColor = Globals.Theme.OnSurface;
      lbDescription.BackColor = Globals.Theme.Surface;
      lbDescription.ForeColor = Globals.Theme.OnSurface;

      lbIDtext.BackColor = Globals.Theme.Surface;
      lbIDtext.ForeColor = Globals.Theme.OnSurface;
      lbID.BackColor = Globals.Theme.Surface;
      lbID.ForeColor = Globals.Theme.OnSurface;

      txSeries.BackColor = Globals.Theme.SurfaceContainerHighest;
      txSeries.ForeColor = Globals.Theme.OnSurface;
      lbSeries.BackColor = Globals.Theme.Surface;
      lbSeries.ForeColor = Globals.Theme.OnSurface;

      lbCover.BackColor = Globals.Theme.Surface;
      lbCover.ForeColor = Globals.Theme.OnSurface;
      pbCover.BackColor = Globals.Theme.Surface;
    }

    public void _LoadData() {
      if(_Mode == enMode.AddNew) {
        btnRemoveCover.Visible = false;
        _Book = new clsBook();
        return;
      }

      _Book = clsBook.Find(_BookID);

      lbIDtext.Text = _Book.ID.ToString();
      txAuthor.Text = _Book.AuthorID.ToString();
      txPublisher.Text = _Book.PublisherID.ToString();
      txPages.Text = _Book.Pages.ToString();
      txEdition.Text = _Book.Edition.ToString();
      txPublicationDate.Text = _Book.PublicationDate.ToString();
      txDescription.Text = _Book.Description;
      txTitle.Text = _Book.Title;
      txTags.Text = _Book.Tags;
      txTopic.Text = _Book.Topic;
      txSeries.Text = _Book.Series;
      txLanguage.Text = _Book.Language;
      txISBN.Text = _Book.ISBN;
      pbCover.ImageLocation = _Book.Cover;
      lbAuthorText.Text = _Book.AuthorInfo.FullName();
      lbPublisherText.Text = _Book.PublisherInfo.Name;
    }

    private void btnAddCover_Click(object sender, EventArgs e) {
      openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*bmp;*.gif";
      openFileDialog1.FilterIndex = 1;
      openFileDialog1.RestoreDirectory = true;

      if(openFileDialog1.ShowDialog() == DialogResult.OK) {
        string selectedFilePath = openFileDialog1.FileName;
        string DestFolderPath = @"C:\MyBookLibrary\Images";
        string newFileName =
            Guid.NewGuid().ToString() + Path.GetExtension(selectedFilePath);
        string DestFilePath = Path.Combine(DestFolderPath, newFileName);

        File.Copy(selectedFilePath, DestFilePath);

        pbCover.Load(DestFilePath);
        btnRemoveCover.Visible = true;
      }
    }

    private void btnRemoveCover_Click(object sender, EventArgs e) {
      pbCover.Image = null;
      btnRemoveCover.Visible = false;
    }

    private void btnSave_Click(object sender, EventArgs e) {
      string selectedFilePath = _Book.Cover;

      _Book.PublisherID = Convert.ToInt32(txPublisher.Text);
      _Book.AuthorID = Convert.ToInt16(txAuthor.Text);
      _Book.Tags = txTags.Text;
      _Book.Topic = txTopic.Text;
      _Book.Title = txTitle.Text;
      _Book.ISBN = txISBN.Text;
      _Book.Language = txLanguage.Text;
      _Book.Pages = Convert.ToInt32(txPages.Text);
      _Book.Edition = Convert.ToByte(txEdition.Text);
      _Book.PublicationDate = DateTime.Parse(txPublicationDate.Text.Trim());

      if(txSeries.Text != null) {
        _Book.Series = txSeries.Text;
      }
      if(txDescription.Text != null) {
        _Book.Description = txDescription.Text;
      }
      if(pbCover.ImageLocation != null) {
        _Book.Cover = pbCover.ImageLocation;
      }

      if(_Book.Save()) {
        /*if(_Book.Cover != selectedFilePath) {
          File.Delete(selectedFilePath);
        }*/

        MessageBox.Show("Book saved successfully");
      } else {
        MessageBox.Show("Error saving Book");
      }

      _Mode = enMode.Update;
      lbIDtext.Text = _Book.ID.ToString();

    }

    private void txPublicationDate_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      DateTime pd;
      bool isValidDate = DateTime.TryParse(txPublicationDate.Text.Trim(), out pd);

      if(!isValidDate) {
        e.Cancel = true;
        errorProvider1.SetError(txPublicationDate, "Date is not valid");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txPublicationDate, "");
      }
    }

    private void txPages_KeyPress(object sender, KeyPressEventArgs e) {
      if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private void txEdition_KeyPress(object sender, KeyPressEventArgs e) {
      if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private void btnSearchAuthor_Click(object sender, EventArgs e) {
      clsAuthor author = clsAuthor.Find(Convert.ToInt32(txAuthor.Text.Trim()));

      if(author == null) {
        MessageBox.Show("Author not found",
          "Error",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error,
          MessageBoxDefaultButton.Button1);
        return;
      }

      lbAuthorText.Text = author.FullName();
    }

    private void btnSearchPublisher_Click(object sender, EventArgs e) {
      clsPublisher publisher = clsPublisher.Find(Convert.ToInt32(txPublisher.Text.Trim()));

      if(publisher == null) {
        MessageBox.Show("Publisher not found",
          "Error",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error,
          MessageBoxDefaultButton.Button1);
        return;
      }

      lbPublisherText.Text = publisher.Name;
    }

    private void txTitle_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if(String.IsNullOrEmpty(txTitle.Text)) {
        e.Cancel = true;
        errorProvider1.SetError(txTitle, "title cannot be empty");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txTitle, "");
      }
    }

    private void txAuthor_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if(String.IsNullOrEmpty(txAuthor.Text)) {
        e.Cancel = true;
        errorProvider1.SetError(txAuthor, "Author ID cannot be empty");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txAuthor, "");
      }
    }

    private void txAuthor_KeyPress(object sender, KeyPressEventArgs e) {
      if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private void txPublisher_KeyPress(object sender, KeyPressEventArgs e) {
      if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private void txPublisher_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if(String.IsNullOrEmpty(txPublisher.Text)) {
        e.Cancel = true;
        errorProvider1.SetError(txPublisher, "Publisher ID cannot be empty");
      } else {
        e.Cancel = false;
        errorProvider1.SetError(txPublisher, "");
      }
    }
  }
}
