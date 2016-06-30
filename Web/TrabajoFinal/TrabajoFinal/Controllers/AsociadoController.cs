﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoFinal.Model;
using TrabajoFinal.ViewModel;

namespace TrabajoFinal.Controllers
{
    public class AsociadoController : Controller
    {
        
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




    }
}