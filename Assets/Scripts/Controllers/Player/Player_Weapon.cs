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
            GameObject projectile = Instantiate(Bullet, transform.position, Quaternion.identity) as GameObject;
            projectile.tag = "Player_Bullet";
            projectile.GetComponent<Bullet_Controller>().Owner = gameObject;

            Vector2 direction = target - transform.position;
            direction.Normalize();
            projectile.GetComponent<Rigidbody2D>().velocity = direction * BulletSpeed;
        }
    }


    void Update()
    {
        timer += Time.deltaTime;
    }
}
