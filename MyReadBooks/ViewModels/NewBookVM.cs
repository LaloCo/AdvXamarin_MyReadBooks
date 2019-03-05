using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Input;
using System.Xml.Serialization;
using MyReadBooks.Models;
using MyReadBooks.ViewModels.Helpers;
using Prism.Commands;

namespace MyReadBooks.ViewModels
{
    public class NewBookVM
    {
        public ICommand SearchCommand { get; set; }

        public NewBookVM()
        {
            SearchCommand = new DelegateCommand<string>(GetSearchResults);
        }

        private void GetSearchResults(string query)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GoodreadsResponse));

            using (WebClient webClient = new WebClient())
            {
                string xml = Encoding.Default.GetString(webClient.DownloadData($"https://www.goodreads.com/search/index.xml?q={query}&key={Constants.GOODREADS_KEY}"));
                using (Stream reader = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
                {
                    GoodreadsResponse response = serializer.Deserialize(reader) as GoodreadsResponse;
                }
            }
        }
    }
}
