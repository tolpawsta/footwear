using DemoShoes.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

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
            catch (NullReferenceException)
            {

                Console.WriteLine("Извините, такой обуви нету");
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

        public void Show(IEnumerable<Footwear> footwears)
        {
            try
            {
                if (footwears==null)
                {
                    throw new NullReferenceException("Извините, такой обуви нету");
                }
                Console.WriteLine(string.Join(Environment.NewLine, footwears.Select(f => f.ToString())));
            }
            catch (NullReferenceException nrExeption)
            {

                Console.WriteLine(nrExeption.Message);
            }
               
           
            
        }
    }
}
