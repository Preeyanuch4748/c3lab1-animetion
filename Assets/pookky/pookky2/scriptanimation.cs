using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptanimation : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    CharacterController characterController;
    void Start() //Start ทำแค่ครั้งเดียวเท่านั้น
    {
        anim = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        anim.SetBool("is defult", false);
        anim.SetBool("is walking", false);
        anim.SetBool("is dancing", false);
        // anim.SetBool("is walking", true);
    }

    // Update is called once per frame
    void Update() //Update จะทำต่อไปเลื่อยๆ

    {
        
//เขียนขึ้นเอง
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("is walking", true);
            anim.SetBool("is defult", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("is defult", true);
            anim.SetBool("is walking", false);
            anim.SetBool("is dancing", true);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("is dancing", true);
            anim.SetBool("is defult", true);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            anim.SetBool("is dancing", false);
            anim.SetBool("is defult", true);
        }
        else if (Input.GetKey(KeyCode.F))
        {
            anim.SetBool("is dancing", true);
            anim.SetBool("is walking", true);
            anim.SetBool("is defult", true);
        }
        else if (Input.GetKey(KeyCode.G))
        {
            anim.SetBool("is dancing", false);
            anim.SetBool("is walking", true);
        }


    }
}
// 