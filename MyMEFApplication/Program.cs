using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace MyMEFApplication {
    class Program {

        private static CompositionContainer _container;

        static void Main(string[] args) {
            //AssemblyCatalog 目录的一种，表示在相应的程序集中搜索
            var catalog = new AssemblyCatalog(typeof(Program).Assembly);
            _container = new CompositionContainer(catalog);

            MathCompute mathCompute = new MathCompute();
            _container.ComposeParts(mathCompute);//组装部件

            Console.WriteLine(mathCompute.Add(1, 3));
            Console.WriteLine(mathCompute.Sub(3, 2));

            Console.ReadLine();
        }
    }

    public class MathCompute {

        //我们需要导入这个契约实现的部件
        [Import(typeof(ICalculator))]
        private ICalculator _calculator;


        public int Add(int a, int b) {
            return _calculator.Add(a, b);
        }

        public int Sub(int a, int b) {
            return _calculator.Sub(a, b);
        }

    }

}
