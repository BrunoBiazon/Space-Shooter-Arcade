using UnityEngine;

public class scriptFundo : MonoBehaviour
{
    Rigidbody2D rgb;
    float velocidade, altura, limiteInferior;

    void Start()
    {
        velocidade = 4;
        rgb = GetComponent<Rigidbody2D>();
        rgb.velocity = new Vector2(0, -velocidade);

        altura = CameraUtils.GetAltura();

        limiteInferior = - altura * 2       ;
    }

    void Update()
    {
        if (transform.position.y < limiteInferior)
        {
            transform.position = new Vector2(0, altura * 2);
        }
    }
}