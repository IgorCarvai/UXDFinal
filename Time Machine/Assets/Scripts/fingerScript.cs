using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fingerScript : MonoBehaviour {
    public Transform from;
    public Transform to;
    public Canvas cv;
    float speed = .2F;
    bool step = true;
    bool step1 = false;
    bool step2 = false;
    bool step3 = false;
    bool step4 = false;
    bool step5 = false;
    bool step6 = false;
    float startTime;
    float duration = 3f;
    Vector3 ogPos = new Vector3(-320f, -75f, 0f);
    Vector3 goalPos = new Vector3(-210f, -75f, 0f);

    void Start()
    {
        startTime = Time.time;
    }
    void Update()
    {
        //This is done for the initial animation

        //make the camera move in
        if (step)
        {
            cv.scaleFactor = Mathf.SmoothStep(.3f, 1f, (Time.time - startTime) / duration);
            if (cv.scaleFactor == 1)
            {
                step = false;
                step1 = true;
            }
        }
        //make the finger rotate towards the screen
        if (step1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, to.rotation, speed);
            if(transform.rotation == to.rotation)
            {
                step1 = false;
                step2 = true;
            }
        }
        //rotate it back 
        if (step2)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, from.rotation, speed);
            if (transform.rotation == from.rotation)
            {
                step2 = false;
                step3 = true;
            }
        }
        //rotate it in
        if (step3)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, to.rotation, speed);
            if (transform.rotation == to.rotation)
            {
                step3 = false;
                step4 = true;
            }
        }
        //move it to the right and retset it
        if (step4)
        {
            transform.localPosition = Vector3.Slerp(transform.localPosition, goalPos, speed*.5f);
            if (Math.Abs(transform.localPosition.x - goalPos.x) <.02f)
            {
                transform.localPosition = ogPos;
                transform.eulerAngles = new Vector3(0,0,0);
                step4 = false;
                step1 = true;
            }
        }
        //destroy this if the user has pressed a button.
        if (Input.GetMouseButtonUp(0))
        {
            Destroy(this.gameObject);
        }


    }
    
}
