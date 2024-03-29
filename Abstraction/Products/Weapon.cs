﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Products
{
    public class Weapon:Product
    {
        public string WayOfInfluencingTheTarget {  get; set; }
        public string TypeOfCaliber {  get; set; }

        public Weapon(string name, float price, int count,string wayOfInfluencingTheTarget, string typeOfCaliber)
            :base(name,price,count)
            {
            WayOfInfluencingTheTarget = wayOfInfluencingTheTarget;
            TypeOfCaliber = typeOfCaliber;
        }

        public override string Display()
        {
            return $"Назва товару:{Name},ціна {Name}(-a/y/и) становить {Price},к-сть даного товару на складі:{Count},спосіб впливу на ціль {WayOfInfluencingTheTarget},тип калібру {TypeOfCaliber}";

        }

    }
}
