using System;
using System.Net;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DownloadProject
{
    class DownloadController
    {
        public string dataDownloaded;
        public string dataAnalyzed;

        public DownloadController() { }

        public void DownloadFromUri(string uri)
        {
            try
            {
                Stream data = WebRequest.Create(uri).GetResponse().GetResponseStream();
                using (StreamReader reader = new StreamReader(data))
                {
                    dataDownloaded = reader.ReadToEnd();
                }

                AnalyseData();
            }
            catch (Exception ex)
            {
                dataAnalyzed = "Could not download the data. Exception details: \n" + ex.Message;
            }
        }

        public void AnalyseData()
        {
            string[] dataSplit = dataDownloaded.Split(new char[] { ' ', ',', '.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t', '<', '>', '=', '/', '{', '}', '#' });

            var dataGrouped = dataSplit.GroupBy(v => v);
            foreach (var group in dataGrouped)
                if (group.Key != "")
                    dataAnalyzed += group.Key + " - " + group.Count() + "\n";
        }
    }
}
