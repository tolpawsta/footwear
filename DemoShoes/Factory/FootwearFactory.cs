using DemoShoes.Model.Entity;
using System;
using System.Collections.Generic;

namespace DemoShoes.Factory
{
    class FootwearFactory : IFactoryable
    {

        public Footwear CreateFootwear(int vendorCode)
        {
            switch (vendorCode)
            {
                case 101:
                    return new Boots()
                    {
                        VendorCode = vendorCode,
                        Name = "Сапоги",
                        Gender = GenderType.Man,
                        Height = 30,
                        IsHeel = true,
                        Material = MatertialType.Leather,
                        Season = SeasonType.Winter,
                        Size = 46,
                        Cost = 90.5m
                    };
                case 102:
                    return new Boots()
                    {
                        VendorCode = vendorCode,
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
                        VendorCode = vendorCode,
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
                        VendorCode = vendorCode,
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
                        VendorCode = vendorCode,
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
                        VendorCode = vendorCode,
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
                        VendorCode = vendorCode,
                        Name = "Кроссовки",
                        Gender = GenderType.Child,
                        Material = MatertialType.Leather,
                        Season = SeasonType.Summer,
                        Size = 23,
                        Cost = 52.4m
                    };

                default: throw new InvalidOperationException($"Can't great shoer with vendor {vendorCode}");
            }


        }

        public List<Footwear> CreateFootwearKit()
        {
            List<Footwear> footwears = new List<Footwear>();
            for (int vendorCode = 101; vendorCode <= 109; vendorCode++)
            {
                footwears.Add(CreateFootwear(vendorCode));
            }
            return footwears;
        }
    }
}
