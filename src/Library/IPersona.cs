using System;

namespace Proyecto_Chatbot
{
    public interface IPersona
    {
        string Nombre {get; set;}
        string Email {get; set;}
        string Username {get; set;}
        void Registrarse(string username, string email, string password);
        void Login();
    }
}