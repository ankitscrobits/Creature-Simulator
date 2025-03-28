using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    protected string creatureName;
    protected int health;

    // ENCAPSULATION: Using getter and setter for health
    public int Health
    {
        get { return health; }
        set { health = Mathf.Clamp(value, 0, 100); } // Health cannot go below 0 or above 100
    }

    // ABSTRACTION: Common functionality for all creatures
    public virtual void Move(Vector3 direction)
    {
        transform.position += direction * Time.deltaTime;
    }

    // POLYMORPHISM: Method to be overridden in child classes
    public abstract void MakeSound();
}
