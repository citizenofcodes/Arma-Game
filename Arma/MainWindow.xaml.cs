using System.Windows;

namespace Arma
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var hangar = new Hangar();

            for (int i = 0; i < hangar.attackAircraftList.Count; i++)
            {
                var unit = new UnitView(hangar.attackAircraftList[i]);

                UnitViewer.Children.Add(unit);

            }

            for (int i = 0; i < hangar.uavlist.Count; i++)
            {
                var unit = new UnitView(hangar.uavlist[i]);

                UnitViewer.Children.Add(unit);
            }

            DataContext = hangar;

        }
    }
}
