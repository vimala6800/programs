using AssemblyTest;
using calculator;
internal class Program
{
    private static void Main(string[] args)
    {
       /* Console.WriteLine("Hello, World!");
        Class1 cal = new Class1();
        int res = cal.add(5, 7);
        Console.WriteLine(res);
        int res1 = cal.sub(5, 7);
        Console.WriteLine(res1);
        int res2 = cal.mul(5, 7);
        Console.WriteLine(res2);
        int res3 = cal.div(5, 7);
        Console.WriteLine(res3);*/


        ElectricityBill r1 = new ElectricityBill();
       // double amount = r1.calculateBill(280);
       // Console.WriteLine(amount);
         Console.WriteLine("please enter the units");
        var units =Convert.ToInt32(Console.ReadLine());
       
        var bill=r1.calculateBill(units);
        Console.WriteLine("The amount is:");

        Console.WriteLine(bill);
       
        //ElectricityBill demo = new ElectricityBill();
        // demo.reference();
        // Console.WriteLine();
        // ReflectionDemo re = new ReflectionDemo();
        // re.method();


    }

}