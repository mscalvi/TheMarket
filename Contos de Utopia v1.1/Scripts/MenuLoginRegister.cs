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

public class MenuLoginRegister : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI MensagemInicial;

    [SerializeField] private TMP_InputField NomeInput;
    [SerializeField] private TMP_InputField EmailInput;
    [SerializeField] private TMP_InputField CelularInput;
    [SerializeField] private TMP_InputField UsuarioInput;
    [SerializeField] private TMP_InputField SenhaInput;
    [SerializeField] private TMP_InputField SenhaRepInput;

    [SerializeField] private Button btnRegistrar;

    private string NomeDigitado;
    private string UsuarioDigitado;
    private string EmailDigitado;
    private string CelularDigitado;
    private string SenhaDigitado;
    
    protected SqliteConnection Connection => new SqliteConnection($"Data Source = {Path.Combine(Application.persistentDataPath, "UtopiaTalesDB.db")};");

    // Start is called before the first frame update
    void Start()
    {
            btnRegistrar.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (string.IsNullOrWhiteSpace(NomeInput.text) || string.IsNullOrWhiteSpace(EmailInput.text) || string.IsNullOrWhiteSpace(CelularInput.text) || string.IsNullOrWhiteSpace(UsuarioInput.text) || string.IsNullOrWhiteSpace(SenhaInput.text))
        {
            btnRegistrar.enabled = false;
        } else if (SenhaInput.text != SenhaRepInput.text) {
            btnRegistrar.enabled = false;
        } else {
            btnRegistrar.enabled = true;
        }
    }

    public void NovoRegistro ()
    {
        NomeDigitado = NomeInput.text;
        UsuarioDigitado = UsuarioInput.text;
        EmailDigitado = EmailInput.text;
        CelularDigitado = CelularInput.text;
        SenhaDigitado = SenhaInput.text;

        Debug.Log (SenhaDigitado);

        Registrar (NomeDigitado, UsuarioDigitado, EmailDigitado, CelularDigitado, SenhaDigitado);
    }
    
    public void Registrar (string NomeUsuario, string UsuarioUsuario, string EmailUsuario, string CelularUsuario, string SenhaUsuario)
    {
        NomeUsuario = NomeInput.text;
        UsuarioUsuario = UsuarioInput.text;
        CelularUsuario = CelularInput.text;
        SenhaUsuario = SenhaInput.text;
        EmailUsuario = EmailInput.text;

        var RegistrarJogador = "INSERT INTO TabelaJogadores (Nome, Usuario, Email, Celular, Senha) VALUES (@Nome, @Usuario, @Email, @Celular, @Senha)";

        using (var conectar = Connection)
        {
            conectar.Open();

            using (var comando = conectar.CreateCommand())
            {
                comando.CommandText = RegistrarJogador;

                comando.Parameters.AddWithValue("@Nome", NomeUsuario);
                comando.Parameters.AddWithValue("@Usuario", UsuarioUsuario);
                comando.Parameters.AddWithValue("@Email", EmailUsuario);
                comando.Parameters.AddWithValue("@Celular", CelularUsuario);
                comando.Parameters.AddWithValue("@Senha", SenhaUsuario);

                var resultado = comando.ExecuteNonQuery();
                Debug.Log($"Usuário Registrado: {resultado.ToString()}");
            }
            
            conectar.Close();
        }
        SceneManager.LoadScene ("LoginPage");
    }

    public void Retornar ()
    {
        SceneManager.LoadScene ("LoginPage");
    }
}
