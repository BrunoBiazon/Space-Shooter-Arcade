using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scriptPlacar : MonoBehaviour
{
    static int placar, velocidadeFasePC;
    static GameObject txtPlacar;
    static GameObject txtFase;
    static int fase, num_fase;
    static float velocidadeFaseTaca;
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
    
    public static int AttFase()
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

    public static int AttVelocidadePC(int p)
    {
        if (p == 1)
        {
            velocidadeFasePC = 10; 
        }
        else if (p == 2)
        {
            velocidadeFasePC = 15;
        }
        else
        {
            velocidadeFasePC = 20;
        }

        return velocidadeFasePC;

    }
    public static float AttVelocidadeTaca(int p)
    {
        if (p == 1)
        {
            velocidadeFaseTaca = 5;
        }
        else if (p == 2)
        {
            velocidadeFaseTaca = 6;
        }
        else
        {
            velocidadeFaseTaca = 7.5f;
        }

        return velocidadeFaseTaca;

    }

}
