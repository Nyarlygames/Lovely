using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{

    public Bullet MainBullet;
    public Bullet AlternateBullet;
    public float Fire_Rate = 1.0f;
    public float Alternate_Fire_Rate = 2.0f;
    public Sprite sprite;
    public int damage = 1;

    public Weapon()
    {

    }

    ~Weapon()
    {

    }
}
