using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsuranceCalculator
{
    public class CountryOfResidence
    {
        public enum Country
        {
            England = 0,
            Wales = -100,
            Scotland = 200,
            Ireland = 50,
            NorthernIreland = 75,
            Other = 100
        }

        public Country SelectCountry()
        {            
            int optionNumber = 1;
            Console.WriteLine("Please select your contry of residence from the list below");
            foreach (Country option in Enum.GetValues(typeof(Country)))
            {
                Console.WriteLine("{0}. {1}", optionNumber, option.ToString());
                optionNumber++;
            }

            int selected = Convert.ToInt32(Console.ReadLine());
            int loop = 1;
            foreach (Country option in Enum.GetValues(typeof(Country)))
            {
                if (loop == selected)
                {
                    return option;
                }
            }

            return Country.Other;
        }

        public int ReturnRHIDifference(Country SelectedCountry)
        {
            return (int)SelectedCountry;
        }
    }
}
