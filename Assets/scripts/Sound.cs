using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class soud : MonoBehaviour
{
    


    public AudioSource audioSource; // Reference to the AudioSource

    private void Start()
    {
        // Check if an AudioSource is assigned
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>(); // Automatically get the AudioSource if not assigned
        }

        // Play the sound at maximum volume
        PlaySound();
    }

    private void PlaySound()
    {
        audioSource.volume = 1.0f; // Set volume to maximum
        audioSource.Play(); // Play the sound
    }

    // Optional: Reload the scene when called (for testing)
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

