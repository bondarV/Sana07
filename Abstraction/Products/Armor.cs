using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Products
{
    public class Armor : Product
    {
        public string ObjectUsing { get; set; }
        public string Material  { get; set; }

        public float _averageReviewRating;
        public float AverageReviewRating {  get => _averageReviewRating;
            set
            {
                if (value >= 5 && value <= 0 || value >= 10 && value <= 0)
                    _averageReviewRating = value;
                else throw new Exception("Рейтинг має бути за 5-ти/10-ти бальною системою");
            }
        }

        public Armor(string name, float price, int count,string objectUsing, string material,float averageReviewRating)
            : base(name, price, count)
        {
            ObjectUsing = objectUsing;
            Material = material;
            AverageReviewRating = averageReviewRating;
        }

        public override string Display()
        {
            return $"Назва товару:{Name},ціна {Name}(-a/y/и) становить {Price},к-сть:{Count},для кого призначенний:{ObjectUsing},матеріал {Material},середня оцінка від експертів {AverageReviewRating}";

        }

    }
}
