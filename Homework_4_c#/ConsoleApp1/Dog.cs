namespace ConsoleApp1;

internal class Dog : Animal
{
    public Dog(string Nickname, int Age, string Gender, double Energy, double Price) : base(Nickname, Age, Gender, Energy, Price)
    {

    }

    public override void Eat()
    {
        if (Energy <= 85)
        {
            Energy += 85;
        }

        else
        {
            Energy = 100;
        }

        Price += 30;
    }

    public override void Sleep()
    {
        Energy = 100;
    }

    public override void Play()
    {
        if (Energy >= 15)
        {
            Energy -= 15;
        }

        else
        {
            Energy = 0;
        }
    }
}
