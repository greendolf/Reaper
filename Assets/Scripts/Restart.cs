using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private Player player;
    private void Start()
    {
        player = GameObject.Find("player").GetComponent<Player>();
    }
    public void ReStart()
    {
        player.Save();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void MainMenu()
    {
        player.Save();
        SceneManager.LoadScene("MainMenu");
    }

}
