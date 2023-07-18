using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirSonrakiBolumeGecis : MonoBehaviour
{
    private Scene sahne;
    private void Awake()
    {
        sahne = SceneManager.GetActiveScene();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Oyuncu"))
        {
            SceneManager.LoadScene(sahne.buildIndex + 1);
        }
    }
}
