using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePopupManager : MonoBehaviour
{
    //Singleton setup
    public static DamagePopupManager current;

    [SerializeField] private GameObject pfPopUp;

    private GameObject player;
    private GameObject enemy;

    private void Awake()
    {
        current = this;


        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            CreatePopup(player.transform.position + Vector3.up);
        }

        if (Input.GetKeyDown(KeyCode.F12))
        {
            CreatePopup(enemy.transform.position + Vector3.up);
        }
    }

    public void CreatePopup(Vector3 position)
    {
        Instantiate(pfPopUp, position, Quaternion.identity);
    }
}
