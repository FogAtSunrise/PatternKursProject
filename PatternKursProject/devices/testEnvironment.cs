using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternKursProject.devices
{
    /// <summary>
    /// класс для генерации тестовых показателей среды
    /// </summary>
    class testEnvironment
    {
        private static Random rnd = new Random();
       
        public static double getMean(string name)
        {
            double mean = 0;
            switch (name)
                {
                case "Термометр":
                    {mean = -40.0 + rnd.NextDouble() * (40.0 + 40.0);
                        break;}

                case "Барометр":
                    {
                        mean = 600.0 + rnd.NextDouble() * (200.0);
                        break;
                    }
                case "Психрометр":
                    {
                        mean = 0.0 + rnd.NextDouble() * (100.0);
                        break;
                    }
            }
            return mean;

        }
    }
}
