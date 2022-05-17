using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 30;
    public int damage = 10;
    public Player player;

    public int minimumCount = 3;
    public int maximumCount = 5;
    public GameObject prefab;

    private float rangeOfSpawn;
    public float rangeSpread = 2;

    private float timeBtfAttack;
    public float startTimeBtfAttack;
    public void Spawn()
    {
        int count = Random.Range(minimumCount, maximumCount);
        for (int i = 0; i < count; ++i)
        {
            float rangeOfSpawn = Random.Range(-rangeSpread / 2, rangeSpread / 2);
            transform.position = transform.position + new Vector3(rangeOfSpawn, 0, 0);
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }

    private void LifeLogic()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
            Spawn();
        }
    }
    private void Update()
    {
        LifeLogic();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (timeBtfAttack <= 0)
        {
                GameObject obj = collision.gameObject;
                if (obj.CompareTag("Player"))
                {
                    print("HAHA");
                    player.GetDamage(damage);
                }
                timeBtfAttack = startTimeBtfAttack;
           }
            else
            {
                timeBtfAttack -= Time.deltaTime;
            }
    }

    public void GetDamage(int value)
    {
        hp -= value;
    }
}
