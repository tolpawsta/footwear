using DemoShoes.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactoryable factory = new FootwearFactory();
            IStorage storage = new FootwearStorage(factory);
            IViewable view = new ConsoleView();
            view.Show("----All footwears in the storage----");
            view.Show(storage.GetAllShoes());
            view.Show("-----Get footwear by vendor code-----");
            view.Show(storage.GetFootwearBy(101));
            view.Show("-----Get all mans footwears-----");
            view.Show(storage.GetFootwearsBy(GenderType.Man));
            view.Show("-----Get family kit by season-----");
            view.Show(storage.GetFootwearsFamilyKit(SeasonType.Winter));
            view.Show("-----Get heeled footwears-----");
            view.Show(storage.GetFootwearsWithHeel());
            Console.ReadLine();

        }
    }
}
