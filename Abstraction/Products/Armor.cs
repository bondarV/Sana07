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
        public float AverageReviewRating {  get; set; }

        public Armor(string name, float price, short count,string objectUsing, string material,float averageReviewRating)
            : base(name, price, count)
        {
            ObjectUsing = objectUsing;
            Material = material;
            AverageReviewRating = averageReviewRating;
        }

        public override string Display()
        {
            return $"Назва товару:{Name},ціна {Name}(-a/y) становить {Price},к-сть:{Count},для кого призначенний:{ObjectUsing},матеріал {Material},середня оцінка від експертів {AverageReviewRating}";

        }

    }
}
