using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [System.Obsolete]
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Bird bird = FindObjectOfType<Bird>();
            bird?.MakeSound();
            bird?.Fly();
        }
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            Fish fish = FindObjectOfType<Fish>();
            fish?.MakeSound();
            fish?.Swim();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Dog dog = FindObjectOfType<Dog>();
            dog?.MakeSound();
        }
    }
}
