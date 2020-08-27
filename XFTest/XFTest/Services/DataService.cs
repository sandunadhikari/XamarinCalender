using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XFTest.Models;

namespace XFTest.Services
{
    public class DataService: IDataService
    {

        public async Task<RequestList> GetBooks()
        {
            // Read json from Data folder
            var name = typeof(DataService).AssemblyQualifiedName.Split(',')[1].Trim();
            var assembly = Assembly.Load(new AssemblyName(name));
            var stream = assembly.GetManifestResourceStream(name + ".Data.XF-Test-Json.json");

            // Parse the JSON and generate CleanData objects
            using (var reader = new StreamReader(stream))
            {
                string json = await reader.ReadToEndAsync();
                //var obj = new { Books = new RequestList() };
                var result = JsonConvert.DeserializeObject<RequestList>(json);
                return result;
            }
        }
    }
}
