using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public string nextScene;

    public string nextSceneName; // The name of the scene to load

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player collides with the teleporter
        if (other.CompareTag("Player")) // Make sure your player is tagged as "Player"
        {
            // Load the specified scene
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
