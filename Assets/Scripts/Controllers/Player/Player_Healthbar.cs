using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Healthbar : MonoBehaviour
{
    private GameObject Healthbar;
    public GameObject Healthbar_Prefab;
    private Vector3 pos;
    private Vector3 offset = new Vector3(0.0f, -50.0f, 0.0f);
    private GameObject Canvas;
    public Player_Controller PlayerController;
    private Slider SliderComponent;

    void Awake()
    {
    }

    void Start()
    {
        Canvas = GameObject.FindGameObjectWithTag("Canvas");
        Healthbar = Instantiate(Healthbar_Prefab, gameObject.transform.position, Quaternion.identity) as GameObject;
        Healthbar.transform.SetParent(Canvas.transform);
        pos = Camera.main.WorldToScreenPoint(PlayerController.transform.position);
        pos = pos - offset;
        Healthbar.transform.position = pos;
        SliderComponent = Healthbar.GetComponent<Slider>();
        SliderComponent.maxValue = PlayerController.max_health;
        SliderComponent.value = PlayerController.health;
    }

    void Update()
    {
        pos = Camera.main.WorldToScreenPoint(PlayerController.transform.position);
        pos = pos - offset;
        Healthbar.transform.position = pos;
        SliderComponent.value = PlayerController.health;
        if (SliderComponent.value == 0)
        {
            // gameover or new life ?
        }

    }

    void OnDestroy()
    {
        Destroy(Healthbar);
    }
}
