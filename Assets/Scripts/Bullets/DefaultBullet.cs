using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultBullet : Bullet
{
    public DefaultBullet()
    {
        BulletSpeed = 5.0f;
        sprite = Resources.Load<Sprite>("gfx/tir");
    }
}
