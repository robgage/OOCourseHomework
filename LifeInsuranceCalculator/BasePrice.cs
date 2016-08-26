using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeInsuranceCalculator
{
    public class BasePrice
    {
        public int LowerAge { get; set; }
        public int MaxAge { get; set; }
        public bool isMale { get; set; }
        public int Base { get; set; }

        public decimal ReturnBasePrice(ApplicantDetails App)
        {
            List<BasePrice> list = LoadBasePrice();
            foreach (BasePrice Price in list)
            {
                if (App.Age >= Price.LowerAge && App.Age <= Price.MaxAge)
                {
                    if (App.isMale == Price.isMale)
                    {
                        return Price.Base;
                    }
                }                    
            }
            return 0;
        }
        private List<BasePrice> LoadBasePrice()
        {
            List<BasePrice> List = new List<BasePrice>();
            List.Add(new BasePrice() { LowerAge = 0, MaxAge = 18, isMale = true, Base = 150 });
            List.Add(new BasePrice() { LowerAge = 0, MaxAge = 18, isMale = false, Base = 100 });
            List.Add(new BasePrice() { LowerAge = 19, MaxAge = 24, isMale = true, Base = 180 });
            List.Add(new BasePrice() { LowerAge = 19, MaxAge = 24, isMale = false, Base = 165 });
            List.Add(new BasePrice() { LowerAge = 25, MaxAge = 35, isMale = true, Base = 200 });
            List.Add(new BasePrice() { LowerAge = 25, MaxAge = 35, isMale = false, Base = 180 });
            List.Add(new BasePrice() { LowerAge = 35, MaxAge = 45, isMale = true, Base = 250 });
            List.Add(new BasePrice() { LowerAge = 35, MaxAge = 45, isMale = false, Base = 225 });
            List.Add(new BasePrice() { LowerAge = 45, MaxAge = 60, isMale = true, Base = 320 });
            List.Add(new BasePrice() { LowerAge = 45, MaxAge = 60, isMale = false, Base = 315 });
            List.Add(new BasePrice() { LowerAge = 60, MaxAge = 99999999, isMale = true, Base = 500 });
            List.Add(new BasePrice() { LowerAge = 60, MaxAge = 99999999, isMale = false, Base = 485 });
            return List;
        }
        

    }
}
