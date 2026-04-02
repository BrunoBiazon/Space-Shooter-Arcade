using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class scriptPc : MonoBehaviour {

    public GameObject tiro;

    AudioSource som_tiro;
    
    Rigidbody2D rbd;
    public float velocidade;
    float altura, largura;

    void Start() {
        transform.position = new Vector2(0, -3.5f);
        rbd = this.GetComponent<Rigidbody2D>();
        velocidade = 10;
        altura = CameraUtils.GetAltura();
        som_tiro = this.GetComponent<AudioSource>();

    }

    void Update() {
        largura = CameraUtils.GetAltura();
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rbd.velocity = new Vector2(x, y) * velocidade;

        if (this.transform.position.x > largura)
            this.transform.position = new Vector2(-largura, this.transform.position.y);
        else if (this.transform.position.x < -11.4)
            this.transform.position = new Vector2(largura, this.transform.position.y);

        if (this.transform.position.y > -0.30)
            this.transform.position = new Vector2(this.transform.position.x, -0.30f);
        else if (this.transform.position.y < -5)
            this.transform.position = new Vector2(this.transform.position.x, -5);

        // futuramente fazer logica para tiros especiais,ex: cada 0,5segundos pressionado = 1 tiro
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) // tiro padrão ao pressionar espaço ou btn esq mouse para baixo
        {
            som_tiro.Play();
            Instantiate(tiro, transform.position, Quaternion.identity); 
        }

    }


}
