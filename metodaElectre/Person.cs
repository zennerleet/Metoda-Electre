using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodaElectre
{
    public class Person
    {
        private Dictionary<Criterion, int> listOfCriteria;
        public Person(Dictionary<Criterion, int> dictionary) 
        {
            listOfCriteria = dictionary; 
        }
        public override String ToString()
        {
            string ret = "";
            for (int i = 0; i < listOfCriteria.Count; i++)
            {
                ret = ret + listOfCriteria.Keys.ElementAt(i) + ":" + listOfCriteria.Values.ElementAt(i) + " ";
            }
            return ret;
        }
    }
}
