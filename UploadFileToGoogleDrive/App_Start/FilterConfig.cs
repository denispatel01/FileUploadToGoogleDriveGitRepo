using System.Web;
using System.Web.Mvc;

namespace UploadFileToGoogleDrive
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
