using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroun : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.position = new Vector2(transform.position.x,transform.position.y - speed * Time.deltaTime) ;   

        if (transform.position.y <= -4.5f)
        {
            transform.position = new Vector2(transform.position.x, 0); 
        }
    }
}
