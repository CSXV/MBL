using MyBookLibrary_BusinessLayer;
using System;
using System.Windows.Forms;

namespace MyBookLibrary_Forms.Assets.Books {
  public partial class Form_InfoBook : Form {
    private int _BookID;
    private clsBook _Book;

    public Form_InfoBook(int BookID) {
      InitializeComponent();
      _BookID = BookID;
    }

    private void Form_InfoBook_Load(object sender, EventArgs e) {
      _UpdateColors();
      _LoadData();
    }

    private void _UpdateColors() {
      this.BackColor = Globals.Theme.Surface;

      btnExit.BackColor = Globals.Theme.PrimaryContainer;
      btnExit.ForeColor = Globals.Theme.OnPrimaryContainer;

      btnEdit.BackColor = Globals.Theme.PrimaryContainer;
      btnEdit.ForeColor = Globals.Theme.OnPrimaryContainer;

      lbTitle.BackColor = Globals.Theme.Surface;
      lbTitle.ForeColor = Globals.Theme.OnSurface;
      lbTitleText.BackColor = Globals.Theme.Surface;
      lbTitleText.ForeColor = Globals.Theme.OnSurface;

      lbPublisher.BackColor = Globals.Theme.Surface;
      lbPublisher.ForeColor = Globals.Theme.OnSurface;
      lbPublisherText.BackColor = Globals.Theme.Surface;
      lbPublisherText.ForeColor = Globals.Theme.OnSurface;

      lbAuthor.BackColor = Globals.Theme.Surface;
      lbAuthor.ForeColor = Globals.Theme.OnSurface;
      lbAuthorText.BackColor = Globals.Theme.Surface;
      lbAuthorText.ForeColor = Globals.Theme.OnSurface;

      lbISBN.BackColor = Globals.Theme.Surface;
      lbISBN.ForeColor = Globals.Theme.OnSurface;
      lbISBNText.BackColor = Globals.Theme.Surface;
      lbISBNText.ForeColor = Globals.Theme.OnSurface;

      lbEdition.BackColor = Globals.Theme.Surface;
      lbEdition.ForeColor = Globals.Theme.OnSurface;
      lbEditionText.BackColor = Globals.Theme.Surface;
      lbEditionText.ForeColor = Globals.Theme.OnSurface;

      lbPublicationDate.BackColor = Globals.Theme.Surface;
      lbPublicationDate.ForeColor = Globals.Theme.OnSurface;
      lbPublicationDateText.BackColor = Globals.Theme.Surface;
      lbPublicationDateText.ForeColor = Globals.Theme.OnSurface;

      lbLanguage.BackColor = Globals.Theme.Surface;
      lbLanguage.ForeColor = Globals.Theme.OnSurface;
      lbLanguageText.BackColor = Globals.Theme.Surface;
      lbLanguageText.ForeColor = Globals.Theme.OnSurface;

      lbTopic.BackColor = Globals.Theme.Surface;
      lbTopic.ForeColor = Globals.Theme.OnSurface;
      lbTopicText.BackColor = Globals.Theme.Surface;
      lbTopicText.ForeColor = Globals.Theme.OnSurface;

      lbPages.BackColor = Globals.Theme.Surface;
      lbPages.ForeColor = Globals.Theme.OnSurface;
      lbPagesText.BackColor = Globals.Theme.Surface;
      lbPagesText.ForeColor = Globals.Theme.OnSurface;

      lbTags.BackColor = Globals.Theme.Surface;
      lbTags.ForeColor = Globals.Theme.OnSurface;
      lbTagsText.BackColor = Globals.Theme.Surface;
      lbTagsText.ForeColor = Globals.Theme.OnSurface;

      txDescription.BackColor = Globals.Theme.SurfaceContainerHighest;
      txDescription.ForeColor = Globals.Theme.OnSurface;
      lbDescription.BackColor = Globals.Theme.Surface;
      lbDescription.ForeColor = Globals.Theme.OnSurface;

      lbIDtext.BackColor = Globals.Theme.Surface;
      lbIDtext.ForeColor = Globals.Theme.OnSurface;
      lbID.BackColor = Globals.Theme.Surface;
      lbID.ForeColor = Globals.Theme.OnSurface;

      lbSeries.BackColor = Globals.Theme.Surface;
      lbSeries.ForeColor = Globals.Theme.OnSurface;
      lbSeriesText.BackColor = Globals.Theme.Surface;
      lbSeriesText.ForeColor = Globals.Theme.OnSurface;

      lbCover.BackColor = Globals.Theme.Surface;
      lbCover.ForeColor = Globals.Theme.OnSurface;
      pbCover.BackColor = Globals.Theme.Surface;
    }

    public void _LoadData() {
      _Book = clsBook.Find(_BookID);
      if(_Book == null) {
        MessageBox.Show("Book not found");
        return;
      }

      lbIDtext.Text = _Book.ID.ToString();
      lbAuthorText.Text = _Book.AuthorInfo.FullName();
      lbPublisherText.Text = _Book.PublisherInfo.Name;
      lbPagesText.Text = _Book.Pages.ToString();
      lbEditionText.Text = _Book.Edition.ToString();
      lbPublicationDateText.Text = _Book.PublicationDate.ToString();
      txDescription.Text = _Book.Description;
      lbTitleText.Text = _Book.Title;
      lbTagsText.Text = _Book.Tags;
      lbTopicText.Text = _Book.Topic;
      if(String.IsNullOrEmpty(_Book.Series)) {
        lbSeriesText.Text = "NULL";
      } else {
        lbSeriesText.Text = _Book.Series;
      }
      lbLanguageText.Text = _Book.Language;
      lbISBNText.Text = _Book.ISBN;
      pbCover.ImageLocation = _Book.Cover;
    }

    private void btnSave_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void btnEdit_Click(object sender, EventArgs e) {
      Form_Add_Update_Book updateBook = new Form_Add_Update_Book(_BookID);
      updateBook.ShowDialog();

      _LoadData();
    }
  }
}
