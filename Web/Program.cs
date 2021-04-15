using System.Globalization;
using System.Threading.Tasks;
using Statiq.App;
using Statiq.Web;

namespace Web
{
    class Program
    {

        public static async Task<int> Main(string[] args)
        {
            // Ensure consistent date handling
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-GB");

            return await Bootstrapper
                .Factory
                .CreateWeb(args)
                .RunAsync();
        }

    }

    public class SocialViewModel
    {
        public string Social { get; set; }
    }

}
