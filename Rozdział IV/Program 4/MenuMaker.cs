using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    class MenuMaker
    {
        public Random Randomizer;
        public string[] Meats = { "Pieczona wołowina", "Salami", "Indyk", "Szynka", "Karkówka" };
        public string[] Condiments = { "Żółta musztarda", "Musztarda miodowa", "Brązowa musztarda", "Majonez", "Przyprawa", "Sos francuski" };
        public string[] Breads = { "Chleb ryżowy", "Chleb biały", "Chleb zbożowy", "Pumpernikiel", "Chleb włoski", "Bułka" };
        public string GetMenuItem()
        {
            string RandomMeat = Meats[Randomizer.Next(Meats.Length)];
            string RandomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string RandomBread = Breads[Randomizer.Next(Breads.Length)];
            return RandomMeat + ", " + RandomCondiment + ", " + RandomBread;
        }

    }
}
