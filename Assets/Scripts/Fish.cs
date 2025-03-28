using UnityEngine;

// INHERITANCE: Fish inherits from Creature
public class Fish : Creature
{
    private void Start()
    {
        creatureName = "Fish";
        health = 100;
    }

    public override void MakeSound()
    {
        Debug.Log("Blub Blub!");
    }

    // ABSTRACTION: A new method only in Fish
    public void Swim()
    {
        transform.position += new Vector3(-1, 0.25f, 0) * Time.deltaTime;
    }
}
