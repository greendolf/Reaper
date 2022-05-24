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

    public float timeBtfAttack = 1f;
    public float startTimeBtfAttack = 1f;
    private Rigidbody2D rb;
    public float knockback = 20F;
    public float knockbackForEnemy = 10F;

    private Transform enemy;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

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
        //LifeLogic();
    }

    private void FixedUpdate()
    {
        timeBtfAttack -= Time.fixedDeltaTime;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
          GameObject obj = collision.gameObject;
          if (obj.CompareTag("Player") && timeBtfAttack <= 0)
          {
               player = collision.GetComponent<Player>();
               enemy = collision.GetComponent<Transform>();
               player.GetDamage(damage, transform, knockback);
               //playerRB.AddForce(transform.right * knockback * -transform.localScale.x, ForceMode2D.Impulse);
               timeBtfAttack = startTimeBtfAttack;
          }
          /*else
          {
            timeBtfAttack -= Time.deltaTime;
          }*/
    }

    public void GetDamage(int value)
    {
        hp -= value;
        /*Vector3 pushFrom = enemy.position;
        Vector3 pushDirection = (pushFrom - transform.position).normalized;
        pushDirection = new Vector3(pushDirection.x, 0f, 0f);
        // Толкаем объект в нужном направлении с силой knockback
        rb.AddForce(pushDirection * knockbackForEnemy * enemy.localScale.x, ForceMode2D.Impulse);*/
        LifeLogic();
    }
}
