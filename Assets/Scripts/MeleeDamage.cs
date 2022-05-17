using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeDamage : MonoBehaviour
{
    public int damage = 10;

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
}
