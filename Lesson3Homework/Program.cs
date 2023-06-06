namespace Lesson3Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ternory operator

            //Console.Write("please confirme your age - ");
            //byte age = Convert.ToByte(Console.ReadLine());

            //string sign1 = "Sorry you can't sign in this app.";
            //string sign2 = "Welcome to our application.";

            //var result = age < 18 ? sign1 : sign2;

            //Console.WriteLine(result);


            //increment

            //            Console.Write("please confirme your age - ");
            //            byte age = Convert.ToByte(Console.ReadLine());
            //            DateTime now = DateTime.Today;
            //            DateTime dt = new DateTime(2023, 06, 07);
            ////ete var i poxaren dnumem datetime error e talis
            //            var resault = now == dt ? "happy birthday you are "+age++ +" years old " : "Sorry today is not your birthday";
            //            Console.WriteLine(resault);


            //decrement

            //byte a = 5;
            //int b = 9;
            //int c = 5;
            //if (a == b || a == c) 
            //{
            //    a++;
            //}
            //else
            //{
            //    b++;
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //if else if

            //byte paper = 120;
            //Console.WriteLine("You can buy "+paper+ " pcs of paper");
            //Console.Write("how many paper do you want to buy? - ");
            //byte pcsPaper = Convert.ToByte(Console.ReadLine());
            //string boughtPaper = null;
            //if (pcsPaper == 0 || pcsPaper < 0)
            //{
            //    boughtPaper = "You can't buy" + pcsPaper + " pcs paper";
            //}
            //else if(pcsPaper > 0 && pcsPaper < paper ) 
            //{
            //    boughtPaper = "You can buy " + pcsPaper + " pcs paper";
            //    paper -= pcsPaper;
            //}else if(pcsPaper > paper)
            //{
            //    boughtPaper = "You can't buy " + pcsPaper + " pcs paper, becouse we have only "+paper+" pcs paper";
            //}

            //Console.WriteLine(boughtPaper);
            //Console.WriteLine("Now we have " + paper + " pcs paper");


            //switch case


            Console.WriteLine("Welcome to our library");
            Console.WriteLine("Please choose library");
            Console.WriteLine("Write 1 if you want books for children");
            Console.WriteLine("Write 2 if you want books for adults");
            Console.WriteLine("Write 3 if you our vip client");
            int library = Convert.ToInt32(Console.ReadLine());
            switch (library) 
            {
                case 1:
                    Console.WriteLine("for children");
                    break;
                case 2:
                    Console.WriteLine("for adults");
                    break;
                case 3:
                    Console.WriteLine("Please write your pin");
                    int pin = Convert.ToInt32(Console.ReadLine());
                    if (pin == 0)
                    {
                        Console.Write("Welcome to library for vip clients and ");
                        goto case 1;
                    }
                    else
                    {
                        Console.WriteLine("Your pin is false. Please try again.");
                    }
                    break;
                default:
                    Console.WriteLine("Please choose real library");
                    break;
            }

        }
    }
}