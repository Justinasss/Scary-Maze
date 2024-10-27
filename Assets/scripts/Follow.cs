using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Follow : MonoBehaviour
{
    public float speed = 15f;

    void Start()
    {
        
        transform.position = new Vector3(0, -4, -1);
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = transform.position.z;
        transform.position = mousePosition;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collided with: " + other.gameObject.name); // Debug line
        if (other.CompareTag("Wall"))
        {
            SceneManager.LoadScene("Start");
        }
    }


}
