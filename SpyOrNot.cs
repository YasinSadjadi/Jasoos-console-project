using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jasoos
{
    /// <summary>
    /// کلاسی که به شما نشان میدهد که بازیکن مورد نظر جاسوس هست یا خیر
    /// </summary>
    internal class SpyOrNot
    {
        /// <summary>
        /// سازنده ی کلاس spy or not
        /// </summary>
        /// <param name="spy"></param>
        public SpyOrNot(bool spy) 
        {
            Spy = spy;
        }

        /// <summary>
        /// پراپرتی ای که جاسوس بودن یا نبودن را در خود ذخیره میکند
        /// </summary>
        public bool Spy { get; set; }
    }
}
