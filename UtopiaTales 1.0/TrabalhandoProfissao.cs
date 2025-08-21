using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class TrabalhandoProfissao : MonoBehaviour
{
    [SerializeField] private Sprite BotaoBloqueado;
    [SerializeField] private Sprite BotaoConfirmar;
    [SerializeField] private Sprite BotaoCalculando;

    [SerializeField] private TextMeshProUGUI ProfissaoResultadoSalario;
    [SerializeField] private TextMeshProUGUI ProfissaoResultadoLoot1;
    [SerializeField] private TextMeshProUGUI ProfissaoResultadoLoot2;
    [SerializeField] private TextMeshProUGUI ProfissaoDiasTrabalhadosTexto;

    [SerializeField] private Button btnMaisDias;
    [SerializeField] private Button btnMenosDias;
    [SerializeField] private Button btnTrabalhar;
    [SerializeField] private Button btnConfirmar;

    private int ProfissaoDiasTrabalhados;
    private int Salario;
    private int DinheiroRecebido;
    private int Loot1Res;
    private int Loot2Res;
    private int Xd20;
    private string Loot1;
    private string Loot2;

    // Start is called before the first frame update
    void Start()
    {
        ProfissaoDiasTrabalhados = 0;
        ProfissaoDiasTrabalhadosTexto.text = ProfissaoDiasTrabalhados.ToString();

        btnTrabalhar.enabled = false;
        btnTrabalhar.GetComponent<Image>().sprite = BotaoBloqueado;

        btnConfirmar.enabled = false;
        btnConfirmar.GetComponent<Image>().sprite = BotaoBloqueado;

        switch (PlayerPrefs.GetString ("ProfissaoPersonagem"))
        {
            case "Auxiliar de Alquimista":
                Salario = 18;
                Loot1 = "30 Ingredientes Ordinários";
                Loot2 = "1 Ingrediente Principal";
                break;

            case "Auxiliar de Comerciante":
                Salario = 21;
                Loot1 = "1 Item Comum";
                Loot2 = "1 Item Incomum";
                break;

            case "Auxiliar de Cozinheiro":
                Salario = 18;
                Loot1 = "1 Elixir de Relaxamento Mínimo";
                Loot2 = "1 Elixir de Relaxamento Simples";
                break;

            case "Auxiliar de Enfermeiro":
                Salario = 30;
                Loot1 = "1 Elixir de Regeneração Mínimo";
                Loot2 = "1 Elixir de Regeneração Simples";
                break;

            case "Auxiliar de Escrivão":
                Salario = 24;
                Loot1 = "1 Livro Raro de Conteúdo Aleatório";
                Loot2 = "1 Livro Específico de Raridade Aleatória";
                break;

            case "Auxiliar de Ferreiro":
                Salario = 18;
                Loot1 = "30 Materiais Ordinários";
                Loot2 = "1 Material Principal";
                break;

            case "Auxiliar de Gari":
                Salario = 6;
                Loot1 = "500 Moedas";
                Loot2 = "1 Item Raro";
                break;

            case "Auxiliar de Guarda":
                Salario = 15;
                Loot1 = "1 Arma Aleatória";
                Loot2 = "1 Equipamento Aleatório";
                break;

            case "Auxiliar de Relojoeiro":
                Salario = 27;
                Loot1 = "10 Peças Ordinárias";
                Loot2 = "20 Peças Ordinárias";
                break;
        }

        ProfissaoResultadoLoot1.enabled = false;
        ProfissaoResultadoLoot2.enabled = false;
        ProfissaoResultadoSalario.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ProfissaoDiasTrabalhados > 0)
        {
            btnTrabalhar.enabled = true;
            btnTrabalhar.GetComponent<Image>().sprite = BotaoCalculando;
        }
        if (ProfissaoDiasTrabalhados == 0)
        {
            btnMenosDias.enabled = false;
        }
    }

    public void MaisDiasTrabalhados ()
    {
        btnMenosDias.enabled = true;
        ProfissaoDiasTrabalhados += 1;
        ProfissaoDiasTrabalhadosTexto.text = ProfissaoDiasTrabalhados.ToString();
    }

    public void MenosDiasTrabalhados ()
    {
        if (ProfissaoDiasTrabalhados <= 1)
        {
            btnMenosDias.enabled = false;
        }
        ProfissaoDiasTrabalhados -= 1;
        ProfissaoDiasTrabalhadosTexto.text = ProfissaoDiasTrabalhados.ToString();
    }

    public void Trabalhar ()
    {
        btnTrabalhar.enabled = false;
        btnMenosDias.enabled = false;
        btnMaisDias.enabled = false;

        ProfissaoResultadoLoot1.enabled = true;
        ProfissaoResultadoLoot2.enabled = true;
        ProfissaoResultadoSalario.enabled = true;

        DinheiroRecebido = 0;
        Loot1Res = 0;
        Loot2Res = 0;

        btnConfirmar.enabled = true;
        btnConfirmar.GetComponent<Image>().sprite = BotaoConfirmar;

        for (int i = 0; i <= ProfissaoDiasTrabalhados; i++)
        {
            Xd20 = Random.Range (1, 21);
            if (Xd20 <= 11)
            {
                DinheiroRecebido += 0;
            } else if (Xd20 == 19) {
                Loot1Res += 1;
            } else if (Xd20 == 20) {
                Loot2Res += 1;
            } else {
                DinheiroRecebido += Salario;
            }
        }

        ProfissaoResultadoLoot1.text = Loot1Res.ToString () + " x " + Loot1;
        ProfissaoResultadoLoot2.text = Loot2Res.ToString () + " x " + Loot2;
        ProfissaoResultadoSalario.text = "Dinheiro Recebido: " + DinheiroRecebido;
    }

    public void ConfirmarTrabalho ()
    {
        btnTrabalhar.enabled = true;
        btnMenosDias.enabled = true;
        btnMaisDias.enabled = true;

    //enviar para mochila?

        ProfissaoDiasTrabalhados = 0;
        ProfissaoDiasTrabalhadosTexto.text = ProfissaoDiasTrabalhados.ToString();

        ProfissaoResultadoLoot1.enabled = false;
        ProfissaoResultadoLoot2.enabled = false;
        ProfissaoResultadoSalario.enabled = false;

        DinheiroRecebido = 0;
        Loot1Res = 0;
        Loot2Res = 0;

        btnConfirmar.enabled = false;
        btnTrabalhar.GetComponent<Image>().sprite = BotaoBloqueado;
        btnConfirmar.GetComponent<Image>().sprite = BotaoBloqueado;
    }
}
