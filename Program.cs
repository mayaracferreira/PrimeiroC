using System;

namespace PrimeiroC
{
    class Program
    {
        static void Main(string[] args) {
            Veiculo c1 = new Veiculo("honda", "city", "FAM4334", "cinza", 50, false, 40, 0, 38000);


            c1.status();
            c1.acelerar();
            c1.abastecer(30);
            c1.frear();
            c1.pintar("preto");
            c1.ligar();
            c1.desligar();



            
     
            







        }
    }
}
