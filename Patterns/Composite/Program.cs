using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Названия переменных взяты из задания, для удобства
            Component reception = new OfficeComponent("Приемная");

            Component a = new OfficeComponent("Должна быть выполнена в теплых тонах");
            reception.Add(a);

            Component b = new OfficeComponent("Журнальный столик");
                Component bi = new OfficeComponent("10-20 журналов типа «компьютерный мир»");
                b.Add(bi);
            reception.Add(b);

            Component c = new OfficeComponent("Мягкий диван");
            reception.Add(c);

            Component d = new OfficeComponent("Стол секретаря");
                Component di = new OfficeComponent("Компьютер");
                    Component di1 = new OfficeComponent("Важно наличие большого объема жесткого диска");
                    di.Add(di1);
                d.Add(di);
                Component dii = new OfficeComponent("Офисный инструментарий");
                d.Add(dii);
            reception.Add(d);

            Component e = new OfficeComponent("Кулер с теплой и холодной водой");
            reception.Add(e);

            reception.Print();
        }
    }

    abstract class Component
    {
        protected string name;
        protected int price;

        public Component(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }

        public virtual void Print() { }
    }

    class OfficeComponent : Component
    {
        private List<Component> components = new List<Component>();

        public OfficeComponent(string name, int price = 0)
            : base(name, price)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine($"{name}{(price != 0 ? $" {price}$" : string.Empty)}");
            
            if (components.Count > 0)
            {
                Console.WriteLine("Подузлы : ");

                for (int i = 0; i < components.Count; i++)
                {
                    components[i].Print();
                }
            }
        }
    }
}
