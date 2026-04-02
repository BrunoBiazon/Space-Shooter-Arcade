using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptRespawn : MonoBehaviour{

    public GameObject taca;

    float larguraObjeto;
    float largura;
    void Start()    {

        largura = CameraUtils.GetLargura();
        larguraObjeto = taca.GetComponent<SpriteRenderer>().bounds.extents.x;
        InvokeRepeating("respawnar", 0, 1);

    }

    private void respawnar()
    {
        float posX;
        posX = Random.Range(-largura + larguraObjeto, largura - larguraObjeto); 

        Vector2 pos = new Vector2(posX, 5);

        Instantiate(taca, pos, Quaternion.identity);

    }
    
    void Update()    {
        


    }
}
