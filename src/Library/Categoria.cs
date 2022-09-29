using System;

namespace Proyecto_Chatbot
{
    public class Categoria
    {
        public string Nombre {get; set;}
        public string Descripcion {get; set;}

        public Categoria(string nombre, string descripcion)
        {
            this.Descripcion = descripcion;
            this.Nombre = nombre;
        }
    }
}