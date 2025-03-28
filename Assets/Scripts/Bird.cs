using UnityEngine;

// INHERITANCE: Bird inherits from Creature
public class Bird : Creature
{
    private void Start()
    {
        creatureName = "Bird";
        health = 100;
    }

    public override void MakeSound()
    {
        Debug.Log("Chirp Chirp!");
    }

    // ABSTRACTION: A new method only in Bird
    public void Fly()
    {
        transform.position += new Vector3(0, 1f, 0) * Time.deltaTime;
    }
}
