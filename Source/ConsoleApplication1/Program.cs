using ChargifyNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var Chargify = new ChargifyConnect("https://subdomain.chargify.com/", "api-key", "X");

                // Do some work here

                Console.WriteLine("Done!");
            }
            catch (ChargifyException chEx)
            {
                Console.WriteLine(chEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}