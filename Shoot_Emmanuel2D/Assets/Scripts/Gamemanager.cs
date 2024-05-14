using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{

    public TextMeshProUGUI pontuacaotxt;
    public int pontuacao;


    public float contador = 2;
    float scan = 0;
    public GameObject enemy;
    public float contador2 = 2;
    float scan2 = 0;
    public GameObject enemy2;
    public float contador3 = 2;
    float scan3 = 0;
    public GameObject enemy3;

    public bool isGameOver;
    public GameObject GameOverSc;

    // Start is called before the first frame update
    void Start()
    {
        pontuacao = 0;
        pontuacaotxt.text = "0";
        scan += 2;
        scan2 += 4;
        scan3 += 7;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= scan)
        {
            contador = Random.Range(1, 3);
            scan = contador + Time.time;
            ger1();
        }
        if (Time.time >= scan2)
        {
            contador2 = Random.Range(2, 5);
            scan2 = contador2 + Time.time;
            ger2();
        }
        if (Time.time >= scan3)
        {
            contador3 = Random.Range(6, 8);
            scan3 = contador3 + Time.time;
            ger3();
        }
        pont();
        GO();
    }

    void ger1()
    {
        Instantiate(enemy, new Vector3(Random.Range(-2.3f,2.4f),5.3f,0),Quaternion.identity);
    }
    void ger2()
    {
        Instantiate(enemy2, new Vector3(Random.Range(-2.3f, 2.4f), 5.3f, 0), Quaternion.identity);
    }
    void ger3()
    {
        Instantiate(enemy3, new Vector3(Random.Range(-2.3f, 2.4f), 5.3f, 0), Quaternion.identity);
    }
    void pont()
    {
        pontuacaotxt.text = pontuacao.ToString();
    }
    void GO()
    {
        if (isGameOver == true)
        {
            GameOverSc.SetActive(true);
        }

    }
}
