using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON_Observer
{
    class EspecialistaRH : IObserver<Aplicacion>
    {
        public string nombre { get; set; }
        public List<Aplicacion> aplicacion { get; set; }

        public EspecialistaRH(string nombre)
        {
            this.nombre = nombre;
            aplicacion = new();
        }

        public virtual void Subcribir(AplicacionNotificacion proveedor)
        {
            cancelacion = proveedor.Subcribir(this);
        }
        public virtual void UnSubcripcion()
        {
            cancelacion.Disponible();
            aplicacion.Clear();
        }
        public void OnCompleted()
        {
            Console.WriteLine($"Hola, {nombre}! no estamos aceptando ninguna aplicacion más");
        }

        public void OnError(Exception error)
        {

        }
        


        public void ListaAplicacion()
        {
            if (aplicacion.Any())
            {
                foreach (var app in aplicacion)
                {
                    Console.WriteLine($"Hola, {nombre}! {app.NombreAplicacion} acaba de solicitar el trabajo no. {app.IdJob}");
                }
            }
            else {
                Console.WriteLine($"Hola, {nombre}! Aún no hay aplicaciones");
            }
        }
    }
}
