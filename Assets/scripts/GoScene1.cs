using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoScene1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player collides with the object tagged "Wall"
        if (other.CompareTag("wall"))
        {
            // Load the "Start" scene
            SceneManager.LoadScene("Start");
        }

        if (other.CompareTag("bo"))
        {
            // Load the "Start" scene
            SceneManager.LoadScene("Boo");
        }


    }
}
