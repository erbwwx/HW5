using System;

abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void MakeSound();
    public abstract void Move();
}

class Dog : Animal
{

    public Dog(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Sound: Bark");
    }

    public override void Move()
    {
        Console.WriteLine("Dog is running");
    }
}

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Sound: Meow");
    }

    public override void Move()
    {
        Console.WriteLine("Cat is walking");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Dena", 2);
        Console.WriteLine($"Dog's name: {dog.Name}, Age: {dog.Age}");
        dog.MakeSound();
        dog.Move();

        Cat cat = new Cat("Murka", 1);
        Console.WriteLine($"Cat's name: {cat.Name}, Age: {cat.Age}");
        cat.MakeSound();
        cat.Move();
    }
}
