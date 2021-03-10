using UnityEngine;
using System.Collections;

// Quits the player when the user hits escape

public class Qoit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            Application.Quit();
        }
    }
}
