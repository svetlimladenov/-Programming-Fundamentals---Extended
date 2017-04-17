using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Dog
    {
        public string Name { get; set; }
        
        public string Breed { get; set; }



        public bool HasEatern { get; set; }
                
        public bool IsAsleep { get; set; }

        public void GoToSleep()
        {
            if (HasEatern)
            {
                IsAsleep = true;

            }
        }

        public void Eat(Cat cat)
        {
            if (cat != null)
            {
                HasEatern = true;
            }
        }


        public DateTime Birthday { get; set; }

        public int Age
        {
            get
            {
                return (int)(DateTime.Now - Birthday).TotalDays / 365;
            }
        }
    }
}
