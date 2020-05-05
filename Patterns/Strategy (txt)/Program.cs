using System;

namespace Strategy
{
    interface IPrint 
    {
        void Print();
    }

    class BlackAndWhiteCartridge : IPrint
    {
        public void Print()
        {
            System.Console.WriteLine("Black And White Print");
        }
    }

    class ColourfulCartridge : IPrint
    {
        public void Print() 
        {
            System.Console.WriteLine("Colourful Print");
        }
    }

    class Printer 
    {
        private IPrint _Printer;

        public Printer(IPrint Printer) {
            _Printer = Printer;
        }

        public void Print() 
        {
            _Printer.Print();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Printer BwPrinter = new Printer(new BlackAndWhiteCartridge());
            BwPrinter.Print();

            Printer CPrinter = new Printer(new ColourfulCartridge());
            CPrinter.Print();
        }
    }
}
