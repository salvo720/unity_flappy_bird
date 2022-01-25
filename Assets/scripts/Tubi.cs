using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubi : MonoBehaviour
{
    bool GiaContanto=false;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameController.gameover){
            transform.position=new Vector2(transform.position.x - 2f * Time.deltaTime , transform.position.y);
            if(transform.position.x<-3){
                Destroy(gameObject);
            }
        }
        if(!GiaContanto && transform.position.x < -1 ){
            audioSource.Play();
            GiaContanto=true;
            Punteggio.ValorePunti += 1;
        }
    }
}
