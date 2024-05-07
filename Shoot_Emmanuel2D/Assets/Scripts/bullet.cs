using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D rB;
    public float speed;
    public float limite;
    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rB.velocity = new Vector2(0, speed);

        if (transform.position.y >= limite)
        {
            Destroy(gameObject);
        }
    }
}
