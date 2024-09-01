using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    private int i = 3;

    void Start()
    {
        Debug.Log(gameObject.name + i);  // Initial log with i = 3
    }

    void Update()
    {
        i++;  // Increment i each frame
        Debug.Log(gameObject.name + i);  // Log the current GameObject's name and value of i
    }
}
