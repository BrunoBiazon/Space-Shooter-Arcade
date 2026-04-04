using TMPro;
using UnityEngine;

public class scriptVida : MonoBehaviour
{
    static int vidaUpdate = 3;
    static GameObject txtVida;

    void Start()
    {
        txtVida = GameObject.Find("txtVida");
        AtualizarTexto();
    }

    public static int AtualizarVida()
    {
        if (txtVida == null)
        {
            txtVida = GameObject.Find("txtVida");
        }

        vidaUpdate--; 

        AtualizarTexto();

        return vidaUpdate;
    }

    static void AtualizarTexto()
    {
        if (txtVida != null)
        {
            txtVida.GetComponent<TMP_Text>().text = "Vida: " + vidaUpdate;
        }
    }
}