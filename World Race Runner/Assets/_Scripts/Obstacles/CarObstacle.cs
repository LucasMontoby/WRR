using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarObstacle : EntityObstacle
{

    void Start()
    {
        //transform.rotation = Quaternion.LookRotation(-Vector3.forward, Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
    }
}
