using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class scriptTaca : MonoBehaviour{

    private Rigidbody2D rbd;
    float velocidade = 5;
    int vida;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("navePC"))
        {
            Debug.Log("if");
            vida = scriptVida.AtualizarVida();

            if (vida  == 0)
            Destroy(this.gameObject);
            
        }
        else
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Debug.Log("else");
            scriptPlacar.AddPlacar(1);
        }     
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
