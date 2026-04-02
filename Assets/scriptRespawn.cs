using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptRespawn : MonoBehaviour{

    public GameObject taca;

    void Start()    {

        InvokeRepeating("respawnar", 0, 1);

    }

    private void respawnar()
    {
        Vector2 pos = new Vector2(0, 5);

        Instantiate(taca, pos, Quaternion.identity);

    }
    
    void Update()    {
        


    }
}
