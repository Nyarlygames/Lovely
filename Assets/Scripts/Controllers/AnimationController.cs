using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public SpriteRenderer Renderer;
    private Sprite[] sprites;
    private int frame = 0;
    private float deltaTime = 0;
    public bool loop;
    public float frameSeconds = 0.2f;
    bool init = false;

    public void Init(SpriteRenderer Sr, string anim_name)
    {
        Renderer = Sr;
        sprites = Resources.LoadAll<Sprite>(anim_name);
        init = true;
    }
    
    void Start()
    {
        
    }
    
   public void Update()
    {
        if (init == true)
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
