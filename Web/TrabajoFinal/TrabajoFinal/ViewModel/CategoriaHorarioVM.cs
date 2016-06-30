using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Model;
using TrabajoFinal.Globalization;

namespace TrabajoFinal.ViewModel
{
    public class CategoriaHorarioVM
    {
        public List<CategoriaHorario> lstCategoriaH { get; set; }
        public Categoria objCategoria { get; set; }

        public void Fill(int ID)
        {
            GymUPCEntities context = new GymUPCEntities();
            var query = context.CategoriaHorario.Where(x => x.IDCategoria == ID);
            lstCategoriaH = query.ToList();
            objCategoria = context.Categoria.FirstOrDefault(x => x.IDCategoria == ID);
        }

    }
}