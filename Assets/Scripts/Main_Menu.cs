using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour
{
    /*private Player player;
    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }*/
    public void LoadGaym()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //player.Load();
    }
    public void QuitGaym()
    {
        Application.Quit();
        Debug.Log("GG");
    }
}
