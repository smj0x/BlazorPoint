using System.Threading.Tasks;
using lms.Models;
using lms.Constants;
using Newtonsoft.Json;
using System.Net.Http;


namespace lms.Workers
{

    public class LMSTools
    {
        //public static async Task<int> GetUserIdAsync(string url)
        //{
        //    HttpClient Http = new HttpClient();
        //    Http.DefaultRequestHeaders.Add("Accept", "application/json");
        //    var response = await Http.GetAsync(url + Config.BaseURL + "_api/web/currentuser");
        //    Root root = JsonConvert.DeserializeObject<Root>(await response.Content.ReadAsStringAsync());
        //    Config.Id = root.Id;
        //    return root.Id;
        //}
        public static async Task<string> GetDigestAsync(string url)
        {
            HttpClient Http = new HttpClient();
            Http.DefaultRequestHeaders.Add("Accept", "application/json");
            var response = await Http.PostAsync(url + Settings.BaseURL + "_api/contextinfo", null);
            Root root = JsonConvert.DeserializeObject<Root>(await response.Content.ReadAsStringAsync());
            return root.FormDigestValue;
        }
        public static string GenerateLicenseId(int id)
        {
            string temp = id.ToString("D9");
            return "LID"+temp;
        }
    }
}
