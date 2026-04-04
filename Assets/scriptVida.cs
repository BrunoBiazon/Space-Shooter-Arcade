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

    public static void AtualizarVida()
    {
        if (txtVida == null)
        {
            txtVida = GameObject.Find("txtVida");
        }

        vidaUpdate--;
        VerificaMorte(vidaUpdate);

        AtualizarTexto();
        
    }

    static void AtualizarTexto()
    {
        if (txtVida != null)
        {
            txtVida.GetComponent<TMP_Text>().text = "Vida: " + vidaUpdate;
        }
    }

    public static int VerificaMorte(int vidaUpdate)
    {
        if (vidaUpdate == 0)
        {

            return 0;
        }

       return 2;     
    }
}