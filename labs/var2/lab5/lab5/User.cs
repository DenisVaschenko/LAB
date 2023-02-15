using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class User
    {
        public User(bool isCase1, bool isCase2, bool isCase3)
        {
            IsCase1 = isCase1;
            IsCase2 = isCase2;
            IsCase3 = isCase3;
        }
        public bool IsCase1 { get; set; }
        public bool IsCase2 { get; set; }
        public bool IsCase3 { get; set; }
    }
}
