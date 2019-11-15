using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes.Model
{
    //Шнуровка
    interface ILaceable
    { // Наличие шнуровки
        bool isLace { get; set; }
    }
}
