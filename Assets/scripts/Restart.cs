using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void ClickRestart(){
        // @Param gameover 
        // resetta la variabile statica ,
        //  altrimenti anche al restart del gioco resta a true 
        GameController.gameover = false;
        // scenemanager load scene andra a ricarica la scena 
        SceneManager.LoadScene(0);
    }
}
