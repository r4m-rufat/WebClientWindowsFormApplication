using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebClientApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        WebClient webClient = new WebClient();

        private void Main_Load(object sender, EventArgs e)
        {
            lbl_username.Text = "Hi, " + Environment.UserName;
            cb_file_type.SelectedIndex = 0;
            getGlobalIPv4();
        }

       
        private void btn_get_data_Click(object sender, EventArgs e)
        {
            rtb_html_codes.Text = webClient.DownloadString(tb_url.Text);

        }

        private void getGlobalIPv4()
        {
            String url = "https://api.ipify.org";
            string ipv4 = webClient.DownloadString(url);
            tb_ipv4.Text = ipv4;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File(*.txt)|*.txt";
            saveFileDialog.FileName = "Untitled";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, rtb_html_codes.Text);
            }
        }

        private void btn_download_file_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\" + Environment.UserName + @"\Desktop\File" + cb_file_type.SelectedItem;
            webClient.DownloadFileAsync(new Uri(tb_download_url.Text), path);
            webClient.DownloadProgressChanged += (s, ev) =>
            {
                pb_download.Value = ev.ProgressPercentage;
                lbl_download_percentage.Text = ev.ProgressPercentage + "%";
                
            };

            webClient.DownloadFileCompleted += (s, ev) =>
            {
                if (pb_download.Value == 100)
                {
                    MessageBox.Show("Successfully completed");
                }
            };
        }
    }
}
