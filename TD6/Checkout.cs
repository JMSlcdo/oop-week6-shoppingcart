using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD6
{
    class Checkout
    {
        public double amount { get; set; }
        public ArrayList items { get; set; }

        public Checkout(double amount, ArrayList items)
        {
            this.amount = amount;
            this.items = items;
        }

        public ArrayList addApple(Apple apple)
        {
            items.Add(apple);
            return items;
        }

        public ArrayList addOrange(Orange orange)
        {
            items.Add(orange);
            return items;
        }

        public double totalCost(Apple apple, Orange orange)
        {
            for(int i = 0; i < items.Count; i++)
            {
                if(items[i] == apple)
                {
                    amount += apple.price;
                }
                if(items[i] == orange)
                {
                    amount += orange.price;
                }
            }
            return amount;
        }
    }
}
