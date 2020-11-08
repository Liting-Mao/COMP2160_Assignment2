using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public float health;
    public float startHealth;
    public GameObject deadEffect;

    public void onTakeDamage(int damage)
    {
        health = health - damage;
        healthBar.fillAmount = health / startHealth;
        if (health <= 0)
        {
            BurstAction();
        }
    }

    public void restoreHealth(int heal)
    {
        health = health + heal;
        healthBar.fillAmount = health / startHealth;
    }

    private void BurstAction()
    {
        //print("ok"); test
        GameObject CarExplosion = Instantiate(deadEffect, transform.position, Quaternion.identity);
    }
}
