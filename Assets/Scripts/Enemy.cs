using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 30;
    public int damage = 10;

    private void Update()
    {
        LifeLogic();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        print(collision.name);
        GameObject obj = collision.gameObject;
        if (obj.CompareTag("Player"))
        {
            print("HAHA");
            collision.GetComponent<Player>().GetDamage(damage);
        }
    }

    private void LifeLogic()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void GetDamage(int value)
    {
        hp -= value;
    }
}
