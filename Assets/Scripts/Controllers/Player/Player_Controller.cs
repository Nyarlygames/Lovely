using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour
{
    private Input_Controller InputController;
    public Player_Weapon WeaponController;
    public int max_health = 100;
    public int start_health = 100;
    public int health;

    void Awake()
    {
        health = start_health;
    }

    void Start()
    {
    }


    void Update()
    {
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy_Bullet")
        {
            health -= col.gameObject.GetComponent<Bullet_Controller>().Damage;
            Destroy(col.gameObject);
        }
    }
}
