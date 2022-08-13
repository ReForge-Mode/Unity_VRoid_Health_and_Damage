using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributeManager : MonoBehaviour, IDamageable
{
    public int health = 100;
    public int attack = 10;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.F11))
        {
            if(gameObject.CompareTag("Player"))
            {
                GameObject.FindGameObjectWithTag("Enemy").GetComponent<AttributeManager>().health -= attack;
            }
        }
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
    }

    public void DealDamage(GameObject target)
    {
        target.GetComponent<AttributeManager>().TakeDamage(attack);
    }
}
