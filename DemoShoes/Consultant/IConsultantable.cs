using DemoShoes.Model.Entity;
using System.Collections.Generic;

namespace DemoShoes.Consultant
{
    interface IConsultantable
    {
        void Work();
        void FinishWork();
        void ShowFootwear(IEnumerable<Footwear> footwears);
        Footwear FindFootwearByVendorCode();
        IEnumerable<Footwear> ChooseFootwearByGender();
        IEnumerable<Footwear> ChooseFamilyKitForSeason();
        IEnumerable<Footwear> ChooseFootwearWithHeel();
        IEnumerable<Footwear> ChooseFootwearBySize();
        IEnumerable<Footwear> ChooseFootwearByCost();

    }
}
