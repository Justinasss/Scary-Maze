using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class soud : MonoBehaviour
{
    


    public AudioSource audioSource; 

    private void Start()
    {
        
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>(); 
        }

        
        PlaySound();
    }

    private void PlaySound()
    {
        audioSource.volume = 1.0f; 
        audioSource.Play(); 
    }

   
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

