using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Kitchen
    {
        public List<Portion> portions = new List<Portion>();
        public List<Garnish> garnishes = new List<Garnish>();
        public List<Meat> meats = new List<Meat>();
        public void AddPortion(Meat meat, Garnish garnish)
        {
            if (meats.Contains(meat) && garnishes.Contains(garnish))
            {
                meats.RemoveAt(meats.IndexOf(meat));
                garnishes.RemoveAt(garnishes.IndexOf(garnish));
                portions.Add(new Portion(meat, garnish));
            }
        }
        public void AddMeat(Meat meat, int n)
        {
            for (int i = 0; i < n; i++)
            {
                meats.Add(meat);
            }
        }
        public void AddGarnish(Garnish garnish, int n)
        {
            for (int i = 0; i < n; i++)
            {
                garnishes.Add(garnish);
            }
        }
    }
}
