using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public Enemy EnemyType;
    public Weapon_Controller Weapon;
    public AnimationController Anim;
    public Player_Controller Player;
    public Enemy_Behaviour AI;
    private HealthbarController HealthController;

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Controller>();
        HealthController = gameObject.AddComponent<HealthbarController>();
      //  HealthController.AttachedObject = gameObject;
    }

    void Start()
    {
        Weapon = gameObject.AddComponent<Weapon_Controller>();
        Weapon.weap = EnemyType.weapon;
        Anim = gameObject.AddComponent<AnimationController>();
        Anim.anim_name = EnemyType.sprite;
        AI = EnemyType.behaviour;
    }

    public void Fire(Vector3 position, int mode)
    {
        if (position == Vector3.zero)
            position = Player.transform.position;
        Weapon.FireWeapon(mode, position, "Enemy_Bullet", this.gameObject);
    }
    
    void Update()
    {
        AI.Update(Player, this);
        HealthController.SliderComponent.value = EnemyType.health;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            AI.OnCollisionEnterPlayer(Player, this);
        }

        if (col.tag == "Player_Bullet")
        {
            EnemyType.health -= col.gameObject.GetComponent<BulletController>().weapon.damage;
            Destroy(col.gameObject);
        }
    }
}
