using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    struct Notebook
    {
        private string _model;
        private string _manufacturer;
        private double _price;
        public Notebook(string model, string manufacturer, double price)
        {
            _model = model;
            _manufacturer = manufacturer;
            _price = price;
        }
        public void ShowNotebookInfo()
        {
            Console.WriteLine("Model: {0}\nManufacturer: {1}\nPrice: {2}",
                _model, _manufacturer, _price);
        }
    }
}