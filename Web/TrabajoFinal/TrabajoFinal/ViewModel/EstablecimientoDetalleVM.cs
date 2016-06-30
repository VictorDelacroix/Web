using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Model;

namespace TrabajoFinal.ViewModel
{
    public class EstablecimientoDetalleVM
    {
        public Establecimiento objEstablecimiento;

        public void Fill(int ID)
        {
            GymUPCEntities context = new GymUPCEntities();
            objEstablecimiento = context.Establecimiento.FirstOrDefault(x => x.IDEstablecimiento == ID);
        }
    }
}