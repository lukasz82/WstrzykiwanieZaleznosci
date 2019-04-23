using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class MojaZaleznosc : IMojaZaleznosc
    {
        public MojaZaleznosc()
        {
        }

        public void NapiszWiadomosc(string message)
        {
            Console.WriteLine
            ($"wywolano MojaZaleznosc.NapiszWiadomosc. Wiadomosc: {message}");
        }
    }
}
