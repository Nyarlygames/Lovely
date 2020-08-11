using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot_Controller : MonoBehaviour
{
    public string mode = "";
    public int Damage = 0;
    public float BulletSpeed = 0.0f;
    public float FireRate = 0.0f;
    public Bullet_Controller Bullet;
    public int health = 0;
    public int weapon_mode = 0;

    public void Apply_Loot(Player_Controller pc)
    {
        pc.health += health;
        pc.WeaponController.Damage += Damage;
        pc.WeaponController.BulletSpeed += BulletSpeed;
        if (Bullet != null)
            pc.WeaponController.Bullet = Bullet;
        if (mode != "")
            pc.WeaponController.mode = mode;

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Apply_Loot(col.gameObject.GetComponent<Player_Controller>());
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        //Destroy(Healthbar);
    }
}
