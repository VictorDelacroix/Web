using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinal.Model;
using TrabajoFinal.ViewModel;

namespace TrabajoFinal.Controllers
{
    public class AdministradorController : Controller
    {
        // GET: Administrador
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Establecimientos()
        {
            EstablecimientosVM objVM = new EstablecimientosVM();
            objVM.Fill();
            return View(objVM);
        }

        public ActionResult CategoriaHorario(int ID)
        {
            CategoriaHorarioVM objVM = new CategoriaHorarioVM();
            objVM.Fill(ID);
            return View(objVM);
        }

        public ActionResult EstablecimientoDetalle(int ID)
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

        public ActionResult Clientes()
        {
            ClienteVM objVM = new ClienteVM();
            objVM.Fill();
            return View(objVM);
        }

        public ActionResult Asociados()
        {
            AsociadoVM objVM = new AsociadoVM();
            objVM.Fill();
            return View(objVM);
        }

        public ActionResult Ventas()
        {
            ClientePlanesVM objVM = new ClientePlanesVM();
            objVM.FillAll();
            return View(objVM);
        }

        public ActionResult ClientePlan(int ID)
        {
            ClientePlanesVM objVM = new ClientePlanesVM();
            objVM.Fill(ID);
            return View(objVM);
        }

        //AGREGADO


        #region Asociado
        public ActionResult DeleteAsociado(int? AsociadoID)
        {
            AddEditAsociadoVM objViewModel = new AddEditAsociadoVM();
            if (AsociadoID.HasValue) objViewModel.DeleteAsociado(AsociadoID);

            TempData["objMensaje"] = new KeyValuePair<String, String>("SUC", "El asociado ha sido eliminado.");

            return RedirectToAction("Asociados");
        }


        public ActionResult AddEditAsociado(int? AsociadoID)
        {
            AddEditAsociadoVM objViewModel = new AddEditAsociadoVM();
            if (AsociadoID.HasValue)
            {
                objViewModel.objAsociado = objViewModel.getAsociado(AsociadoID);
                objViewModel.IDAsociado = objViewModel.objAsociado.IDAsociado;
            }
            else objViewModel.objAsociado = new Asociado();
            return View("AddEditAsociado", "_LayoutAdministrador", objViewModel);
        }
        [HttpPost]
        public ActionResult AddEditAsociado(AddEditAsociadoVM objViewModel)
        {
            try
            {
                if (objViewModel.IDAsociado.HasValue)
                {
                    objViewModel.EditAsociado(objViewModel.objAsociado, objViewModel.IDAsociado);
                }
                else objViewModel.AddAsociado(objViewModel.objAsociado);

                String MensajeRespuesta = objViewModel.IDAsociado.HasValue ? "El asociado se actualizó correctamente." : "El asociado se registró correctamente.";
                TempData["objMensaje"] = new KeyValuePair<String, String>("SUC", MensajeRespuesta);

                return RedirectToAction("LstAsociados","Administrador");
            }
            catch (Exception ex)
            {
                TempData["objMensaje"] = new KeyValuePair<String, String>("ERR", "Por favor intente más tarde.");
                return View(objViewModel);
            }
        }
        public ActionResult LstAsociados()
        {

            AsociadoVM objViewModel = new AsociadoVM();
            objViewModel.LstAsociados = objViewModel.GetLstAsociado();
            return View("Asociados", "_LayoutAdministrador", objViewModel);
        }
        [HttpPost]
        public ActionResult LstAsociados(AsociadoVM objViewModel)
        {
            objViewModel.LstAsociados = objViewModel.GetLstAsociado();
            return View("Asociados", "_LayoutAdministrador", objViewModel);
        }
        #endregion
    }
}