namespace MyBookLibrary_Forms.Assets.Books {
  partial class Form_ManageBooks {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.lbAuthors = new System.Windows.Forms.Label();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.dgvBooks = new System.Windows.Forms.DataGridView();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbAuthors
      // 
      this.lbAuthors.AutoSize = true;
      this.lbAuthors.Font = new System.Drawing.Font("Roboto", 36F);
      this.lbAuthors.Location = new System.Drawing.Point(12, 9);
      this.lbAuthors.Name = "lbAuthors";
      this.lbAuthors.Size = new System.Drawing.Size(158, 58);
      this.lbAuthors.TabIndex = 6;
      this.lbAuthors.Text = "Books";
      // 
      // btnRefresh
      // 
      this.btnRefresh.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.refresh_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnRefresh.Location = new System.Drawing.Point(1076, 12);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(56, 56);
      this.btnRefresh.TabIndex = 4;
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.add_16dp_EADDFF_FILL0_wght400_GRAD0_opsz20;
      this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnAdd.Location = new System.Drawing.Point(1138, 12);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(56, 56);
      this.btnAdd.TabIndex = 5;
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // dgvBooks
      // 
      this.dgvBooks.AllowUserToAddRows = false;
      this.dgvBooks.AllowUserToDeleteRows = false;
      this.dgvBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 16F);
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      this.dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvBooks.ContextMenuStrip = this.contextMenuStrip1;
      this.dgvBooks.Location = new System.Drawing.Point(12, 74);
      this.dgvBooks.Name = "dgvBooks";
      this.dgvBooks.ReadOnly = true;
      this.dgvBooks.Size = new System.Drawing.Size(1182, 450);
      this.dgvBooks.TabIndex = 3;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Font = new System.Drawing.Font("Roboto", 16F);
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.infoToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(154, 100);
      // 
      // updateToolStripMenuItem
      // 
      this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
      this.updateToolStripMenuItem.Size = new System.Drawing.Size(153, 32);
      this.updateToolStripMenuItem.Text = "Update";
      this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
      // 
      // deleteToolStripMenuItem
      // 
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new System.Drawing.Size(153, 32);
      this.deleteToolStripMenuItem.Text = "Delete";
      this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
      // 
      // infoToolStripMenuItem
      // 
      this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
      this.infoToolStripMenuItem.Size = new System.Drawing.Size(153, 32);
      this.infoToolStripMenuItem.Text = "Info";
      this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
      // 
      // Form_ManageBooks
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1206, 524);
      this.Controls.Add(this.lbAuthors);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.dgvBooks);
      this.Font = new System.Drawing.Font("Roboto", 16F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Form_ManageBooks";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Manage Books";
      this.Load += new System.EventHandler(this.Form_ManageBooks_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbAuthors;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.DataGridView dgvBooks;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
  }
}