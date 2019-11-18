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
            IViewable view = new ConsoleView();
            IFactoryable factory = new FootwearFactory(view);
            IStorage storage = new FootwearStorage(factory);
            IConsultantable consultant = new FootwearConsultant(view, storage);
            consultant.Work();
            consultant.FinishWork();
        }
    }
}
