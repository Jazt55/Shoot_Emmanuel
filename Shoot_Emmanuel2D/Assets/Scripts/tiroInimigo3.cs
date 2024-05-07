using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class tiroInimigo3 : MonoBehaviour
{
    Rigidbody2D rB;
    public Vector2 speed;
    
    
    public float limite;
    
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rB.velocity = speed;
        
        if (transform.position.y <= -limite)
        {
            Destroy(gameObject);
        }
        
    }
}
