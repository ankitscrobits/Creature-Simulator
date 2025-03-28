using UnityEngine;

// INHERITANCE: Dog inherits from Creature
public class Dog : Creature
{
    private void Start()
    {
        creatureName = "Dog";
        health = 100;
    }

    public override void MakeSound()
    {
        Debug.Log("Woof Woof!");
    }
}
