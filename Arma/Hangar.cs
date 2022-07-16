using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Arma
{
    internal class Hangar:INotifyPropertyChanged
    {
        public List<AttackAircraft> attackAircraftList = new List<AttackAircraft>();
        public List<UAV> uavlist = new List<UAV>();
        private int _balance = 250000;

        public int Balance
        {
            get { return _balance; }
            set { _balance = value; OnPropertyChanged(); }
        }



        readonly int MAX_QUANTITY_OF_FIGHTERS = 0;
        readonly int MAX_QUANTITY_OF_ATTACKAIRCRAFT = 0;
        readonly int MAX_QUANTITY_OF_UAV = 0;
        readonly int MAX_QUANTITY_OF_ELECTRONICWARFARE = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public Hangar()
        {
            Random random = new Random();


            MAX_QUANTITY_OF_FIGHTERS = random.Next(3, 10);
            MAX_QUANTITY_OF_ATTACKAIRCRAFT = random.Next(3, 10);
            MAX_QUANTITY_OF_UAV = random.Next(3, 10);
            MAX_QUANTITY_OF_ELECTRONICWARFARE = random.Next(3, 10);
            AddNewUnit();
        }

        public void AddNewUnit()
        {

            while (attackAircraftList.Count < MAX_QUANTITY_OF_ATTACKAIRCRAFT)
            {
                attackAircraftList.Add(new AttackAircraft(producingCountry: "USA",
                                                          Model: "RC-12",
                                                          passangerCapacity: 2,
                                                          emptyWeight: 3318,
                                                          maxSpeed: 536,
                                                          price: 1000000,
                                                          guidedMissiles: 2,
                                                          notGuidedMissiles: 0,
                                                          bombs: 1));
            }

            while (uavlist.Count < MAX_QUANTITY_OF_UAV)
            {
                uavlist.Add(new UAV(producingCountry: "USA",
                                    Model: "MQ-1C Gray Eagle",
                                    passangerCapacity: 0,
                                    emptyWeight: 3318,
                                    maxSpeed: 309,
                                    price: 500000,
                                    wingspan: 17,
                                    payload: 3000,
                                    notGuidedMissiles: 0,
                                    guidedMissiles: 4,
                                    bombs: 4));
            }
        }

        public  void SellUnit(int HashCode, object list)
        {

        }
    }
}
