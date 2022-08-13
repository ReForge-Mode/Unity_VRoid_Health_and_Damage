using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public AttributesManager playerAtm;
    public AttributesManager enemyAtm;
    public int damage;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F11))
        {
            playerAtm.TakeDamage(damage);
        }

        if(Input.GetKeyDown(KeyCode.F12))
        {
            enemyAtm.TakeDamage(damage);
        }
    }
}
