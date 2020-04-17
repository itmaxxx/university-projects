using System;

public enum FuelType { gasoline, diesel, gas }

public enum CarType { sedan, coupe, universal, hatchback }

public enum TransmissionTypes { automatic, manual, robot }

namespace Abstract_Factory__txt_
{
    class Engine
    {
        protected int Volume;
        protected int NumberOfCylinders;
        protected FuelType FuelType;

        public void SetVolume(int volume)
        {
            this.Volume = volume;
        }
        public int GetVolume()
        {
            return Volume;
        }

        public void SetNumberOfCylinders(int numberOfCylinders)
        {
            this.NumberOfCylinders = numberOfCylinders;
        }
        public int GetNumberOfCylinders()
        {
            return NumberOfCylinders;
        }

        public void SetFuelType(FuelType fuelType)
        {
            this.FuelType = fuelType;
        }
        public FuelType GetFuelType()
        {
            return FuelType;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"Engine Info :\nVolume : {Volume}\nNumber Of Cylinders : {NumberOfCylinders}\nFuel Type : {FuelType}");
        }
    }

    abstract class Car
    {
        protected Engine Engine;
        protected CarType CarType;
        protected TransmissionTypes Transmission;

        public void SetEngine(Engine engine)
        {
            this.Engine = engine;
        }
        public Engine GetEngine()
        {
            return Engine;
        }

        public void SetCarType(CarType carType)
        {
            this.CarType = carType;
        }
        public CarType GetCarType()
        {
            return CarType;
        }

        public void SetTransmission(TransmissionTypes transmission)
        {
            this.Transmission = transmission;
        }
        public TransmissionTypes GetTransmission()
        {
            return Transmission;
        }
    
        public void ShowInfo()
        {
            System.Console.WriteLine($"Car Info :\nCar Type : {CarType}\nTransmission : {Transmission}");

            if (Engine != null) {
                Engine.ShowInfo();
            }
        }
    }

    class InfinitiEngine : Engine
    {
        public InfinitiEngine()
        {
            Volume = 3500;
            NumberOfCylinders = 6;
            FuelType = FuelType.gasoline;
        }
    }

    class AudiEngine : Engine
    {
        public AudiEngine()
        {
            Volume = 3000;
            NumberOfCylinders = 8;
            FuelType = FuelType.diesel;
        }
    }

    class InfinitiG35x : Car
    {
        public InfinitiG35x()
        {
            CarType = CarType.sedan;
            Transmission = TransmissionTypes.automatic;
        }
    }

    class AudiA7 : Car
    {
        public AudiA7()
        {
            CarType = CarType.sedan;
            Transmission = TransmissionTypes.automatic;
        }
    }

    interface ICarFactory
    {
        Car CreateCar();
    }

    class InfinitiG35xFactory : ICarFactory
    {
        public Car CreateCar()
        {
            Engine infinitiEngine = new InfinitiEngine();

            Car car = new InfinitiG35x();
            car.SetEngine(infinitiEngine);

            return car;
        }
    }

    class AudiA7Factory : ICarFactory
    {
        public Car CreateCar()
        {
            Engine audiEngine = new AudiEngine();

            Car car = new AudiA7();
            car.SetEngine(audiEngine);

            return car;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InfinitiG35xFactory infinitiFactory = new InfinitiG35xFactory();
            AudiA7Factory audiFactory = new AudiA7Factory();

            Car car = infinitiFactory.CreateCar();

            car.ShowInfo();

            car = audiFactory.CreateCar();

            car.ShowInfo();
        }
    }
}
