using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using TrabajoFinal.Globalization;
using TrabajoFinal.Model;
namespace TrabajoFinal.ViewModel
{



    public class LoginVM
    {
        public Cliente objCliente { get; set; }
        public string Imagen { get; set; }

        [Required(ErrorMessageResourceName = "CampoUsuario", ErrorMessageResourceType = typeof(ValidationString))]
        public string UsuarioCodigo { get; set; }
        [Required(ErrorMessageResourceName = "CampoPassword", ErrorMessageResourceType = typeof(ValidationString))]
        public string UsuarioPassword { get; set; }
        public LoginVM() { }
        public void AddCliente(Cliente objCliente)
        {

            GymUPCEntities context = new GymUPCEntities();
            context.Cliente.Add(objCliente);
            context.SaveChanges();
        }
        public bool ExisteCliente(Cliente objCliente)
        {

            GymUPCEntities context = new GymUPCEntities();
            if (context.Cliente.FirstOrDefault(x => x.IDCliente == objCliente.IDCliente) != null) return true;
            return false;
        }
        public bool ExisteClienteRS(Cliente objCliente)
        {
            GymUPCEntities context = new GymUPCEntities();
            if (context.Cliente.FirstOrDefault(x => x.IDRS == objCliente.IDRS) != null) return true;
            return false;
        }
        public Cliente GetClienteRS(string IDRS)
        {
            GymUPCEntities context = new GymUPCEntities();
            return context.Cliente.FirstOrDefault(x => x.IDRS == IDRS);
        }

    }
}