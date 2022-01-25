using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject gameover;
    public GameObject restart;
    public AudioClip[] audioClip;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        // definisco il tipo di variabili 
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !GameController.gameover)
        {
            // suono quando premo 
            audioSource.PlayOneShot(audioClip[0]);
            rb.velocity = new Vector2(0f,7f);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        // suono alla collisione
        audioSource.PlayOneShot(audioClip[1]);
        // e avvenuta una collisione quindi gameover diventa true 
        GameController.gameover = true;
        gameover.SetActive(true);
        restart.SetActive(true);
    }
}
