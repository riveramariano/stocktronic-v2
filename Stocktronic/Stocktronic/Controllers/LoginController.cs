﻿using Stocktronic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stocktronic.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        [HttpGet]
        public ActionResult IniciarSesion(string correo, string contrasenna)
        {
            LoginModel login = new LoginModel();
            var usuario = login.IniciarSesion(correo, contrasenna);

            if (usuario != null)
            {
                Session["ID_USUARIO"] = usuario.ID_USUARIO;
                Session["USR_NOMBRE"] = usuario.USR_NOMBRE;
                Session["USR_APELLIDO1"] = usuario.USR_APELLIDO1;
                Session["FK_ID_ROL"] = usuario.FK_ID_ROL;
                CarritoModel carrito = new CarritoModel();
                Session["Cantidad"] = carrito.ListarProductosAgregados(Convert.ToInt32(usuario.ID_USUARIO)).Count();
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.DenyGet);
            }
        }

        [HttpGet]
        public ActionResult CerrarSesion()
        {
            Session.Clear();
            Session.Abandon();
            Session["ID_USUARIO"] = null;
            Session["USR_NOMBRE"] = null;
            Session["USR_APELLIDO1"] = null;
            Session["FK_ID_ROL"] = null;
            Session["Cantidad"] = null;
            return Json(true, JsonRequestBehavior.AllowGet);
        }

    }
}
