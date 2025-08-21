using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using Mono.Data.Sqlite;

public class SQLiteManager : MonoBehaviour
{
    public string DatabaseNome;
    protected string DatabaseCaminho;
    protected SqliteConnection Connection => new SqliteConnection($"Data Source = {this.DatabaseCaminho};");

    private void Awake ()
    {
        if(string.IsNullOrEmpty(this.DatabaseNome))
        {
            Debug.LogError ("Nome do DB em branco!");
            return;
        }
        
        if (File.Exists(DatabaseCaminho))
        {
            Debug.Log("Database já criada.");
        } else {
            CriarDataBase();
            try
            {
                CriarTabelas();
            }
            catch (Exception e)
            {
                Debug.LogError (e.Message);
            }
        }
    }

    protected void CriarTabelas()
    {
        using (var conn = Connection)
        {
            var ParametrosJogador = $"CREATE TABLE TabelaJogadores" +
                $"(" +
                $"  Id INTEGER PRIMARY KEY, " +
                $"  Usuario TEXT NOT NULL, " +
                $"  Senha TEXT NOT NULL, " +
                $"  Email TEXT NOT NULL, " +
                $"  Celular TEXT NOT NULL, " +
                $"  Nome TEXT NOT NULL" +
                $");";

            var ParametrosPersonagens = $"CREATE TABLE PersonagensJogador" +
                $"(" +
                $"  IdDonoPersonagem INTEGER, " +
                $"  NomePersonagem TEXT NOT NULL, " +
                $"  EspeciePersonagem TEXT NOT NULL, " +
                $"  FOREIGN KEY(IdDonoPersonagem) REFERENCES TabelaJogadores(Nome)" +
                $");";

            conn.Open();

            using (var command = conn.CreateCommand())
            {
                command.CommandText = ParametrosJogador;
                command.ExecuteNonQuery();
                Debug.Log ("Tabela Jogadores Ok");
            }

            using (var command = conn.CreateCommand())
            {
                command.CommandText = ParametrosPersonagens;
                command.ExecuteNonQuery();
                Debug.Log ("Tabela Personagens Ok");
            }
        }
    }

    #region CriandoDB

    private void CriarDataBase()
    {
        this.DatabaseCaminho = Path.Combine(Application.persistentDataPath, this.DatabaseNome);
        SqliteConnection.CreateFile(this.DatabaseCaminho);
    }

    #endregion
}
