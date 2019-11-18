using DemoShoes.Model.Entity;
using DemoShoes.Storage;
using DemoShoes.View;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DemoShoes.Consultant.Impl
{
    class FootwearConsultant : ConsultantBase, IConsultantable
    {
        IViewable view;
        IStorage storage;

        public FootwearConsultant(IViewable view, IStorage storage, string name = "John Smith")
        {
            Name = name;
            this.view = view;
            this.storage = storage;
        }


        public void Work()
        {
            view.Show($"Здравсвуйте, меня зовут {Name}. Я могу вам помочь.");
            bool proceed = true;
            do
            {
                view.Show($"Выберите действия:");
                view.Show("1. Посмотрель всю обувь.");
                view.Show("2. Найти обувь по артикулу.");
                view.Show("3. Подобрать обувь по полу.");
                view.Show("4. Подобрать семейный набор обуви для сезона.");
                view.Show("5. Найти обувь с каблуками.");
                view.Show("6. Подобрать обувь по размеру.");
                view.Show("7. Подобрать обувь по цене.");
                view.Show("0. Спасибо, мне ничего не надо.");
                int choice;
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 0: proceed = false; break;
                    case 1: ShowFootwear(storage.GetAllShoes()); break;
                    case 2: view.Show(FindFootwearByVendorCode()); break;
                    case 3: view.Show(ChooseFootwearByGender()); break;
                    case 4: view.Show(ChooseFamilyKitForSeason()); break;
                    case 5:
                    case 6:
                    case 7:
                    default:
                        break;
                }
            } while (proceed);



        }

        public void FinishWork()
        {
            view.Show("До свидания!");
            Thread.Sleep(2000);
        }

        public void ShowFootwear(List<Footwear> footwears)
        {
            bool proceed = true;
            do
            {
                view.Show("Отсортировать результат по:\n 1. Возростанию артикула \n2. Убыванию уртикула \n0. Завершить");
                int choice;
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 0: proceed = false; break;
                    case 1: footwears.Sort((f1, f2) => f1.VendorCode.CompareTo(f2.VendorCode)); break;
                    case 2: footwears.Reverse(); ; break;

                    default: view.Show("Такой операции не существует."); break;
                }

            } while (proceed);
        }

        public Footwear FindFootwearByVendorCode()
        {
            int vendorCode;
            if (int.TryParse(Console.ReadLine(), out vendorCode))
            {
                return storage.GetFootwearBy(vendorCode);
            }
            return null;
        }

        public List<Footwear> ChooseFootwearByGender()
        {
            view.Show("Укажите пол:\n 1. Мужской \n2. Женский \n3. Обувь для детей");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1: return storage.GetFootwearsBy(GenderType.Man);
                    case 2: return storage.GetFootwearsBy(GenderType.Woman);
                    case 3: return storage.GetFootwearsBy(GenderType.Child);
                    default: view.Show("Такой операции не существует."); break;
                }
            }
            return null;
        }

        public List<Footwear> ChooseFamilyKitForSeason()
        {
            view.Show("Выберите сезон:\n 1. Весна \n2. Лето \n3. Осень \n4. Зима");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1: return storage.GetFootwearsFamilyKit(SeasonType.Spring);
                    case 2: return storage.GetFootwearsFamilyKit(SeasonType.Summer);
                    case 3: return storage.GetFootwearsFamilyKit(SeasonType.Autumn);
                    case 4: return storage.GetFootwearsFamilyKit(SeasonType.Winter);

                    default: view.Show("Не известный сезон."); break;
                }
            }
            return null;
        }
    }
}
