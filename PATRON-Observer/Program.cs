using System;

namespace PATRON_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var observer1 = new EspecialistaRH("Marco");
            var observer2 = new EspecialistaRH("Maria");

            var proveedor = new AplicacionNotificacion();
            observer1.Subcribir(proveedor);
            observer2.Subcribir(proveedor);

            proveedor.AddAplicaciones(new(1, "Contador"));
            proveedor.AddAplicaciones(new(2, "Cantante"));

            observer1.ListaAplicacion();
            observer2.ListaAplicacion();

            observer2.UnSubcripcion();

            Console.WriteLine();
            Console.WriteLine($"{observer2.nombre} se ha eliminado su subcripcion");
            Console.WriteLine();

            proveedor.AddAplicaciones(new ( 3, "Sistemas"));

            observer1.ListaAplicacion();
            observer2.ListaAplicacion();
        }
    } 
}

