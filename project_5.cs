{
    Console.WriteLine("Hello World");
    Console.WriteLine("Personal Profile Generator");

    Console.Write("enter your name: ");
    string userName = Console.ReadLine();

    Console.Write("year of birth: ");
    string userYOB = Console.ReadLine();
    int YOB = Convert.ToInt32(userYOB);
    int age = (int) 2026 - YOB;

    Console.Write("enter your height(in cm): ");
    string cmHeight = Console.ReadLine();
    double mHeight = Convert.ToDouble(cmHeight)/100;

    Console.Write("enter your city: ");
    string userCity = Console.ReadLine();

    Console.WriteLine("Hello, I am " + userName + " and I am currently " + age + "yrs old, I am " + mHeight + "m tall and I live in " + userCity);
}