using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class JamesSiti : MonoBehaviour
{
    public Sprite JamesSitiSprite;
    // Start is called before the first frame update
    public SpriteRenderer render;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand("JamesSiti")]
    public void JamesSitiChange() {
        render.sprite = JamesSitiSprite;
    }

    [YarnCommand("HideJamesSiti")]
    public void HideJamesSiti() {
        render.sprite = null;
    }
}
