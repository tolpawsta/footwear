using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes.Model
{
    //Наличие застежки
    interface IClaspable
    { 
        bool IsClasp { get; set; }
    }
}
