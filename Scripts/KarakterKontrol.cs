using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    public float ziplamakuvveti = 2.0f;
    public float hiz = 1.0f;
    private float hareketyonu;
    private bool yerdemiyim = true;
    private bool hareketediyormuyum;
    private bool zipladimmi;
    private Rigidbody2D fizik;
    private SpriteRenderer SR;
    private Animator animasyon;

    private void Awake()
    {
        animasyon = GetComponent<Animator>();
    }
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        SR = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        if (fizik.velocity != Vector2.zero)
        {
            hareketediyormuyum = true;
        }
        else
        {
            hareketediyormuyum = false;
        }
        fizik.velocity = new Vector2(hiz * hareketyonu, fizik.velocity.y);
        if (zipladimmi == true)
        {
            fizik.velocity = new Vector2(fizik.velocity.x, ziplamakuvveti);
            zipladimmi = false;
        }
    }
    void Update()
    {
        if (yerdemiyim == true && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            if (Input.GetKey(KeyCode.A))
            {
                hareketyonu = -1.0f;
                SR.flipX = true;
                animasyon.SetFloat("hiz", hiz);
            }else if (Input.GetKey(KeyCode.D))
            {
                hareketyonu = 1.0f;
                SR.flipX = false;
                animasyon.SetFloat("hiz", hiz);
            }
        }else if (yerdemiyim == true)
        {
            hareketyonu = 0.0f;
            animasyon.SetFloat("hiz", 0.0f);
        }
        if (yerdemiyim == true && Input.GetKey(KeyCode.W))
        {
            zipladimmi = true;
            yerdemiyim = false;
            animasyon.SetTrigger("zipladimmi");
            animasyon.SetBool("yerdemiyim", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            animasyon.SetBool("yerdemiyim", true);
            yerdemiyim = true; 
        }
    }
}
