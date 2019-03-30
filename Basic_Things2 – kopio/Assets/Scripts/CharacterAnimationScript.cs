using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationScript : MonoBehaviour

    
{

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAnimations();
    }


    void UpdateAnimations()
    {

        //Forward
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.CrossFade("WalkingCycle", 0.1f);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isLeft", false);
            anim.SetBool("isRight", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isBack", false);
            anim.SetBool("isJump", false);
        }
        //Left
        else if (Input.GetKeyDown(KeyCode.A))
        {
            anim.CrossFade("WalkingLeft", 0.1f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isLeft", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isRight", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isBack", false);
            anim.SetBool("isJump", false);
        }
        //Right
        else if (Input.GetKeyDown(KeyCode.D))
        {
            anim.CrossFade("WalkingRight", 0.1f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isRight", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isLeft", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isBack", false);
            anim.SetBool("isJump", false);
        }
        //Backward
        else if (Input.GetKeyDown(KeyCode.S))
        {
            anim.CrossFade("WalkingBack", 0.1f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isBack", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isLeft", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isRight", false);
            anim.SetBool("isJump", false);
            anim.SetBool("isDab", false);
        }
        //Jump
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.CrossFade("Jump", 0.1f);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("isJump", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isLeft", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isRight", false);
            anim.SetBool("isBack", false);
            anim.SetBool("isDab", false);
        }
        //Dab
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            anim.CrossFade("Dab", 0.1f);
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            anim.SetBool("isDab", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isLeft", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isRight", false);
            anim.SetBool("isBack", false);
            anim.SetBool("isJump", false);
        }
        //OrIdle
        else
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isRight", false);
            anim.SetBool("isLeft", false);
            anim.SetBool("isBack", false);
            anim.SetBool("isIdle", true);
            anim.SetBool("isJump", false);
            anim.SetBool("isDab", false);
        }
    }
}
