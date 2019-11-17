using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzenBord_Database
{
    public delegate void delegateSendMessage(string Message);
    class Program
    {
        static void Main(string[] args)
        {
            Spel spel = new Spel();
            //delegateSendMessage SendMessage = new delegateSendMessage(PrintMessage);
            spel.OnSendMessage += PrintMessage;

            Console.WriteLine("Je staat op start. Gooi je dobbelsteen (g)");
            spel.Starten();
        }

        public static void PrintMessage(string Message)
        {
            Console.WriteLine(Message);
            Console.WriteLine("Om verder te gaan druk op (g)");
            Console.ReadKey();
        }
    }
}
