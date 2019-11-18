using DemoShoes.Model;
using DemoShoes.Model.Entity;
using System.Collections.Generic;

namespace DemoShoes.Storage
{
    interface IStorage
    {
        List<Footwear> GetAllShoes();
        Footwear GetFootwearBy(int vendorCode);
        List<Footwear> GetFootwearsBy(GenderType gender);
        List<Footwear> GetFootwearsFamilyKit(SeasonType seasonType);
        List<Footwear> GetFootwearsWithHeel();
        List<Footwear> GetFootwearsBySize(double minSize, double maxSize);
        List<Footwear> GetFootwearsByCost(decimal minCost, decimal maxCost);
    }
}
