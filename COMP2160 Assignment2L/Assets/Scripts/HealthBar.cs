using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    public float health;
    public float startHealth;

    public void onTakeDamage(int damage)
    {
        health = health - damage;
        healthBar.fillAmount = health / startHealth;
    }

    public void restoreHealth(int heal)
    {
        health = health + heal;
        healthBar.fillAmount = health / startHealth;
    }
}
