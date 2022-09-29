using System;
using System.Collections.Generic;

namespace Proyecto_Chatbot
{
    public class Empleador : IPersona
    {
        public string Nombre {get; set;}
        public string Email {get; set;}
        public string Username {get; set;}
        private string Contraseña {get; set;}
        public int Telefono {get; set;}
        public string Ubicacion {get; set;}
        public double Reputacion {get; set;}
        public List<Calificacion> Calificaciones = new List<Calificacion>();
        public List<Trabajador> Trabajadores = new List<Trabajador>();

        public Empleador(string nombre, string email, string username, string contraseña, int telefono, string ubicacion, double reputacion)
        {
            this.Nombre = nombre;
            this.Email = email;
            this.Username = username;
            this.Contraseña = contraseña;
            this.Telefono = telefono;
            this.Ubicacion = ubicacion;
            this.Reputacion = reputacion;
        }
        public void Calificar(Calificacion calificacion)
        {
            /* Code here */
        }
        public void ContratarTrabajador(Contratacion contratacion)
        {
            /* Code here */
        }
        public void DespedirTrabajador(Trabajador trabajador)
        {
            /* Code here */
        }
        public void Registrarse(string username, string email, string password)
        {
            /* Code here */
        }
        public void Login()
        {
            /* Code here */
        }
    }

}
