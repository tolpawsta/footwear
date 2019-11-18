using DemoShoes.Model;
using DemoShoes.Model.Entity;
using System.Collections.Generic;

namespace DemoShoes.Storage
{
    interface IStorage
    {
        IEnumerable<Footwear> GetAllShoes();
        Footwear GetFootwearBy(int vendorCode);
        IEnumerable<Footwear> GetFootwearsBy(GenderType gender);
        IEnumerable<Footwear> GetFootwearsFamilyKit(SeasonType seasonType);
        IEnumerable<Footwear> GetFootwearsWithHeel();
        IEnumerable<Footwear> GetFootwearsBySize(int minSize, int maxSize);
        IEnumerable<Footwear> GetFootwearsByCost(double minCost, double maxCost);
    }
}
