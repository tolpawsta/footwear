using DemoShoes.Model.Entity;
using System;
using System.Collections.Generic;

namespace DemoShoes.View.Impl
{
    class ConsoleView : IViewable
    {
        public void Show(Footwear footwear)
        {
            try
            {
                Console.WriteLine(footwear.ToString());
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void Show(List<Footwear> footwears)
        {
            if (footwears == null)
            {
                throw new NullReferenceException("Sorry footwears not found");
            }
            footwears.ForEach(f => Console.WriteLine(f.ToString()));
        }

        public void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
