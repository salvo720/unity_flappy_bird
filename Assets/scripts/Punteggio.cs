using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punteggio : MonoBehaviour
{
    public static int ValorePunti;
    // Start is called before the first frame update
    void Start()
    {
        ValorePunti=0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = ValorePunti.ToString();
    }
}
