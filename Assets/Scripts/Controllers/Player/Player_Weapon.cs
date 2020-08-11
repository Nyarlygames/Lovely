using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Weapon : MonoBehaviour
{
    public Bullet_Controller Bullet;

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
            Bullet_Controller projectile = Instantiate(Bullet, transform.position, Quaternion.identity);
            projectile.tag = "Player_Bullet";
            projectile.Owner = gameObject;
            projectile.Damage = Damage;
            projectile.Direction = direction;
            projectile.BulletSpeed = BulletSpeed;
            projectile.GetComponent<Rigidbody2D>().velocity = direction * BulletSpeed;
        }
    }


    void Update()
    {
        timer += Time.deltaTime;
    }
}
