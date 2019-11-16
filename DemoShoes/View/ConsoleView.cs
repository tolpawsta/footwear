using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShoes.View
{
    class ConsoleView : IViewable
    {
        public void Show(Footwear footwear)
        {
            try
            {
                Console.WriteLine(footwear.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Show(List<Footwear> footwears)
        {
            if (footwears==null)
            {
                throw new NullReferenceException("Sorry footwears not found");
            }
            footwears.ForEach(f => Console.WriteLine(f.ToString()));
        }
    }
}
