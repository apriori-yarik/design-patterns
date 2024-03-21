using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveGenerics
{
    public class PersonBuilder<T>
        where T : PersonBuilder<T>
    {
        protected Person person = new Person();

        public T Name(string name)
        {
            this.person.Name = name;
            return (T)this;
        }

        public T Age(int age)
        {
            this.person.Age = age;
            return (T)this;
        }

        public T IsMale(bool isMale)
        {
            this.person.isMale = isMale;
            return (T)this;
        }

        public Person Build()
        {
            return this.person;
        }
    }
}
