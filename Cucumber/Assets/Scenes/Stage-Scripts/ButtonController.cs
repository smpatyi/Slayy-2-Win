using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // visual feedback to the player
    private SpriteRenderer spriteRenderer;

    public Sprite defaultImage;
    public Sprite pressedImage;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = getComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
