using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageControl : MonoBehaviour
{
    public HealthBar healthbar;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Tree")
        {
            if (healthbar)
            {
                healthbar.onTakeDamage(20);
            }
        }
    }
}
