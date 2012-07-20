using System.Web;
using System.Web.Mvc;

namespace ProjetoBase.Vs2012.Web.Teste
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}