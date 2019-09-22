

//Write MyBook class
class MyBook : Book
{
    private int price;

    public MyBook(String title, String author, int price) : base(title, author)
    {
        this.price = price;
    }

    public override void display()
    {
        Console.WriteLine($"Title: {this.title}");
        Console.WriteLine($"Author: {this.author}");
        Console.WriteLine($"Price: {this.price}");
    }
}


