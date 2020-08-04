using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject Initiator;
    public Weapon weapon;

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
