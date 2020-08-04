using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberBullet : Bullet
{
    public BomberBullet()
    {
        BulletSpeed = 1.0f;
        damage = 5.0f;
        sprite = Resources.Load<Sprite>("gfx/tir2");
    }
}
