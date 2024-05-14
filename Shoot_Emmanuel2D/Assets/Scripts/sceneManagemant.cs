using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManagemant : MonoBehaviour
{

    
    public bool isMute;
    public AudioSource []sounds;
    // Start is called before the first frame update
    void Start()
    {
        sounds[0] = GameObject.Find("MainCamera").GetComponent<AudioSource>();
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        mutado();
    }
    public void jogar()
    {
        SceneManager.LoadScene(1);
    }
    public void sair()
    {
        Application.Quit();
    }
    public void mutar()
    {
        isMute = !isMute;
    }
    void mutado()
    {
        sounds[0].enabled = !isMute;
       


    }

}
