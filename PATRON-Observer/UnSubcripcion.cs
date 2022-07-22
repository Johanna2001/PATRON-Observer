using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON_Observer
{
    class UnSubcripcion:IDisposable
    {
        private readonly List<IObserver<Aplicacion>> observers;
        public List<Aplicacion> observer { get; set; }

        public UnSubcripcion(List<IObserver<Aplicacion>> observers, IObserver<Aplicacion> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }
    }
}
