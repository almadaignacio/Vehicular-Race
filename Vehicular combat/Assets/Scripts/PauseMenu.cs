using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject MenuPausa;
    bool PauseMode;

    // Start is called before the first frame update
    void Start()
    {
        PauseMode = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && PauseMode == false)
        {
            PauseMode = true;
            Pausa();
        }

        else if (Input.GetKey(KeyCode.Escape) && PauseMode == true)
        {
            Renaudar();
            PauseMode = false;
        }
    }

    public void Pausa()
    {

        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        MenuPausa.SetActive(true);
        PauseMode = true;
    }

    public void Renaudar()
    {
        Time.timeScale = 1f;
        MenuPausa.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        PauseMode = false;
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
