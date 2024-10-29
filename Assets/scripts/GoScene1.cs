using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoScene1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("wall"))
        {
            
            SceneManager.LoadScene("Start");
        }

        if (other.CompareTag("bo"))
        {
            
            SceneManager.LoadScene("Boo");
        }


    }
}
