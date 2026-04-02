using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptTaca : MonoBehaviour{

    private Rigidbody2D rbd;
    float velocidade = 5;

    void Start(){
        
        rbd = this.GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -velocidade);

    }

    void Update(){
        
        if( transform.position.y < -Camera.main.orthographicSize )
        {
            Destroy(this.gameObject);

        }


    }
}
