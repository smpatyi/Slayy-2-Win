using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlugManager : MonoBehaviour
{


    private SpriteRenderer theSR;
    public Sprite defaultSlug;
    public Sprite leftSlug;
    public Sprite rightSlug;
    public Sprite upSlug;
    public Sprite downSlug;

    // public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start()
    {  
        theSR = GetComponent<SpriteRenderer>();
        theSR.sprite = defaultSlug;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("up")) {
            theSR.sprite = upSlug;
        } else if (Input.GetKeyDown("down")) {
            theSR.sprite = downSlug;
        } else if (Input.GetKeyDown("right")) {
            theSR.sprite = rightSlug;
        } else if (Input.GetKeyDown("left")) {
            theSR.sprite = leftSlug;
        }
        
    }
}
