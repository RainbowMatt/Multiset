using System;
using MultiSetClassLibray;

namespace Multiset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiSet<char> m = new MultiSet<char>();
            m.Add('a');
            m.Add('c');
            m.Add('b');
            Console.WriteLine(m);
        }
    }
}
