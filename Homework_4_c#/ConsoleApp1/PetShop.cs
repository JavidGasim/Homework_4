using System.Security.Cryptography;
using System.Transactions;

namespace ConsoleApp1;

internal class PetShop
{
    Cat[] cats { get; set; }
    Dog[] dogs { get; set; }
    Bird[] birds { get; set; }
    Animal[][] animals { get; set; }

    public PetShop()
    {

    }

    public PetShop(Cat[] cats, Dog[] dogs, Bird[] birds, Animal[][] animals)
    {
        this.cats = cats;
        this.dogs = dogs;
        this.birds = birds;
        this.animals = animals;
    }

    public void fillArr()
    {
        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                for (int j = 0; j < 2; j++)
                {
                    animals[i][j] = cats[j];
                }
            }

            else if (i == 1)
            {
                for (int j = 0; j < 2; j++)
                {
                    animals[i][j] = dogs[j];
                }
            }

            else if (i == 2)
            {
                for (int j = 0; j < 1; j++)
                {
                    animals[i][j] = birds[j];
                }
            }
        }

    }
    public void menu()
    {
        Console.WriteLine("1)All Animals and Details");
        Console.WriteLine("2)Remove Animal By Nickname");
        Console.WriteLine("3)Give Food");
        Console.WriteLine("4)Sleep");
        Console.WriteLine("5)Play with Animal");
        Console.Write("Choose: ");

        string secim;

        secim = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine();

        if (secim == "1")
        {
            allAnimals();
        }

        else if (secim == "2")
        {
            removeAnimal();
        }

        else if (secim == "3")
        {
            string animal;
            Console.Write("Enter Nickname: ");
            animal = Console.ReadLine();

            if (animal == "Mesi")
            {
                animals[0][0].Eat();
            }

            else if(animal =="Mestan")
            {
                animals[0][1].Eat();
            }

            else if (animal == "Cek")
            {
                animals[1][0].Eat();
            }

            else if (animal == "Reks")
            {
                animals[1][1].Eat();
            }

            else if (animal == "Papuqay")
            {
                animals[2][0].Eat();
            }

            else
            {
                menu();
            }
        }

        else if (secim == "4")
        {
            string animal;
            Console.Write("Enter Nickname: ");
            animal = Console.ReadLine();

            if (animal == "Mesi")
            {
                animals[0][0].Sleep();
            }

            else if (animal == "Mestan")
            {
                animals[0][1].Sleep();
            }

            else if (animal == "Cek")
            {
                animals[1][0].Sleep();
            }

            else if (animal == "Reks")
            {
                animals[1][1].Sleep();
            }

            else if (animal == "Papuqay")
            {
                animals[2][0].Sleep();
            }

            else
            {
                menu();
            }
        }

        else if (secim == "5")
        {
            string animal;
            Console.Write("Enter Nickname: ");
            animal = Console.ReadLine();

            if (animal == "Mesi")
            {
                animals[0][0].Play();

                if (animals[0][0].Energy==0)
                {
                    animals[0][0].Sleep();
                }

                menu();
            }

            else if (animal == "Mestan")
            {
                animals[0][1].Play();

                if (animals[0][1].Energy == 0)
                {
                    animals[0][1].Sleep();
                }

                menu();
            }

            else if (animal == "Cek")
            {
                animals[1][0].Play();

                if (animals[1][0].Energy == 0)
                {
                    animals[1][0].Sleep();
                }

                menu();
            }

            else if (animal == "Reks")
            {
                animals[1][1].Play();

                if (animals[1][1].Energy == 0)
                {
                    animals[1][1].Sleep();
                }

                menu();
            }

            else if (animal == "Papuqay")
            {
                animals[2][0].Play();

                if (animals[2][0].Energy == 0)
                {
                    animals[2][0].Sleep();
                }

                menu();
            }

            else
            {
                menu();
            }
        }

        else
        {
            Console.WriteLine("False choice");
            menu();
        }
    }

    public void allAnimals()
    {
        int a = 1;
        for (int i = 0; i < animals.Length; i++)
        {
            for (int j = 0; j < animals[i].Length; j++)
            {
                if (i == 0)
                {
                    Console.Write(a + ")");
                    Console.WriteLine("Cat");
                }

                else if (i == 1)
                {
                    Console.Write(a + ")");
                    Console.WriteLine("Dog");
                }

                else if (i == 2)
                {
                    Console.Write(a + ")");
                    Console.WriteLine("Bird");
                }

                Console.Write("Nickname: ");
                Console.WriteLine(animals[i][j].Nickname);
                Console.Write("Age: ");
                Console.WriteLine(animals[i][j].Age);
                Console.Write("Gender: ");
                Console.WriteLine(animals[i][j].Gender);
                Console.Write("Energy: ");
                Console.WriteLine(animals[i][j].Energy);
                Console.Write("Price: ");
                Console.WriteLine(animals[i][j].Price);
                Console.WriteLine("<---------------->");
                Console.WriteLine();
                Console.WriteLine();
                a++;
            }
        }
        menu();
    }

    public void removeAnimal()
    {
        Console.Write("Enter Nickname: ");

        string nickname = Console.ReadLine();

        if (nickname == "Mesi")
        {
            if (animals[0].Length == 2)
            {
                animals[0][0] = animals[0][1];
                Array.Resize(ref animals[0], 1);
            }

            else
            {
                Array.Resize(ref animals[0], 0);
            }
        }

        else if (nickname == "Mestan")
        {
            if (animals[0].Length == 2)
            {
                Array.Resize(ref animals[0], 1);
            }

            else
            {
                Array.Resize(ref animals[0], 0);
            }
        }

        else if (nickname == "Cek")
        {
            if (animals[0].Length == 2)
            {
                animals[1][0] = animals[1][1];
                Array.Resize(ref animals[1], 1);
            }

            else
            {
                Array.Resize(ref animals[1], 0);
            }
        }

        else if (nickname == "Reks")
        {
            if (animals[1].Length == 2)
            {
                Array.Resize(ref animals[1], 1);
            }

            else
            {
                Array.Resize(ref animals[1], 0);
            }
        }

        else if (nickname == "Papuqay")
        {
            Array.Resize(ref animals[2], 0);
        }

        else { Console.WriteLine("There is no animal with this nickname"); }

        menu();

    }
}
