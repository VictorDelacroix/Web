using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoFinal.Model;

namespace TrabajoFinal.BE
{
    public class AdministradorBE
    {
        public bool ValidarLogin(string user, string pass)
        {
            try
            {
                GymUPCEntities context = new GymUPCEntities();
                Administrador objAdministrador= context.Administrador.FirstOrDefault(x => x.Usuario == user && x.Pass == pass);

                if (objAdministrador != null) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #region Asociado

        public void AddAsociado(Asociado objAsociado)
        {
            GymUPCEntities context = new GymUPCEntities();
            context.Asociado.Add(objAsociado);
            context.SaveChanges();
        }
        public void EditAsociado(Asociado objAsociado)
        {
            GymUPCEntities context = new GymUPCEntities();
            Asociado obj=context.Asociado.FirstOrDefault(x => x.IDAsociado == objAsociado.IDAsociado);
            obj.Apellido = objAsociado.Apellido;
            obj.Direccion = objAsociado.Direccion;
            obj.DNI = objAsociado.DNI;
            obj.Nombre = objAsociado.Nombre;
            obj.Pass = objAsociado.Pass;
            obj.Telefono = objAsociado.Telefono;
            obj.Usuario = objAsociado.Usuario;
            
            context.SaveChanges();
        }
        public void DeleteAsociado(Asociado objAsociado)
        {
            GymUPCEntities context = new GymUPCEntities();
            context.Asociado.Remove(objAsociado);
            context.SaveChanges();
        }

        public List<Asociado>LstAsociados()
        {
            GymUPCEntities context = new GymUPCEntities();
            return context.Asociado.ToList();
        }

        #endregion
        #region Establecimiento

        public List<Establecimiento> LstEstablecimientos()
        {
            GymUPCEntities context = new GymUPCEntities();
            return context.Establecimiento.ToList();
        }
        public void AddEstablecimiento(Establecimiento objEstablecimiento)
        {
            GymUPCEntities context = new GymUPCEntities();
            context.Establecimiento.Add(objEstablecimiento);
            context.SaveChanges();
        }
        public void EditEstablecimiento(Establecimiento objEstablecimiento)
        {
            GymUPCEntities context = new GymUPCEntities();
            Establecimiento obj = context.Establecimiento.FirstOrDefault(x => x.IDEstablecimiento == objEstablecimiento.IDEstablecimiento);
            obj.Descripcion = objEstablecimiento.Descripcion;
            obj.Latitud = objEstablecimiento.Latitud;
            obj.Longitud = objEstablecimiento.Longitud;
            obj.Nombre = objEstablecimiento.Nombre;
            context.SaveChanges();
        }
        public void DeleteEstablecimiento(Establecimiento objEstablecimiento)
        {
            GymUPCEntities context = new GymUPCEntities();
            context.Establecimiento.Remove(objEstablecimiento);
        }
        #endregion
        public void EditAdministrador(Administrador objAdministrador)
        {
            GymUPCEntities context = new GymUPCEntities();
            Administrador obj = context.Administrador.FirstOrDefault(x => x.IDAdministrador == objAdministrador.IDAdministrador);
            obj.Apellido = objAdministrador.Apellido;
            obj.Direccion = objAdministrador.Direccion;
            obj.DNI = objAdministrador.DNI;
            obj.Nombre = objAdministrador.Nombre;
            obj.Pass = objAdministrador.Pass;
            obj.Telefono = objAdministrador.Telefono;
            obj.Usuario = objAdministrador.Usuario;
            context.SaveChanges();
        }

        public Administrador getAdministrador(string usuario,string pass)
        {
            GymUPCEntities context = new GymUPCEntities();
            Administrador objAdministrador = context.Administrador.FirstOrDefault(x => x.Usuario == usuario && x.Pass == pass);
            return objAdministrador;
        }
    }
}