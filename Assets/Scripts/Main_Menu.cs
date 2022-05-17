using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour
{
    public void LoadGaym()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGaym()
    {
        Application.Quit();
        Debug.Log("GG");
    }
}
