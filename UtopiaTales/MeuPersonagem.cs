using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MeuPersonagem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI NomePersonagem;

    private int PainelAberto = 0;
    private GameObject PainelFicha;
    private GameObject PainelAtributos;
    private GameObject PainelCombate;
    private GameObject PainelProfissao;
    private GameObject PainelHabilidades;
    private GameObject PainelMochila;
    private GameObject PainelEquipamentos;
    private GameObject PainelRelacionamentos;
    private GameObject PainelAntecedentes;
    private GameObject PainelHistoria;
    private GameObject PainelAnotacoes;
    private GameObject PainelAlteracoes;

    [SerializeField] private Image ImagemFundo;
    [SerializeField] private Sprite Anguza;
    [SerializeField] private Sprite Anao;
    [SerializeField] private Sprite Celestial;
    [SerializeField] private Sprite Elfo;
    [SerializeField] private Sprite Fada;
    [SerializeField] private Sprite Gigante;
    [SerializeField] private Sprite Goblin;
    [SerializeField] private Sprite Guyra;
    [SerializeField] private Sprite Humano;
    [SerializeField] private Sprite Karumbe;
    [SerializeField] private Sprite Ocelot;
    [SerializeField] private Sprite Orc;
    [SerializeField] private Sprite Profano;
    [SerializeField] private Sprite Teju;
    [SerializeField] private Sprite Tritao;
    [SerializeField] private Sprite Vakame;
    [SerializeField] private Sprite Ytta;

    [SerializeField] private TextMeshProUGUI NomeCompletoPersonagem;
    [SerializeField] private TextMeshProUGUI EspeciePersonagem;
    [SerializeField] private TextMeshProUGUI ClassePersonagem;
    [SerializeField] private TextMeshProUGUI AlturaPersonagem;
    [SerializeField] private TextMeshProUGUI PesoPersonagem;
    [SerializeField] private TextMeshProUGUI AntecedentesPersonagem;
    [SerializeField] private TextMeshProUGUI ProfissaoPersonagem;
    [SerializeField] private TextMeshProUGUI AparenciaPersonagem;

    [SerializeField] private TextMeshProUGUI Constituicao;
    [SerializeField] private TextMeshProUGUI Destreza;
    [SerializeField] private TextMeshProUGUI Forca;
    [SerializeField] private TextMeshProUGUI Inteligencia;
    [SerializeField] private TextMeshProUGUI Magia;
    [SerializeField] private TextMeshProUGUI Memoria;
    [SerializeField] private TextMeshProUGUI Sensibilidade;
    [SerializeField] private TextMeshProUGUI Velocidade;

    [SerializeField] private TextMeshProUGUI Vida;
    [SerializeField] private TextMeshProUGUI Mana;
    [SerializeField] private TextMeshProUGUI Sanidade;

    [SerializeField] private TextMeshProUGUI ArmasArremesso;
    [SerializeField] private TextMeshProUGUI ArmasCorpoCorpo;
    [SerializeField] private TextMeshProUGUI ArmasLongoAlcance;
    [SerializeField] private TextMeshProUGUI ArmasPrecisao;
    [SerializeField] private TextMeshProUGUI ArtesMarciais;
    [SerializeField] private TextMeshProUGUI Bloqueio;
    [SerializeField] private TextMeshProUGUI Canalizadores;
    [SerializeField] private TextMeshProUGUI ContraAtaque;
    [SerializeField] private TextMeshProUGUI Esquiva;
    [SerializeField] private TextMeshProUGUI SegundaMao;
    [SerializeField] private TextMeshProUGUI Acrobacia;
    [SerializeField] private TextMeshProUGUI Arcanismo;
    [SerializeField] private TextMeshProUGUI Atletismo;
    [SerializeField] private TextMeshProUGUI Carisma;
    [SerializeField] private TextMeshProUGUI Concentracao;
    [SerializeField] private TextMeshProUGUI ConAlquimicos;
    [SerializeField] private TextMeshProUGUI ConArcanos;
    [SerializeField] private TextMeshProUGUI ConHistoricos;
    [SerializeField] private TextMeshProUGUI ConMecanicos;
    [SerializeField] private TextMeshProUGUI ConMedicinais;
    [SerializeField] private TextMeshProUGUI ConNaturais;
    [SerializeField] private TextMeshProUGUI DestrezaManual;
    [SerializeField] private TextMeshProUGUI Equilibrio;
    [SerializeField] private TextMeshProUGUI Folego;
    [SerializeField] private TextMeshProUGUI Furtividade;
    [SerializeField] private TextMeshProUGUI PercepcaoArcana;
    [SerializeField] private TextMeshProUGUI PercepcaoSensorial;
    [SerializeField] private TextMeshProUGUI PersuasaoAnimal;
    [SerializeField] private TextMeshProUGUI PrimeirosSocorros;
    [SerializeField] private TextMeshProUGUI Reflexo;

    [SerializeField] private TextMeshProUGUI ProfissaoTitulo;
    [SerializeField] private TextMeshProUGUI ProfissaoDescricao;
    [SerializeField] private TextMeshProUGUI ProfissaoSalario;
    [SerializeField] private TextMeshProUGUI ProfissaoLoot1;
    [SerializeField] private TextMeshProUGUI ProfissaoLoot2;


    // Start is called before the first frame update
    void Start()
    {
        PainelFicha = GameObject.Find("PainelFicha");
        PainelAtributos = GameObject.Find("PainelAtributos");
        PainelCombate = GameObject.Find("PainelCombate");
        PainelProfissao = GameObject.Find("PainelProfissao");
        PainelHabilidades = GameObject.Find("PainelHabilidades");
        PainelMochila = GameObject.Find("PainelMochila");
        PainelEquipamentos = GameObject.Find("PainelEquipamentos");
        PainelRelacionamentos = GameObject.Find("PainelRelacionamentos");
        PainelAntecedentes = GameObject.Find("PainelAntecedentes");
        PainelHistoria = GameObject.Find("PainelHistoria");
        PainelAlteracoes = GameObject.Find("PainelAlteracoes");
        PainelAnotacoes = GameObject.Find("PainelAnotacoes");

        NomePersonagem.text = PlayerPrefs.GetString("NomePersonagem");
        
        switch (PlayerPrefs.GetString("EspeciePersonagem"))
        {
            case "Anguza":
                ImagemFundo.sprite = Anguza;
                break;
            case "Anão":
                ImagemFundo.sprite = Anao;
                break;
            case "Celestial":
                ImagemFundo.sprite = Celestial;
                break;
            case "Elfo":
                ImagemFundo.sprite = Elfo;
                break;
            case "Fada":
                ImagemFundo.sprite = Fada;
                break;
            case "Gigante":
                ImagemFundo.sprite = Gigante;
                break;
            case "Goblin":
                ImagemFundo.sprite = Goblin;
                break;
            case "Guyra":
                ImagemFundo.sprite = Guyra;
                break;
            case "Humano":
                ImagemFundo.sprite = Humano;
                break;
            case "Karumbe":
                ImagemFundo.sprite = Karumbe;
                break;
            case "Ocelot":
                ImagemFundo.sprite = Ocelot;
                break;
            case "Orc":
                ImagemFundo.sprite = Orc;
                break;
            case "Profano":
                ImagemFundo.sprite = Profano;
                break;
            case "Teju":
                ImagemFundo.sprite = Teju;
                break;
            case "Tritão":
                ImagemFundo.sprite = Tritao;
                break;
            case "Vakame":
                ImagemFundo.sprite = Vakame;
                break;
            case "Ytta":
                ImagemFundo.sprite = Ytta;
                break;
        }
        ImagemFundo.enabled = true;

        ConsPainel1 ();
        ConsPainel2 ();
        ConsPainel3 ();
        ConsPainel4 ();

        TrocarPainel ();
    }

    public void Botao1 (){PainelAberto = 1; TrocarPainel ();}
    public void Botao2 (){PainelAberto = 2; TrocarPainel ();}
    public void Botao3 (){PainelAberto = 3; TrocarPainel ();}
    public void Botao4 (){PainelAberto = 4; TrocarPainel ();}
    public void Botao5 (){PainelAberto = 5; TrocarPainel ();}
    public void Botao6 (){PainelAberto = 6; TrocarPainel ();}
    public void Botao7 (){PainelAberto = 7; TrocarPainel ();}
    public void Botao8 (){PainelAberto = 8; TrocarPainel ();}
    public void Botao9 (){PainelAberto = 9; TrocarPainel ();}
    public void Botao10 (){PainelAberto = 10; TrocarPainel ();}
    public void Botao11 (){PainelAberto = 11; TrocarPainel ();}
    public void Botao12 (){PainelAberto = 12; TrocarPainel ();}

    public void TrocarPainel ()
    {
        switch (PainelAberto)
        {
            case 0:
                ImagemFundo.enabled = true;
                PainelFicha.gameObject.SetActive(false);
                PainelAtributos.gameObject.SetActive(false);
                PainelCombate.gameObject.SetActive(false);
                PainelProfissao.gameObject.SetActive(false);
                PainelHabilidades.gameObject.SetActive(false);
                PainelMochila.gameObject.SetActive(false);
                PainelEquipamentos.gameObject.SetActive(false);
                PainelRelacionamentos.gameObject.SetActive(false);
                PainelAntecedentes.gameObject.SetActive(false);
                PainelHistoria.gameObject.SetActive(false);
                PainelAlteracoes.gameObject.SetActive(false);
                PainelAnotacoes.gameObject.SetActive(false);
                break;
            case 1:
                ImagemFundo.enabled = false;
                PainelFicha.gameObject.SetActive(true);
                PainelAtributos.gameObject.SetActive(false);
                PainelCombate.gameObject.SetActive(false);
                PainelProfissao.gameObject.SetActive(false);
                PainelHabilidades.gameObject.SetActive(false);
                PainelMochila.gameObject.SetActive(false);
                PainelEquipamentos.gameObject.SetActive(false);
                PainelRelacionamentos.gameObject.SetActive(false);
                PainelAntecedentes.gameObject.SetActive(false);
                PainelHistoria.gameObject.SetActive(false);
                PainelAlteracoes.gameObject.SetActive(false);
                PainelAnotacoes.gameObject.SetActive(false);
                break;
            case 2:
                ImagemFundo.enabled = false;
                PainelFicha.gameObject.SetActive(false);
                PainelAtributos.gameObject.SetActive(true);
                PainelCombate.gameObject.SetActive(false);
                PainelProfissao.gameObject.SetActive(false);
                PainelHabilidades.gameObject.SetActive(false);
                PainelMochila.gameObject.SetActive(false);
                PainelEquipamentos.gameObject.SetActive(false);
                PainelRelacionamentos.gameObject.SetActive(false);
                PainelAntecedentes.gameObject.SetActive(false);
                PainelHistoria.gameObject.SetActive(false);
                PainelAlteracoes.gameObject.SetActive(false);
                PainelAnotacoes.gameObject.SetActive(false);
                break;
            case 3:
                ImagemFundo.enabled = false;
                PainelFicha.gameObject.SetActive(false);
                PainelAtributos.gameObject.SetActive(false);
                PainelCombate.gameObject.SetActive(true);
                PainelProfissao.gameObject.SetActive(false);
                PainelHabilidades.gameObject.SetActive(false);
                PainelMochila.gameObject.SetActive(false);
                PainelEquipamentos.gameObject.SetActive(false);
                PainelRelacionamentos.gameObject.SetActive(false);
                PainelAntecedentes.gameObject.SetActive(false);
                PainelHistoria.gameObject.SetActive(false);
                PainelAlteracoes.gameObject.SetActive(false);
                PainelAnotacoes.gameObject.SetActive(false);
                break;
            case 4:
                ImagemFundo.enabled = false;
                PainelFicha.gameObject.SetActive(false);
                PainelAtributos.gameObject.SetActive(false);
                PainelCombate.gameObject.SetActive(false);
                PainelProfissao.gameObject.SetActive(true);
                PainelHabilidades.gameObject.SetActive(false);
                PainelMochila.gameObject.SetActive(false);
                PainelEquipamentos.gameObject.SetActive(false);
                PainelRelacionamentos.gameObject.SetActive(false);
                PainelAntecedentes.gameObject.SetActive(false);
                PainelHistoria.gameObject.SetActive(false);
                PainelAlteracoes.gameObject.SetActive(false);
                PainelAnotacoes.gameObject.SetActive(false);
                break;
            case 5:
                ImagemFundo.enabled = false;
                PainelFicha.gameObject.SetActive(false);
                PainelAtributos.gameObject.SetActive(false);
                PainelCombate.gameObject.SetActive(false);
                PainelProfissao.gameObject.SetActive(false);
                PainelHabilidades.gameObject.SetActive(true);
                PainelMochila.gameObject.SetActive(false);
                PainelEquipamentos.gameObject.SetActive(false);
                PainelRelacionamentos.gameObject.SetActive(false);
                PainelAntecedentes.gameObject.SetActive(false);
                PainelHistoria.gameObject.SetActive(false);
                PainelAlteracoes.gameObject.SetActive(false);
                PainelAnotacoes.gameObject.SetActive(false);
                break;
            case 6:
                ImagemFundo.enabled = false;
                PainelFicha.gameObject.SetActive(false);
                PainelAtributos.gameObject.SetActive(false);
                PainelCombate.gameObject.SetActive(false);
                PainelProfissao.gameObject.SetActive(false);
                PainelHabilidades.gameObject.SetActive(false);
                PainelMochila.gameObject.SetActive(true);
                PainelEquipamentos.gameObject.SetActive(false);
                PainelRelacionamentos.gameObject.SetActive(false);
                PainelAntecedentes.gameObject.SetActive(false);
                PainelHistoria.gameObject.SetActive(false);
                PainelAlteracoes.gameObject.SetActive(false);
                PainelAnotacoes.gameObject.SetActive(false);
                break;
            case 7:
                ImagemFundo.enabled = false;
                PainelFicha.gameObject.SetActive(false);
                PainelAtributos.gameObject.SetActive(false);
                PainelCombate.gameObject.SetActive(false);
                PainelProfissao.gameObject.SetActive(false);
                PainelHabilidades.gameObject.SetActive(false);
                PainelMochila.gameObject.SetActive(false);
                PainelEquipamentos.gameObject.SetActive(true);
                PainelRelacionamentos.gameObject.SetActive(false);
                PainelAntecedentes.gameObject.SetActive(false);
                PainelHistoria.gameObject.SetActive(false);
                PainelAlteracoes.gameObject.SetActive(false);
                PainelAnotacoes.gameObject.SetActive(false);
                break;
            case 8:
                ImagemFundo.enabled = false;
                PainelFicha.gameObject.SetActive(false);
                PainelAtributos.gameObject.SetActive(false);
                PainelCombate.gameObject.SetActive(false);
                PainelProfissao.gameObject.SetActive(false);
                PainelHabilidades.gameObject.SetActive(false);
                PainelMochila.gameObject.SetActive(false);
                PainelEquipamentos.gameObject.SetActive(false);
                PainelRelacionamentos.gameObject.SetActive(true);
                PainelAntecedentes.gameObject.SetActive(false);
                PainelHistoria.gameObject.SetActive(false);
                PainelAlteracoes.gameObject.SetActive(false);
                PainelAnotacoes.gameObject.SetActive(false);
                break;
            case 9:
                ImagemFundo.enabled = false;
                PainelFicha.gameObject.SetActive(false);
                PainelAtributos.gameObject.SetActive(false);
                PainelCombate.gameObject.SetActive(false);
                PainelProfissao.gameObject.SetActive(false);
                PainelHabilidades.gameObject.SetActive(false);
                PainelMochila.gameObject.SetActive(false);
                PainelEquipamentos.gameObject.SetActive(false);
                PainelRelacionamentos.gameObject.SetActive(false);
                PainelAntecedentes.gameObject.SetActive(true);
                PainelHistoria.gameObject.SetActive(false);
                PainelAlteracoes.gameObject.SetActive(false);
                PainelAnotacoes.gameObject.SetActive(false);
                break;
            case 10:
                ImagemFundo.enabled = false;
                PainelFicha.gameObject.SetActive(false);
                PainelAtributos.gameObject.SetActive(false);
                PainelCombate.gameObject.SetActive(false);
                PainelProfissao.gameObject.SetActive(false);
                PainelHabilidades.gameObject.SetActive(false);
                PainelMochila.gameObject.SetActive(false);
                PainelEquipamentos.gameObject.SetActive(false);
                PainelRelacionamentos.gameObject.SetActive(false);
                PainelAntecedentes.gameObject.SetActive(false);
                PainelHistoria.gameObject.SetActive(true);
                PainelAlteracoes.gameObject.SetActive(false);
                PainelAnotacoes.gameObject.SetActive(false);
                break;
            case 11:
                ImagemFundo.enabled = false;
                PainelFicha.gameObject.SetActive(false);
                PainelAtributos.gameObject.SetActive(false);
                PainelCombate.gameObject.SetActive(false);
                PainelProfissao.gameObject.SetActive(false);
                PainelHabilidades.gameObject.SetActive(false);
                PainelMochila.gameObject.SetActive(false);
                PainelEquipamentos.gameObject.SetActive(false);
                PainelRelacionamentos.gameObject.SetActive(false);
                PainelAntecedentes.gameObject.SetActive(false);
                PainelHistoria.gameObject.SetActive(false);
                PainelAlteracoes.gameObject.SetActive(true);
                PainelAnotacoes.gameObject.SetActive(false);
                break;
            case 12:
                ImagemFundo.enabled = false;
                PainelFicha.gameObject.SetActive(false);
                PainelAtributos.gameObject.SetActive(false);
                PainelCombate.gameObject.SetActive(false);
                PainelProfissao.gameObject.SetActive(false);
                PainelHabilidades.gameObject.SetActive(false);
                PainelMochila.gameObject.SetActive(false);
                PainelEquipamentos.gameObject.SetActive(false);
                PainelRelacionamentos.gameObject.SetActive(false);
                PainelAntecedentes.gameObject.SetActive(false);
                PainelHistoria.gameObject.SetActive(false);
                PainelAlteracoes.gameObject.SetActive(false);
                PainelAnotacoes.gameObject.SetActive(true);
                break;
        }
    }

    private void ConsPainel1 ()
    {
        Debug.Log ("Preparando Painel 1");

        if (PlayerPrefs.GetInt("ANobre") == 1)
        {
            NomeCompletoPersonagem.text = PlayerPrefs.GetString("TituloPersonagem") + ", " + PlayerPrefs.GetString("NomePersonagem") + " " + PlayerPrefs.GetString("NomeMeioPersonagem") + " " + PlayerPrefs.GetString("SobrenomePersonagem");
        } else {
            NomeCompletoPersonagem.text = PlayerPrefs.GetString("NomePersonagem") + " " + PlayerPrefs.GetString("NomeMeioPersonagem") + " " + PlayerPrefs.GetString("SobrenomePersonagem");
        }
        
        EspeciePersonagem.text = PlayerPrefs.GetString ("EspeciePersonagem", "EspeciePersonagem") + " " + PlayerPrefs.GetString ("OrigemPersonagem", "ND");
        ClassePersonagem.text = "Classe: " + PlayerPrefs.GetString ("ClassePersonagem");
        AlturaPersonagem.text = PlayerPrefs.GetString ("AlturaPersonagem") + "m";
        PesoPersonagem.text = PlayerPrefs.GetString ("PesoPersonagem") + "Kg";
        AntecedentesPersonagem.text = PlayerPrefs.GetString ("AntecedentesPersonagem");
        ProfissaoPersonagem.text = PlayerPrefs.GetString ("ProfissaoPersonagem") + " nas horas vagas.";
        AparenciaPersonagem.text = PlayerPrefs.GetString ("DescricaoPersonagem");
        Debug.Log ("Pronto Painel 1");
    }

    private void ConsPainel2 ()
    {
        Debug.Log ("Preparando Painel 2");
        Constituicao.text = PlayerPrefs.GetInt ("Constituicao").ToString();
        Destreza.text = PlayerPrefs.GetInt ("Destreza").ToString();
        Forca.text = PlayerPrefs.GetInt ("Forca").ToString();
        Inteligencia.text = PlayerPrefs.GetInt ("Inteligencia").ToString();
        Magia.text = PlayerPrefs.GetInt ("Magia").ToString();
        Memoria.text = PlayerPrefs.GetInt ("Memoria").ToString();
        Sensibilidade.text = PlayerPrefs.GetInt ("Sensibilidade").ToString();
        Velocidade.text = PlayerPrefs.GetInt ("Velocidade").ToString();

        ArmasCorpoCorpo.text = PlayerPrefs.GetInt ("ArmasCorpoCorpo").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODArmasCorpoCorpo", 0).ToString ();
        ArmasArremesso.text = PlayerPrefs.GetInt ("ArmasArremesso").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODArmasArremesso", 0).ToString ();
        ArmasLongoAlcance.text = PlayerPrefs.GetInt ("ArmasLongoAlcance").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODArmasLongoAlcance", 0).ToString ();
        ArmasPrecisao.text = PlayerPrefs.GetInt ("ArmasPrecisao").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODArmasPrecisao", 0).ToString ();
        ArtesMarciais.text = PlayerPrefs.GetInt ("ArtesMarciais").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODArtesMarciais", 0).ToString ();
        Bloqueio.text = PlayerPrefs.GetInt ("Bloqueio").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODBloqueio", 0).ToString ();
        Canalizadores.text = PlayerPrefs.GetInt ("Canalizadores").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODCanalizadore", 0).ToString ();
        ContraAtaque.text = PlayerPrefs.GetInt ("ContraAtaque").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODContraAtaque", 0).ToString ();
        Esquiva.text = PlayerPrefs.GetInt ("Esquiva").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODEsquiva", 0).ToString ();
        SegundaMao.text = PlayerPrefs.GetInt ("SegundaMao").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODSegundaMao", 0).ToString ();
        Acrobacia.text = PlayerPrefs.GetInt ("Acrobacia").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODAcrobacia", 0).ToString ();
        Arcanismo.text = PlayerPrefs.GetInt ("Arcanismo").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODArcanismo", 0).ToString ();
        Atletismo.text = PlayerPrefs.GetInt ("Atletismo").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODAtletismo", 0).ToString ();
        Carisma.text = PlayerPrefs.GetInt ("Carisma").ToString () + "d6 + " + PlayerPrefs.GetInt ("CMODarisma", 0).ToString ();
        Concentracao.text = PlayerPrefs.GetInt ("Concentracao").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODConcentracao", 0).ToString ();
        DestrezaManual.text = PlayerPrefs.GetInt ("DestrezaManual").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODDestrezaManual", 0).ToString ();
        Equilibrio.text = PlayerPrefs.GetInt ("Equilibrio").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODEquilibrio", 0).ToString ();
        Folego.text = PlayerPrefs.GetInt ("Folego").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODFolego", 0).ToString ();
        Furtividade.text = PlayerPrefs.GetInt ("Furtividade").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODFurtividade", 0).ToString ();
        PercepcaoArcana.text = PlayerPrefs.GetInt ("PercepcaoArcana").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODPercepcaoArcana", 0).ToString ();
        PercepcaoSensorial.text = PlayerPrefs.GetInt ("PercepcaoSensorial").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODPercepcaoSensorial", 0).ToString ();
        PersuasaoAnimal.text = PlayerPrefs.GetInt ("PersuasaoAnimal").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODPersuasaoAnimal", 0).ToString ();
        PrimeirosSocorros.text = PlayerPrefs.GetInt ("PrimeirosSocorros").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODPrimeirosSocorros", 0).ToString ();
        Reflexo.text = PlayerPrefs.GetInt ("Reflexo").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODReflexo", 0).ToString ();
        ConAlquimicos.text = PlayerPrefs.GetInt ("ConAlquimicos").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODConAlquimicos", 0).ToString ();
        ConArcanos.text = PlayerPrefs.GetInt ("ConArcanos").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODConArcanos", 0).ToString ();
        ConHistoricos.text = PlayerPrefs.GetInt ("ConHistoricos").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODConHistoricos", 0).ToString ();
        ConMecanicos.text = PlayerPrefs.GetInt ("ConMecanicos").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODConMecanicos", 0).ToString ();
        ConMedicinais.text = PlayerPrefs.GetInt ("ConMedicinais").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODConMedicinais", 0).ToString ();
        ConNaturais.text = PlayerPrefs.GetInt ("ConNaturais").ToString () + "d6 + " + PlayerPrefs.GetInt ("MODConNaturais", 0).ToString ();

        Debug.Log ("Pronto Painel 2");
    }

    private void ConsPainel3 ()
    {
        Debug.Log ("Preparando Painel 3");
        Vida.text = PlayerPrefs.GetInt ("VidaMax").ToString();
        Mana.text = PlayerPrefs.GetInt ("ManaMax").ToString();
        Sanidade.text = PlayerPrefs.GetInt ("SaniMax").ToString();
        Debug.Log ("Pronto Painel 3");
    }

    private void ConsPainel4 ()
    {
        Debug.Log ("Preparando Painel 4");
        
        ProfissaoTitulo.text = PlayerPrefs.GetString("ProfissaoPersonagem");
        
        switch (PlayerPrefs.GetString ("ProfissaoPersonagem"))
        {
            case "Auxiliar de Alquimista":
                ProfissaoDescricao.text = "Você procura vaga nos laboratórios locais, vendo se pode ajudar no preparo de ingredientes e misturas simples, sem atrapalhar os profissionais locais.";
                ProfissaoSalario.text = "Salário: 18 moedas";
                ProfissaoLoot1.text = "5% de chance de conseguir 30 Ingredientes Ordinários";
                ProfissaoLoot2.text = "5% de chance de conseguir 1 Ingrediente Principal";
                break;

            case "Auxiliar de Comerciante":
                ProfissaoDescricao.text = "Você procura vaga no comércio, atrás de uma pequena comissão por suas vendas.";
                ProfissaoSalario.text = "Salário: 21 moedas";
                ProfissaoLoot1.text = "5% de chance de conseguir 1 Item Comum";
                ProfissaoLoot2.text = "5% de chance de conseguir 1 Item Incomum";
                break;

            case "Auxiliar de Cozinheiro":
                ProfissaoDescricao.text = "Você procura vaga nos restaurantes e tabernas locais, se oferecendo para fazer o preparo dos ingredientes.";
                ProfissaoSalario.text = "Salário: 18 moedas";
                ProfissaoLoot1.text = "5% de chance de conseguir 1 Elixir de Relaxamento Mínimo";
                ProfissaoLoot2.text = "5% de chance de conseguir 1 Elixir de Relaxamento Simples";
                break;

            case "Auxiliar de Enfermeiro":
                ProfissaoDescricao.text = "Você procura vaga nas casas de repouso e hospitais locais, se oferecendo para auxiliar no tratamento básico dos enfêrmos.";
                ProfissaoSalario.text = "Salário: 30 moedas";
                ProfissaoLoot1.text = "5% de chance de conseguir 1 Elixir de Regeneração Mínimo";
                ProfissaoLoot2.text = "5% de chance de conseguir 1 Elixir de Regeneração Simples";
                break;

            case "Auxiliar de Escrivão":
                ProfissaoDescricao.text = "Você procura os cartórios e casas da moeda locais, se oferecendo para fazer trabalho burocrático.";
                ProfissaoSalario.text = "Salário: 24 moedas";
                ProfissaoLoot1.text = "5% de chance de conseguir 1 Livro Raro de Conteúdo Aleatório";
                ProfissaoLoot2.text = "5% de chance de conseguir 1 Livro Específico de Raridade Aleatória";
                break;

            case "Auxiliar de Ferreiro":
                ProfissaoDescricao.text = "Você procura as ferrarias locais, se oferecendo para fazer o trabalho de organização e reparo de peças simples.";
                ProfissaoSalario.text = "Salário: 18 moedas";
                ProfissaoLoot1.text = "5% de chance de conseguir 30 Materiais Ordinários";
                ProfissaoLoot2.text = "5% de chance de conseguir 1 Material Principal";
                break;

            case "Auxiliar de Gari":
                ProfissaoDescricao.text = "Você procura a prefeitura local, se oferecendo para ajudar na limpeza da cidade.";
                ProfissaoSalario.text = "Salário: 6 moedas";
                ProfissaoLoot1.text = "5% de chance de conseguir 500 Moedas";
                ProfissaoLoot2.text = "5% de chance de conseguir 1 Item Raro";
                break;

            case "Auxiliar de Guarda":
                ProfissaoDescricao.text = "Você procura a guarda local, se oferecendo para auxiliar nos turnos menos requisitados.";
                ProfissaoSalario.text = "Salário: 15 moedas";
                ProfissaoLoot1.text = "5% de chance de conseguir 1 Arma Aleatória";
                ProfissaoLoot2.text = "5% de chance de conseguir 1 Equipamento Aleatório";
                break;

            case "Auxiliar de Relojoeiro":
                ProfissaoDescricao.text = "Você procura as casas de artífices e relojoeiros locais, se oferecendo para ajudar na organização e manutenção das peças.";
                ProfissaoSalario.text = "Salário: 27 moedas";
                ProfissaoLoot1.text = "5% de chance de conseguir 10 Peças Ordinárias";
                ProfissaoLoot2.text = "5% de chance de conseguir 20 Peças Ordinárias";
                break;
        }

        Debug.Log ("Pronto Painel 4");
    }
    
    public void Retornar ()
    {
        SceneManager.LoadScene ("MenuInicial");
    }

    public void Sair ()
    {
        Application.Quit ();
    }
}
