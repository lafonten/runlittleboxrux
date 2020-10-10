using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class blockMoveControler : MonoBehaviour
{
    public float speed;
    
    
    void Start()
    {
        Destroy(gameObject, 7f);
    }

    
    void FixedUpdate()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
