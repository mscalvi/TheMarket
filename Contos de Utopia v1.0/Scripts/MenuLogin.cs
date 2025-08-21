using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuLogin : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI MensagemInicial;
    public TMP_InputField UsuarioInput;
    public TMP_InputField SenhaInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Registrar ()
    {
    }

    public void Conectar ()
    {

    }

    public void EsqueciSenha ()
    {

    }

    public void Sair ()
    {
        Application.Quit ();
    }
}
