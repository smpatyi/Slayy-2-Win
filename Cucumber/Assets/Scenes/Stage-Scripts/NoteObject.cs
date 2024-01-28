using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;

    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite successImage;

    // public float timer;

    // public float beatTempo;

    // public bool isMoving = false;

    // Start is called before the first frame update
    void Start()
    {
        // beatTempo = beatTempo / 60f;

        theSR = GetComponent<SpriteRenderer>();
        theSR.sprite = defaultImage;

        // if(!isMoving) {
        //     isMoving = true;
        // }
    }

    // Update is called once per frame
    void Update()
    {
        // if(isMoving) {
        //     transform.position += new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        // }

        if(Input.GetKeyDown(keyToPress)) {
            if(canBePressed) {
                // for (int i = 0; i < timer; i++ ) {
                //     if (timer > 0) {
                //         theSR.sprite = successImage;
                //     }
                //     timer --;
                // }
                
                // if (timer <= 0) {
                //     gameObject.SetActive(false);
                // }

                // OnTriggerStay2D();

                theSR.sprite = successImage;

                GameManager.instance.NoteHit();
                
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Activator") {
            canBePressed = true;
            
        }
    }

    // private void OnTriggerStay2D(Collider2D other) {
    //     for (int i = 0; i < timer; i++ ) {
    //         if (timer > 0) {
    //             theSR.sprite = successImage;
    //         }
    //         timer --;
    //     }
        
    //     if (timer <= 0) {
    //         gameObject.SetActive(false);
    //     }

    //     isMoving = false;
                
    // }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Activator") {
            canBePressed = false;
            // isMoving = false;
            
            GameManager.instance.NoteMissed();
        }
    }
}
