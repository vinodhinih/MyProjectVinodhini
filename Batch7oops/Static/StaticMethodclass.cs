class StaticMethodclass
{
    static int y = 100;
    int x = 200;
    static void add()
    {
        StaticMethodclass obj = new StaticMethodclass();
        Console.WriteLine(obj.x + y);
    }
    public static void Main()
    {
        StaticMethodclass.add();
        Console.ReadLine();
    }
}
    

