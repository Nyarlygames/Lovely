using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthbarController : MonoBehaviour
{
    private GameObject Healthbar;
    private GameObject Healthbar_Prefab;
    private Vector3 pos;
    private Vector3 offset = new Vector3(0.0f, -50.0f, 0.0f);
    private GameObject Canvas;
    public GameObject AttachedObject;

    void Awake()
    {
        Healthbar_Prefab = Resources.Load<GameObject>("prefabs/HealthBar");
    }

    void Start()
    {
        Canvas = GameObject.FindGameObjectWithTag("Canvas");
        Healthbar = Instantiate(Healthbar_Prefab, gameObject.transform.position, Quaternion.identity) as GameObject;
        Healthbar.transform.SetParent(Canvas.transform);
        pos = Camera.main.WorldToScreenPoint(AttachedObject.transform.position);
        pos = pos - offset;
        Healthbar.transform.position = pos;
    }
    
    void Update()
    {
        
    }

    void OnDestroy()
    {
        Destroy(Healthbar);
    }
}
