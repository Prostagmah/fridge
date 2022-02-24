using System;
using System.Threading;

namespace Holodos
{
    class Fridge
    {
        private string food;
        public string Food
        {
            get
            {
                return food + " Заморожен!";  //I'm freeze your soul!
            }
            set
            {
                food = value;
            }
        }
        private int time = 0;
        public int Time
        {
            get
            {
                return time;
            }
            set
            {
                if (value <= 60 && value >= 0)
                {
                    time = value * 1000;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }
        public void Freezing()
        {
            Console.WriteLine($"Вы положили {food} ");
            Thread.Sleep(time);
            Console.WriteLine(Food);

        }
    }
}
