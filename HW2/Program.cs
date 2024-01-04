using System.Numerics;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Start 1"); 
            //Money money = new Money { banknotes = 100, pennies = 50 };
            //Product product = new Product(money);
            //money.Show();
            //product.SetDiscount();
            //money.Show();
            //Console.WriteLine("End 1");


            //Console.WriteLine("Start 2");
            //Violin violin = new Violin("Скрипка", "Дринь-дринь-дринь", "Впервые была создана ...","Мини гитара с тонкими струнами");
            //Cello cello = new Cello("Виолончель", "Трунь-Трунь-Трунь", "Впервые была создана ...", "Большая скрипка...");
            //violin.start();
            //cello.start();
            //Console.WriteLine("End 2");


            //Console.WriteLine("Start 3"); 
            //Number number = new Number();
            //number.num = 50;
            //Console.WriteLine(TobinaryNumber(number.num));
            //Console.WriteLine(ToOctalNumber(number.num));
            //Console.WriteLine(ToDecimalNumber(number.num));
            //
            //string TobinaryNumber(int x){
            //    string x_s = Convert.ToString(x, 2); return x_s;
            //}
            //string ToOctalNumber(int x){
            //    string x_s = Convert.ToString(x, 8); return x_s;
            //}
            //string ToDecimalNumber(int x){
            //    string x_s = x.ToString("X"); return x_s;
            //}
            //Console.WriteLine("End 3");
        }

        
    }
}
#region
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
#endregion

#region
public abstract class MusicalInstrument
{
    string name;
    string sound;
    string story;
    string desc;

    public MusicalInstrument(string name, string sound, string story, string desc)
    {
        this.name = name; this.sound = sound; this.story = story; this.desc = desc;
    }

    public void Sound()
    {
        Console.WriteLine(sound);
    }
    public void Show()
    {
        Console.WriteLine(name);
    }
    public void Desc()
    {
        Console.WriteLine(desc);
    }
    public void History()
    {
        Console.WriteLine(story);
    }


    public void start (){
        Show();
        Sound();
        Desc();
        History();

        }
}
public class Violin : MusicalInstrument
{
    public Violin(string name, string sound, string story, string desc) : base(name, sound, story, desc)
    {
    }
}
public class Cello : MusicalInstrument
{
    public Cello(string name, string sound, string story, string desc) : base(name, sound, story, desc)
    {
    }
}
#endregion


public struct Number
{
    public int num;
}