namespace Arma
{
    internal abstract class Plane : GameItem
    {

        public string ProducingCountry { get; }
        public string Model { get; }
        public int Price { get; }
        public int PassangerCapacity { get; }
        public int EmptyWeight { get; }
        public int MaxSpeed { get; }

        public Plane(string producingCountry, string Model, int passangerCapacity, int emptyWeight, int maxSpeed, int price)
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

        public  int GetPrice()
        {
            return Price;
        }

    }


    internal class Fighter : Plane
    {
        // To be updated..
        public Fighter(string producingCountry, string Model, int passangerCapacity, int emptyWeight, int maxSpeed, int price) : base(producingCountry, Model, passangerCapacity, emptyWeight, maxSpeed, price)
        {

        }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
    }

    internal class AttackAircraft : Plane
    {
        public int NotGuidedMissiles { get; }

        public int GuidedMissiles { get; }

        public int Bombs { get; }
        public AttackAircraft(string producingCountry, string Model, int passangerCapacity, int emptyWeight, int maxSpeed, int price, int guidedMissiles, int notGuidedMissiles, int bombs) : base(producingCountry, Model, passangerCapacity, emptyWeight, maxSpeed, price)
        {
            GuidedMissiles = guidedMissiles;
            NotGuidedMissiles = notGuidedMissiles;
            Bombs = bombs;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + $"Неуправляемые ракеты:{NotGuidedMissiles}\n" +
                $"Управляемые ракеты:{GuidedMissiles}\n" +
                $"Бомбы:{Bombs}\n";
        }

    }

    internal class UAV : Plane
    {
        public int NotGuidedMissiles { get; }

        public int GuidedMissiles { get; }

        public int Bombs { get; }

        public int Wingspan { get; }

        public int Payload { get; }
        public UAV(string producingCountry, string Model, int passangerCapacity, int emptyWeight, int maxSpeed, int price, int wingspan, int payload, int notGuidedMissiles, int guidedMissiles, int bombs) : base(producingCountry, Model, passangerCapacity, emptyWeight, maxSpeed, price)
        {
            Wingspan = wingspan;
            Payload = payload;
            NotGuidedMissiles = notGuidedMissiles;
            GuidedMissiles = guidedMissiles;
            Bombs = bombs;
        }


        public override string GetInfo()
        {
            return base.GetInfo() + $"Неуправляемые ракеты:{NotGuidedMissiles}\n" +
                $"Управляемые ракеты:{GuidedMissiles}\n" +
                $"Бомбы:{Bombs}\n" +
                $"Размах крыла:{Wingspan}\n" +
                $"Полезная нагрузка:{Payload}\n";
        }
    }


}
