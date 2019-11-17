using DemoShoes.Consultant;
using DemoShoes.Factory;
using DemoShoes.Storage;
using DemoShoes.View;

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
