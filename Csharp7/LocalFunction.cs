using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp7
{
    class LocalFunction
    {
        public void Arguments()
        {
            Action<int> foo = i =>
            {
                i += 1;
                Console.WriteLine("foo " + i);
            };

            void Foo(int i)
            {
                i += 1;
                Console.WriteLine("Foo " + i);
            }

            int i1 = 1;
            int i2 = 2;

            foo(i1);
            Console.WriteLine(i1);

            Foo(i2);
            Console.WriteLine(i2);
        }


        public void SideEffects()
        {
            int i1 = 0;
            Action fooWithSideEffect = () =>
            {
                i1 += 1;
                Console.WriteLine("foo " + i1);
            };

            fooWithSideEffect();
            Console.WriteLine(i1);

            int i2 = 0;

            void FooWithSideEffect()
            {
                i2 += 1;
                Console.WriteLine("Foo " + i2);
            }

            FooWithSideEffect();
            Console.WriteLine(i2);

            int i3 = 0;
            var t1 = Enumerable.Range(0, 1).Select(x => (i3 += 1)).ToList();

            Console.WriteLine(i3);

        }
    }
}
