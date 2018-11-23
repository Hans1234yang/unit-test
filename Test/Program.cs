using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Add_Ok();
        }
        public void Add_Ok()
        {
            Arithmetic arithmetic = new Arithmetic();
            var sum = arithmetic.Add(1, 2);

            Assert.True(sum == 3);//断言验证
        }
    }


}
