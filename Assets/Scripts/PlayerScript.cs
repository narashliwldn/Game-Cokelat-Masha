using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Vector3 playerpost;
    public float posX, posY;
    public float speedX = 0.02f;
    public float speedY = 0.02f;
    public Animator farahAnimator;

    void Start(){
        farahAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreScript.Instance.health > 0){
            playerpost = transform.position;
            posX = transform.position.x;
            posY = transform.position.y;

            posX+=speedX;

        if(Input.GetKey(KeyCode.RightArrow)){
            farahAnimator.SetBool("isWalking", true);
            transform.Translate(speedX, 0,0);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            farahAnimator.SetBool("isWalking",true);
            transform.Translate(-speedX,0,0);
        }
        else if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)){
            farahAnimator.SetBool("isWalking",false);
        }
        //semangat

        if(Input.GetKeyDown(KeyCode.UpArrow)){
            farahAnimator.SetTrigger("isJumping");
            // transform.Translate(0, speedY, 0);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,speedY));
        }
        }      
    }
}
