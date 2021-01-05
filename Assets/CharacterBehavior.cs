using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehavior : MonoBehaviour
{
    public Rigidbody2D rb;
    public float vitesse;
    public float maxjump;
    private bool isGrounded=false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity += new Vector2 (vitesse,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && isGrounded){
            jump();
        }
    }
    void jump(){
            rb.velocity += new Vector2 (0,maxjump);
    }
   void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("Ground")){
            isGrounded=true;
        }

    }
    void OnCollisionExit2D(Collision2D col){
         if(col.gameObject.CompareTag("Ground")){
            isGrounded=false;
        }

    }
}
