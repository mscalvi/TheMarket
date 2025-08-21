using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using TMPro;
using Mono.Data.Sqlite;

public class MenuLogin : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI MensagemInicial;
    public TMP_InputField UsuarioInput;
    public TMP_InputField SenhaInput;
    [SerializeField] private TMP_Text SenhaText;

    private string UsuarioEntrou;
    private string SenhaEntrou;
    bool UsuarioRegistrado = false;

    string DatabaseCaminho = string.Empty;

    void Start ()
    {
#if UNITY_EDITOR
    DatabaseCaminho = Path.Combine(Application.persistentDataPath, "UtopiaTalesDB.db");
#elif UNITY_ANDROID
    DatabaseCaminho = Path.Combine(Application.persistentDataPath, "UtopiaTalesDB.db");
#endif

        MensagemInicial.text = "Verifique os dados.";
        MensagemInicial.enabled = false;
        Debug.Log("Caminho do banco de dados: " + DatabaseCaminho);
    }

    public void Registrar ()
    {
        SceneManager.LoadScene ("LoginPageRegister");
    }

    public bool VerificarNomeExistente(string Usuario, string Senha)
    {
        string ContarUsuarios = $"SELECT COUNT(*) FROM TabelaJogadores WHERE Usuario = @Usuario AND Senha = @Senha";

        using (var conectar = new SqliteConnection($"Data Source = {DatabaseCaminho};"))
        {
            conectar.Open();

            using (var command = conectar.CreateCommand())
            {
                command.CommandText = ContarUsuarios;
                command.Parameters.AddWithValue("@Usuario", Usuario);
                command.Parameters.AddWithValue("@Senha", Senha);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    UsuarioRegistrado = true;
                }
                Debug.Log("Encontrado(s) " + count + " registro(s).");
            }

            conectar.Close();
        }

        return UsuarioRegistrado;
    }

    public void Conectar ()
    {
        UsuarioEntrou = UsuarioInput.text;
        SenhaEntrou = SenhaInput.text;

        VerificarNomeExistente (UsuarioEntrou, SenhaEntrou);

        if (!UsuarioRegistrado)
        {
            MensagemInicial.enabled = true;
        } else {
            MensagemInicial.text = "Conectando.";
            MensagemInicial.enabled = true;
            SceneManager.LoadScene("MenuInicial");
        }
    }

    public void EsqueciSenha ()
    {
        SceneManager.LoadScene("EsqueciSenha");        
    }

    public void Sair ()
    {
        Application.Quit ();
    }
}