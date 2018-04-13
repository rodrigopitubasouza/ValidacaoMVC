using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidacoesMVC.Models;

namespace ValidacoesMVC.Controllers
{
    public class UsuarioController : Controller
    {
        
        // GET: Usuario
        public ActionResult Usuario()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario) {
         

            if (ModelState.IsValid) {
                return View("Resultado",usuario);  
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario) {
            return View(usuario);
        }
    }
}