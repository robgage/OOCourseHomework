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
            Console.WriteLine("Please select your contry of residence from the list below");
            Console.WriteLine("1. England");
            Console.WriteLine("2. Wales");
            Console.WriteLine("3. Scotland");
            Console.WriteLine("4. Ireland");
            Console.WriteLine("5. Northern Ireland");
            Console.WriteLine("6. Any Other Country");            

            int selected = Convert.ToInt32(Console.ReadLine());
            if (selected == 1)
            {
                return Country.England;
            }
            else if (selected == 2)
            {
                return Country.Wales;
            }
            else if (selected == 3)
            {
                return Country.Scotland;
            }
            else if (selected == 4)
            {
                return Country.Ireland;
            }
            else if (selected == 5)
            {
                return Country.NorthernIreland;
            }
            else if (selected == 6)
            {
                return Country.Other;
            }
            else
            {
                ApplicantDetails foo = new ApplicantDetails();
                foo.ItsAllBroken();
                return Country.Other;
            }
            
            
        }

        public int ReturnRHIDifference(Country SelectedCountry)
        {
            return (int)SelectedCountry;
        }
    }
}
