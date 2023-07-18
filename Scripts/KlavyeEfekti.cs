using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KlavyeEfekti : MonoBehaviour
{
    [Multiline] public string metin;
    private Text BuMetin;
    public float gecikme;
    void Start()
    {
        BuMetin = GetComponent<Text>();
        StartCoroutine(KlavyeninEfekti());
    }
    IEnumerator KlavyeninEfekti()
    {
        foreach (char a in metin)
        {
            BuMetin.text += a.ToString();
            if (a.ToString() == ".")
            {
                yield return new WaitForSeconds(1);
            }
            yield return new WaitForSeconds(gecikme);
        }
    }
}
