using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleControl : MonoBehaviour
{
    public bool changeTurn;
    public float spinRate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (changeTurn)
        {
            transform.Rotate(0f,0f,-spinRate*Time.deltaTime);
        } else{
            transform.Rotate(0f,0f,spinRate*Time.deltaTime);
        }
        
    }
}
