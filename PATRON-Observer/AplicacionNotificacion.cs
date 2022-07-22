using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON_Observer
{
    class AplicacionNotificacion
    {
        private readonly List<IObserver<Aplicacion>> observers;
        public List<Aplicacion> aplicacion { get; set; }

        public AplicacionNotificacion()
        {
            observers = new();
            aplicacion = new();
        }
        public IDisposable Subcribir(IObserver<Aplicacion> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                foreach (var item in aplicacion)
                {
                    observer.OnNext(item);
                }
            }
            return new Unsubcripcion(observers, observer);
        }
        public void AddAplicaciones(Aplicacion app)
        {
            aplicacion.Add(app);

            foreach (var observer in observers)
            {
                observer.OnNext(app);
            }
        }
        public void CerrarAplicacion()
        {
            aplicacion.Add(app);

        }
        }
    }

