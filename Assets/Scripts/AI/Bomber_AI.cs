using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber_AI : MonoBehaviour
{
    public Enemy_Controller Enemy;

    void Start()
    {
        
    }
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Enemy.Player.transform.position, Enemy.speed * Time.deltaTime);
    }
}
