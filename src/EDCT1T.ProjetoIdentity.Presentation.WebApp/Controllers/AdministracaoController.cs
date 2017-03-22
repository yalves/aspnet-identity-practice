using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EDCT1T.ProjetoIdentity.Presentation.WebApp.Controllers
{
	[Authorize]
	public class AdministracaoController : Controller
    {
        // GET: Administracao
        public ActionResult Index()
        {
            return View();
        }

		//[Authorize(Roles = "Vendedor, WebMaster")]
		[Authorize(Roles = "Vendedor")]
		public ActionResult Vendedores()
		{
			return View();
		}

		[Authorize(Users = "eu@email.com")]
		public ActionResult MeuAccessPrivado()
		{
			return View();
		}
	}
}