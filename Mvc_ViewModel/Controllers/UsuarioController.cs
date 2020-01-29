using Mvc_ViewModel.Models;
using Mvc_ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_ViewModel.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        // GET: Usuario
        public ActionResult AlterarSenha()
        {
            ///Usuario usuario = new Usuario();
            AlteraSenhaViewModel viewMode = new AlteraSenhaViewModel();
            return View(viewMode);
        }

       [HttpPost]
        public ActionResult AlterarSenha(AlteraSenhaViewModel usuario)
        {
            return View();
        }
    }
}