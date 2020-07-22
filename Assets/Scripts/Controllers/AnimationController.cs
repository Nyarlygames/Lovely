using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private SpriteRenderer Renderer;
    private int frame = 0;
    private float deltaTime = 0;
    private Sprite[] sprites;

    public bool loop;
    public float frameSeconds = 0.2f;
    public string anim_name = "";

    public void Awake()
    {
    }
    
    void Start()
    {
        Renderer = gameObject.GetComponent<SpriteRenderer>();
        sprites = Resources.LoadAll<Sprite>(anim_name);
        Renderer.sprite = sprites[0];
        gameObject.GetComponent<BoxCollider2D>().size = Renderer.sprite.bounds.size;
    }

    public void Update()
    {
        Animate();
    }

    public void Animate()
    {
        deltaTime += Time.deltaTime;
        while (deltaTime >= frameSeconds)
        {
            deltaTime -= frameSeconds;
            frame++;
            if (loop)
                frame %= sprites.Length;
            else if (frame >= sprites.Length)
                frame = 0;
        }
        Renderer.sprite = sprites[frame];
    }
}
