using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMov : MonoBehaviour {

    public float speed;
    float horizontal;
    public float jumpForce;
    bool grounded;
    Rigidbody2D rigid;
    Animator anim;
    SpriteRenderer sprite;
 
    void Start() {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update() {
        flip();
        Mouvement();
        Jump();
    }

    void flip() {
        if (horizontal > 0) {
            sprite.flipX = false;
        } else if (horizontal < 0) {
            sprite.flipX = true;
        }
    }

    void Mouvement() {

        horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        rigid.velocity = new Vector2(horizontal, rigid.velocity.y);

 
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0 && grounded) {
            anim.SetBool("Running", true);
        } else {
            anim.SetBool("Running", false);
        }
        
    }

    void Jump() {
        if (grounded) {
            if (Input.GetButtonDown("Jump")) {
                rigid.AddForce(new Vector3(0, jumpForce, 0));
                anim.SetTrigger("Jumping");
                grounded = false;
            }
        }
    }

    
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == ("Ground")) {
            grounded = true;
        }
                if (coll.gameObject.tag == ("Player")) {
            grounded = true;
        }
    }
    
      void OnTriggerEnter2D(Collider2D coll) {
        if (coll.gameObject.tag == ("Death")) {
            //gameOverSprite.SetActive(true);
            Destroy(gameObject);
        }
        if (coll.gameObject.tag == ("Key")) {
            Destroy(coll.gameObject);
        }
         if (coll.gameObject.tag == ("CleLVL2")) {
            Destroy(coll.gameObject);
        }
        if (coll.gameObject.tag == ("EndGame")) {
            coll.gameObject.GetComponent<Menu>().SwitchScene();
        }
    }
}
 