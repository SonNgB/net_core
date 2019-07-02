using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Generics
{
    class Program
    {
        #region 10.0 abstract 
        //static void Main(string[] args)
        //{
        //    Lion lion = new Lion();
        //    lion.Eat();
        //    lion.Hunt();
        //    lion.Sleep();
        //    Console.ReadLine();
        //}

        //public abstract class Cat
        //{
        //    public abstract void Eat();
        //    public abstract void Hunt();
        //    public abstract void Sleep();
        //}

        //public class Lion : Cat
        //{
        //    public override void Eat()
        //    {
        //        Console.WriteLine("Lion Eat");
        //    }

        //    public override void Hunt()
        //    {
        //        Console.WriteLine("Lion Hunt");
        //    }

        //    public override void Sleep()
        //    {
        //        Console.WriteLine("Lion Sleep");
        //    }
        //}
        #endregion

        #region 11.0 interface
        //static void Main(string[] args)
        //{
        //    Cheetah cheetah = new Cheetah();
        //    cheetah.Eat();
        //    cheetah.SoftPurr(60);
        //    Console.ReadLine();
        //}

        //public abstract class Cat
        //{
        //    public abstract void Eat();
        //}

        //interface IPurrable
        //{
        //    void SoftPurr(int decibel);
        //}

        //public class Cheetah : Cat, IPurrable
        //{
        //    public override void Eat()
        //    {
        //        Console.WriteLine("Lion Eat");
        //    }


        //    public void SoftPurr(int decibel)
        //    {
        //        Console.WriteLine($"Lion Eat {decibel} decibels");
        //    }

        //}
        #endregion


        #region 12.0 Creating and using a generic class or method
        //static void Main(string[] args)
        //{
        //    PerformAction<int> action = new PerformAction<int>(10);
        //    action.IdentifyDataType();
        //    Console.ReadLine();
        //}

        //public class PerformAction<T>
        //{
        //    private T _value;
        //    public PerformAction(T value)
        //    {
        //        _value = value;
        //    }

        //    public void IdentifyDataType()
        //    {
        //        Console.WriteLine($"The data type is {_value.GetType()}");
        //    }
        //}
        #endregion

        #region 13.0 Creating and Using a Generic Interface
        //static void Main(string[] args)
        //{
        //    Test t = new Test();
        //    InspectClass<Test> inspectClass = new InspectClass<Test>(t);
        //    List<string> lst = inspectClass.GetPropertyList();
        //    foreach (var item in lst)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.ReadLine();
        //}

        //class Test
        //{
        //    public int field1 { get; set; }
        //    public int field2 { get; set; }
        //}

        //interface IListClassProperties<T>
        //{
        //    List<string> GetPropertyList();
        //}

        //public class InspectClass<T> : IListClassProperties<T>
        //{
        //    T _classToInspect;

        //    public InspectClass(T classToInspect)
        //    {
        //        _classToInspect = classToInspect;
        //    }
        //    public List<string> GetPropertyList()
        //    {
        //        return _classToInspect.GetType().GetProperties().Select(p => p.Name).ToList();
        //    }
        //}
        #endregion
    }
}
