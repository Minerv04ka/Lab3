using System;
using System.Numerics;
class Dog{
    public string Name;
    public string FurColor;
    public double BodyWeight;
    public bool isSleeping = false;
    public Dog(string name){
        this.Name = name;
    }
    public Dog(string name, string furColor)
        :this(name)
    {
        FurColor = furColor;
    }
    public Dog(string name, double bodyWeight)
        :this(name)
    {
        BodyWeight = bodyWeight;
    }
    public Dog(string name, string furColor, double bodyWeight)
        :this(name, furColor)
    {
        BodyWeight = bodyWeight;
    }
    public void WakeUp(){
        if (!isSleeping){
            Console.WriteLine("Dog {0} woke up", Name);
        } else Console.WriteLine("Dog {0} cannot wake up, it's sleeping right now", Name);
    }
    public void Sleep(){
        Console.WriteLine("Dog {0} is sleeping now", Name);
        isSleeping = true;
    }
    public void Bark(){
        if (!isSleeping){
            if (BodyWeight > 20){
                Console.WriteLine("Big dog {0} is barking loudly", Name);
            } else Console.WriteLine("Small dog {0} is barking quietly", Name);
        } else Console.WriteLine("Dog {0} is sleeping. It cannot bark", Name);
    }
    public void Run(){
        if (!isSleeping){
            if (BodyWeight > 20){
                Console.WriteLine("Big dog {0} is running fastly", Name);
            } else Console.WriteLine("Small dog {0} is running slowly", Name);
        } Console.WriteLine("Dog {0} is sleeping. It cannot run");
    }
}
class Program{
    static void Main(){
        Dog bigDog = new Dog("Дабі", "Бакс", 25);
        Dog smallDog = new Dog("Шарик", 10);

        bigDog.WakeUp();
        bigDog.Bark();
        bigDog.Sleep();
        bigDog.Bark();

        smallDog.WakeUp();
        smallDog.Bark();
        smallDog.Sleep();
        smallDog.Bark();

        Console.ReadLine();
    }
}