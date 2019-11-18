using DemoShoes.Factory;
using DemoShoes.Model.Entity;
using DemoShoes.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoShoes.Storage
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

        public List<Footwear> GetAllShoes()
        {
            return footwears;
        }

        public Footwear GetFootwearBy(int vendor)
        {

            return footwears.SingleOrDefault(x => x.VendorCode == vendor);


        }

        public List<Footwear> GetFootwearsBy(GenderType gender)
        {
            return footwears.FindAll(f => f.Gender == gender).ToList();
        }

        public List<Footwear> GetFootwearsFamilyKit(SeasonType seasonType)
        {
            List<Footwear> tempList = new List<Footwear>();
            foreach (GenderType gender in Enum.GetValues(typeof(GenderType)))
            {
                tempList.Add(footwears.Find(f => f.Gender == gender && f.Season==seasonType));
            }
            return tempList;
        }

        public List<Footwear> GetFootwearsWithHeel()
        {
            return footwears.FindAll(f => f is IHeelable && ((IHeelable)f).IsHeel == true);
        }
    }
}
