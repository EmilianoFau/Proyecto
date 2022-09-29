using System;

namespace Proyecto_Chatbot
{
    public class Administrador : IPersona
    {
        public string Nombre {get; set;}
        public string Email {get; set;}
        public string Username {get; set;}
        private string Contraseña {get; set;}
        public Administrador(string nombre, string email, string username, string contraseña)
        {
            this.Nombre = nombre;
            this.Email = email;
            this.Username = username;
            this.Contraseña = contraseña;
        }
        
        public void CrearCategoria(Categoria categoria)
        {
            /* Code here */
        }
        public void EliminarCategoria(Categoria categoria)
        {
            /* Code here */
        }
        public void EliminarOferta(OfertaLaboral oferta)
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