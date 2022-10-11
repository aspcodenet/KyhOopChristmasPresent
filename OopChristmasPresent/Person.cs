using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopChristmasPresent
{
    public class Person
    {
        private string name;

        //        private List<ChristmasPresent> presents = new();
        private List<ChristmasPresent> presentList = new List<ChristmasPresent>();

        public void AddPresent(ChristmasPresent present)
        {
            presentList.Add(present);
        }
        

        public Person(string name)
        {
            this.name = name;
            //this.presents = new List<ChristmasPresent>();
        }


    }
}
