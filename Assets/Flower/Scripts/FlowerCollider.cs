using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerCollider : MonoBehaviour
{

    public bool isCollider;
    float timer;
    bool startTimer;

    //private void Update()
    //{
    //    if (startTimer)
    //    {
    //        timer += Time.deltaTime;
    //        if (timer > 10)
    //        {
    //            startTimer = false;
    //            isCollider = false;
    //            timer = 0;
    //        }
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        isCollider = true;
        print("碰到了");
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    isCollider = true;
    //    print("碰到了");
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    startTimer = true;
    //    timer = 0;
    //    print("离开了");

    //}
}
