using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;

    public GameObject downVictory;
    public GameObject leftVictory;
    public GameObject rightVictory;
    public GameObject upVictory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress)) {
            if(canBePressed) {
                gameObject.SetActive(false);
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Activator") {
            canBePressed = true;
            // if(Input.GetKeyDown(keyToPress.DownArrow)){
            //     downVictory.SetActive(true);
            // } else if(Input.GetKeyDown(keyToPress.UpArrow)){
            //     upVictory.SetActive(true);
            // } else if(Input.GetKeyDown(keyToPress.LeftArrow)){
            //     leftVictory.SetActive(true);
            // } else if(Input.GetKeyDown(keyToPress.RightArrow)){
            //     rightVictory.SetActive(true);
            // }
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Activator") {
            canBePressed = false;
            // if(Input.GetKeyUp(keyToPress.DownArrow)){
            //     downVictory.SetActive(false);
            // } else if(Input.GetKeyUp(keyToPress.UpArrow)){
            //     upVictory.SetActive(false);
            // } else if(Input.GetKeyUp(keyToPress.LeftArrow)){
            //     leftVictory.SetActive(false);
            // } else if(Input.GetKeyUp(keyToPress.RightArrow)){
            //     rightVictory.SetActive(false);
            // }
        }
    }
}
