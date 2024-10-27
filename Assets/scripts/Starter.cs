using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starter : MonoBehaviour
{
    public string sceneName = "Lvl1"; // The name of the scene you want to load
    
    void Update()
    {
        // Check if the left mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneName);
        }
    }
}
