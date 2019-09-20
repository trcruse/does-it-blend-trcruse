﻿using System;
using System.Collections.Generic;

namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IBlendable> items = new List<IBlendable>();
            items.Add(new Strawberry());
            items.Add(new Banana());
            items.Add(new Mango());
            items.Add(new IceCubes());
            items.Add(new CellPhone());
            items.Add(new Tomato());

            string result = "";
            foreach(dynamic item in items)
            {
                result += item.Blend();
            }
            Console.WriteLine(result);
        }
    }
}
