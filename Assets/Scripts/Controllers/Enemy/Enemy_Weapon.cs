using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Weapon : MonoBehaviour
{
    public Weapon weap;
    private GameObject BulletPrefab;
    private GameObject Initiator;

    private float timerDefault = 0.0f;
    private float timerAlternate = 0.0f;

    void Awake()
    {
        BulletPrefab = Resources.Load<GameObject>("prefabs/Bullet");
        weap = new DefaultWeapon();
    }

    void Start()
    {

    }

    public void FireWeapon(int mode, Vector3 target, string tag, GameObject initiator)
    {
        Initiator = initiator;
        Bullet bullet;
        bool canFire = false;

        if (mode == 0)
        {
            bullet = weap.MainBullet;
            if (timerDefault >= weap.Fire_Rate)
            {
                canFire = true;
                timerDefault = 0.0f;
            }
        }
        else
        {
            bullet = weap.AlternateBullet;
            if (timerAlternate >= weap.Alternate_Fire_Rate)
            {
                canFire = true;
                timerAlternate = 0.0f;
            }
        }

        if (canFire)
        {
            GameObject projectile = Instantiate(BulletPrefab, transform.position, Quaternion.identity) as GameObject;
            projectile.tag = tag;
            projectile.GetComponent<BulletController>().weapon = weap;
            projectile.GetComponent<BulletController>().Initiator = initiator;
            projectile.GetComponent<SpriteRenderer>().sprite = bullet.sprite;

            Vector2 direction = target - transform.position;
            direction.Normalize();
            projectile.GetComponent<Rigidbody2D>().velocity = direction * bullet.BulletSpeed;
        }
    }


    void Update()
    {
        timerDefault += Time.deltaTime;
        timerAlternate += Time.deltaTime;
    }
}
