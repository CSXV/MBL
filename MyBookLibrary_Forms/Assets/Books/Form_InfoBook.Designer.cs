namespace MyBookLibrary_Forms.Assets.Books {
  partial class Form_InfoBook {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.txDescription = new System.Windows.Forms.TextBox();
      this.lbDescription = new System.Windows.Forms.Label();
      this.lbTopic = new System.Windows.Forms.Label();
      this.lbTags = new System.Windows.Forms.Label();
      this.lbPages = new System.Windows.Forms.Label();
      this.lbCover = new System.Windows.Forms.Label();
      this.lbLanguage = new System.Windows.Forms.Label();
      this.lbPublicationDate = new System.Windows.Forms.Label();
      this.lbEdition = new System.Windows.Forms.Label();
      this.lbISBN = new System.Windows.Forms.Label();
      this.lbSeries = new System.Windows.Forms.Label();
      this.lbTitle = new System.Windows.Forms.Label();
      this.lbIDtext = new System.Windows.Forms.Label();
      this.lbID = new System.Windows.Forms.Label();
      this.lbAuthor = new System.Windows.Forms.Label();
      this.lbPublisher = new System.Windows.Forms.Label();
      this.lbPublisherText = new System.Windows.Forms.Label();
      this.lbAuthorText = new System.Windows.Forms.Label();
      this.lbTitleText = new System.Windows.Forms.Label();
      this.lbSeriesText = new System.Windows.Forms.Label();
      this.lbISBNText = new System.Windows.Forms.Label();
      this.lbPublicationDateText = new System.Windows.Forms.Label();
      this.lbLanguageText = new System.Windows.Forms.Label();
      this.lbTagsText = new System.Windows.Forms.Label();
      this.lbTopicText = new System.Windows.Forms.Label();
      this.lbEditionText = new System.Windows.Forms.Label();
      this.lbPagesText = new System.Windows.Forms.Label();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.pbCover = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
      this.SuspendLayout();
      // 
      // txDescription
      // 
      this.txDescription.Font = new System.Drawing.Font("Roboto", 10F);
      this.txDescription.Location = new System.Drawing.Point(482, 83);
      this.txDescription.Multiline = true;
      this.txDescription.Name = "txDescription";
      this.txDescription.ReadOnly = true;
      this.txDescription.Size = new System.Drawing.Size(230, 389);
      this.txDescription.TabIndex = 2;
      // 
      // lbDescription
      // 
      this.lbDescription.AutoSize = true;
      this.lbDescription.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbDescription.Location = new System.Drawing.Point(477, 52);
      this.lbDescription.Name = "lbDescription";
      this.lbDescription.Size = new System.Drawing.Size(122, 27);
      this.lbDescription.TabIndex = 154;
      this.lbDescription.Text = "Description";
      // 
      // lbTopic
      // 
      this.lbTopic.AutoSize = true;
      this.lbTopic.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbTopic.Location = new System.Drawing.Point(14, 252);
      this.lbTopic.Name = "lbTopic";
      this.lbTopic.Size = new System.Drawing.Size(66, 27);
      this.lbTopic.TabIndex = 153;
      this.lbTopic.Text = "Topic";
      // 
      // lbTags
      // 
      this.lbTags.AutoSize = true;
      this.lbTags.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbTags.Location = new System.Drawing.Point(14, 291);
      this.lbTags.Name = "lbTags";
      this.lbTags.Size = new System.Drawing.Size(59, 27);
      this.lbTags.TabIndex = 152;
      this.lbTags.Text = "Tags";
      // 
      // lbPages
      // 
      this.lbPages.AutoSize = true;
      this.lbPages.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbPages.Location = new System.Drawing.Point(14, 369);
      this.lbPages.Name = "lbPages";
      this.lbPages.Size = new System.Drawing.Size(73, 27);
      this.lbPages.TabIndex = 151;
      this.lbPages.Text = "Pages";
      // 
      // lbCover
      // 
      this.lbCover.AutoSize = true;
      this.lbCover.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbCover.Location = new System.Drawing.Point(713, 51);
      this.lbCover.Name = "lbCover";
      this.lbCover.Size = new System.Drawing.Size(69, 27);
      this.lbCover.TabIndex = 150;
      this.lbCover.Text = "Cover";
      // 
      // lbLanguage
      // 
      this.lbLanguage.AutoSize = true;
      this.lbLanguage.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbLanguage.Location = new System.Drawing.Point(14, 213);
      this.lbLanguage.Name = "lbLanguage";
      this.lbLanguage.Size = new System.Drawing.Size(108, 27);
      this.lbLanguage.TabIndex = 149;
      this.lbLanguage.Text = "Language";
      // 
      // lbPublicationDate
      // 
      this.lbPublicationDate.AutoSize = true;
      this.lbPublicationDate.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbPublicationDate.Location = new System.Drawing.Point(14, 330);
      this.lbPublicationDate.Name = "lbPublicationDate";
      this.lbPublicationDate.Size = new System.Drawing.Size(171, 27);
      this.lbPublicationDate.TabIndex = 148;
      this.lbPublicationDate.Text = "Publication Date";
      // 
      // lbEdition
      // 
      this.lbEdition.AutoSize = true;
      this.lbEdition.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbEdition.Location = new System.Drawing.Point(14, 408);
      this.lbEdition.Name = "lbEdition";
      this.lbEdition.Size = new System.Drawing.Size(79, 27);
      this.lbEdition.TabIndex = 147;
      this.lbEdition.Text = "Edition";
      // 
      // lbISBN
      // 
      this.lbISBN.AutoSize = true;
      this.lbISBN.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbISBN.Location = new System.Drawing.Point(14, 135);
      this.lbISBN.Name = "lbISBN";
      this.lbISBN.Size = new System.Drawing.Size(61, 27);
      this.lbISBN.TabIndex = 146;
      this.lbISBN.Text = "ISBN";
      // 
      // lbSeries
      // 
      this.lbSeries.AutoSize = true;
      this.lbSeries.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbSeries.Location = new System.Drawing.Point(14, 174);
      this.lbSeries.Name = "lbSeries";
      this.lbSeries.Size = new System.Drawing.Size(72, 27);
      this.lbSeries.TabIndex = 145;
      this.lbSeries.Text = "Series";
      // 
      // lbTitle
      // 
      this.lbTitle.AutoSize = true;
      this.lbTitle.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbTitle.Location = new System.Drawing.Point(14, 18);
      this.lbTitle.Name = "lbTitle";
      this.lbTitle.Size = new System.Drawing.Size(54, 27);
      this.lbTitle.TabIndex = 144;
      this.lbTitle.Text = "Title";
      // 
      // lbIDtext
      // 
      this.lbIDtext.AutoSize = true;
      this.lbIDtext.Location = new System.Drawing.Point(191, 445);
      this.lbIDtext.Name = "lbIDtext";
      this.lbIDtext.Size = new System.Drawing.Size(51, 27);
      this.lbIDtext.TabIndex = 143;
      this.lbIDtext.Text = "N/A";
      // 
      // lbID
      // 
      this.lbID.AutoSize = true;
      this.lbID.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbID.Location = new System.Drawing.Point(14, 445);
      this.lbID.Name = "lbID";
      this.lbID.Size = new System.Drawing.Size(32, 27);
      this.lbID.TabIndex = 142;
      this.lbID.Text = "ID";
      // 
      // lbAuthor
      // 
      this.lbAuthor.AutoSize = true;
      this.lbAuthor.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbAuthor.Location = new System.Drawing.Point(14, 57);
      this.lbAuthor.Name = "lbAuthor";
      this.lbAuthor.Size = new System.Drawing.Size(77, 27);
      this.lbAuthor.TabIndex = 155;
      this.lbAuthor.Text = "Author";
      // 
      // lbPublisher
      // 
      this.lbPublisher.AutoSize = true;
      this.lbPublisher.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbPublisher.Location = new System.Drawing.Point(14, 96);
      this.lbPublisher.Name = "lbPublisher";
      this.lbPublisher.Size = new System.Drawing.Size(102, 27);
      this.lbPublisher.TabIndex = 141;
      this.lbPublisher.Text = "Publisher";
      // 
      // lbPublisherText
      // 
      this.lbPublisherText.AutoSize = true;
      this.lbPublisherText.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbPublisherText.Location = new System.Drawing.Point(191, 96);
      this.lbPublisherText.Name = "lbPublisherText";
      this.lbPublisherText.Size = new System.Drawing.Size(51, 27);
      this.lbPublisherText.TabIndex = 141;
      this.lbPublisherText.Text = "N/A";
      // 
      // lbAuthorText
      // 
      this.lbAuthorText.AutoSize = true;
      this.lbAuthorText.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbAuthorText.Location = new System.Drawing.Point(191, 57);
      this.lbAuthorText.Name = "lbAuthorText";
      this.lbAuthorText.Size = new System.Drawing.Size(51, 27);
      this.lbAuthorText.TabIndex = 155;
      this.lbAuthorText.Text = "N/A";
      // 
      // lbTitleText
      // 
      this.lbTitleText.AutoSize = true;
      this.lbTitleText.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbTitleText.Location = new System.Drawing.Point(191, 18);
      this.lbTitleText.Name = "lbTitleText";
      this.lbTitleText.Size = new System.Drawing.Size(51, 27);
      this.lbTitleText.TabIndex = 144;
      this.lbTitleText.Text = "N/A";
      // 
      // lbSeriesText
      // 
      this.lbSeriesText.AutoSize = true;
      this.lbSeriesText.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbSeriesText.Location = new System.Drawing.Point(191, 174);
      this.lbSeriesText.Name = "lbSeriesText";
      this.lbSeriesText.Size = new System.Drawing.Size(51, 27);
      this.lbSeriesText.TabIndex = 145;
      this.lbSeriesText.Text = "N/A";
      // 
      // lbISBNText
      // 
      this.lbISBNText.AutoSize = true;
      this.lbISBNText.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbISBNText.Location = new System.Drawing.Point(191, 135);
      this.lbISBNText.Name = "lbISBNText";
      this.lbISBNText.Size = new System.Drawing.Size(51, 27);
      this.lbISBNText.TabIndex = 146;
      this.lbISBNText.Text = "N/A";
      // 
      // lbPublicationDateText
      // 
      this.lbPublicationDateText.AutoSize = true;
      this.lbPublicationDateText.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbPublicationDateText.Location = new System.Drawing.Point(191, 330);
      this.lbPublicationDateText.Name = "lbPublicationDateText";
      this.lbPublicationDateText.Size = new System.Drawing.Size(51, 27);
      this.lbPublicationDateText.TabIndex = 148;
      this.lbPublicationDateText.Text = "N/A";
      // 
      // lbLanguageText
      // 
      this.lbLanguageText.AutoSize = true;
      this.lbLanguageText.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbLanguageText.Location = new System.Drawing.Point(191, 213);
      this.lbLanguageText.Name = "lbLanguageText";
      this.lbLanguageText.Size = new System.Drawing.Size(51, 27);
      this.lbLanguageText.TabIndex = 149;
      this.lbLanguageText.Text = "N/A";
      // 
      // lbTagsText
      // 
      this.lbTagsText.AutoSize = true;
      this.lbTagsText.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbTagsText.Location = new System.Drawing.Point(191, 291);
      this.lbTagsText.Name = "lbTagsText";
      this.lbTagsText.Size = new System.Drawing.Size(51, 27);
      this.lbTagsText.TabIndex = 152;
      this.lbTagsText.Text = "N/A";
      // 
      // lbTopicText
      // 
      this.lbTopicText.AutoSize = true;
      this.lbTopicText.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbTopicText.Location = new System.Drawing.Point(191, 252);
      this.lbTopicText.Name = "lbTopicText";
      this.lbTopicText.Size = new System.Drawing.Size(51, 27);
      this.lbTopicText.TabIndex = 153;
      this.lbTopicText.Text = "N/A";
      // 
      // lbEditionText
      // 
      this.lbEditionText.AutoSize = true;
      this.lbEditionText.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbEditionText.Location = new System.Drawing.Point(191, 408);
      this.lbEditionText.Name = "lbEditionText";
      this.lbEditionText.Size = new System.Drawing.Size(51, 27);
      this.lbEditionText.TabIndex = 147;
      this.lbEditionText.Text = "N/A";
      // 
      // lbPagesText
      // 
      this.lbPagesText.AutoSize = true;
      this.lbPagesText.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbPagesText.Location = new System.Drawing.Point(191, 369);
      this.lbPagesText.Name = "lbPagesText";
      this.lbPagesText.Size = new System.Drawing.Size(51, 27);
      this.lbPagesText.TabIndex = 151;
      this.lbPagesText.Text = "N/A";
      // 
      // btnExit
      // 
      this.btnExit.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.close_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnExit.Location = new System.Drawing.Point(420, 416);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(56, 56);
      this.btnExit.TabIndex = 10;
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.edit_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnEdit.Location = new System.Drawing.Point(358, 416);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(56, 56);
      this.btnEdit.TabIndex = 20;
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // pbCover
      // 
      this.pbCover.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.no_photography_40dp_EADDFF_FILL0_wght400_GRAD0_opsz40;
      this.pbCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pbCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbCover.Location = new System.Drawing.Point(718, 82);
      this.pbCover.Name = "pbCover";
      this.pbCover.Size = new System.Drawing.Size(314, 390);
      this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbCover.TabIndex = 156;
      this.pbCover.TabStop = false;
      // 
      // Form_InfoBook
      // 
      this.AcceptButton = this.btnExit;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1042, 480);
      this.Controls.Add(this.lbPagesText);
      this.Controls.Add(this.lbEditionText);
      this.Controls.Add(this.lbTopicText);
      this.Controls.Add(this.lbTagsText);
      this.Controls.Add(this.lbLanguageText);
      this.Controls.Add(this.lbPublicationDateText);
      this.Controls.Add(this.lbISBNText);
      this.Controls.Add(this.lbSeriesText);
      this.Controls.Add(this.lbTitleText);
      this.Controls.Add(this.lbAuthorText);
      this.Controls.Add(this.lbPublisherText);
      this.Controls.Add(this.btnEdit);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.txDescription);
      this.Controls.Add(this.pbCover);
      this.Controls.Add(this.lbDescription);
      this.Controls.Add(this.lbTopic);
      this.Controls.Add(this.lbTags);
      this.Controls.Add(this.lbPages);
      this.Controls.Add(this.lbCover);
      this.Controls.Add(this.lbLanguage);
      this.Controls.Add(this.lbPublicationDate);
      this.Controls.Add(this.lbEdition);
      this.Controls.Add(this.lbISBN);
      this.Controls.Add(this.lbSeries);
      this.Controls.Add(this.lbTitle);
      this.Controls.Add(this.lbIDtext);
      this.Controls.Add(this.lbID);
      this.Controls.Add(this.lbAuthor);
      this.Controls.Add(this.lbPublisher);
      this.Font = new System.Drawing.Font("Roboto", 16F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Form_InfoBook";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Book Info";
      this.Load += new System.EventHandler(this.Form_InfoBook_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.TextBox txDescription;
    private System.Windows.Forms.PictureBox pbCover;
    private System.Windows.Forms.Label lbDescription;
    private System.Windows.Forms.Label lbTopic;
    private System.Windows.Forms.Label lbTags;
    private System.Windows.Forms.Label lbPages;
    private System.Windows.Forms.Label lbCover;
    private System.Windows.Forms.Label lbLanguage;
    private System.Windows.Forms.Label lbPublicationDate;
    private System.Windows.Forms.Label lbEdition;
    private System.Windows.Forms.Label lbISBN;
    private System.Windows.Forms.Label lbSeries;
    private System.Windows.Forms.Label lbTitle;
    private System.Windows.Forms.Label lbIDtext;
    private System.Windows.Forms.Label lbID;
    private System.Windows.Forms.Label lbAuthor;
    private System.Windows.Forms.Label lbPublisher;
    private System.Windows.Forms.Label lbPublisherText;
    private System.Windows.Forms.Label lbAuthorText;
    private System.Windows.Forms.Label lbTitleText;
    private System.Windows.Forms.Label lbSeriesText;
    private System.Windows.Forms.Label lbISBNText;
    private System.Windows.Forms.Label lbPublicationDateText;
    private System.Windows.Forms.Label lbLanguageText;
    private System.Windows.Forms.Label lbTagsText;
    private System.Windows.Forms.Label lbTopicText;
    private System.Windows.Forms.Label lbEditionText;
    private System.Windows.Forms.Label lbPagesText;
    private System.Windows.Forms.Button btnEdit;
  }
}