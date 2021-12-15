
namespace WebClientApplication
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_ipv4 = new System.Windows.Forms.TextBox();
            this.lbl_download_percentage = new System.Windows.Forms.Label();
            this.pb_download = new System.Windows.Forms.ProgressBar();
            this.btn_download_file = new System.Windows.Forms.Button();
            this.tb_download_url = new System.Windows.Forms.TextBox();
            this.rtb_html_codes = new System.Windows.Forms.RichTextBox();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_get_data = new System.Windows.Forms.Button();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.cb_file_type = new System.Windows.Forms.ComboBox();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ipv4
            // 
            this.tb_ipv4.Enabled = false;
            this.tb_ipv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_ipv4.Location = new System.Drawing.Point(644, 20);
            this.tb_ipv4.Name = "tb_ipv4";
            this.tb_ipv4.Size = new System.Drawing.Size(144, 27);
            this.tb_ipv4.TabIndex = 25;
            // 
            // lbl_download_percentage
            // 
            this.lbl_download_percentage.AutoSize = true;
            this.lbl_download_percentage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_download_percentage.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_download_percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_download_percentage.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbl_download_percentage.Location = new System.Drawing.Point(186, 155);
            this.lbl_download_percentage.Name = "lbl_download_percentage";
            this.lbl_download_percentage.Size = new System.Drawing.Size(41, 20);
            this.lbl_download_percentage.TabIndex = 24;
            this.lbl_download_percentage.Text = "0 %";
            // 
            // pb_download
            // 
            this.pb_download.Location = new System.Drawing.Point(12, 149);
            this.pb_download.Name = "pb_download";
            this.pb_download.Size = new System.Drawing.Size(382, 31);
            this.pb_download.TabIndex = 23;
            // 
            // btn_download_file
            // 
            this.btn_download_file.Location = new System.Drawing.Point(292, 81);
            this.btn_download_file.Name = "btn_download_file";
            this.btn_download_file.Size = new System.Drawing.Size(105, 29);
            this.btn_download_file.TabIndex = 21;
            this.btn_download_file.Text = "Download File";
            this.btn_download_file.UseVisualStyleBackColor = true;
            this.btn_download_file.Click += new System.EventHandler(this.btn_download_file_Click);
            // 
            // tb_download_url
            // 
            this.tb_download_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_download_url.Location = new System.Drawing.Point(11, 83);
            this.tb_download_url.Name = "tb_download_url";
            this.tb_download_url.Size = new System.Drawing.Size(191, 27);
            this.tb_download_url.TabIndex = 20;
            // 
            // rtb_html_codes
            // 
            this.rtb_html_codes.ContextMenuStrip = this.cms;
            this.rtb_html_codes.Location = new System.Drawing.Point(427, 140);
            this.rtb_html_codes.Name = "rtb_html_codes";
            this.rtb_html_codes.Size = new System.Drawing.Size(361, 369);
            this.rtb_html_codes.TabIndex = 18;
            this.rtb_html_codes.Text = "";
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.cms.Name = "contextMenuStrip1";
            this.cms.Size = new System.Drawing.Size(110, 28);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // btn_get_data
            // 
            this.btn_get_data.Location = new System.Drawing.Point(663, 81);
            this.btn_get_data.Name = "btn_get_data";
            this.btn_get_data.Size = new System.Drawing.Size(125, 33);
            this.btn_get_data.TabIndex = 17;
            this.btn_get_data.Text = "Get Data";
            this.btn_get_data.UseVisualStyleBackColor = true;
            this.btn_get_data.Click += new System.EventHandler(this.btn_get_data_Click);
            // 
            // tb_url
            // 
            this.tb_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_url.Location = new System.Drawing.Point(427, 83);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(218, 27);
            this.tb_url.TabIndex = 16;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_username.Location = new System.Drawing.Point(68, 20);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(107, 19);
            this.lbl_username.TabIndex = 26;
            this.lbl_username.Text = "Hi, username";
            // 
            // cb_file_type
            // 
            this.cb_file_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_file_type.FormattingEnabled = true;
            this.cb_file_type.Items.AddRange(new object[] {
            ".exe",
            ".txt",
            ".pdf",
            ".docx"});
            this.cb_file_type.Location = new System.Drawing.Point(208, 82);
            this.cb_file_type.Name = "cb_file_type";
            this.cb_file_type.Size = new System.Drawing.Size(78, 28);
            this.cb_file_type.TabIndex = 28;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.cb_file_type);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.tb_ipv4);
            this.Controls.Add(this.lbl_download_percentage);
            this.Controls.Add(this.pb_download);
            this.Controls.Add(this.btn_download_file);
            this.Controls.Add(this.tb_download_url);
            this.Controls.Add(this.rtb_html_codes);
            this.Controls.Add(this.btn_get_data);
            this.Controls.Add(this.tb_url);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebClient";
            this.Load += new System.EventHandler(this.Main_Load);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ipv4;
        private System.Windows.Forms.Label lbl_download_percentage;
        private System.Windows.Forms.ProgressBar pb_download;
        private System.Windows.Forms.Button btn_download_file;
        private System.Windows.Forms.TextBox tb_download_url;
        private System.Windows.Forms.RichTextBox rtb_html_codes;
        private System.Windows.Forms.Button btn_get_data;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ComboBox cb_file_type;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

