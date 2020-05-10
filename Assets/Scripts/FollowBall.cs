﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform ballTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ballTransform.position.y > transform.position.y)
        {
            transform.position=new Vector3(transform.position.x,ballTransform.position.y,transform.position.z);
        }
    }
}
