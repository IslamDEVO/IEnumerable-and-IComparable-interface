using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace cSharp_Review_T
{
    //class Program
    //{
    #region model
    //static void Main(string[] args)
    //{

    //}
    #endregion

    #region pip and filter dictionary

    //public static int F1KeyToInt(string key)
    //{
    //    int n = 0;
    //    for(int i=0; i<key.Length; i++)
    //        n += (int)key[i];
    //    return n;
    //}

    //public static void F2Shearsh(int key, string[] strs)
    //{
    //    int keyToMatch = 0;
    //    for (int i = 0; i < strs.Length; i++)
    //    {
    //        for (int j = 0; j < strs[i].Length; j++)
    //            keyToMatch += (int)strs[i][j];
    //        if (keyToMatch == key)
    //            Console.WriteLine(strs[i]);
    //        keyToMatch = 0;
    //    }
    //}

    //static void Main(string[] args)
    //{
    //    string[] strs = {"stop","post","pots","end","go"};

    //    Console.WriteLine("enter your word \t");
    //    string key = Console.ReadLine();
    //    int keyToInt = 0;
    //    keyToInt = F1KeyToInt(key);
    //    //F2Shearsh(keyToInt, strs);
    //    /*using pip and filter*/
    //    F2Shearsh(F1KeyToInt(key), strs);

    //}
    #endregion

    #region bubbel sort

    //delegate bool myDelegate(object o1, object o2);
    //class Bubbel_sort
    //{
    //    public static void Sort(object[] obs, myDelegate de)
    //    {
    //        for (int i = 0; i < obs.Length; i++)
    //        {
    //            for (int j = i; j < obs.Length; j++)
    //            {
    //                if (de(obs[i], obs[j]))
    //                {
    //                    object temp = obs[i];
    //                    obs[i] = obs[j];
    //                    obs[j] = temp;

    //                }
    //            }
    //        }
    //    }
    //}

    //class Employee
    //{
    //    string name;

    //    public string Name
    //    {
    //        get { return name; }
    //        set { name = value; }
    //    }
    //    float salary;

    //    public float Salary
    //    {
    //        get { return salary; }
    //        set { salary = value; }
    //    }

    //    public Employee(string name, float salary)
    //    {
    //        this.name = name;
    //        this.salary = salary;
    //    }

    //    public static bool RshIsGreaterThanLsh(object lsh, object rsh)
    //    {
    //        Employee emLsh = (Employee)lsh;
    //        Employee emrsh = (Employee)rsh;
    //        if (emrsh.salary > emLsh.salary)
    //            return true;
    //        else
    //            return false;

    //    }

    //}

    //static void Main(string[] args)
    //{
    //    myDelegate de = new myDelegate(Employee.RshIsGreaterThanLsh);
    //    Employee[] empls = { 
    //                       new Employee("eslam",3000),
    //                       new Employee("ali",5000),
    //                       new Employee("omr",2000),
    //                       new Employee("ahmed",3000)};
    //    Bubbel_sort.Sort(empls, de);
    //    foreach (Employee e in empls)
    //        Console.WriteLine("name : {0} , salary is : {1}", e.Name, e.Salary);


    //}

    #endregion

    //}

    #region Min & Max ex_2 in mid exam using extention methods
    //delegate bool MyDelegate(object o1, object o2);

    //static class Extention_Class
    //{
    //    public static object GetMax(this object[] array, MyDelegate de)
    //        {
    //            object max = array[0]; 
    //            foreach (object o in array)
    //            {
    //                if(de(max, o))
    //                {
    //                    max = o;
    //                }
    //            }
    //            return max;
    //        }

    //    public static object GetMin(this object[] array, MyDelegate de)
    //    {
    //        object min = array[0];
    //        foreach (object o in array)
    //        {
    //            if (!de(min, o))
    //            {
    //                min = o;
    //            }
    //        }
    //        return min;
    //    }
    //}

    //class Int
    //{
    //    int n;
    //    public Int(int n)
    //    {
    //        this.n = n;
    //    }
    //    public static bool RshIsGreaterThanLhs(object o1, object o2)
    //    {
    //        Int lInt = (Int)o1;
    //        Int rInt = (Int)o2;
    //        if (rInt.n > lInt.n)
    //            return true;
    //        else
    //            return false;
    //    }
    //    public override string ToString()
    //    {
    //        return string.Format("the number is : {0}",n);
    //    }
    //}

    //class Program
    //{

    //    static void Main()
    //    {
    //        Int[] ints = { new Int(5),
    //                     new Int(8),
    //                     new Int(7),
    //                     new Int(4),
    //                     new Int(6),};
    //        MyDelegate de = Int.RshIsGreaterThanLhs;
    //        Console.WriteLine(((Int)(ints.GetMax(de))));
    //        Console.WriteLine(((Int)(ints.GetMax(de))));
    //    }
    //}
    #endregion

    #region Search and Sort using List<T> & Extention methods

    //delegate int MyDelegateToBinarySearch(object o1, object o2);
    //delegate bool MyDelegateToSort(object o1, object o2);

    //static class Extention_Class
    //{
    //    public static int BinarySearch<T>(this List<T> list , T key, MyDelegateToBinarySearch de)
    //    {
    //        int low, high, mid;
    //        high = list.Count-1;
    //        low = 0;
    //        while(low <= high)
    //        {
    //            mid = (low+high)/2;
    //            if(de(key, list[mid]) == 0)
    //                return mid;
    //            else if(de(key, list[mid]) > 0)
    //                low = mid+1;
    //            else
    //                high = mid-1;
    //        }
    //        return -1;
    //    }

    //    public static void Sort<T>(this List<T> list, MyDelegateToSort de)
    //    {
    //        for (int i = 0; i < list.Count; i++)
    //        {
    //            for (int j = i; j < list.Count; j++)
    //            {
    //                if (de(list[i], list[j]))
    //                {
    //                    T temp = list[i];
    //                    list[i] = list[j];
    //                    list[j] = temp;
    //                }
    //            }
    //        }
    //    }
    //}

    //class Employee
    //{
    //    string name;
    //    float salary;

    //    public Employee(string name, float salary)
    //    {
    //        this.name = name;
    //        this.salary = salary;
    //    }

    //    public static int Search(object o1, object o2)
    //    {
    //        Employee emp1 = (Employee)o1;
    //        Employee emp2 = (Employee)o2;

    //        if (emp1.salary == emp2.salary && emp1.name == emp2.name) return 0;
    //        else return -1;
    //    }

    //    public static bool RhsIsGreaterThanLhs(object o1, object o2)
    //    {
    //        Employee emp1 = (Employee)o1;
    //        Employee emp2 = (Employee)o2;

    //        return emp2.salary > emp1.salary ? true : false;
    //    }

    //    public override string ToString()
    //    {
    //        return string.Format("name is : {0} \t salary is : {1}", name, salary);
    //    } 

    //}

    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        List<Employee> emps = new List<Employee>();
    //        emps.Add(new Employee("eslam", 5000));
    //        emps.Add(new Employee("ali", 7000));
    //        emps.Add(new Employee("omr", 4000));
    //        emps.Add(new Employee("hassan", 5000));                

    //        MyDelegateToBinarySearch deSearch = Employee.Search;
    //        MyDelegateToSort deSort = Employee.RhsIsGreaterThanLhs;

    //        emps.Sort(deSort);
    //        foreach (Employee e in emps)
    //            Console.WriteLine(e.ToString());
    //        Console.WriteLine(emps.BinarySearch(new Employee("eslam", 5000), deSearch));
    //    }

    //}

    #endregion

    #region singleton class review

    //public sealed class Singleton
    //{
    //    private static Singleton instance = new Singleton();
    //    //private static readonly object _lock = new object();
    //    Singleton() { }
    //    public static Singleton Instance
    //    {
    //        get
    //        {
    //            //lock (_lock)
    //            //{
    //                //if (instance == null)
    //                //{
    //                    instance = new Singleton();
    //                //}
    //                return instance;
    //            //}
    //        }
    //    }

    //    //test
    //    public int n = 1;
    //    public void test()
    //    {
    //        Console.WriteLine("test is done n : {0}", n);
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Singleton.Instance.test();

    //    }
    //}

    #endregion

    #region pip and filter review

    //public static class ExtensionHelper
    //{
    //    public static Func<T1, T3> Chain<T1, T2, T3>(this Func<T1, T2> f1,
    //        Func<T2, T3> f2)
    //    {
    //        return item => f2(f1(item));
    //    }
    //}
    //class Program
    //{

    //    static void Main(string[] args)
    //    {

    //        Func<int, int> f1 = AddOne;
    //        //var val = f1.Chain(Double).Chain(i => i - 1).Chain(Double)(10);
    //        var chained3 = f1.Chain(i => i - 1).Chain(AddOne);
    //        var val = chained3.Chain(Double).Chain(Double)(10);
    //        Console.WriteLine("the value is : {0}", val);
    //        Console.ReadLine();

    //    }

    //    public static int AddOne(int i)
    //    {
    //        return i + 1;
    //    }

    //    public static int Double(int i)
    //    {
    //        return i * 2;   
    //    }

    //}

    #endregion

    #region Comparable interface

    //class Cat : IComparable<Cat>
    //{
    //    string name;
    //    int age;

    //    public Cat(string name, int age) { this.name = name; this.age = age; }

    //    public override string ToString()
    //    {
    //        return string.Format("name is : {0} \t age is : {1}", name, age);
    //    }

    //    public int CompareTo(Cat o2)
    //    {
    //        if(this.age == o2.age)
    //            return this.name.CompareTo(o2.name);
    //        else
    //            return this.age.CompareTo(o2.age);
    //    }
    //}

    //public static class Utilty
    //{
    //    public static T Max<T>(List<T> arr, int s, int e) where T : IComparable<T>
    //    {
    //        T max = arr[0];
    //        for (int i = 0; i < arr.Count; i++)
    //            if (arr[i].CompareTo(max) > 0)
    //                max = arr[i];

    //        return max;
    //    }

    //    public static T Min<T>(T[] arr, int s, int e) where T : IComparable<T>
    //    {
    //        T min = arr[0];
    //        for (int i = 0; i < arr.Length; i++)
    //            if (arr[i].CompareTo(min) < 0)
    //                min = arr[i];

    //        return min;
    //    }

    //    public static int BinarySearch<T>(T[] arr, T key) where T : IComparable<T>
    //    {
    //        int s, e, mid;
    //        s = 0;
    //        e = arr.Length-1;
    //        while (s <= e)
    //        {
    //            mid = (s + e) / 2;
    //            if (key.CompareTo(arr[mid]) == 0)
    //                return mid;
    //            else if (key.CompareTo(arr[mid]) > 0)
    //                s = mid + 1;
    //            else
    //                e = mid - 1;

    //        }

    //        return -1;
    //    }

    //    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    //    {
    //        int min;
    //        for (int i = 0; i < arr.Length - 1; i++)
    //        {
    //            min = i;
    //            for(int j = i; j < arr.Length; j++)
    //                if (arr[j].CompareTo(arr[min]) < 0)
    //                    min = j;
    //            T temp = arr[i];
    //            arr[i] = arr[min];
    //            arr[min] = temp;
    //        }
    //    }

    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        int[] x = { 1, 1, 1, 5, 6, 7, 8, 9 };

    //        List<Cat> strs = new List<Cat>();
    //        strs.Add(new Cat("asas", 12));
    //        strs.Add(new Cat("pisa",12));
    //        strs.Add(new Cat("osa", 12));
    //        strs.Add(new Cat("pispisa", 11));
    //        strs.Add(new Cat("nosa", 9));
    //        strs.Sort();
    //        //Debug.Assert(1 == 2, " yes ");
    //        //Console.WriteLine(strs[0]);
    //        Cat max = Utilty.Max(strs, 0, 5);
    //        Console.WriteLine(Utilty.Max(strs, 0, 5).ToString());
    //        Console.WriteLine(Utilty.Min(x,0,5).ToString());
    //        foreach (Cat c in strs)
    //            Console.WriteLine(c.ToString());
    //        //Console.WriteLine(Utilty.Max(strs, 0, 5).ToString());
    //        Console.WriteLine("------------------- bin search");
    //        Utilty.SelectionSort(x);
    //        foreach (int c in x)
    //            Console.WriteLine(c.ToString());
    //        int n = 9;
    //        Console.WriteLine(Utilty.BinarySearch(x, n));

    //    }
    //}

    #endregion

    #region final sheet

    class Test
    {
        static void Main(string[] args)
        {
            foreach (string x in Foo())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("----------------IEn");
            Cat[] cats = {new Cat("posi",12),
                             new Cat("osa",11),
                             new Cat("pasposa",10),
                             new Cat("meme",9)};
            foreach (Cat x in cats)
            {
                Console.WriteLine(x.ToString());
            }

        }
        static IEnumerable Foo()
        {
            yield return "Hello";
            yield return "there";
        }

        class Cat //: IEnumerable
        {
            int age;
            string name;
            public Cat(string name, int age){this.name = name; this.age = age;}

           /*public IEnumerator GetEnumerator()
           {
               yield return new Cat(name, age);
           }*/
           public override string ToString()
           {
               return string.Format("name : {0} \t age : {1}", name, age);
           }

        }

    #endregion

    }
}
