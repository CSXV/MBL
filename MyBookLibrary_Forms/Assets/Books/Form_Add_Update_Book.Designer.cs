namespace MyBookLibrary_Forms.Assets.Books {
  partial class Form_Add_Update_Book {
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
      this.components = new System.ComponentModel.Container();
      this.lbPublisher = new System.Windows.Forms.Label();
      this.lbAuthor = new System.Windows.Forms.Label();
      this.lbTitle = new System.Windows.Forms.Label();
      this.lbISBN = new System.Windows.Forms.Label();
      this.lbEdition = new System.Windows.Forms.Label();
      this.lbPublicationDate = new System.Windows.Forms.Label();
      this.lbLanguage = new System.Windows.Forms.Label();
      this.lbCover = new System.Windows.Forms.Label();
      this.lbPages = new System.Windows.Forms.Label();
      this.lbTags = new System.Windows.Forms.Label();
      this.lbTopic = new System.Windows.Forms.Label();
      this.lbDescription = new System.Windows.Forms.Label();
      this.txDescription = new System.Windows.Forms.TextBox();
      this.txPublisher = new System.Windows.Forms.TextBox();
      this.txAuthor = new System.Windows.Forms.TextBox();
      this.txTitle = new System.Windows.Forms.TextBox();
      this.txISBN = new System.Windows.Forms.TextBox();
      this.txEdition = new System.Windows.Forms.TextBox();
      this.txLanguage = new System.Windows.Forms.TextBox();
      this.txTopic = new System.Windows.Forms.TextBox();
      this.txPages = new System.Windows.Forms.TextBox();
      this.txTags = new System.Windows.Forms.TextBox();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.txPublicationDate = new System.Windows.Forms.TextBox();
      this.lbID = new System.Windows.Forms.Label();
      this.lbSeries = new System.Windows.Forms.Label();
      this.txSeries = new System.Windows.Forms.TextBox();
      this.lbIDtext = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnRemoveCover = new System.Windows.Forms.Button();
      this.btnAddCover = new System.Windows.Forms.Button();
      this.pbCover = new System.Windows.Forms.PictureBox();
      this.btnSearchAuthor = new System.Windows.Forms.Button();
      this.btnSearchPublisher = new System.Windows.Forms.Button();
      this.lbAuthorText = new System.Windows.Forms.Label();
      this.lbPublisherText = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbCover)).BeginInit();
      this.SuspendLayout();
      // 
      // lbPublisher
      // 
      this.lbPublisher.AutoSize = true;
      this.lbPublisher.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbPublisher.Location = new System.Drawing.Point(13, 97);
      this.lbPublisher.Name = "lbPublisher";
      this.lbPublisher.Size = new System.Drawing.Size(102, 27);
      this.lbPublisher.TabIndex = 1;
      this.lbPublisher.Text = "Publisher";
      // 
      // lbAuthor
      // 
      this.lbAuthor.AutoSize = true;
      this.lbAuthor.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbAuthor.Location = new System.Drawing.Point(13, 58);
      this.lbAuthor.Name = "lbAuthor";
      this.lbAuthor.Size = new System.Drawing.Size(77, 27);
      this.lbAuthor.TabIndex = 1;
      this.lbAuthor.Text = "Author";
      // 
      // lbTitle
      // 
      this.lbTitle.AutoSize = true;
      this.lbTitle.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbTitle.Location = new System.Drawing.Point(13, 19);
      this.lbTitle.Name = "lbTitle";
      this.lbTitle.Size = new System.Drawing.Size(54, 27);
      this.lbTitle.TabIndex = 1;
      this.lbTitle.Text = "Title";
      // 
      // lbISBN
      // 
      this.lbISBN.AutoSize = true;
      this.lbISBN.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbISBN.Location = new System.Drawing.Point(13, 136);
      this.lbISBN.Name = "lbISBN";
      this.lbISBN.Size = new System.Drawing.Size(61, 27);
      this.lbISBN.TabIndex = 1;
      this.lbISBN.Text = "ISBN";
      // 
      // lbEdition
      // 
      this.lbEdition.AutoSize = true;
      this.lbEdition.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbEdition.Location = new System.Drawing.Point(13, 409);
      this.lbEdition.Name = "lbEdition";
      this.lbEdition.Size = new System.Drawing.Size(79, 27);
      this.lbEdition.TabIndex = 1;
      this.lbEdition.Text = "Edition";
      // 
      // lbPublicationDate
      // 
      this.lbPublicationDate.AutoSize = true;
      this.lbPublicationDate.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbPublicationDate.Location = new System.Drawing.Point(13, 331);
      this.lbPublicationDate.Name = "lbPublicationDate";
      this.lbPublicationDate.Size = new System.Drawing.Size(171, 27);
      this.lbPublicationDate.TabIndex = 1;
      this.lbPublicationDate.Text = "Publication Date";
      // 
      // lbLanguage
      // 
      this.lbLanguage.AutoSize = true;
      this.lbLanguage.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbLanguage.Location = new System.Drawing.Point(13, 214);
      this.lbLanguage.Name = "lbLanguage";
      this.lbLanguage.Size = new System.Drawing.Size(108, 27);
      this.lbLanguage.TabIndex = 1;
      this.lbLanguage.Text = "Language";
      // 
      // lbCover
      // 
      this.lbCover.AutoSize = true;
      this.lbCover.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbCover.Location = new System.Drawing.Point(713, 135);
      this.lbCover.Name = "lbCover";
      this.lbCover.Size = new System.Drawing.Size(69, 27);
      this.lbCover.TabIndex = 1;
      this.lbCover.Text = "Cover";
      // 
      // lbPages
      // 
      this.lbPages.AutoSize = true;
      this.lbPages.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbPages.Location = new System.Drawing.Point(13, 370);
      this.lbPages.Name = "lbPages";
      this.lbPages.Size = new System.Drawing.Size(73, 27);
      this.lbPages.TabIndex = 1;
      this.lbPages.Text = "Pages";
      // 
      // lbTags
      // 
      this.lbTags.AutoSize = true;
      this.lbTags.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbTags.Location = new System.Drawing.Point(13, 292);
      this.lbTags.Name = "lbTags";
      this.lbTags.Size = new System.Drawing.Size(59, 27);
      this.lbTags.TabIndex = 1;
      this.lbTags.Text = "Tags";
      // 
      // lbTopic
      // 
      this.lbTopic.AutoSize = true;
      this.lbTopic.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbTopic.Location = new System.Drawing.Point(13, 253);
      this.lbTopic.Name = "lbTopic";
      this.lbTopic.Size = new System.Drawing.Size(66, 27);
      this.lbTopic.TabIndex = 1;
      this.lbTopic.Text = "Topic";
      // 
      // lbDescription
      // 
      this.lbDescription.AutoSize = true;
      this.lbDescription.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbDescription.Location = new System.Drawing.Point(477, 136);
      this.lbDescription.Name = "lbDescription";
      this.lbDescription.Size = new System.Drawing.Size(122, 27);
      this.lbDescription.TabIndex = 1;
      this.lbDescription.Text = "Description";
      // 
      // txDescription
      // 
      this.txDescription.Font = new System.Drawing.Font("Roboto", 10F);
      this.txDescription.Location = new System.Drawing.Point(482, 167);
      this.txDescription.Multiline = true;
      this.txDescription.Name = "txDescription";
      this.txDescription.Size = new System.Drawing.Size(230, 352);
      this.txDescription.TabIndex = 120;
      // 
      // txPublisher
      // 
      this.txPublisher.Font = new System.Drawing.Font("Roboto", 16F);
      this.txPublisher.Location = new System.Drawing.Point(190, 94);
      this.txPublisher.Name = "txPublisher";
      this.txPublisher.Size = new System.Drawing.Size(211, 33);
      this.txPublisher.TabIndex = 30;
      this.txPublisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPublisher_KeyPress);
      this.txPublisher.Validating += new System.ComponentModel.CancelEventHandler(this.txPublisher_Validating);
      // 
      // txAuthor
      // 
      this.txAuthor.Font = new System.Drawing.Font("Roboto", 16F);
      this.txAuthor.Location = new System.Drawing.Point(190, 55);
      this.txAuthor.Name = "txAuthor";
      this.txAuthor.Size = new System.Drawing.Size(211, 33);
      this.txAuthor.TabIndex = 20;
      this.txAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txAuthor_KeyPress);
      this.txAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.txAuthor_Validating);
      // 
      // txTitle
      // 
      this.txTitle.Font = new System.Drawing.Font("Roboto", 16F);
      this.txTitle.Location = new System.Drawing.Point(190, 16);
      this.txTitle.Name = "txTitle";
      this.txTitle.Size = new System.Drawing.Size(250, 33);
      this.txTitle.TabIndex = 10;
      this.txTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txTitle_Validating);
      // 
      // txISBN
      // 
      this.txISBN.Font = new System.Drawing.Font("Roboto", 16F);
      this.txISBN.Location = new System.Drawing.Point(190, 133);
      this.txISBN.Name = "txISBN";
      this.txISBN.Size = new System.Drawing.Size(250, 33);
      this.txISBN.TabIndex = 40;
      // 
      // txEdition
      // 
      this.txEdition.Font = new System.Drawing.Font("Roboto", 16F);
      this.txEdition.Location = new System.Drawing.Point(190, 406);
      this.txEdition.Name = "txEdition";
      this.txEdition.Size = new System.Drawing.Size(250, 33);
      this.txEdition.TabIndex = 110;
      this.txEdition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txEdition_KeyPress);
      // 
      // txLanguage
      // 
      this.txLanguage.Font = new System.Drawing.Font("Roboto", 16F);
      this.txLanguage.Location = new System.Drawing.Point(190, 211);
      this.txLanguage.Name = "txLanguage";
      this.txLanguage.Size = new System.Drawing.Size(250, 33);
      this.txLanguage.TabIndex = 60;
      // 
      // txTopic
      // 
      this.txTopic.Font = new System.Drawing.Font("Roboto", 16F);
      this.txTopic.Location = new System.Drawing.Point(190, 250);
      this.txTopic.Name = "txTopic";
      this.txTopic.Size = new System.Drawing.Size(250, 33);
      this.txTopic.TabIndex = 70;
      // 
      // txPages
      // 
      this.txPages.Font = new System.Drawing.Font("Roboto", 16F);
      this.txPages.Location = new System.Drawing.Point(190, 367);
      this.txPages.Name = "txPages";
      this.txPages.Size = new System.Drawing.Size(250, 33);
      this.txPages.TabIndex = 100;
      this.txPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPages_KeyPress);
      // 
      // txTags
      // 
      this.txTags.Font = new System.Drawing.Font("Roboto", 16F);
      this.txTags.Location = new System.Drawing.Point(190, 289);
      this.txTags.Name = "txTags";
      this.txTags.Size = new System.Drawing.Size(250, 33);
      this.txTags.TabIndex = 80;
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // txPublicationDate
      // 
      this.txPublicationDate.Font = new System.Drawing.Font("Roboto", 16F);
      this.txPublicationDate.Location = new System.Drawing.Point(190, 328);
      this.txPublicationDate.Name = "txPublicationDate";
      this.txPublicationDate.Size = new System.Drawing.Size(250, 33);
      this.txPublicationDate.TabIndex = 90;
      this.txPublicationDate.Validating += new System.ComponentModel.CancelEventHandler(this.txPublicationDate_Validating);
      // 
      // lbID
      // 
      this.lbID.AutoSize = true;
      this.lbID.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbID.Location = new System.Drawing.Point(17, 448);
      this.lbID.Name = "lbID";
      this.lbID.Size = new System.Drawing.Size(32, 27);
      this.lbID.TabIndex = 1;
      this.lbID.Text = "ID";
      // 
      // lbSeries
      // 
      this.lbSeries.AutoSize = true;
      this.lbSeries.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbSeries.Location = new System.Drawing.Point(13, 175);
      this.lbSeries.Name = "lbSeries";
      this.lbSeries.Size = new System.Drawing.Size(72, 27);
      this.lbSeries.TabIndex = 1;
      this.lbSeries.Text = "Series";
      // 
      // txSeries
      // 
      this.txSeries.Font = new System.Drawing.Font("Roboto", 16F);
      this.txSeries.Location = new System.Drawing.Point(190, 172);
      this.txSeries.Name = "txSeries";
      this.txSeries.Size = new System.Drawing.Size(250, 33);
      this.txSeries.TabIndex = 50;
      // 
      // lbIDtext
      // 
      this.lbIDtext.AutoSize = true;
      this.lbIDtext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Italic);
      this.lbIDtext.Location = new System.Drawing.Point(185, 448);
      this.lbIDtext.Name = "lbIDtext";
      this.lbIDtext.Size = new System.Drawing.Size(50, 27);
      this.lbIDtext.TabIndex = 1;
      this.lbIDtext.Text = "N/A";
      // 
      // btnSave
      // 
      this.btnSave.AccessibleDescription = "Save current book info";
      this.btnSave.AccessibleName = "Save button";
      this.btnSave.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.check_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnSave.Location = new System.Drawing.Point(384, 463);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(56, 56);
      this.btnSave.TabIndex = 140;
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnRemoveCover
      // 
      this.btnRemoveCover.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.delete_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnRemoveCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnRemoveCover.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnRemoveCover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnRemoveCover.Location = new System.Drawing.Point(930, 127);
      this.btnRemoveCover.Name = "btnRemoveCover";
      this.btnRemoveCover.Size = new System.Drawing.Size(33, 33);
      this.btnRemoveCover.TabIndex = 5;
      this.btnRemoveCover.UseVisualStyleBackColor = true;
      this.btnRemoveCover.Click += new System.EventHandler(this.btnRemoveCover_Click);
      // 
      // btnAddCover
      // 
      this.btnAddCover.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.add_a_photo_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnAddCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnAddCover.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnAddCover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnAddCover.Location = new System.Drawing.Point(969, 127);
      this.btnAddCover.Name = "btnAddCover";
      this.btnAddCover.Size = new System.Drawing.Size(33, 33);
      this.btnAddCover.TabIndex = 130;
      this.btnAddCover.UseVisualStyleBackColor = true;
      this.btnAddCover.Click += new System.EventHandler(this.btnAddCover_Click);
      // 
      // pbCover
      // 
      this.pbCover.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.no_photography_80dp_EADDFF_FILL0_wght400_GRAD0_opsz48;
      this.pbCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pbCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbCover.Location = new System.Drawing.Point(718, 166);
      this.pbCover.Name = "pbCover";
      this.pbCover.Size = new System.Drawing.Size(284, 353);
      this.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbCover.TabIndex = 2;
      this.pbCover.TabStop = false;
      // 
      // btnSearchAuthor
      // 
      this.btnSearchAuthor.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.search_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnSearchAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnSearchAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnSearchAuthor.Location = new System.Drawing.Point(407, 55);
      this.btnSearchAuthor.Name = "btnSearchAuthor";
      this.btnSearchAuthor.Size = new System.Drawing.Size(33, 33);
      this.btnSearchAuthor.TabIndex = 141;
      this.btnSearchAuthor.UseVisualStyleBackColor = true;
      this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
      // 
      // btnSearchPublisher
      // 
      this.btnSearchPublisher.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.search_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnSearchPublisher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnSearchPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnSearchPublisher.Location = new System.Drawing.Point(407, 94);
      this.btnSearchPublisher.Name = "btnSearchPublisher";
      this.btnSearchPublisher.Size = new System.Drawing.Size(33, 33);
      this.btnSearchPublisher.TabIndex = 141;
      this.btnSearchPublisher.UseVisualStyleBackColor = true;
      this.btnSearchPublisher.Click += new System.EventHandler(this.btnSearchPublisher_Click);
      // 
      // lbAuthorText
      // 
      this.lbAuthorText.AutoSize = true;
      this.lbAuthorText.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbAuthorText.Location = new System.Drawing.Point(477, 58);
      this.lbAuthorText.Name = "lbAuthorText";
      this.lbAuthorText.Size = new System.Drawing.Size(51, 27);
      this.lbAuthorText.TabIndex = 1;
      this.lbAuthorText.Text = "N/A";
      // 
      // lbPublisherText
      // 
      this.lbPublisherText.AutoSize = true;
      this.lbPublisherText.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbPublisherText.Location = new System.Drawing.Point(477, 97);
      this.lbPublisherText.Name = "lbPublisherText";
      this.lbPublisherText.Size = new System.Drawing.Size(51, 27);
      this.lbPublisherText.TabIndex = 1;
      this.lbPublisherText.Text = "N/A";
      // 
      // Form_Add_Update_Book
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1014, 529);
      this.Controls.Add(this.btnSearchPublisher);
      this.Controls.Add(this.btnSearchAuthor);
      this.Controls.Add(this.txTags);
      this.Controls.Add(this.txPages);
      this.Controls.Add(this.txTopic);
      this.Controls.Add(this.txLanguage);
      this.Controls.Add(this.txPublicationDate);
      this.Controls.Add(this.txEdition);
      this.Controls.Add(this.txISBN);
      this.Controls.Add(this.txTitle);
      this.Controls.Add(this.txAuthor);
      this.Controls.Add(this.txSeries);
      this.Controls.Add(this.txPublisher);
      this.Controls.Add(this.btnRemoveCover);
      this.Controls.Add(this.btnAddCover);
      this.Controls.Add(this.btnSave);
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
      this.Controls.Add(this.lbAuthorText);
      this.Controls.Add(this.lbAuthor);
      this.Controls.Add(this.lbPublisherText);
      this.Controls.Add(this.lbPublisher);
      this.Font = new System.Drawing.Font("Roboto", 8F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "Form_Add_Update_Book";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Add/Update Book";
      this.Load += new System.EventHandler(this.Form_Add_Update_Book_Load);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbCover)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label lbPublisher;
    private System.Windows.Forms.Label lbAuthor;
    private System.Windows.Forms.Label lbTitle;
    private System.Windows.Forms.Label lbISBN;
    private System.Windows.Forms.Label lbEdition;
    private System.Windows.Forms.Label lbPublicationDate;
    private System.Windows.Forms.Label lbLanguage;
    private System.Windows.Forms.Label lbCover;
    private System.Windows.Forms.Label lbTags;
    private System.Windows.Forms.Label lbTopic;
    private System.Windows.Forms.Label lbDescription;
    private System.Windows.Forms.PictureBox pbCover;
    private System.Windows.Forms.TextBox txDescription;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnAddCover;
    private System.Windows.Forms.Button btnRemoveCover;
    private System.Windows.Forms.TextBox txPublisher;
    private System.Windows.Forms.TextBox txAuthor;
    private System.Windows.Forms.TextBox txTitle;
    private System.Windows.Forms.TextBox txISBN;
    private System.Windows.Forms.TextBox txEdition;
    private System.Windows.Forms.TextBox txLanguage;
    private System.Windows.Forms.TextBox txTopic;
    private System.Windows.Forms.TextBox txPages;
    private System.Windows.Forms.TextBox txTags;
    private System.Windows.Forms.Label lbPages;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.TextBox txPublicationDate;
    private System.Windows.Forms.Label lbID;
    private System.Windows.Forms.TextBox txSeries;
    private System.Windows.Forms.Label lbSeries;
    private System.Windows.Forms.Label lbIDtext;
    private System.Windows.Forms.Button btnSearchAuthor;
    private System.Windows.Forms.Button btnSearchPublisher;
    private System.Windows.Forms.Label lbAuthorText;
    private System.Windows.Forms.Label lbPublisherText;
  }
}