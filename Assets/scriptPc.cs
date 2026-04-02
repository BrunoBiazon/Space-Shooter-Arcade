using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class scriptPc : MonoBehaviour { 

    private Rigidbody2D rbd;
    public float velocidade;
    private float altura, largura;

    void Start(){
        transform.position = new Vector2(0, -3.5f);
        rbd = this.GetComponent<Rigidbody2D>();
        velocidade = 10;
        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;
    }

    void Update(){
        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rbd.velocity = new Vector2(x, y) * velocidade; 

        if (this.transform.position.x > largura)
            this.transform.position = new Vector2(-largura, this.transform.position.y);
        else if(this.transform.position.x < -11.4)
            this.transform.position = new Vector2(largura, this.transform.position.y);

        if (this.transform.position.y > -0.30)
            this.transform.position = new Vector2(this.transform.position.x, -0.30f);
        else if (this.transform.position.y < -5)
            this.transform.position = new Vector2(this.transform.position.x, -5);

    }
}
