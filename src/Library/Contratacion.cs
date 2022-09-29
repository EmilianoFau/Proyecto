using System;

namespace Proyecto_Chatbot
{
    public class Contratacion
    {
        public OfertaLaboral OfertaLaboral {get; set;}
        public Empleador Empleador {get; set;}
        public Trabajador Trabajador {get; set;}
        public int CostoServicio {get; set;}
        public string Descripcion {get; set;}

        public Contratacion(OfertaLaboral ofertaLaboral, Empleador empleador, Trabajador trabajador, int costoServicio, string descripcion)
        {
            this.OfertaLaboral = ofertaLaboral;
            this.Empleador = empleador;
            this.Trabajador = trabajador;
            this.CostoServicio = costoServicio;
            this.Descripcion = descripcion;
        }
    }
}