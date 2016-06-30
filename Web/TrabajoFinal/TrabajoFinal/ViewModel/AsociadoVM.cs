using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Model;
using TrabajoFinal.Globalization;

namespace TrabajoFinal.ViewModel
{
    public class AsociadoVM
    {
        public List<Asociado> LstAsociados { get; set; }
        public string Filtro { get; set; }

        public void Fill()
        {
            GymUPCEntities context = new GymUPCEntities();
            var query = context.Asociado.AsQueryable();
            LstAsociados = query.ToList();  
        }
        public List<Asociado> GetLstAsociado()
        {
            GymUPCEntities context = new GymUPCEntities();
            var query = context.Asociado.AsQueryable();
            if (!string.IsNullOrEmpty(Filtro))
                query = query.Where(x => x.Apellido.Contains(Filtro.ToUpper()) || x.Nombre.Contains(Filtro.ToUpper()));
            LstAsociados = query.ToList();
            return LstAsociados;
        }
    }
}