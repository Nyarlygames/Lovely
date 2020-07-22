using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public Weapon weap;
    private GameObject BulletPrefab;

    void Awake()
    {
        BulletPrefab = Resources.Load<GameObject>("prefabs/Bullet");
        weap = new DefaultWeapon();
    }

    void Start()
    {

    }

    public void FireWeapon(int mode, Vector3 target)
    {
        Bullet bullet;
        if (mode == 0)
            bullet = weap.MainBullet;
        else
            bullet = weap.AlternateBullet;

        GameObject projectile = Instantiate(BulletPrefab, transform.position, Quaternion.identity) as GameObject;
        projectile.GetComponent<SpriteRenderer>().sprite = bullet.sprite;

        Vector2 direction = target - transform.position;
        direction.Normalize();
        projectile.GetComponent<Rigidbody2D>().velocity = direction * bullet.BulletSpeed;
    }
    
    
    void Update()
    {
        
    }
}
