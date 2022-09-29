using System;
using System.Collections.Generic;

namespace Proyecto_Chatbot
{
    public class Trabajador : IPersona
    {
        public string Nombre {get; set;}
        public string Email {get; set;}
        public string Username {get; set;}
        private string Contraseña {get; set;}
        public int Telefono {get; set;}
        public string Ubicacion {get; set;}
        public double Reputacion {get; set;}
        public List<OfertaLaboral> Ofertas = new List<OfertaLaboral>();
        public void CrearOferta(OfertaLaboral oferta)
        {
            /* Code here */
        }
        public void Calificar(Calificacion calificacion)
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