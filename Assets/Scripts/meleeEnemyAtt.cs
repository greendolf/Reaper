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
