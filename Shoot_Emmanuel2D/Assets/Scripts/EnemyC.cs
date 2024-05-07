using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyC : MonoBehaviour
{
    Rigidbody2D rB;
    public float speed;
    public float bulletSpeed;
    public float limite;

    public GameObject[] bullet;
    public GameObject[] bala;

    public float contador = 2;
    float scan = 2;
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

        if (Time.time >= scan)
        {
            scan = contador + Time.time;
            tiro();
        }
    }
    void Movimento()
    {
        rB.velocity = new Vector2(0, -speed);
    }
    void tiro()
    {
        Instantiate(bullet[0], bala[0].transform.position, transform.rotation);
        bullet[0].GetComponent<tiroInimigo3>().speed = new Vector2(1 * bulletSpeed, 1 * bulletSpeed);
        Instantiate(bullet[1], bala[1].transform.position, transform.rotation);
        bullet[1].GetComponent<tiroInimigo3>().speed = new Vector2(-1 * bulletSpeed, 1 * bulletSpeed);
        Instantiate(bullet[2], bala[2].transform.position, transform.rotation);
        bullet[2].GetComponent<tiroInimigo3>().speed = new Vector2(0 * bulletSpeed, 1 * bulletSpeed);
    }
    void Destroy()
    {
        if (transform.position.y <= -limite)
        {
            Destroy(gameObject);
        }
    }
}
