using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class MojaZaleznosc2 : IMojaZaleznosc
    {
        public MojaZaleznosc2()
        {
        }

        public void NapiszWiadomosc(string message)
        {
            Console.WriteLine
            ($"wywolano MojaZaleznosc2 .NapiszWiadomosc. Wiadomosc: {message}");
        }
    }
}
