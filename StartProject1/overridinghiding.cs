//using System;

//public class Animal
//{
//    // Method that can be overridden by derived classes
//    public virtual void MakeSound()
//    {
//        Console.WriteLine("The animal makes a sound.");
//    }
//}

//public class Dog : Animal
//{
//    // Method that overrides the MakeSound method in the base class
//    public override void MakeSound()
//    {
//        Console.WriteLine("The dog barks.");
//    }

//    // Method that hides the Eat method in the base class
//    public new void Eat()
//    {
//        Console.WriteLine("The dog eats.");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Create an Animal object and call its MakeSound method
//        Animal animal = new Animal();
//        animal.MakeSound();  // Outputs "The animal makes a sound."

//        // Create a Dog object and call its MakeSound and Eat methods
//        Dog dog = new Dog();
//        dog.MakeSound();  // Outputs "The dog barks."
//        dog.Eat();  // Outputs "The dog eats."

//        // Create an Animal object that is actually a Dog object
//        Animal dogAsAnimal = new Dog();

//        // Call the overridden MakeSound method on the dogAsAnimal object
//        dogAsAnimal.MakeSound();  // Outputs "The dog barks."

//        // Call the hidden Eat method on the dogAsAnimal object (cast as a Dog)
//        ((Dog)dogAsAnimal).Eat();  // Outputs "The animal eats.", not "The dog eats."
//    }
//}
