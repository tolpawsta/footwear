using DemoShoes.Factory;
using DemoShoes.Model;
using DemoShoes.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoShoes.Storage.Impl
{
    class FootwearStorage : IStorage
    {
        List<Footwear> footwears;
        IFactoryable factory;
        public FootwearStorage(IFactoryable factory)
        {
            footwears = new List<Footwear>();
            this.factory = factory;
            Initialization();
        }

        private void Initialization()
        {
            this.footwears = factory.CreateFootwearKit();
        }

        public IEnumerable<Footwear> GetAllShoes()
        {
            return footwears;
        }

        public Footwear GetFootwearBy(int vendor)
        {

            return footwears.SingleOrDefault(x => x.VendorCode == vendor);


        }

        public IEnumerable<Footwear> GetFootwearsBy(GenderType gender)
        {
            return footwears.FindAll(f => f.Gender == gender);
        }

        public IEnumerable<Footwear> GetFootwearsFamilyKit(SeasonType seasonType)
        {
            List<Footwear> tempList = new List<Footwear>();
            foreach (GenderType gender in Enum.GetValues(typeof(GenderType)))
            {
                var footwear = footwears.Find(f => f.Gender == gender && f.Season == seasonType);
                if (footwear != null)
                {
                    tempList.Add(footwear);
                }

            }
            return tempList;
            // return ((IEnumerable<GenderType>)Enum.GetValues(typeof(GenderType))).Join(footwears)
        }

        public IEnumerable<Footwear> GetFootwearsWithHeel()
        {
            return footwears.FindAll(f => f is IHeelable && ((IHeelable)f).IsHeel == true);
        }

        public IEnumerable<Footwear> GetFootwearsBySize(int minSize, int maxSize)
        {
            return footwears.FindAll(f => f.Size >= minSize && f.Size <= maxSize);
        }

        public IEnumerable<Footwear> GetFootwearsByCost(double minCost, double maxCost)
        {
            return footwears.FindAll(f => f.Cost >= minCost && f.Cost <= maxCost);
        }
    }
}
