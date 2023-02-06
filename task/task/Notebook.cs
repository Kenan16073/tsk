using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace task
{
    internal class Notebook
    {
        public Notebook(string brand,string model)
        {
            this.Brand = brand;
            this.Model = model;
        }
        public string Brand;
        public string Model;
        public int Price;
        public void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand} - model:{Model} - price:{Price}");
        }
    }
}
