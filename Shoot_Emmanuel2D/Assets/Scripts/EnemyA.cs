using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyA : MonoBehaviour
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
        Movimento();
        Destroy();
    }
    private void Destroy()
    {
        if(transform.position.y <= -limite)
        {
            Destroy(gameObject);
        }
    }
    void Movimento()
    {
        rB.velocity = new Vector2(0, -speed);
    }
}
