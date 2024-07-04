using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxYSpace : MonoBehaviour
{
    public float parallaxEffectMultiplier = 0.5f;
    public Renderer quad;

    void Start()
    {
        
    }

    void Update()
    {
       Vector2 offset = new Vector2(0, Time.deltaTime * parallaxEffectMultiplier);
         
       quad.material.mainTextureOffset += offset;
    }
}
