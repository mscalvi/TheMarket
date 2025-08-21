using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class SelecaoPersonagem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Personagem1 () 
    {
        SceneManager.LoadScene ("Personagem1");
    }

    public void Retornar ()
    {
        SceneManager.LoadScene ("MenuInicial");
    }
}
