using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Cat
    {
        public string Name { get; set; }
        
        public int Age { get; set; }

        public string Color { get; set; }   

        public string Gender { get; set; }      

        public string SaySomething(string word)
        {
            return word;
        }
        public string SayHello()
        {
            return $"Hello, my name is {Name}, and I am {Age} years old";
        }
        public int MyProperty { get; set; }
        //prop + TAB + TAB make new public int Name....
    }
}
