using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;

namespace GoogleSearchAPI
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //// Search 32 results of keyword : "Google APIs for .NET"
            //GwebSearchClient client = new GwebSearchClient(/* Enter the URL of your site here */);
            //IList<IWebResult> results = client.Search("Google API for .NET", 32);
            //foreach (IWebResult result in results)
            //{
            //    Console.WriteLine("[{0}] {1} => {2}", result.Title, result.Content, result.Url);
            //}


            //WebQuery query = new WebQuery("Insert query here");
            //query.StartIndex.Value = 2;
            //query.HostLangauge.Value = Languages.English;
            //IGoogleResultSet<GoogleWebResult> resultSet = GoogleService.Instance.Search<GoogleWebResult>(query);


            //const string apiKey = "YOUR_API_KEY";
            //const string searchEngineId = "010297209645085268115:tvi4k-bftis";
            //const string query = "'sky is blue'";
            //CustomsearchService customSearchService =
            //    new CustomsearchService(new Google.Apis.Services.BaseClientService.Initializer() { ApiKey = apiKey });
            //Google.Apis.Customsearch.v1.CseResource.ListRequest listRequest = customSearchService.Cse.List(query);
            //listRequest.Cx = searchEngineId;
            //Search search = listRequest.Execute();
            //foreach (var item in search.Items)
            //{
            //    Console.WriteLine("Title : " + item.Title + Environment.NewLine + "Link : " + item.Link +
            //                      Environment.NewLine + "Description: " + item.Snippet + Environment.NewLine);
            //}
            //Console.ReadLine();


            const string apiKey = "YOUR_API_KEY";
            const string searchEngineId = "003470263288780838160:ty47piyybua";
            const string query = "sky is blue";
            CustomsearchService customSearchService = new CustomsearchService(new Google.Apis.Services.BaseClientService.Initializer() { ApiKey = apiKey });
            Google.Apis.Customsearch.v1.CseResource.ListRequest listRequest = customSearchService.Cse.List(query);
            listRequest.Cx = searchEngineId;
            Search search = listRequest.Execute();
            foreach (var item in search.Items)
            {
                Console.WriteLine("Title : " + item.Title + Environment.NewLine + "Link : " + item.Link + Environment.NewLine + item.Snippet + Environment.NewLine);
            }
            Console.ReadLine();

        }
    }
}
