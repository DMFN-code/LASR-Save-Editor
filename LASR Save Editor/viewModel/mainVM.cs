using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LASR_Save_Editor.model;
using System.Text.Json;

namespace LASR_Save_Editor.viewModel
{
    public class mainVM : baseViewModel
    { 
        public ObservableCollection<Car> Garage { get; set; }
        public mainVM()
        {
            //Garage.Add(new Car("Hatch S2","assets/img/Model_Hatch_S2.png",69));
            //Garage.Add(new Car("Hatch Trend", "assets/img/Model_Hatch_Trend.png", 70));
            string carsJson = File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets/cars.json"));
            var cars = JsonSerializer.Deserialize <Car[] >(carsJson);
            Garage = new ObservableCollection<Car>(cars);
        }
    }
}
