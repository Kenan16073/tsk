using System;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook("Asus", "Tuf");
            notebook1.Price = 1500;
            notebook1.ShowInfo();

            Notebook notebook2 = new Notebook("Hp","840 G8");
            notebook2.Price = 1000;
            notebook2.ShowInfo();

            Notebook notebook3= new Notebook("Dell","Inspiron");
            notebook3.Price = 1300;
            notebook3.ShowInfo();

            Notebook[]arr=new Notebook[] {notebook1,notebook2, notebook3};

            var count = 0;
            var sum =0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i].Price;
                count++;
                
            }
              Console.WriteLine($"ortalama qiymet:{ sum/count}");



        }
       
    }
}
