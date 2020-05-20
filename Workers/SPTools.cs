using System.Threading.Tasks;
using dc.Models;
using dc.Constants;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;

namespace dc.Workers
{

    public class SPTools
    {
        public static async Task<string> GetDigestAsync(string url)
        {
            HttpClient Http = new HttpClient();
            Http.DefaultRequestHeaders.Add("Accept", "application/json");
            var response = await Http.PostAsync(url + Settings.BaseURL + "_api/contextinfo", null);
            Root root = JsonConvert.DeserializeObject<Root>(await response.Content.ReadAsStringAsync());
            return root.FormDigestValue;
        }

        public static async Task<List<Group>> GetMyGroupsAsync(string url)
        {
            List<Group> _groups = new List<Group>();
            HttpClient Http = new HttpClient();
            Root root = new Root();
            root.Groups = _groups;
            Http.DefaultRequestHeaders.Add("Accept", "application/json");
            string temp = await Http.GetStringAsync(url + Settings.BaseURL + "_api/web/currentuser?$expand=groups");
            root = JsonConvert.DeserializeObject<Root>(temp);
            return root.Groups;
        }
    }
}
