using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class scriptPc : MonoBehaviour { 

    private Rigidbody2D rbd;
    public float velocidade;

    void Start(){

        rbd = this.GetComponent<Rigidbody2D>();
        velocidade = 10;
    }

    void Update(){
        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rbd.velocity = new Vector2(x, y) * velocidade; 

        if (this.transform.position.x > 11.4)
            this.transform.position = new Vector2(-11.4f, this.transform.position.y);
        else if(this.transform.position.x < -11.4)
            this.transform.position = new Vector2(11.4f, this.transform.position.y);

        if (this.transform.position.y > -0.30)
            this.transform.position = new Vector2(this.transform.position.x, -0.30f);
        else if (this.transform.position.y < -5)
            this.transform.position = new Vector2(this.transform.position.x, -5);

    }
}
