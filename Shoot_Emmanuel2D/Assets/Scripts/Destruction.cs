using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{

    public string Tag;
    Gamemanager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("Gamemanager").GetComponent<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == Tag)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            gm.pontuacao++; 
        }
        
    }
}
