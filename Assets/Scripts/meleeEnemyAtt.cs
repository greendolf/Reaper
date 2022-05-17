using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeEnemyAtt : MonoBehaviour
{
    public float timeBtAttack;
    private player player;
    public Transform attackPos;
    public float attackRange;
    public int attackDamage;
    public Transform transform;

    public int hp = 10;

    // COIN SPAWN FUNC
    /*
    public int minimumCount = 3;
    public int maximumCount = 5;
    public GameObject prefab;

    private float rangeOfSpawn;
    public float rangeSpread;
    public void Spawn()
    {
        // Randomly pick the count of prefabs to spawn.
        int count = Random.Range(minimumCount, maximumCount);
        // Spawn them!
        for (int i = 0; i < count; ++i)
        {
            float rangeOfSpawn = Random.Range(- rangeSpread / 2, rangeSpread / 2);
            transform.position = transform.position + new Vector3(rangeOfSpawn, 0, 0);
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
    }*/
    // END OF COIN SPAWN FUNC

    private void Start()
    {
        player = FindObjectOfType<player>();

    }
    void Update()
    {
       /* if(timeBtAttack <= 0)
        {
            if(Input.GetMouseButton(0) && Vector2.Distance(attackPos.position, player.position) <= attackRange)
            {
                
            }
        }*/
    }
}
