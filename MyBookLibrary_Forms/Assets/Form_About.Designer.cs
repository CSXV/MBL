namespace MyBookLibrary_Forms.Assets {
  partial class Form_About {
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
      this.lbInfo = new System.Windows.Forms.Label();
      this.lbTechnology = new System.Windows.Forms.Label();
      this.pbMark = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pbMark)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // lbInfo
      // 
      this.lbInfo.AutoSize = true;
      this.lbInfo.Font = new System.Drawing.Font("Roboto", 36F);
      this.lbInfo.Location = new System.Drawing.Point(12, 9);
      this.lbInfo.Name = "lbInfo";
      this.lbInfo.Size = new System.Drawing.Size(367, 58);
      this.lbInfo.TabIndex = 0;
      this.lbInfo.Text = "My Book Library";
      // 
      // lbTechnology
      // 
      this.lbTechnology.AutoSize = true;
      this.lbTechnology.Font = new System.Drawing.Font("Roboto", 16F);
      this.lbTechnology.Location = new System.Drawing.Point(17, 235);
      this.lbTechnology.Name = "lbTechnology";
      this.lbTechnology.Size = new System.Drawing.Size(175, 108);
      this.lbTechnology.TabIndex = 0;
      this.lbTechnology.Text = "C#\r\nADO.NET\r\n.NET Framework\r\nSQL Server";
      // 
      // pbMark
      // 
      this.pbMark.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.MyBookLibrary;
      this.pbMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pbMark.Location = new System.Drawing.Point(404, 12);
      this.pbMark.Name = "pbMark";
      this.pbMark.Size = new System.Drawing.Size(338, 329);
      this.pbMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pbMark.TabIndex = 3;
      this.pbMark.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.sql_server_logo_white;
      this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pictureBox2.Location = new System.Drawing.Point(22, 70);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(203, 162);
      this.pictureBox2.TabIndex = 2;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackgroundImage = global::MyBookLibrary_Forms.Properties.Resources.net_framework_service_pack_1_hosting;
      this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pictureBox1.Location = new System.Drawing.Point(231, 70);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(167, 162);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // Form_About
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(754, 401);
      this.Controls.Add(this.pbMark);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.lbTechnology);
      this.Controls.Add(this.lbInfo);
      this.Font = new System.Drawing.Font("Roboto", 16F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Form_About";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "About";
      this.Load += new System.EventHandler(this.Form_About_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbMark)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbInfo;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Label lbTechnology;
    private System.Windows.Forms.PictureBox pbMark;
  }
}