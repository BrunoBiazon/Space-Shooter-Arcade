using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class scriptPc : MonoBehaviour {

    public GameObject tiro;

    AudioSource som_tiro;
    
    Rigidbody2D rbd;
   
    float altura, largura, alturaNave,velocidade;
    

    void Start() {
        transform.position = new Vector2(0, -3.5f);
        rbd = this.GetComponent<Rigidbody2D>();
        velocidade = 10;
        altura = CameraUtils.GetAltura();
        som_tiro = this.GetComponent<AudioSource>();

        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Bounds limites = sr.bounds;
        alturaNave = limites.size.y;

    }

    void Update() {
        largura = CameraUtils.GetAltura();
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        velocidade = scriptPlacar.AttVelocidadePC(scriptPlacar.AttFase());
        rbd.velocity = new Vector2(x, y) * velocidade;

        if (this.transform.position.x > largura)
            this.transform.position = new Vector2(-largura, this.transform.position.y);
        else if (this.transform.position.x < -11.4)
            this.transform.position = new Vector2(largura, this.transform.position.y);

        if (this.transform.position.y > -0.30)
            this.transform.position = new Vector2(this.transform.position.x, -0.30f);
        else if (this.transform.position.y < -5 + (alturaNave/2) ) 
            this.transform.position = new Vector2(this.transform.position.x, -5 + (alturaNave / 2) );

        // futuramente fazer logica para tiros especiais,ex: cada 0,5segundos pressionado = 1 tiro
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) // tiro padrão ao pressionar espaço ou btn esq mouse para baixo
        {
            som_tiro.Play();
            Vector2 posicaoTiro = new Vector2(transform.position.x, transform.position.y + (alturaNave - 1));
            Instantiate(tiro, posicaoTiro, Quaternion.identity); 
        }

    }


}
