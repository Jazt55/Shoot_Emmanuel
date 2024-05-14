using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMov : MonoBehaviour
{
    
    Rigidbody2D rB;
    public float speed;
    public GameObject bullet;
    Vector3 posicaoBala;

    Gamemanager gm;

    public float contador = 2;
    float scan = 0;

    AudioSource audioPlayer;
    public AudioClip somMorte;
    public AudioClip somTiro;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("Gamemanager").GetComponent<Gamemanager>();
        rB = GetComponent<Rigidbody2D>();
        audioPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Jump") && Time.time >= scan)
        {
            scan = contador + Time.time;
            tiro();
            
        }

        movimento();

        limite();


    }
    void movimento()
    {
        rB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;
    }
    void limite()
    {
        if (transform.position.y <= -4.72f)
        {
            transform.position = new Vector2(transform.position.x, -4.72f);
        }
        if (transform.position.y >= 4.71f)
        {
            transform.position = new Vector2(transform.position.x, 4.71f);
        }
        if (transform.position.x <= -2.57)
        {
            transform.position = new Vector2(-2.57f,transform.position.y);
        }
        if (transform.position.x >= 2.58)
        {
            transform.position = new Vector2(2.58f, transform.position.y);
        }

        
    }

   

    void tiro()
    {
        posicaoBala = transform.position + new Vector3(0, 1, 0);
        Instantiate(bullet, posicaoBala , Quaternion.identity);
        audioPlayer.PlayOneShot(somTiro);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            gm.isGameOver = true;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            audioPlayer.PlayOneShot(somMorte);
            gm.pontuacao++;
           
        }

    }
}
