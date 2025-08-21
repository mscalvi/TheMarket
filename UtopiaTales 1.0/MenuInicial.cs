using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuInicial : MonoBehaviour
{
    [SerializeField] Button BtnMeuPersonagem;
    [SerializeField] TextMeshProUGUI tBtnMeuPersonagem;

    [SerializeField] Button BtnCriarPersonagem;
    [SerializeField] TextMeshProUGUI tBtnCriarPersonagem;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("Conectando ao Servidor");
    }

    public void MeuPersonagem (string cena)
    {  
        SceneManager.LoadScene ("SelecaoPersonagem");
    }

    public void CriacaoPersonagens (string cena)
    {  
        SceneManager.LoadScene ("Criar001Especies");
    }

    public void Sair ()
    {
        Application.Quit ();
    }
}
