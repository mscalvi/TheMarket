using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Criar006Profissao : MonoBehaviour
{
    public static bool ConfirmarEscolhaProfissao;
    
    [SerializeField] private Button BtnConfirmar;
    [SerializeField] private Sprite BotaoBloqueado;
    [SerializeField] private Sprite BotaoConfirmar;
    [SerializeField] private Sprite BotaoCalculando;

    [SerializeField] private Button ProfAuxiliar;
    [SerializeField] private Button ProfComerciante;
    [SerializeField] private Button ProfCozinheiro;
    [SerializeField] private Button ProfEnfermeiro;
    [SerializeField] private Button ProfEscrivao;
    [SerializeField] private Button ProfFerreiro;
    [SerializeField] private Button ProfGari;
    [SerializeField] private Button ProfGuarda;
    [SerializeField] private Button ProfRelojoeiro;

    [SerializeField] private TextMeshProUGUI ProfAuxiliarText;
    [SerializeField] private TextMeshProUGUI ProfComercianteText;
    [SerializeField] private TextMeshProUGUI ProfCozinheiroText ;
    [SerializeField] private TextMeshProUGUI ProfEnfermeiroText;
    [SerializeField] private TextMeshProUGUI ProfEscrivaoText;
    [SerializeField] private TextMeshProUGUI ProfFerreiroText;
    [SerializeField] private TextMeshProUGUI ProfGariText;
    [SerializeField] private TextMeshProUGUI ProfGuardaText;
    [SerializeField] private TextMeshProUGUI ProfRelojoeiroText;

    [SerializeField] private TextMeshProUGUI DinheiroInicialTexto;
    [SerializeField] private TextMeshProUGUI DiaTrabalho;
    [SerializeField] private TextMeshProUGUI BonusProficiencia;
    [SerializeField] private TextMeshProUGUI NomeProfissao;
    [SerializeField] private TextMeshProUGUI BonusItem;
    [SerializeField] private TextMeshProUGUI DescricaoItem;

    public static int ProfissaoEscolhida;

    // Start is called before the first frame update
    void Start()
    {
        BtnConfirmar.enabled = false;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoBloqueado;

        DinheiroInicialTexto.enabled = false;
        DiaTrabalho.enabled = false;
        BonusProficiencia.enabled = false;
        NomeProfissao.enabled = false;
        BonusItem.enabled = false;
        DescricaoItem.enabled = false;

        if (PlayerPrefs.GetInt("Constituicao") < 6)
        {
            ProfGari.GetComponent<Image>().sprite = BotaoBloqueado;
            ProfGari.enabled = false;
        }
        if (PlayerPrefs.GetInt("Destreza") < 6)
        {
            ProfEnfermeiro.GetComponent<Image>().sprite = BotaoBloqueado;
            ProfEnfermeiro.enabled = false;
            ProfRelojoeiro.GetComponent<Image>().sprite = BotaoBloqueado;
            ProfRelojoeiro.enabled = false;
        }
        if (PlayerPrefs.GetInt("Forca") < 6)
        {
            ProfFerreiro.GetComponent<Image>().sprite = BotaoBloqueado;
            ProfFerreiro.enabled = false;
        }
        if (PlayerPrefs.GetInt("Inteligencia") < 6)
        {
            ProfAuxiliar.GetComponent<Image>().sprite = BotaoBloqueado;
            ProfAuxiliar.enabled = false;
        }
        if (PlayerPrefs.GetInt("Memoria") < 6)
        {
            ProfCozinheiro.GetComponent<Image>().sprite = BotaoBloqueado;
            ProfCozinheiro.enabled = false;
            ProfEscrivao.GetComponent<Image>().sprite = BotaoBloqueado;
            ProfEscrivao.enabled = false;
        }
        if (PlayerPrefs.GetInt("Sensibilidade") < 6)
        {
            ProfComerciante.GetComponent<Image>().sprite = BotaoBloqueado;
            ProfComerciante.enabled = false;
        }
        if (PlayerPrefs.GetInt("Velocidade") < 6)
        {
            ProfGuarda.GetComponent<Image>().sprite = BotaoBloqueado;
            ProfGuarda.enabled = false;
        }
    }

    public void LiberarPainel ()
    {
        BtnConfirmar.enabled = true;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoConfirmar;

        DinheiroInicialTexto.enabled = true;
        DiaTrabalho.enabled = true;
        BonusProficiencia.enabled = true;
        NomeProfissao.enabled = true;
        BonusItem.enabled = true;
        DescricaoItem.enabled = true;
    }

    public void AuxiliarProf ()
    {
        LiberarPainel ();
        ProfissaoEscolhida = 1;
        NomeProfissao.text = "Auxiliar de Laboratório";
        DinheiroInicialTexto.text = "Dinheiro Inicial: 370 moedas";
        DiaTrabalho.text = "Remuneração por Dia Trabalhado: 18 moedas";
        BonusProficiencia.text = "Conhecimentos Alquímicos +1";
        DescricaoItem.text = "Você tem 5% de chance (1 no d20) de ganhar 30 Ingredientes Ordinários e 5% de chance (20 no d20) de receber 1 Ingrediente Principal a cada dia de trabalho";
    }

    public void ComercianteProf ()
    {
        LiberarPainel ();
        ProfissaoEscolhida = 2;
        NomeProfissao.text = "Comerciante";
        DinheiroInicialTexto.text = "Dinheiro Inicial: 340 moedas";
        DiaTrabalho.text = "Remuneração por Dia Trabalhado: 21 moedas";
        BonusProficiencia.text = "Carisma +1";
        DescricaoItem.text = "Você tem 5% de chance (1 no d20) de ganhar 1 Item Comum e 5% de chance (20 no d20) de receber 1 Item Incomum a cada dia de trabalho";
    }

    public void CozinheiroProf ()
    {
        LiberarPainel ();
        ProfissaoEscolhida = 3;
        NomeProfissao.text = "Cozinheiro";
        DinheiroInicialTexto.text = "Dinheiro Inicial: 370 moedas";
        DiaTrabalho.text = "Remuneração por Dia Trabalhado: 18 moedas";
        BonusProficiencia.text = "Conhecimentos Naturais +1";
        DescricaoItem.text = "Você tem 5% de chance (1 no d20) de ganhar 1 Elixir de Relaxamaneto Mínimo e 5% de chance (20 no d20) de receber 1 Elixir de Relaxamento Simples a cada dia de trabalho";
    }

    public void EnfermeiroProf ()
    {
        LiberarPainel ();
        ProfissaoEscolhida = 4;
        NomeProfissao.text = "Enfermeiro";
        DinheiroInicialTexto.text = "Dinheiro Inicial: 250 moedas";
        DiaTrabalho.text = "Remuneração por Dia Trabalhado: 30 moedas";
        BonusProficiencia.text = "Primeiros Socorros +1";
        DescricaoItem.text = "Você tem 5% de chance (1 no d20) de ganhar 1 Elixir de Regeneração Mínimo e 5% de chance (20 no d20) de receber 1 Elixir de Regeneração Simples a cada dia de trabalho";
    }

    public void EscrivaoProf ()
    {
        LiberarPainel ();
        ProfissaoEscolhida = 5;
        NomeProfissao.text = "Escrivão";
        DinheiroInicialTexto.text = "Dinheiro Inicial: 310 moedas";
        DiaTrabalho.text = "Remuneração por Dia Trabalhado: 24 moedas";
        BonusProficiencia.text = "Conhecimentos Históricos +1";
        DescricaoItem.text = "Você tem 5% de chance (1 no d20) de ganhar 1 Livro raro de conteúdo aleatório e 5% de chance (20 no d20) de receber 1 Livro de conteúdo específico e raridade aleatória a cada dia de trabalho";
    }

    public void FerreiroProf ()
    {
        LiberarPainel ();
        ProfissaoEscolhida = 6;
        NomeProfissao.text = "Ferreiro";
        DinheiroInicialTexto.text = "Dinheiro Inicial: 370 moedas";
        DiaTrabalho.text = "Remuneração por Dia Trabalhado: 18 moedas";
        BonusProficiencia.text = "Atletismo +1";
        DescricaoItem.text = "Você tem 5% de chance (1 no d20) de ganhar 30 Materiais Ordinários e 5% de chance (20 no d20) de receber 1 Material Princiapl a cada dia de trabalho";
    }

    public void GariProf ()
    {
        LiberarPainel ();
        ProfissaoEscolhida = 7;
        NomeProfissao.text = "Gari";
        DinheiroInicialTexto.text = "Dinheiro Inicial: 500 moedas";
        DiaTrabalho.text = "Remuneração por Dia Trabalhado: 6 moedas";
        BonusProficiencia.text = "Fôlego +1";
        DescricaoItem.text = "Você tem 5% de chance (1 no d20) de ganhar 500 Moedas e 5% de chance (20 no d20) de receber 1 Item Raro a cada dia de trabalho";
    }

    public void GuardaProf ()
    {
        LiberarPainel ();
        ProfissaoEscolhida = 8;
        NomeProfissao.text = "Guarda";
        DinheiroInicialTexto.text = "Dinheiro Inicial: 400 moedas";
        DiaTrabalho.text = "Remuneração por Dia Trabalhado: 15 moedas";
        BonusProficiencia.text = "Percepção Sensorial +1";
        DescricaoItem.text = "Você tem 5% de chance (1 no d20) de ganhar 1 Arma Aleatória e 5% de chance (20 no d20) de receber 1 Equipamento Aleatório a cada dia de trabalho";
    }

    public void RelojoeiroProf ()
    {
        LiberarPainel ();
        ProfissaoEscolhida = 9;
        NomeProfissao.text = "Relojoeiro";
        DinheiroInicialTexto.text = "Dinheiro Inicial: 280 moedas";
        DiaTrabalho.text = "Remuneração por Dia Trabalhado: 27 moedas";
        BonusProficiencia.text = "Destreza Manual +1";
        DescricaoItem.text = "Você tem 5% de chance (1 no d20) de ganhar 10 Peças Ordinárias e 5% de chance (20 no d20) de receber 20 Peças Ordinárias a cada dia de trabalho";
    }

    public void ConfirmarEscolha ()
    {
        ConfirmarEscolhaProfissao = true;
        switch (ProfissaoEscolhida)
        {
            case 1:
                PlayerPrefs.SetString("ProfissaoPersonagem", "Auxiliar de Alquimista");
                PlayerPrefs.SetInt("ConAlquimicos", PlayerPrefs.GetInt("MODConAlquimicos") + 1);
                NovoPersonagem.DinheiroInicial = 370;
                break;

            case 2:
                PlayerPrefs.SetString("ProfissaoPersonagem", "Auxiliar de Comerciante");
                PlayerPrefs.SetInt("MODCarisma", PlayerPrefs.GetInt("MODCarisma") + 1);
                NovoPersonagem.DinheiroInicial = 340;
                break;
                
            case 3:
                PlayerPrefs.SetString("ProfissaoPersonagem", "Auxiliar de Cozinheiro");
                PlayerPrefs.SetInt("MODConNaturais", PlayerPrefs.GetInt("MODConNaturais") + 1);
                NovoPersonagem.DinheiroInicial = 370;
                break;
                
            case 4:
                PlayerPrefs.SetString("ProfissaoPersonagem", "Auxiliar de Enfermeiro");
                PlayerPrefs.SetInt("MODPrimeirosSocorros", PlayerPrefs.GetInt("MODPrimeirosSocorros") + 1);
                NovoPersonagem.DinheiroInicial = 250;
                break;
                
            case 5:
                PlayerPrefs.SetString("ProfissaoPersonagem", "Auxiliar de Escrivão");
                PlayerPrefs.SetInt("MODConHistoricos", PlayerPrefs.GetInt("MODConHistoricos") + 1);
                NovoPersonagem.DinheiroInicial = 310;
                break;
                
            case 6:
                PlayerPrefs.SetString("ProfissaoPersonagem", "Auxiliar de Ferreiro");
                PlayerPrefs.SetInt("MODAtletismo", PlayerPrefs.GetInt("MODAtletismo") + 1);
                NovoPersonagem.DinheiroInicial = 370;
                break;
                
            case 7:
                PlayerPrefs.SetString("ProfissaoPersonagem", "Auxiliar de Gari");
                PlayerPrefs.SetInt("MODFolego", PlayerPrefs.GetInt("MODFolego") + 1);
                NovoPersonagem.DinheiroInicial = 500;
                break;
                
            case 8:
                PlayerPrefs.SetString("ProfissaoPersonagem", "Auxiliar de Guarda");
                PlayerPrefs.SetInt("MODPercepcaoSensorial", PlayerPrefs.GetInt("MODPercepcaoSensorial") + 1);
                NovoPersonagem.DinheiroInicial = 400;
                break;
                
            case 9:
                PlayerPrefs.SetString("ProfissaoPersonagem", "Auxiliar de Relojoeiro");
                PlayerPrefs.SetInt("MODDestrezaManual", PlayerPrefs.GetInt("MODDestrezaManual") + 1);
                NovoPersonagem.DinheiroInicial = 280;
                break;
        }
        SceneManager.LoadScene ("Criar007Detalhes");
    }

    public void Retornar ()
    {
        SceneManager.LoadScene ("Criar005Antecedentes");
    }
}