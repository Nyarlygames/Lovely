using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Enemy EnemyType;
    public WeaponController Weapon;
    public AnimationController Anim;
    public PlayerController Player;
    public Enemy_Behaviour AI;

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Start()
    {
        Weapon = gameObject.AddComponent<WeaponController>();
        Weapon.weap = EnemyType.weapon;
        Anim = gameObject.AddComponent<AnimationController>();
        Anim.anim_name = EnemyType.sprite;
        AI = EnemyType.behaviour;
    }
    
    void Update()
    {
        AI.Update(Player, this);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("collided");
        Debug.Log(col.collider.tag);
        if (col.collider.tag == "Player")
        {
            AI.OnCollisionEnterPlayer(Player, this);
        }
    }
}
