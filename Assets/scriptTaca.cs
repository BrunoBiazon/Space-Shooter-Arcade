using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class scriptTaca : MonoBehaviour{

    private Rigidbody2D rbd;
    float velocidade = 5;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(this.gameObject);
        
        scriptPlacar.AddPlacar(1);
    }

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
