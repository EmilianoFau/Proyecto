using System;

namespace Proyecto_Chatbot
{
    public interface IPersona
    {
        public string Nombre {get; set;}
        public string Email {get; set;}
        public string Username {get; set;}
        private string Contraseña {get; set;}


    }
}