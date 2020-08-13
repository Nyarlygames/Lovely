using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    public Player_Controller Player;

    public int max_health = 20;
    public int destroy_damage = 0;
    public int start_health = 15;
    public int health;

    private void Awake()
    {
        health = start_health;
    }
    void Start()
    {
        Player = AssetManager.Instance.Player;
    }
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player_Bullet")
        {
            health -= col.gameObject.GetComponent<Bullet_Controller>().Damage;
            Destroy(col.gameObject);
        }
    }
}
