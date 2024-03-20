using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Foo
    {
        private Foo() 
        { 
        }

        private async Task<Foo> InitAsync()
        {
            // this is only an example
            // in reality, we would have some http requests, calls to third-party apps, etc.
            await Task.Delay(1000);
            return this;
        }

        public static async Task<Foo> CreateAsync()
        {
            var foo = new Foo();
            return await foo.InitAsync();
        }
    }
}
