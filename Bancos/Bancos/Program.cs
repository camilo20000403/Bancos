using System;

namespace Bancos
{
    class Program
    {
        static void Main(string[] args)
        {
            float cuenta, saldo, saldoConsignacion, saldoRetiro;
            String linea, nombre;
            Console.WriteLine("Ingrese el Nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese #cuenta ");
            linea = Console.ReadLine();
            cuenta = float.Parse(linea);

            Console.WriteLine("Ingrese Saldo de Apertura ");
            linea = Console.ReadLine();
            saldo = float.Parse(linea);


            Console.WriteLine("Ingrese Saldo de Consignacion ");
            linea = Console.ReadLine();
            saldoConsignacion = float.Parse(linea);
            saldoConsignacion = saldo + saldoConsignacion;
            Console.WriteLine("SU SALDO ES  " + saldoConsignacion);

            Console.WriteLine("Ingrese Saldo de Retiro ");
            linea = Console.ReadLine();
            saldoRetiro = float.Parse(linea);



            saldoRetiro = saldo - saldoRetiro;


            Console.WriteLine("SU SALDO ES  " + saldoRetiro);
            Console.ReadLine();
        }
    }
}
