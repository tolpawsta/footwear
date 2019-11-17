using DemoShoes.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes.Consultant
{
    interface IConsultantable
    {
        void Work();
        void FinishWork();
        void ShowFootwear(List<Footwear> footwears);
        Footwear FindFootwearByVendorCode();
        List<Footwear> ChooseFootwearByGender();
        List<Footwear> ChooseFamilyKitForSeason();

    }
}
