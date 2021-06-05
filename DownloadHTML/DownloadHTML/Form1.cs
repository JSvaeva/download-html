using System;
using System.Net;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DownloadProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            DownloadController download = new DownloadController();
            download.DownloadFromUri(uriTextBox.Text);
            infoLabel.Text = download.dataAnalyzed;
        }

        private void clearButton_Click(object sender, EventArgs e) => ClearLabels();

        private void ClearLabels()
        {
            infoLabel.Text = "";
            uriTextBox.Text = "";
        }
    }
}
