using DemoShoes.Model.Entity;
using System.Collections.Generic;

namespace DemoShoes.View
{
    interface IViewable
    {
        void Show(string message);
        void Show(Footwear footwear);
        void Show(List<Footwear> footwears);
        void Show(IEnumerable<Footwear> footwears);
    }
}
