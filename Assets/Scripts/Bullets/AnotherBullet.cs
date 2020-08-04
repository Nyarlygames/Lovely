using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherBullet : Bullet
{
    public AnotherBullet()
    {
        sprite = Resources.Load<Sprite>("gfx/tir2");
        BulletSpeed = 10.0f;
        damage = 5.0f;
    }
}
