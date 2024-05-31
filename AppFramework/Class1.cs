using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary22
{
    public class MyCommand<T> where T : new()
    {
        public string CommandMethod(T t, MyQuery t2)
        {
            t = new T();
            var s = t2.ToString();
            var s1 = 1.ToString();
            return t.ToString();
        }
    }

    public class NormalClass
    {
        public void A(MyQuery q)
        {
            var myCommand = new MyCommand<MyQuery>();
            myCommand.CommandMethod(q, new MyQuery());
        }
    }

    public class MyQuery
    {
        public MyQuery()
        {
            var s1 = 1.ToString();
            Console.WriteLine();
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}