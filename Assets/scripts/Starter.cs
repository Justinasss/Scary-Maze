using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starter : MonoBehaviour
{
    public string sceneName = "Lvl1"; 

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            
            SceneManager.LoadScene(sceneName);
        }
    }
}
