using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Enemy EnemyType;
    public WeaponController Weapon;
    public AnimationController Anim;
    public GameObject Player;

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Start()
    {
        Weapon = gameObject.AddComponent<WeaponController>();
        Weapon.weap = EnemyType.weapon;
        Anim = gameObject.AddComponent<AnimationController>();
        Anim.anim_name = EnemyType.sprite;
    }
    
    void Update()
    {
      //  Weapon.FireWeapon(1, Player.transform.position);
    }
}
