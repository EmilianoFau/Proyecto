using System;

namespace Proyecto_Chatbot
{
    public class Calificacion
    {
        public string Descripcion{get; set;}
        public double Puntaje {get; set;}

        public Calificacion(string descripcion, double puntaje)
        {
            this.Descripcion = descripcion;
            this.Puntaje = puntaje;
        }
    }
}