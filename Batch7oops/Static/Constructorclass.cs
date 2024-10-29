class Constructorclass
{
     int no_of_books = 1500;
     int story_books = 260;
     int technical_books = 590;
     static void storybook()
     {
        Constructorclass obj = new Constructorclass();
        Console.WriteLine(obj.story_books);
     }
     public void book(int no_of_books)
     {
       
        Console.WriteLine("Number of books in library="+no_of_books);
     }
     public int technical()
     {
        Console.WriteLine("Technical books="+technical_books);
        Constructorclass obj = new Constructorclass();
        return technical_books;
     }
     public static void Main(string[]args)
     {
        Constructorclass c1 = new Constructorclass();
       
        Constructorclass.storybook();
        Constructorclass.book();
     }
        
}

