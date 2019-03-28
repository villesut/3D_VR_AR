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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.CrossFade("Jump", 0.1f);
            //anim.SetBool("isIdle", false);
        }

        if (Input.GetKeyDown(KeyCode.W)){
            anim.CrossFade("WalkingCycle", 0.1f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
        }
        
        else
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isIdle", true);
        }
    }
}
