using TMPro;
using UnityEngine;

public class scriptVida : MonoBehaviour
{
    static int vidaUpdate;
    static GameObject txtVida;

    void Start()
    {
        vidaUpdate = 3;

        txtVida = GameObject.Find("txtVida");
    }

    public static int AtualizarVida()
    {
        if (txtVida == null)
        {
            Debug.Log("if Atualizar vida");
            txtVida = GameObject.Find("txtVida");
        }
        
        vidaUpdate = vidaUpdate - 1 ; Debug.Log("Decremento");
        txtVida.GetComponent<TMP_Text>().text = "Vida: " + vidaUpdate;

        return vidaUpdate;
    }
}