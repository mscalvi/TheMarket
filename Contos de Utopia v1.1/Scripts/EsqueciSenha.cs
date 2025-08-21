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

public class EsqueciSenha : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI MensagemInicial;
    public TMP_InputField UsuarioInput;
    public TMP_InputField EmailInput;

    private string UsuarioEntrou;
    private string EmailEntrou;
    private string SenhaNovaUsuario = string.Empty;
    bool UsuarioRegistrado = false;
    private int IdUsuario = -1;

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

    public bool VerificarNomeExistente(string Usuario, string Email)
    {
        var ContarUsuarios = $"SELECT COUNT(*) FROM TabelaJogadores WHERE Usuario = @Usuario AND Email = @Email";
        var AcharID = $"SELECT Id FROM TabelaJogadores WHERE Usuario = @Usuario AND Email = @Email";
        using (var conectar = new SqliteConnection($"Data Source = {DatabaseCaminho};"))
        {
            conectar.Open();

            using (var command = conectar.CreateCommand())
            {
                command.CommandText = ContarUsuarios;
                command.Parameters.AddWithValue("@Usuario", Usuario);
                command.Parameters.AddWithValue("@Email", Email);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    UsuarioRegistrado = true;
                }
                Debug.Log("Encontrado(s) " + count + " registro(s).");
                
                if (UsuarioRegistrado)
                {
                    command.CommandText = AcharID;
                    command.Parameters.AddWithValue("@Usuario", Usuario);
                    command.Parameters.AddWithValue("@Email", Email);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IdUsuario = reader.GetInt32(0);
                        }
                    }
                Debug.Log("Senha Resetada");
                }
            }

            conectar.Close();
        }

        return UsuarioRegistrado;
    }

    public void NovaSenha ()
    {
        for (int i = 0; i < 6; i++)
        {
            SenhaNovaUsuario += UnityEngine.Random.Range(0,10).ToString();
        }

        var AcharUsuario = $"UPDATE TabelaJogadores SET Senha = @Senha WHERE  Id = @Id";
          
        using (var conectar = new SqliteConnection($"Data Source = {DatabaseCaminho};"))
        {
            conectar.Open();

            using (var command = conectar.CreateCommand())
            {
                command.CommandText = AcharUsuario;
                command.Parameters.AddWithValue("@Id", IdUsuario);
                command.Parameters.AddWithValue("@Senha", SenhaNovaUsuario);
                command.ExecuteNonQuery();
            }

            conectar.Close ();
        }
    }

    public void ResetarSenhas ()
    {
        UsuarioEntrou = UsuarioInput.text;
        EmailEntrou = EmailInput.text;

        VerificarNomeExistente (UsuarioEntrou, EmailEntrou);

        if (!UsuarioRegistrado)
        {
            MensagemInicial.enabled = true;
        } else {
            NovaSenha ();
            MensagemInicial.text = "Sua nova senha é: " + SenhaNovaUsuario;
            MensagemInicial.enabled = true;
        }
    }

    public void Retornar ()
    {
            SceneManager.LoadScene("LoginPage");
    }
}