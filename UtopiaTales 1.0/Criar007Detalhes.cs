using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Criar007Detalhes : MonoBehaviour
{
    public static bool ConfirmarEscolhaDetalhes;
    
    [SerializeField] private Button BtnConfirmar;
    [SerializeField] private Sprite BotaoBloqueado;
    [SerializeField] private Sprite BotaoConfirmar;
    [SerializeField] private Sprite BotaoCalculando;
    [SerializeField] private Sprite BotaoAleatorio;
    [SerializeField] private Sprite BotaoDigitar;

    [SerializeField] private Button bTitulo;

    [SerializeField] private Button BtnAleatorio;
    [SerializeField] private Button BtnEscolher;
    [SerializeField] private Button BotaoConfirmarMirin;
    
    [SerializeField] private TextMeshProUGUI FuncaoTexto;
    [SerializeField] private TextMeshProUGUI ValorPadraoTexto;
    [SerializeField] private TextMeshProUGUI ValorAtualTexto;
    [SerializeField] private TextMeshProUGUI AntecedentesTexto;

    [SerializeField] private TextMeshProUGUI NomeAtual;
    [SerializeField] private TextMeshProUGUI SobrenomeAtual;
    [SerializeField] private TextMeshProUGUI MeioAtual;
    [SerializeField] private TextMeshProUGUI TituloAtual;
    [SerializeField] private TextMeshProUGUI AlturaAtual;
    [SerializeField] private TextMeshProUGUI PesoAtual;
    [SerializeField] private TextMeshProUGUI DescricaoAtual;


    [SerializeField] private TMP_InputField CaixaEntrada;

    private GameObject [] PainelEditavel;
    private GameObject [] PainelFixo;
    [SerializeField] private Toggle MasculinoGen;
    [SerializeField] private Toggle FemininoGen;

    private int CodigoFuncao;
    private int AleNome;
    private int AleTitulo;
    private int Genero;
    private int Gigantismo;
    private int Nanismo;
    private double AlturaBase;
    private double AlturaRolada;
    private double AlturaFinal;
    private double PesoBase;
    private double PesoRolado;
    private double PesoFinal;
    private string Especie;

    private bool Valor1Pronto;
    private bool Valor2Pronto;
    private bool Valor3Pronto;
    private bool Valor4Pronto;
    private bool Valor5Pronto;
    private bool Valor6Pronto;
    private bool Valor7Pronto;

    private bool Aleatoriezado;
    private bool Escolhido;

    // Start is called before the first frame update
    void Start()
    {
        BtnConfirmar.enabled = false;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoBloqueado;

        PainelEditavel = GameObject.FindGameObjectsWithTag("PainelEditavel");
        PainelFixo = GameObject.FindGameObjectsWithTag("PainelFixo");

        MasculinoGen.onValueChanged.AddListener(MasculinoSelecionado);
        FemininoGen.onValueChanged.AddListener(FemininoSelecionado);

        foreach(GameObject panel in PainelEditavel)
    	{
    		panel.gameObject.SetActive(false);
    	}

        if (PlayerPrefs.GetInt("ANobre") == 0)
        {
            bTitulo.enabled = false;
            bTitulo.gameObject.SetActive(false);
            TituloAtual.text = "Não pertence à Nobreza.";
            Valor4Pronto = true;
        }
    }

    void Update ()
    {
        if (Valor1Pronto == true && Valor2Pronto == true && Valor3Pronto == true && Valor4Pronto == true && Valor5Pronto == true && Valor6Pronto == true && Valor7Pronto == true)
        {
            BtnConfirmar.enabled = true;
            BtnConfirmar.GetComponent<Image>().sprite = BotaoConfirmar;
        }
    }

    public void EditarNome ()
    {
        CodigoFuncao = 1;
        LigarPainel ();
    }

    public void EditarSobrenome ()
    {
        CodigoFuncao = 2;
        LigarPainel ();
    }

    public void EditarMeio ()
    {
        CodigoFuncao = 3;
        LigarPainel ();
    }

    public void EditarTitulo ()
    {
        CodigoFuncao = 4;
        LigarPainel ();
    }

    public void EditarAltura ()
    {
        CodigoFuncao = 5;
        LigarPainel ();
    }

    public void EditarPeso ()
    {
        CodigoFuncao = 6;
        LigarPainel ();
    }

    public void EditarDescricao ()
    {
        CodigoFuncao = 7;
        LigarPainel ();
    }

    private void MasculinoSelecionado (bool isChecked)
    {
        if (isChecked)
        {
            FemininoGen.isOn = false;
            Genero = 1;
            Debug.Log("Gênero selecionado: Masculino");
        }
    } 

    private void FemininoSelecionado (bool isChecked)
    {
        if (isChecked)
        {
            MasculinoGen.isOn = false;
            Genero = 0;
            Debug.Log("Gênero selecionado: Masculino");
        }
    } 

    public void Aleatoriezar ()
    {
        Aleatoriezado = true;
        Escolhido = false;
        CaixaEntrada.interactable = false;
        switch (CodigoFuncao)
        {
            case 3:
                AleNome = Random.Range (1, 27);
                switch (AleNome)
                {
                    case 1:
                        ValorAtualTexto.text = "A.";
                        break;
                    
                    case 2:
                    ValorAtualTexto.text = "B.";
                        break;
                    
                    case 3:
                    ValorAtualTexto.text = "C.";
                        break;
                    
                    case 4:
                    ValorAtualTexto.text = "D.";
                        break;
                    
                    case 5:
                    ValorAtualTexto.text = "E.";
                        break;
                    
                    case 6:
                    ValorAtualTexto.text = "F.";
                        break;
                    
                    case 7:
                    ValorAtualTexto.text = "G.";
                        break;
                    
                    case 8:
                    ValorAtualTexto.text = "H.";
                        break;
                    
                    case 9:
                    ValorAtualTexto.text = "I.";
                        break;
                    
                    case 10:
                    ValorAtualTexto.text = "J.";
                        break;
                    
                    case 11:
                    ValorAtualTexto.text = "K.";
                        break;
                    
                    case 12:
                    ValorAtualTexto.text = "L.";
                        break;
                    
                    case 13:
                    ValorAtualTexto.text = "M.";
                        break;
                    
                    case 14:
                    ValorAtualTexto.text = "N.";
                        break;
                    
                    case 15:
                    ValorAtualTexto.text = "O.";
                        break;
                    
                    case 16:
                    ValorAtualTexto.text = "P.";
                        break;
                    
                    case 17:
                    ValorAtualTexto.text = "Q.";
                        break;
                    
                    case 18:
                    ValorAtualTexto.text = "R.";
                        break;
                    
                    case 19:
                    ValorAtualTexto.text = "S.";
                        break;
                    
                    case 20:
                    ValorAtualTexto.text = "T.";
                        break;
                    
                    case 21:
                    ValorAtualTexto.text = "U.";
                        break;
                    
                    case 22:
                    ValorAtualTexto.text = "V.";
                        break;
                    
                    case 23:
                    ValorAtualTexto.text = "W.";
                        break;
                    
                    case 24:
                    ValorAtualTexto.text = "X.";
                        break;
                    
                    case 25:
                    ValorAtualTexto.text = "Y.";
                        break;
                    
                    case 26:
                    ValorAtualTexto.text = "Z."; 
                        break;                   
                }
                break;
                
            case 4:
                AleTitulo = Random.Range (1, 10);
                switch (AleTitulo)
                {
                    case 1:
                        if (Genero == 1){
                            ValorAtualTexto.text = "Príncipe";
                        } else {
                            ValorAtualTexto.text = "Princesa";
                        }
                        break;

                    case 2:
                        if (Genero == 1){
                            ValorAtualTexto.text = "Duque";
                        } else {
                            ValorAtualTexto.text = "Duquesa";
                        }
                        break;
                        
                    case 3:
                        if (Genero == 1){
                            ValorAtualTexto.text = "Marquês";
                        } else {
                            ValorAtualTexto.text = "Marquesa";
                        }
                        break;
                        
                    case 4:
                        if (Genero == 1){
                            ValorAtualTexto.text = "Conde";
                        } else {
                            ValorAtualTexto.text = "Condessa";
                        }
                        break;
                        
                    case 5:
                        if (Genero == 1){
                            ValorAtualTexto.text = "Barão";
                        } else {
                            ValorAtualTexto.text = "Baronesa";
                        }
                        break;
                        
                    case 6:
                        if (Genero == 1){
                            ValorAtualTexto.text = "Lorde";
                        } else {
                            ValorAtualTexto.text = "Lady";
                        }
                        break;
                        
                    case 7:
                        if (Genero == 1){
                            ValorAtualTexto.text = "Cavaleiro";
                        } else {
                            ValorAtualTexto.text = "Dama";
                        }
                        break;
                        
                    case 8:
                        if (Genero == 1){
                            ValorAtualTexto.text = "Mestre";
                        } else {
                            ValorAtualTexto.text = "Mestra";
                        }
                        break;
                        
                    case 9:
                        if (Genero == 1){
                            ValorAtualTexto.text = "Senhor";
                        } else {
                            ValorAtualTexto.text = "Senhora";
                        }
                        break;
                }
                PlayerPrefs.SetString("TituloPersonagem", ValorAtualTexto.text);
                break;
                
            case 5:
                Gigantismo = PlayerPrefs.GetInt("AGigantismo");
                Nanismo = PlayerPrefs.GetInt("ANanismo");
                Especie = PlayerPrefs.GetString("EspeciePersonagem");
                Debug.Log (Especie);
                switch (Especie)
                {
                    case "Anguza":
                        AlturaBase = 1.20;
                        AlturaRolada = 0.01*Random.Range (1, 21);
                        break;

                    case "Anão":
                        AlturaBase = 1.10;
                        AlturaRolada = 0.01*Random.Range (1, 21);
                        break;

                    case "Celestial":
                        AlturaBase = 1.35;
                        AlturaRolada = 0.01*(Random.Range (1, 21) + Random.Range (1, 21) + Random.Range (1, 21));
                        break;

                    case "Elfo":
                        AlturaBase = 1.90;
                        AlturaRolada = 0.01*(Random.Range (1, 21)+ Random.Range (1, 21));
                        break;

                    case "Fada":
                        AlturaBase = 0.15;
                        AlturaRolada = 0.01*Random.Range (1, 7);
                        break;

                    case "Gigante":
                        AlturaBase = 2.70;
                        AlturaRolada = 0.01*(Random.Range (1, 21)+ Random.Range (1, 21)+ Random.Range (1, 21)+ Random.Range (1, 21)+ Random.Range (1, 21));
                        break;

                    case "Goblin":
                        AlturaBase = 0.9;
                        AlturaRolada = 0.01*( Random.Range (1, 7) + Random.Range (1, 7) );
                        break;

                    case "Guyra":
                        AlturaBase = 1.30;
                        AlturaRolada = 0.01*(Random.Range (1, 21)+ Random.Range (1, 21));
                        break;

                    case "Humano":
                        AlturaBase = 1.40;
                        AlturaRolada = 0.01*(Random.Range (1, 21)+ Random.Range (1, 21)+ Random.Range (1, 21));
                        break;

                    case "Karumbe":
                        AlturaBase = 1.40;
                        AlturaRolada = 0.01*(Random.Range (1, 21)+ Random.Range (1, 21)+ Random.Range (1, 21));
                        break;

                    case "Ocelot":
                        AlturaBase = 1.40;
                        AlturaRolada = 0.01*(Random.Range (1, 21)+ Random.Range (1, 21)+ Random.Range (1, 21));
                        break;

                    case "Orc":
                        AlturaBase = 1.80;
                        AlturaRolada = 0.01*(Random.Range (1, 7) + Random.Range (1, 7) + Random.Range (1, 7) + Random.Range (1, 7) + Random.Range (1, 7));
                        break;

                    case "Profano":
                        AlturaBase = 1.40;
                        AlturaRolada = 0.01*(Random.Range (1, 21)+ Random.Range (1, 21));
                        break;

                    case "Teju":
                        AlturaBase = 1.60;
                        AlturaRolada = 0.01*Random.Range (1, 11);
                        break;

                    case "Tritão":
                        AlturaBase = 1.20;
                        AlturaRolada = 0.01*(Random.Range (1, 21) + Random.Range (1, 21));
                        break;

                    case "Vakame":
                        AlturaBase = 1.80;
                        AlturaRolada = 0.01*Random.Range (1, 21);
                        break;

                    case "Ytta":
                        AlturaBase = 1.35;
                        AlturaRolada = 0.01*(Random.Range (1, 21) + Random.Range (1, 21));
                        break;
                }
                if (Nanismo == 1)
                {
                    AlturaRolada -= 2*AlturaRolada;
                }
                if (Gigantismo == 1)
                {
                    AlturaRolada += AlturaRolada;
                }
                AlturaFinal = AlturaBase + AlturaRolada;
                ValorAtualTexto.text = AlturaFinal.ToString();
                PlayerPrefs.SetString("AlturaPersonagem", ValorAtualTexto.text);
                break;
                
            case 6:
                switch (PlayerPrefs.GetString("EspeciePersonagem"))
                {
                    case "Anguza":
                        PesoBase = 30;
                        PesoRolado = Random.Range (1, 11);
                        break;

                    case "Anão":
                        PesoBase = 70;
                        PesoRolado = Random.Range (1, 21) + Random.Range (1, 21);
                        break;

                    case "Celestial":
                        PesoBase = 40;
                        PesoRolado = Random.Range (1, 21) + Random.Range (1, 21);
                        break;

                    case "Elfo":
                        PesoBase = 60;
                        PesoRolado = Random.Range (1, 11) + Random.Range (1, 11);
                        break;

                    case "Fada":
                        PesoBase = 0.5;
                        PesoRolado = 0.1*Random.Range (1, 7);
                        break;

                    case "Gigante":
                        PesoBase = 200;
                        PesoRolado = Random.Range (1, 21) + Random.Range (1, 21) + Random.Range (1, 21);
                        break;

                    case "Goblin":
                        PesoBase = 15;
                        PesoRolado = Random.Range (1, 7) + Random.Range (1, 7);
                        break;

                    case "Guyra":
                        PesoBase = 30;
                        PesoRolado = Random.Range (1, 11) + Random.Range (1, 11);
                        break;

                    case "Humano":
                        PesoBase = 50;
                        PesoRolado = Random.Range (1, 11) + Random.Range (1, 11);
                        break;

                    case "Karumbe":
                        PesoBase = 270;
                        PesoRolado = Random.Range (1, 11) + Random.Range (1, 11) + Random.Range (1, 11);
                        break;

                    case "Ocelot":
                        PesoBase = 30;
                        PesoRolado = Random.Range (1, 21);
                        break;

                    case "Orc":
                        PesoBase = 80;
                        PesoRolado = Random.Range (1, 21) + Random.Range (1, 21);
                        break;

                    case "Profano":
                        PesoBase = 50;
                        PesoRolado = Random.Range (1, 21) + Random.Range (1, 21);
                        break;

                    case "Teju":
                        PesoBase = 40;
                        PesoRolado = Random.Range (1, 11) + Random.Range (1, 11);
                        break;

                    case "Tritão":
                        PesoBase = 30;
                        PesoRolado = Random.Range (1, 21);
                        break;

                    case "Vakame":
                        PesoBase = 140;
                        PesoRolado = Random.Range (1, 21) + Random.Range (1, 21);
                        break;

                    case "Ytta":
                        PesoBase = 50;
                        PesoRolado = Random.Range (1, 11);
                        break;
                }
                PesoFinal = PesoBase + PesoRolado;
                ValorAtualTexto.text = PesoFinal.ToString();
                PlayerPrefs.SetString("PesoPersonagem", ValorAtualTexto.text);
                break;
        }
    }

    public void Escolher ()
    {
        CaixaEntrada.interactable = true;
        Aleatoriezado = false;
        Escolhido = true;
        ValorAtualTexto.text = "-";
    }

    public void ConfirmarMirin ()
    {
        switch (CodigoFuncao)
        {
            case 1:
                PlayerPrefs.SetString ("NomePersonagem", CaixaEntrada.text);
                Valor1Pronto = true;
                break;
            case 2:
                PlayerPrefs.SetString ("SobrenomePersonagem", CaixaEntrada.text);
                Valor2Pronto = true;
                break;
            case 3:
                PlayerPrefs.SetString ("NomeMeioPersonagem", ValorAtualTexto.text);
                Valor3Pronto = true;
                break;
            case 4:
                if (Aleatoriezado == true)
                {
                    PlayerPrefs.SetString ("TituloPersonagem", ValorAtualTexto.text);
                } else {
                    PlayerPrefs.SetString ("TituloPersonagem", CaixaEntrada.text);
                }
                Valor4Pronto = true;
                break;
            case 5:
                if (Aleatoriezado == true)
                {
                    PlayerPrefs.SetString ("AlturaPersonagem", ValorAtualTexto.text);
                } else {
                    PlayerPrefs.SetString ("AlturaPersonagem", CaixaEntrada.text);
                }
                Valor5Pronto = true;
                break;
            case 6:
                if (Aleatoriezado == true)
                {
                    PlayerPrefs.SetString ("PesoPersonagem", ValorAtualTexto.text);
                } else {
                    PlayerPrefs.SetString ("PesoPersonagem", CaixaEntrada.text);
                }
                Valor6Pronto = true;
                break;
            case 7:
                PlayerPrefs.SetString ("DescricaoPersonagem", CaixaEntrada.text);
                Valor7Pronto = true;
                break;
        }
        foreach(GameObject panel in PainelEditavel)
    	{
    		panel.gameObject.SetActive(false);
    		Debug.Log ("Desligando: " + panel.name);
    	}
        foreach(GameObject panel in PainelFixo)
    	{
    		panel.gameObject.SetActive(true);
    		Debug.Log ("Ligando: " + panel.name);
    	}
        NomeAtual.text = PlayerPrefs.GetString ("NomePersonagem", "-");
        SobrenomeAtual.text = PlayerPrefs.GetString ("SobrenomePersonagem", "-");
        MeioAtual.text = PlayerPrefs.GetString ("NomeMeioPersonagem", "-");
        TituloAtual.text = PlayerPrefs.GetString ("TituloPersonagem", "-");
        AlturaAtual.text = PlayerPrefs.GetString ("AlturaPersonagem", "-") + "m";
        PesoAtual.text = PlayerPrefs.GetString ("PesoPersonagem", "-") + "Kg";
        DescricaoAtual.text = PlayerPrefs.GetString ("DescricaoPersonagem", "-");

        CaixaEntrada.text = " ";
    }

    public void LigarPainel ()
    {
        foreach(GameObject panel in PainelEditavel)
    	{
    		panel.gameObject.SetActive(true);
    		Debug.Log ("Ligando: " + panel.name);
    	}
        foreach(GameObject panel in PainelFixo)
    	{
    		panel.gameObject.SetActive(false);
    		Debug.Log ("Desligando: " + panel.name);
    	}

        CaixaEntrada.interactable = false;

        BtnAleatorio.enabled =true;
        BtnEscolher.enabled = true;
        BotaoConfirmarMirin.enabled = true;
        
        AntecedentesTexto.enabled = true;

        BtnAleatorio.GetComponent<Image>().sprite = BotaoAleatorio;
        BtnEscolher.GetComponent<Image>().sprite = BotaoDigitar;

        switch (CodigoFuncao)
        {
            case 1:
                CaixaEntrada.text = "Apenas o primeiro nome.";
                BtnAleatorio.enabled =false;
                BtnAleatorio.GetComponent<Image>().sprite = BotaoBloqueado;
                BtnEscolher.enabled = false;
                BtnEscolher.GetComponent<Image>().sprite = BotaoBloqueado;
                FuncaoTexto.text = "Nome";
                ValorAtualTexto.text = PlayerPrefs.GetString ("NomePersonagem", "-");
                CaixaEntrada.interactable = true;
                break;

            case 2:
                CaixaEntrada.text = "Apenas o último nome.";
                BtnAleatorio.enabled =false;
                BtnAleatorio.GetComponent<Image>().sprite = BotaoBloqueado;
                BtnEscolher.enabled = false;
                BtnEscolher.GetComponent<Image>().sprite = BotaoBloqueado;
                FuncaoTexto.text = "Sobrenome";
                ValorAtualTexto.text = PlayerPrefs.GetString ("SobrenomePersonagem", "-");
                CaixaEntrada.interactable = true;
                break;

            case 3:
                BtnEscolher.enabled = false;
                BtnEscolher.GetComponent<Image>().sprite = BotaoBloqueado;
                FuncaoTexto.text = "Nome do Meio";
                ValorAtualTexto.text = PlayerPrefs.GetString ("NomeMeioPersonagem", "-");
                break;

            case 4:
                FuncaoTexto.text = "Título de Nobreza.";
                ValorAtualTexto.text = PlayerPrefs.GetString ("TituloPersonagem", "-");
                AntecedentesTexto.text = "Você é membro da Nobresa, quer seja lembrado ou não.";
                break;

            case 5:
                CaixaEntrada.text = "Lembre dos Antecedentes!";
                FuncaoTexto.text = "Altura";
                ValorAtualTexto.text = PlayerPrefs.GetString ("AlturaPersonagem", "-");
                break;

            case 6:
                CaixaEntrada.text = "Peso do seu personagem.";
                FuncaoTexto.text = "Peso";
                ValorAtualTexto.text = PlayerPrefs.GetString ("PesoPersonagem", "-");
                break;

            case 7:
                BtnAleatorio.enabled =false;
                BtnAleatorio.GetComponent<Image>().sprite = BotaoBloqueado;
                BtnEscolher.enabled = false;
                BtnEscolher.GetComponent<Image>().sprite = BotaoBloqueado;
                FuncaoTexto.text = "Descrição";
                ValorAtualTexto.text = PlayerPrefs.GetString ("DescricaoPersonagem", "-");
                CaixaEntrada.interactable = true;
                break;
        }
    }

    public void Retornar ()
    {
        SceneManager.LoadScene ("Criar001Especies");
    }

    public void ConfirmarEscolha ()
    {
        ConfirmarEscolhaDetalhes = true;
        PlayerPrefs.SetInt("PersonagemPronto", 1);
        SceneManager.LoadScene ("MenuInicial");
    }
}
