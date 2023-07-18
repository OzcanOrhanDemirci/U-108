using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DikenOlum : MonoBehaviour
{
    private Scene sahne;
    private void Awake()
    {
        sahne = SceneManager.GetActiveScene();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Oyuncu"))
        {
            SceneManager.LoadScene(sahne.name);
        }
    }
}
