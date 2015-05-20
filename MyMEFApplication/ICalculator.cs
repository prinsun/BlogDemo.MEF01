using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMEFApplication {
    //这便是我们的契约 Contract
    public interface ICalculator {

        int Add(int a, int b);

        int Sub(int a, int b);
    }
}
