using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int minimumCount = 3;
    public int maximumCount = 5;
    public GameObject prefab;

    private float rangeOfSpawn;
    public float rangeSpread;
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
            Spawn();
        }
    }
    public void GetDamage(int value)
    {
        hp -= value;
    }

    public void Spawn()
    {
        // Randomly pick the count of prefabs to spawn.
        int count = Random.Range(minimumCount, maximumCount);
        // Spawn them!
        for (int i = 0; i < count; ++i)
        {
            float rangeOfSpawn = Random.Range(-rangeSpread / 2, rangeSpread / 2);
            transform.position = transform.position + new Vector3(rangeOfSpawn, 0, 0);
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}
