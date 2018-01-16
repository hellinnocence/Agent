using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Agent.Controllers;

namespace Agent.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AgentControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
