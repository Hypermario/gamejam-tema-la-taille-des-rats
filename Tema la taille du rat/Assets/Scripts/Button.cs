using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    SpriteRenderer sprite;
    public GameObject door;
    public bool pressed;
    

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pressed){
            door.GetComponent<Animator>().SetTrigger("Opening");
        } else if (pressed = false ){
            door.GetComponent<Animator>().SetTrigger("Closing");
        }  
    }

     void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == ("Player")) {
            pressed = true;
              sprite.color = Color.blue;
        }
    }
}
