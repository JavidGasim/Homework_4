namespace ConsoleApp1;

internal abstract class Animal
{
    public string Nickname { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public double Energy { get; set; }
    public double Price { get; set; }

    public Animal()
    {
        
    }

    public Animal(string Nickname, int Age, string Gender, double Energy, double Price)
    {
        this.Nickname = Nickname;
        this.Age = Age;
        this.Gender = Gender;
        this.Energy = Energy;
        this.Price = Price;
    }

    public abstract void Eat();
    public abstract void Sleep();
    public abstract void Play();
}