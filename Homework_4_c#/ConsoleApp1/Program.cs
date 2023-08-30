using ConsoleApp1;
using System.Security.Cryptography;

Cat c1 = new Cat("Mesi", 2, "Erkek", 88.2, 50);
Cat c2 = new Cat("Mestan", 1, "Dishi", 62.8, 65);

Dog d1 = new Dog("Cek", 5, "Erkek", 97, 120);
Dog d2 = new Dog("Reks", 7, "Dishi", 75.3, 95);

Bird b1 = new Bird("Papuqay", 1, "Erkek", 45.5, 15);

Cat[] cats = new Cat[] { c1, c2 };
Dog[] dogs = new Dog[] { d1, d2 };
Bird[] birds = new Bird[] { b1 };
Animal[][] animals = new Animal[3][] { cats, dogs, birds };

PetShop petShop = new PetShop(cats, dogs, birds, animals);

petShop.fillArr();
petShop.menu();