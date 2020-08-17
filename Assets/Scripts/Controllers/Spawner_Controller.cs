using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Controller : MonoBehaviour
{
    public int spawnRate = 0;
    public int spawnLimit = 0;
    public Enemy_Controller spawnType;
    private float timer = 0.0f;
    private List<Enemy_Controller> spawns = new List<Enemy_Controller>();

    void Start()
    {
        
    }
    
    void Update()
    {
        timer += Time.deltaTime;
        if ((timer > spawnRate) && (spawns.Count < spawnLimit))
        {
            timer = 0.0f;
            Enemy_Controller spawn = Instantiate(spawnType, transform.position, Quaternion.identity);
            spawn.Spawner = this;
            spawns.Add(spawn);
        }
    }
}
