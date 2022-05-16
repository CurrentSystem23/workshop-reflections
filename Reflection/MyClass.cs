using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
  public class MyClass
  {
    public MyClass()
    {
      FirstValue = 42;
      SecondValue = "Nothing";
    }
    public MyClass(int firstValue)
    {
      FirstValue = firstValue;
      SecondValue = "Nothing";
    }
    public MyClass(int firstValue, string secondValue)
    {
      FirstValue = firstValue;
      SecondValue = secondValue;
    }

    public void DoSomething(string name)
    {}

    public int DoSomethingMore()
    {
      return 42;
    }

    public int FirstValue { get; set; }
    public string SecondValue { get; set; }
  }
}
