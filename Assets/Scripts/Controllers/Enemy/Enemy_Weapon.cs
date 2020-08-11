using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Weapon : MonoBehaviour
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
            projectile.tag = tag;
            projectile.GetComponent<Bullet_Controller>().Owner = gameObject;

            Vector2 direction = target - transform.position;
            direction.Normalize();
            projectile.GetComponent<Rigidbody2D>().velocity = direction * BulletSpeed;
        }
    }


    void Update()
    {
        timer += Time.deltaTime;
       // FireWeapon(gameObject.GetComponent<Enemy_Controller>().Player.transform.position);
    }
    /*  private GameObject BulletPrefab;
      private GameObject Initiator;

      private float timerDefault = 0.0f;
      private float timerAlternate = 0.0f;

      void Awake()
      {
          BulletPrefab = Resources.Load<GameObject>("prefabs/Bullet");
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
      }*/
}
