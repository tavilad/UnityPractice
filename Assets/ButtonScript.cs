﻿using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    public bool isPressedLeft;
    public bool isPressedRight;

    public GameObject obj;

    public void Update()
    {
        if (isPressedLeft)
        {
            Movement.MoveLeft(obj, 10f);
        }

        if(isPressedRight)
        {
            Movement.MoveRight(obj, 10f);
        }
    }

  
    

    public void flip(GameObject obj)
    {
        GameObjectUtil.flip(obj.transform);
    }

    public void jump(Rigidbody rb)
    {
        Movement.Jump(rb);
    }

    public void onPointerDown(GameObject obj)
    {
        if(obj.transform.tag=="Left")
        {
            isPressedLeft = true;
        }
        
        if(obj.transform.tag=="Right")
        {
            isPressedRight = true;
        }
        

    }
    public void onPointerUp(GameObject obj)
    {
        if (obj.transform.tag == "Left")
        {
            isPressedLeft = false;
        }

        if(obj.transform.tag=="Right")
        {
            isPressedRight = false;
        }


    }
}