using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public Enemy EnemyType;
    public WeaponController Weapon;
    public AnimationController Anim;
    public PlayerController Player;
    public Enemy_Behaviour AI;
    private HealthbarController HealthController;

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        HealthController = gameObject.AddComponent<HealthbarController>();
        HealthController.AttachedObject = gameObject;
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

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            AI.OnCollisionEnterPlayer(Player, this);
        }
    }
}
