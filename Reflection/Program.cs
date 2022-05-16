using System;
using System.Reflection;

namespace Reflection
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Type type = typeof(MyClass);

      Console.WriteLine("Constructor Informations");
      //get the public construcotrs
      foreach (ConstructorInfo item in type.GetConstructors())
      {
        Console.WriteLine("Name: " + item.Name + ", IsPublic: " + item.IsPublic + ", IsPrivate: " + item.IsPrivate + ", IsStatic: " + item.IsStatic);
      }

      //get the private constructors
      foreach (ConstructorInfo item in type.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic))
      {
        Console.WriteLine("Name: " + item.Name + ", IsPublic: " + item.IsPublic + ", IsPrivate: " + item.IsPrivate + ", IsStatic: " + item.IsStatic);
      }

      //get the static constructors
      foreach (ConstructorInfo item in type.GetConstructors(BindingFlags.Static | BindingFlags.NonPublic))
      {
        Console.WriteLine("Name: " + item.Name + ", IsPublic: " + item.IsPublic + ", IsPrivate: " + item.IsPrivate + ", IsStatic: " + item.IsStatic);
      }

      foreach (ConstructorInfo constructorInfo in type.GetConstructors())
      {
        Console.WriteLine(constructorInfo.ToString());

        foreach (var param in constructorInfo.GetParameters())
        {
          Console.WriteLine(string.Format(
            "Param {0} is named {1} and is of type {2}",
            param.Position, param.Name, param.ParameterType));
        }
      }
      Console.WriteLine();

      Console.WriteLine("Method Informations");
      foreach (MethodInfo methodInfo in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
      {
        Console.WriteLine(methodInfo.Name);
        foreach (var param in methodInfo.GetParameters())
        {
          Console.WriteLine(string.Format(
            "Param {0} is named {1} and is of type {2}",
            param.Position, param.Name, param.ParameterType));
        }
        Console.WriteLine("ReturnType: " + methodInfo.ReturnType);
      }

      Console.WriteLine();

      Console.WriteLine("Property Informations");
      foreach (PropertyInfo propertyInfo in type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
      {
        Console.WriteLine(propertyInfo.Name + " " + propertyInfo.PropertyType);
      }
      Console.ReadLine();
    }
  }
}
