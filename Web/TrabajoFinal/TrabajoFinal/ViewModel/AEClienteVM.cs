using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoFinal.ViewModel
{
    public class AEClienteVM
    {
        public int IDCliente { get; set; }
        public String Usuario {get; set;}
        public String Pass { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String DNI { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }

        public AEClienteVM()
        {

        }

        public void Fill(int IDCliente, string Modo)
        {
            this.IDCliente = IDCliente;
            
            //if(IDCliente !="" && )

        }
        
    }
}