
using basiccsharp;                          
using basiccsharp;
using System.Security.Principal;


//internal class Program
//{
//  private static void Main(string[] args)
// {

/* loops.whileloop();
     loops.forloop();
     loops.forloopbreak();
     operators.arithmeticoperator();
     simpleinterest.time();
 conversion.kms();
 printingtable.table();
 user.eligibletovote();
 convert.currency();
 convert.currency1();
 array.arrays();


*/
CoronaTest.test();

/*Console.WriteLine("constructor");
constructor customer = new constructor(1, "a", "abc@gmail.com", "8765367897", "banglore");
Console.WriteLine(customer.info());
customer.country = "india";
Console.WriteLine("country"+customer.country);
customer.zipcode = 560062;
Console.WriteLine("zipcode"+customer.zipcode);
constructor customer1 = new constructor(2, "b", "gbj@gmail.com", "6785367897", "ap");
Console.WriteLine(customer1.info());
customer1.country = "india";
Console.WriteLine("country" + customer1.country);
customer1.zipcode = 565738;
Console.WriteLine("zipcode" + customer1.zipcode);
product p1=new product();
p1.code = 1;
p1.name = "mobile";
p1.description = "samsung";
p1.supplier = "xyz";
p1.price = 1130;
Car car1 = new Car();
car1.name = "SUV";
car1.model = "Creta";
car1.make = "Hundai";
car1.price = 17000000;
car1.ac = "Kenstar";
car1.start();
car1.move();
car1.move();
Console.WriteLine(car1.info());
car1.stop();*/




/*account ac1 = new account(456654, "vimala", "vimala@gmail.com", "4563798765", 2500f);

Console.WriteLine(ac1.info());

Console.WriteLine("available balance is:" + ac1.Depositamount(456654, 6797f));
Console.WriteLine("Remaing balance is:" + ac1.Withdrawamount(456654, 500f));
Console.WriteLine(ac1.Bal());
account ac2 = new account(654653, "sai", "sai@gmail.com", "9863797765", 3000f);
account ac3 = new account(765438, "madhuri", "madhuri@gmail.com", "8563798765", 2000f);
Console.WriteLine(ac2.info());
Console.WriteLine(ac3.info());
int x;
Console.WriteLine("\n 1  Account Information \n 2  Deposit\n3  Withdraw\n4 Balance enquiry");
x = Convert.ToInt32(Console.ReadLine());
switch (x)
{

}


int x;
for (int i = 4; i != 0;)
{
    Console.WriteLine("MENU");
    Console.WriteLine("\nPress 1 for Account Information \nPress 2 for Deposit\nPress 3 for Withdraw\nPress 4 for Balance enquiry");
    x = Convert.ToInt32(Console.ReadLine());
    switch (x)
    {
        case 1:
            Console.WriteLine("Please enter Your Account Number");
            int acno = Convert.ToInt32(Console.ReadLine());
            switch (acno)
            {
                case 101:
                    account1 account = new account1(101, "vimala\n", "vimala@gmail.com\n", "87654893457\n");
                    Console.WriteLine(account.info());
                    break;
                case 102:
                    account1 account1 = new account1(10002, "Sai\n", "sai@gmail.com\n", "98767845697\n");
                    Console.WriteLine(account1.info());
                    break;
                default:
                    Console.WriteLine("Please enter a valid Account Number");
                    break;
            }
            break;
        case 2:
            Console.WriteLine("Please enter Account Number");
            int acn = Convert.ToInt32(Console.ReadLine());
            if (acn == 101)
            {
                Console.WriteLine("Welcome vimala");
                Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT");
                deposit = int.Parse(Console.ReadLine());
                amount = amount + deposit;
                Console.WriteLine("YOUR BALANCE IS {0}", amount);
            }
            else if (acn == 102)
            {
                {
                    Console.WriteLine("Welcome sai");
                    Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT");
                    deposit = int.Parse(Console.ReadLine());
                    amount = amount + deposit;
                    Console.WriteLine("YOUR BALANCE IS {0}", amount);
                }
            }
            else
            {
                Console.WriteLine("Please enter valid account number");
            }

            break;

        case 3:
            Console.WriteLine("\n ENTER THE AMOUNT TO WITHDRAW: ");
            withdraw = int.Parse(Console.ReadLine());
            if (withdraw % 100 != 0)
            {
                Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 100");
            }
            else if (withdraw > (amount - 1000))
            {
                Console.WriteLine("\nMinimum balance should be 1000/-");
                Console.WriteLine("\n INSUFFICENT BALANCE");
            }
            else
            {
                amount = amount - withdraw;
                Console.WriteLine("Successful!....");
                Console.WriteLine("\n YOUR CURRENT BALANCE IS {0}", amount);
            }
            break;


        case 4:
            Console.WriteLine("\n YOUR BALANCE IN Rs : {0} ", amount);
            break;
        default:
            i = 0;
            Console.WriteLine("Please enter a valid number");
            break;











            ///method overloadig

             methodoverloading a = new methodoverloading();
              int sum = a.add(45, 87);
             double sum2 = a.add(23d, 54d);
             float sum1 = a.add(13f, 57f);
              Console.WriteLine("addition is: "+sum);
             Console.WriteLine("addition is:" + sum1);
             Console.WriteLine( "addition is:" + sum2);

             //rbi sbi hdfc

             methodoverride.testmethodoverride();



             ///interface
              //overriding
              IUniversalRemote a = new SonyTV();
              a.SwitchOn();
              a.SwitchOff();
              a.changeChannel("gemini");
              a.changeVolume(15);

             //interface1
             UniversalRemote a1 = new TCLTV();
             a1.SwitchOn();
             a1.SwitchOff();
             a1.changeChannel("cartoon");
             a1.changeVolume(20);

             //arraylist
             arraylist.demo();

             arraylist.demo1();
             arraylist.demo2();
             arraylist.demo3();
             arraylist.demo4();
             arraylist.demo5();
             arraylist.demo6();
             arraylist.demo7();

             ///list
             list.demo();
             list.demo1();
             list.demo2();
             list.demo3();
             list.demo4();
             list.demo5();
             list.demo6();


             CWG.demo();
             dictionary.demo();
             Console.WriteLine();
             dictionary.demo1();
             Console.WriteLine();
             dictionary.demo2();
             Console.WriteLine();
             dictionary.demo3();
             Console.WriteLine();


             exception.demo();
             Console.WriteLine();
             exception.demo1();
             Console.WriteLine();
             exception.demo2();
             Console.WriteLine();
             exception.demo3();
             Console.WriteLine();
             exception.demo4();

            Throw.demo();
            Throw.demo1();
            Throw.Method1();
     Throw.Method2();
            Throw.demo2();
Throw.Method3();
Throw.Method4() */






