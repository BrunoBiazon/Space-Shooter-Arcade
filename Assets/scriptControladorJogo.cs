using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptControladorJogo : MonoBehaviour
{
    private bool pausa;

    void Start()
    {
        pausa = false;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (pausa)
            {
                RetomarJogo();
            }
            else
            {
                PausarJogo();
            }
        }
    }

    public void PausarJogo()
    {
        pausa = true;
        Time.timeScale = 0;
        SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);
    }

    public void RetomarJogo()
    {
        pausa = false;
        Time.timeScale = 1;
        SceneManager.UnloadSceneAsync(2);
    }
}