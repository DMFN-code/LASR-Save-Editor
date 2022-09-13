using LASR_Save_Editor.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LASR_Save_Editor.model
{
    public class Car : baseViewModel
    {
        public string Name { get; set; }
        public string ImgSource { get; set; }
        public int ID { get; set; }
        public bool IsOwned { get => _isOwned;
            set {
                if(!value)
                    IsWidebody = false;
                _isOwned = value;
                OnPropertyChanged();
                OnPropertyChanged("IsWidebody");
            }
        }
        public bool IsWidebody { get; set; }
        public List<Part> Parts { get; set; }
        public Car(string name, string imgSource, int id)
        {
            Name = name;
            ImgSource = imgSource;
            ID = id;
        }
        private bool _isOwned = false;
    }
}
