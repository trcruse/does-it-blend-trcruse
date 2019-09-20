using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// Helps blend objects that don't all fall under the same category
    /// </summary>
    interface IBlendable
    {
        string Blend();
    }
}
