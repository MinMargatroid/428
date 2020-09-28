using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovingObstacle : MonoBehaviour
{
    public float speed;

    int num = 1;

    void Update () {  
        if (transform.position.x<530)
        {
            num = 1;      
        }
        if (transform.position.x>560)
        {
            num = -1;   
        }
        transform.Translate(Vector3.right * Time.deltaTime * num * speed);
    }
}
