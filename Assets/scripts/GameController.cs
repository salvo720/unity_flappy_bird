using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float SpawnTimer;
    float SpawnRate = 3f;
    public GameObject tubo;
    // il valore iniziale della variabile 
    // @Param gameover e false 
    // @Param gameover e una variabile statica quindi se ricarico la scena sara sempre true ,
    //  quindi deve essere resettata da codice assegnandogli il valore false nella funzione del restart 
    public static bool gameover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // spawn timer parte da 0 , gli andiamo ad aggiungere il delta time
        //  che e il tempo per ogni frame , quando raggiunge o supera il valore dello spawnrate , ovvero 3 float 
        // gli si sottrae il valore dello spawnrate , si calcola il la posizione che andranno ad usare i tubi , tutto denttro il @param SpawnPos 
        if(!gameover){
            SpawnTimer += Time.deltaTime;
            if(SpawnTimer >= SpawnRate ){
                SpawnTimer -= SpawnRate;
                Vector2 SpawnPos = new Vector2(5f,Random.Range(-1f,1f));
                // con instantiatte si instazia o crea un nuovo leemento , che sara di tipo tubo alla posizione calcolata nella SpawnPos , e come ultimo paramentro gli si passa la rotazione che ein questo caso e nulla , quindi gli si passa la funzione Quaternion.identify .
                Instantiate(tubo , SpawnPos , Quaternion.identity);
            }
        }
    }
}
