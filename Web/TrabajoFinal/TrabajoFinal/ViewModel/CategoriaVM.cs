using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Model;
using TrabajoFinal.Globalization;

namespace TrabajoFinal.ViewModel
{
    public class CategoriaVM
    {
        public List<Categoria> lstCategoria {get; set;}

        public void Fill()
        {
            GymUPCEntities context = new GymUPCEntities();
            var query= context.Categoria.AsQueryable();
            lstCategoria = query.ToList();

        }
    }
}