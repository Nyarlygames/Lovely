using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{
    public int Damage = 1;
    public GameObject Owner;
    public Vector3 Direction;
    public float BulletSpeed;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
