namespace Arma
{
    internal abstract class Car : GameItem
    {


        public string ProducingCountry { get; }
        public string Model { get; }
        public int Price { get; }
        public int PassangerCapacity { get; }
        public int EmptyWeight { get; }
        public int MaxSpeed { get; }


        public Car(string producingCountry, string Model, int passangerCapacity, int emptyWeight, int maxSpeed, int price)
        {
            Hash = GetHashCode();
            type = ItemType.Unit;

            this.Model = Model;
            ProducingCountry = producingCountry;
            PassangerCapacity = passangerCapacity;
            EmptyWeight = emptyWeight;
            MaxSpeed = maxSpeed;
            Price = price;

        }

        public virtual string GetInfo()
        {
            string info = $"Страна производитель:{ProducingCountry}\n" +
                $"Модель:{Model}\n" +
                $"Вместимость пассажиров:{PassangerCapacity}\n" +
                $"Вес:{EmptyWeight}\n" +
                $"Максимальная скорость:{MaxSpeed}\n";

            return info;
        }

        



    }


    internal class ElectronicWarfare : Car
    {
        public int Range { get; }
        public ElectronicWarfare(string producingCountry, string Model, int passangerCapacity, int emptyWeight, int maxSpeed, int price, int range) : base(producingCountry, Model, passangerCapacity, emptyWeight, maxSpeed, price)
        {
            Range = range;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Дальность действия:{Range}\n";
        }
    }
}
