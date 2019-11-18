using DemoShoes.Model.Entity;
using System.Collections.Generic;

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
        List<Footwear> ChooseFootwearWithHeel();
        List<Footwear> ChooseFootwearBySize();
        List<Footwear> ChooseFootwearByCost();

    }
}
