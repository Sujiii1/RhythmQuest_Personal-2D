using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_double : MonoBehaviour
{
    public int Health;
    public int maxHealth = 5;
    public float delayTime = 0.15f;

    public Movement2D movement2D;
    public EnemyControll enemyControll;

    private void Start()
    {
        Health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        StartCoroutine(KnockbackDelay());
    }


    IEnumerator KnockbackDelay()
    {
        movement2D.enabled = false;
        yield return new WaitForSeconds(delayTime);
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            movement2D.enabled = true;
        }
    }


}
