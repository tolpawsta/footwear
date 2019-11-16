using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes.View
{
    interface IViewable
    {
        void Show(Footwear footwear);
        void Show(List<Footwear> footwears);
    }
}
