using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD6
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(0.6);
            Orange orange = new Orange(0.25);
            Checkout checkout = new Checkout(0, [apple, apple, orange]);
        }

    }
}
