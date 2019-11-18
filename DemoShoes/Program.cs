using DemoShoes.Consultant;
using DemoShoes.Consultant.Impl;
using DemoShoes.Factory;
using DemoShoes.Factory.Impl;
using DemoShoes.Storage;
using DemoShoes.Storage.Impl;
using DemoShoes.View;
using DemoShoes.View.Impl;

namespace DemoShoes
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactoryable factory = new FootwearFactory();
            IStorage storage = new FootwearStorage(factory);
            IViewable view = new ConsoleView();
            IConsultantable consultant = new FootwearConsultant(view, storage);
            consultant.Work();
            consultant.FinishWork();
        }
    }
}
