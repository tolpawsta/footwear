using DemoShoes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes
{
    class BootsFactory : IFactoryable
    {

        public Footwear CreateFootwear(int vendor)
        {
            switch (vendor)
            {
                case 101:
                    return new Boots()
                    {
                        Vendor = vendor,
                        Name = "Сапоги",
                        Gender = GenderType.Man,
                        Height = 30,
                        IsHeel = true,
                        Material = MatertialType.Leather,
                        Season = SeasonType.Winter, Size=46, Cost=90.5m
                    };
                case 102:
                    return new Boots()
                    {
                        Vendor = vendor,
                        Name = "Сапоги",
                        Gender = GenderType.Woman,
                        Height = 50,
                        IsHeel = true,
                        Material = MatertialType.Leather,
                        Season = SeasonType.Winter,
                        Size = 39,
                        Cost = 120.5m
                    };

                case 103:
                    return new Boots()
                    {
                        Vendor = vendor,
                        Name = "Ботинки",
                        Gender = GenderType.Child,
                        Height = 40,
                        IsHeel = true,
                        Material = MatertialType.Rubber,
                        Season = SeasonType.Winter,
                        Size = 35,
                        Cost = 85.3m
                    };
                case 104:
                    return new Shoes()
                    {
                        Vendor = vendor,
                        Name = "Туфли",
                        Gender = GenderType.Woman,
                        IsHeel = true,
                        Material = MatertialType.Shammy,
                        Season = SeasonType.Spring,
                        Size = 39,
                        Cost = 112.5m
                    };
                case 105:
                    return new Sandals()
                    {
                        Vendor = vendor,
                        Name = "Босоножки",
                        Gender = GenderType.Woman,
                        IsClasp = true,
                        isBarefoot = true,
                        Material = MatertialType.Leather,
                        Season = SeasonType.Summer,
                        Size = 39,
                        Cost = 120.5m
                    };
                case 106:
                    return new Slippers()
                    {
                        Vendor = vendor,
                        Name = "Тапочки",
                        Gender = GenderType.Man,
                        IsFootSole = true,
                        Material = MatertialType.Textile,
                        Season = SeasonType.Summer,
                        Size = 44,
                        Cost = 20m
                    };
                case 107:
                    return new Sneakers()
                    {
                        Vendor = vendor,
                        Name = "Кроссовки",
                        Gender = GenderType.Child,
                        Material = MatertialType.Leather,
                        Season = SeasonType.Summer,
                        Size = 23,
                        Cost = 52.4m
                    };

                default: throw new InvalidOperationException($"Can't great shoer with vendor {vendor}");
            }
           
            
        }

        public List<Footwear> CreateFootwearKit()
        {
            List<Footwear> footwears = new List<Footwear>();
            for (int vendor = 101; vendor <= 109; vendor++)
            {
                footwears.Add(CreateFootwear(vendor));
            }
            return footwears;
        }
    }
}
