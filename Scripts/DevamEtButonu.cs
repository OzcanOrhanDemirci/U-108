using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DevamEtButonu : MonoBehaviour
{
    private Scene sahne;
    private void Awake()
    {
        sahne = SceneManager.GetActiveScene();
    }
    public void DevamEtFonksiyonu()
    {
        SceneManager.LoadScene(sahne.buildIndex + 1);
    }
}
