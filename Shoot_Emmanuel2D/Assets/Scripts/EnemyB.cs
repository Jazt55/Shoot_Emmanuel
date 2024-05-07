using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyB : MonoBehaviour
{
    Rigidbody2D rB;
    public float speed;
    public float limite;

    public GameObject bullet;
    Vector3 posicaoBala;

    public float contador = 2;
    float scan = 2;

    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody2D>();
        speed = Random.Range(2, 7);
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
        Destroy();

        if(Time.time >= scan)
        {
            scan = contador + Time.time;
            tiro();
        }
    }
    private void Destroy()
    {
        if (transform.position.y <= -limite)
        {
            Destroy(gameObject);
        }
    }
    void Movimento()
    {
        rB.velocity = new Vector2(0, -speed);
    }
    void tiro()
    {
        posicaoBala = transform.position + new Vector3(0, -1, 0);
        Instantiate(bullet, posicaoBala, Quaternion.identity);
    }
}
