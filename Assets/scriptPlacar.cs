using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scriptPlacar : MonoBehaviour
{
    static int placar;
    static GameObject txtPlacar;
    static GameObject txtFase;
    static int fase, num_fase;
    public void Start()
    {
        txtPlacar = GameObject.Find("txtPlacar");
        txtFase = GameObject.Find("txtFase");
    }

    public static void AddPlacar(int a)
    {

        placar += a;
        fase = AttFase();
        txtPlacar.GetComponent<TMP_Text>().text = "Placar: " + placar;
        txtFase.GetComponent<TMP_Text>().text = "Fase: " + fase;
    }
    
    static int AttFase()
    {
        if (placar >= 0 && placar <= 30)
        {
            num_fase = 1;
        }
        else if (placar > 30 && placar < 75)
        {
            num_fase = 2;
        }
        else
        {
            num_fase = 3;
        }

        return num_fase;
    }
}
