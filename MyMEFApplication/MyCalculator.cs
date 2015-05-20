using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace MyMEFApplication {

    //此处我们导出了契约，这就是一个部件
    [Export(typeof(ICalculator))]
    public class MyCalculator : ICalculator {

        public int Add(int a, int b) {
            Console.WriteLine("Add Invoked");
            return a + b;
        }

        public int Sub(int a, int b) {
            Console.WriteLine("Sub Invoked");
            return a - b;
        }
    }
}
