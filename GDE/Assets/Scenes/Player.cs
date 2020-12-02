using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    private Animator anim;
    public float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var v = Input.GetAxis("Vertical");
        anim.SetFloat("speed",v);
        if(Input.GetKey(KeyCode.A))
            anim.SetFloat("turn",Math.Min(anim.GetFloat("turn")+0.05f,0.5f));
        else if(Input.GetKey(KeyCode.D))
            anim.SetFloat("turn",Math.Max(anim.GetFloat("turn")-0.05f,-0.5f));
        else{
            if(anim.GetFloat("turn") > 0.0f){
                anim.SetFloat("turn",Math.Max(anim.GetFloat("turn") - 0.05f,0.0f));
            }
            else if(anim.GetFloat("turn") < 0.0f){
                anim.SetFloat("turn",Math.Min(anim.GetFloat("turn") + 0.05f,0.0f));
            }
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            anim.SetBool("Jump",true);
        }
        else
            anim.SetBool("Jump",false);
    }
}
