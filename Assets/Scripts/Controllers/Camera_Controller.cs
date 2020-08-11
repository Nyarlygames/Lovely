using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{

    public Player_Controller Player;
    public Vector3 Offset;

    void Start()
    {
        Offset = new Vector3(0.0f, 0.0f, -10.0f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.gameObject.transform.position + Offset;
    }
}
