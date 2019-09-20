using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A base class representing fruit
    /// </summary>
    /// can't run abstract 
    public abstract class Fruit : IBlendable
    {
        public abstract string Blend(); //abstract doesn't need a body
        
    }
}
