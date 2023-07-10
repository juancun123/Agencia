using System;
using System.Collections.Generic;
using System.Text;

namespace Agencia.src.model
{
    class Usuario
    {
        private string idUsuario;
        private string nombreUsuario;
        private string contrasenia;
        private int rolUsuario;

        public Usuario()
        {
            
        }

        public string IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }
        public int RolUsuario
        {
            get { return rolUsuario; }
            set { rolUsuario = value;}
        }

        public void Registro(string idUsuario, string nombreUsuario, string contrasenia, int rolUsuario)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
            this.rolUsuario = rolUsuario;
        }

        public void ActualizarContra(string contrasenia)
        {
            this.contrasenia = contrasenia;
        }

        public string login(string usuario,string contrasenia)
        {
            if(this.nombreUsuario != usuario)
            {
                throw new Exception("El usuario ingresado no se encuentra registrado.");
            }
            if(this.contrasenia != contrasenia)
            {
                throw new Exception("La contraseña ingresada no se encuentra registrada.");
            }
            return this.nombreUsuario;

        }
    }
}
