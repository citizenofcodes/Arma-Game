using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Arma
{
    /// <summary>
    /// Логика взаимодействия для UnitView.xaml
    /// </summary>
    public partial class UnitView : UserControl
    {

        public int Price;

        internal UnitView(object Unit)
        {
            
            

            InitializeComponent();


            if (Unit is AttackAircraft aircraft)
            {
                InfoBlock.Text = aircraft.GetInfo();
                HashBlock.Text = aircraft.Hash.ToString();
                Price = aircraft.GetPrice();
            }

            else if (Unit is Fighter fighter)
            {
                InfoBlock.Text = fighter.GetInfo();
                HashBlock.Text = fighter.Hash.ToString();
                Price = fighter.GetPrice();
            }         
            
            else if (Unit is UAV uav)
            {
                InfoBlock.Text = uav.GetInfo();
                HashBlock.Text = uav.Hash.ToString();
                Price = uav.GetPrice();
            }

            else if (Unit is ElectronicWarfare electronicWarfare)
            {
                InfoBlock.Text = electronicWarfare.GetInfo();
                HashBlock.Text = electronicWarfare.Hash.ToString();
                Price = electronicWarfare.Price;
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

           

        }
    }
}
