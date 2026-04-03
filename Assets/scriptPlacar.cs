using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scriptPlacar : MonoBehaviour
{
    static int placar;
    static GameObject txtPlacar;

    public void Start()
    {
        txtPlacar = GameObject.Find("txtPlacar");      
    }

    public static void AddPlacar(int a)
    {

        placar += a;

        txtPlacar.GetComponent<TMP_Text>().text = "Placar: " + placar;

    }
}
