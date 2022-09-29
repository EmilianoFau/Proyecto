using System;

namespace Proyecto_Chatbot
{
    public class OfertaLaboral
    {
        public int Id {get; set;}
        public Categoria Categoria {get; set;}
        public Trabajador Trabajador {get; set;}
        public string Descripcion {get; set;}
        public int Precio {get; set;}
        public OfertaLaboral(int id, Categoria categoria, Trabajador trabajador, string descripcion, int precio)
        {
            this.Id = id;
            this.Categoria = categoria;
            this.Trabajador = trabajador;
            this.Descripcion = descripcion;
            this.Precio = precio;
        }

    }
}