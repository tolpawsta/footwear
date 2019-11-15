using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes.Model
{
    //Наличие коблука
    interface IHeelable
    {
        bool IsHeel { get; set; }
    }
}
