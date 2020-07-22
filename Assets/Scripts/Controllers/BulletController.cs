using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    void OnBecameInvisible()
    {
        Debug.Log("destroy me");
        Destroy(gameObject);
    }
}
