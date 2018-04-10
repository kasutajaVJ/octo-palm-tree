using System;

namespace GitHub
{
    internal class Tervitaja
    {
        /// <summary>
        /// Show greeting to console.
        /// </summary>
        /// <param name="nimi"></param>
        internal static void Tervita(string nimi)
        {
           Console.WriteLine("Hello " + nimi);
        }
    }
}