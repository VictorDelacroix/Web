using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrabajoFinal.BE;
using TrabajoFinal.Model;
using TrabajoFinal.ViewModel;

namespace TrabajoFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session.Clear();
            return View();
        }

        public ActionResult Establecimientos()
        {
            EstablecimientosVM objViewModel = new EstablecimientosVM();
            objViewModel.Fill();
            return View(objViewModel);
        }
        public ActionResult CategoriaHorario(int ID)
        {
            CategoriaHorarioVM objVM = new CategoriaHorarioVM();
            objVM.Fill(ID);
            return View(objVM);
        }
        public ActionResult DetalleMapa(int ID)
        {
            EstablecimientoDetalleVM objVM = new EstablecimientoDetalleVM();
            objVM.Fill(ID);
            return View(objVM);
        }
        public ActionResult Categorias()
        {
            CategoriaVM objVM = new CategoriaVM();
            objVM.Fill();
            return View(objVM);
        }
        public ActionResult Planes()
        {
            PlanesVM objVM = new PlanesVM();
            objVM.Fill();
            return View(objVM);
        }
        public ActionResult Login()
        {
            LoginVM objVM = new LoginVM();
            return View(objVM);
        }
        [HttpPost]
        public ActionResult Login(LoginVM objViewModel)
        {
            try
            {
                AdministradorBE administradorBE = new AdministradorBE(); Administrador objAdm = new Administrador();
                AsociadoBE asociadoBE = new AsociadoBE(); Asociado objAsc = new Asociado();
                ClienteBE clienteBE = new ClienteBE(); Cliente objCli = new Cliente();
                objAdm = administradorBE.getAdministrador(objViewModel.UsuarioCodigo, objViewModel.UsuarioPassword);
                objAsc = asociadoBE.getAsociado(objViewModel.UsuarioCodigo, objViewModel.UsuarioPassword);
                objCli = clienteBE.getCliente(objViewModel.UsuarioCodigo, objViewModel.UsuarioPassword);
                if (objAdm != null)
                {
                    Session["objAdministrador"] = objAdm;
                    Session["Nombre"] = objAdm.Nombre;
                    return RedirectToAction("Index", "Administrador");
                }
                else if (objAsc != null)
                {
                    Session["objAsociado"] = objAsc;
                    Session["Nombre"] = objAsc.Nombre;
                    return RedirectToAction("Index", "Asociado");
                }
                else if (objCli != null)
                {
                    Session["objCliente"] = objCli;
                    Session["Nombre"] = objCli.Nombre;
                    return RedirectToAction("Index", "Cliente");
                }
                else return View(objViewModel);
            }
            catch (Exception)
            {
                return View(objViewModel);
            }
        }

        [HttpPost]
        public ActionResult LoginRS(LoginVM objViewModel)
        {
            try
            {
                if (objViewModel.Imagen != null)
                {
                    var Descargar = new WebClient();
                    byte[] data = Descargar.DownloadData(objViewModel.Imagen);
                    objViewModel.objCliente.Imagen = data;
                }
                if (!objViewModel.ExisteClienteRS(objViewModel.objCliente)) objViewModel.AddCliente(objViewModel.objCliente);

                Cliente obj = objViewModel.GetClienteRS(objViewModel.objCliente.IDRS);
                Session["objCliente"] = obj; return RedirectToAction("index", "Cliente");
            }
            catch (Exception ex)
            {
                string asd = ex.ToString();
                return RedirectToAction("Index", "Home");
            }
        }
    }
}