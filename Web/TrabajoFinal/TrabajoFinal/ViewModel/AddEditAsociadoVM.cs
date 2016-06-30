using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Model;
namespace TrabajoFinal.ViewModel
{
    public class AddEditAsociadoVM
    {
        public Asociado objAsociado { get; set; }
        public int? IDAsociado { get; set; }
        public HttpPostedFileBase Img { get; set; }
        public int? IDAdministrador { get; set; }
        public AddEditAsociadoVM() { }

        public Asociado getAsociado(int? IDAsociado)
        {
            GymUPCEntities context = new GymUPCEntities();
            Asociado obj = context.Asociado.FirstOrDefault(x => x.IDAsociado == IDAsociado);
            return obj;
        }
        public void EditAsociado(Asociado objAsociado, int? IDAsociado)
        {
            GymUPCEntities context = new GymUPCEntities();
            Asociado obj = context.Asociado.FirstOrDefault(x => x.IDAsociado == IDAsociado);

            obj.Direccion = objAsociado.Direccion;
            obj.Pass = objAsociado.Pass;
            obj.Telefono = objAsociado.Telefono;
            obj.Nombre = objAsociado.Nombre;
            obj.Apellido = objAsociado.Apellido;
            obj.DNI = objAsociado.DNI;
            obj.Usuario = objAsociado.Usuario;
            obj.Direccion = objAsociado.Direccion;
            obj.Telefono = objAsociado.Telefono;

            context.SaveChanges();
        }
        public void DeleteAsociado(int? IDAsociado)
        {
            GymUPCEntities context = new GymUPCEntities();
            Asociado obj = context.Asociado.FirstOrDefault(x => x.IDAsociado == IDAsociado);
            context.SaveChanges();
        }
        public void AddAsociado(Asociado obj)
        {
            GymUPCEntities context = new GymUPCEntities();
            context.Asociado.Add(obj);
            context.SaveChanges();
        }
    }
}