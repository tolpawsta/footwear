﻿using DemoShoes.Model.Interface;

namespace DemoShoes.Model.Entity
{
    class Boots : Footwear, IHeelable, IHeightable
    {
        public double Height { get; set; }
        public bool IsHeel { get; set; }
        public override string ToString()
        {
            return base.ToString() +
                " height " + Height +
                "heel " + IsHeel;
        }

    }
}
