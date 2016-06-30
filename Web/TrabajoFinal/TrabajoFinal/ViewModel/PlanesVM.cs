using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Model;
using TrabajoFinal.Globalization;

namespace TrabajoFinal.ViewModel
{
    public class PlanesVM
    {

        public List<Planes> lstPlanes { get; set; }
       

        public void Fill()
        {
            GymUPCEntities context = new GymUPCEntities();
            var query = context.Planes.AsQueryable();
            lstPlanes = query.ToList();
        }


    }
}