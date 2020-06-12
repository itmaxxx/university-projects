using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        private static Random random = new Random();

        public interface IComponent
        {
            void ShowInfo();
        }

        public class GraphicsCard : IComponent
        {
            public void ShowInfo()
            {
                Console.WriteLine("Graphic Card status : (working)");
                Console.WriteLine($"3D : {random.Next(0, 100)}%");
                Console.WriteLine($"Copy : {random.Next(0, 100)}%");
                Console.WriteLine($"Vieo encode : {random.Next(0, 100)}%");
                Console.WriteLine($"Video decode :  {random.Next(0, 100)}%");
                Console.WriteLine($"Graphic memory use :  {random.Next(0, 1024 * 8)} MB");
            }
        }

        public class CPU : IComponent
        {
            public void ShowInfo()
            {
                Console.WriteLine("CPU status : (working)");
                Console.WriteLine($"Usage : {random.Next(0, 100)}%");
                Console.WriteLine($"Processes : {random.Next(0, 500)} processes");
            }
        }

        public class HDD : IComponent
        {
            public void ShowInfo()
            {
                Console.WriteLine("HDD status : (working)");
                Console.WriteLine($"Active time : {random.Next(0, 100)}%");
            }
        }

        public class RAM : IComponent
        {
            public void ShowInfo()
            {
                Console.WriteLine("RAM status : (working)");
                Console.WriteLine($"Memory usage : {random.Next(0, 1024 * 16)} MB");
            }
        }

        public class PC
        {
            private readonly List<IComponent> components = new List<IComponent>();
            private int currentComponent = 0;

            public void AddComponent(IComponent component)
            {
                components.Add(component);
            }

            public void RemoveComponent(IComponent component)
            {
                components.Remove(component);
            }

            public void NextComponent()
            {
                if (currentComponent < components.Count - 1)
                {
                    currentComponent++;
                }

                ShowCurrentComponent();
            }

            public void PreviousComponent()
            {
                if (currentComponent > 0)
                {
                    currentComponent--;
                }

                ShowCurrentComponent();
            }

            public void ShowCurrentComponent()
            {
                components[currentComponent].ShowInfo();
            }

            public void ShowAllComponents()
            {
                foreach (var component in components)
                {
                    component.ShowInfo();
                }
            }

            public string GetCounterString()
            {
                return $"{currentComponent + 1}/{components.Count}";
            }
        }

        static void Main(string[] args)
        {
            PC pc = new PC();

            pc.AddComponent(new GraphicsCard());
            pc.AddComponent(new CPU());
            pc.AddComponent(new HDD());
            pc.AddComponent(new RAM());

            pc.ShowAllComponents();
        }
    }
}
