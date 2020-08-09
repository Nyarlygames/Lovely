using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Weapon : MonoBehaviour
{
    public GameObject Bullet;

    private float timer = 0.0f;
    public string mode = "default";
    public float FireRate = 1.0f;
    public float BulletSpeed = 1.0f;
    public int Damage = 1;

    void Awake()
    {
    }

    void Start()
    {

    }

    public void FireWeapon(Vector3 target)
    {
        if (timer >= FireRate)
        {
            timer = 0.0f;
            Vector2 direction = target - transform.position;
            direction.Normalize();
            GameObject projectile = Instantiate(Bullet, transform.position, Quaternion.identity) as GameObject;
            projectile.tag = "Player_Bullet";
            var bc = projectile.GetComponent<Bullet_Controller>();
            bc.Owner = gameObject;
            bc.Damage = Damage;
            bc.Direction = direction;
            bc.BulletSpeed = BulletSpeed;
            projectile.GetComponent<Rigidbody2D>().velocity = direction * BulletSpeed;
        }
    }


    void Update()
    {
        timer += Time.deltaTime;
    }
}
