using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float timeBtfAttack;
    public float startTimeBtfAttack;

    public Transform attackPos;
    public LayerMask enemy;
    public float attackRange;
    public int damage;
    public Animator anim;

    private void Update()
    {
        if (timeBtfAttack <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                anim.SetTrigger("attack");
                timeBtfAttack = startTimeBtfAttack;
            }
        }
        else
        {
            timeBtfAttack -= Time.deltaTime;
        }
    }
    public void OnAttack()
    {
        Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPos.position, attackRange, enemy);
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].GetComponent<Enemy>().GetDamage(damage);
            print("LOL");
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
