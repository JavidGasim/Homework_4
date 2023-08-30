namespace ConsoleApp1;

internal class Cat : Animal
{
    public Cat(string Nickname, int Age, string Gender, double Energy, double Price) : base(Nickname, Age, Gender, Energy, Price)
    {

    }

    public override void Eat()
    {
        if (Energy <= 75)
        {
            Energy += 25;
        }

        else
        {
            Energy = 100;
        }

        Price += 20;
    }

    public override void Sleep()
    {
        Energy = 100;
    }

    public override void Play()
    {
        if (Energy>=25)
        {
            Energy -= 25;
        }

        else
        {
            Energy = 0;
        }
    }
}
