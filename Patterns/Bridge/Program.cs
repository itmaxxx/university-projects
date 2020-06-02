using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        interface Component
        {
            void ShowInfo();
        }

        class PC
        {
            private Component component;

            public PC(Component _component)
            {
                component = _component;
            }

            public void ShowComponentInfo()
            {
                component.ShowInfo();
            }
        }

        class GraphicsCard : Component
        {
            public void ShowInfo()
            {
                Console.WriteLine("It is graphic card info");
            }
        }

        class Processor : Component
        {
            public void ShowInfo()
            {
                Console.WriteLine("It is processor info");
            }
        }

        class HDD : Component
        {
            public void ShowInfo()
            {
                Console.WriteLine("It is HDD info");
            }
        }

        class RAM : Component
        {
            public void ShowInfo()
            {
                Console.WriteLine("It is RAM info");
            }
        }

        static void Main(string[] args)
        {
            GraphicsCard graphicsCard = new GraphicsCard();
            PC pc = new PC(graphicsCard);
            pc.ShowComponentInfo();
        }
    }
}
