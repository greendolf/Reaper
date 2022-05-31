using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MonoBehaviour
{
    public int hpPrice = 20;
    public int damagePrice = 50;
    public int speedPrice = 40;

    public GameObject marketUI;
    public GameObject enough;

    private void Start()
    {
        enough.SetActive(false);
        marketUI.SetActive(false);
    }
    public void IncreaseHP()
    {
        Player player = GameObject.Find("player").GetComponent<Player>();
        if (player.coins >= hpPrice)
        {
            //enough.SetActive(false);
            player.hpValue += 10;
            player.coins -= hpPrice;
            hpPrice *= 2;
        }
        else
        {
            enough.SetActive(true);
        }
    }

    public void IncreaseDamage()
    {
        PlayerAttack player = GameObject.Find("player").GetComponent<PlayerAttack>();
        Player player1 = GameObject.Find("player").GetComponent<Player>();
        if (player1.coins >= hpPrice)
        {
           // enough.SetActive(false);
            player.damage += 10;
            player1.coins -= damagePrice;
            hpPrice *= 2;
        }
        else
        {
            enough.SetActive(true);
        }
    }

    public void IncreaseSpeed()
    {
        Player player = GameObject.Find("player").GetComponent<Player>();
        if (player.coins >= hpPrice)
        {
           // enough.SetActive(false);
            player.speed += 2;
            player.coins -= speedPrice;
            hpPrice *= 2;
        }
        else
        {
            enough.SetActive(true);
        }
    }
}
