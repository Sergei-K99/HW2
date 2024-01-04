namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money { banknotes = 100, pennies = 50 };
            Product product = new Product(money);

            Console.WriteLine("Start");

            money.Show();
            product.SetDiscount();
            money.Show();


            Console.WriteLine("End");

        }
    }
}

public class Money
{
    public int banknotes { get; set; }
    public int pennies { get; set; }

    public void Show()
    {
        Console.WriteLine($"{banknotes},{pennies} $");
    }
}

public class Product
{
    public string name { get; set; }
    public Money money { get; set; }

    public Product(Money money)
    {
        this.money = money;
    }

    public void SetDiscount()
    {
        Console.WriteLine("Ваша скидка:");
        if(!double.TryParse(Console.ReadLine(), out double discount))
        {
            Console.WriteLine("Проблемы с числом");
            return;
        }
        Console.WriteLine("Скидка применилась");

        money.banknotes -= (int)discount;
        money.pennies -= (int)discount % 1;
    }
}