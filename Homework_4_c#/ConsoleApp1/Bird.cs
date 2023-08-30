namespace ConsoleApp1;

internal class Bird:Animal
{
    public Bird(string Nickname, int Age, string Gender, double Energy, double Price) : base(Nickname, Age, Gender, Energy, Price)
    {

    }

    public override void Eat()
    {
        if (Energy <= 95)
        {
            Energy += 5;
        }

        else
        {
            Energy = 100;
        }

        Price += 5;
    }

    public override void Sleep()
    {
        Energy = 100;
    }

    public override void Play()
    {
        if (Energy >= 5)
        {
            Energy -= 5;
        }

        else
        {
            Energy = 0;
        }
    }
}
