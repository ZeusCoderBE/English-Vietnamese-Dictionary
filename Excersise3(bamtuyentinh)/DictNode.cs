using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise3
{
   
        public class DictNode
        {
           private Word word;
           private DictNode next;

        public Word Word { get => word; set => word = value; }
        public DictNode Next { get => next; set => next = value; }
        }
    
}
