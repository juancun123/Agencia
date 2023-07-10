using System;
using System.Collections.Generic;
using System.Text;

namespace Agencia.src.model
{
    class Cliente
    {
        private string cedula;
        private string nombres;
        private string apellidos;
        private string telefono;
        private string direccion;
        private string email;
        private string ciudad;

        public void Registro(string cedula, string nombres, string apellidos, string telefono, string direccion, string email, string ciudad)
        {
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.ciudad = ciudad;
        }

        public void Eliminar()
        {
            this.cedula = null;
            this.nombres = null;
            this.apellidos = null;
            this.telefono = null;
            this.direccion = null;
            this.email = null;
            this.ciudad = null;
        }

        public void Actualizar(string cedula, string nombres, string apellidos, string telefono, string direccion, string email, string ciudad)
        {
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.ciudad = ciudad;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }

       
    }
}
