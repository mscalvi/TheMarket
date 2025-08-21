using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SalvarPersonagem : MonoBehaviour
{
    private string Nome;
    private string Sobrenome;
    private string NomeMeio;
    private string Titulo;
    private string Altura;
    private string Peso;
    private string Descricao;

    private string Classe;
    private string Profissao;
    private string Especie;
    private string Origem;

    private string ListaAnteceentes;

    private int AAleijado;
    private int ACovarde;
    private int AHemofobico;
    private int AAnalfabeto;
    private int AAnsioso;
    private int APobre;
    private int AMagifobico;
    private int AImpulsivo;
    private int APapas;
    private int AViciado;
    private int AAtrapalhado;
    private int ANanismo;
    private int AGigantismo;
    private int ANormal;
    private int ATrombadinha;
    private int AFazenda;
    private int AAtleta;
    private int AEstudado;
    private int ACircense;
    private int AColetor;
    private int ANobre;
    private int ARico;
    private int AAmbidestro;
    private int AGenio;
    private int AExpoente;
    private int AEspecial;

    private int Constituicao;
    private int Destreza;
    private int Forca;
    private int Inteligencia;
    private int Magia;
    private int Memoria;
    private int Sensibilidade;
    private int Velocidade;

    private int VidaMax;
    private int ManaMax;
    private int SaniMax;
    private int VidaAtual;
    private int ManaAtual;
    private int SaniAtual;

    private int PAcrobacia;
    private int PMODAcrobacia;
    private int PArcanismo;
    private int PMODArcanismo;
    private int PArmasArremesso;
    private int PMODArmasArremesso;
    private int PArmasCorpoCorpo;
    private int PMODArmasCorpoCorpo;
    private int PLongoAlcance;
    private int PMODLongoAlcance;
    private int PArmasPrecisao;
    private int PMODArmasPrecisao;
    private int PArtesMarciais;
    private int PMODArtesMarciais;
    private int PAtletismo;
    private int PMODAtletismo;
    private int PBloqueio;
    private int PMODBloqueio;
    private int PCanalizadores;
    private int PMODCanalizadores;
    private int PCarisma;
    private int PMODCarisma;
    private int PConcentracao;
    private int PMODConcentracao;
    private int PConAlquimicos;
    private int PMODConAlquimicos;
    private int PConArcanos;
    private int PMODConArcanos;
    private int PConHistoricos;
    private int PMODConHistoricos;  
    private int PConMecanicos;
    private int PMODConMecanicos;
    private int PConMedicinais;
    private int PMODConMedicinais;
    private int PConNaturais;
    private int PMODConNaturais;
    private int PContraAtaque;
    private int PMODContraAtaque;
    private int PDestrezaManual;
    private int PMODDestrezaManual;
    private int PEqulibrio;
    private int PMODEqulibrio;
    private int PEsquiva;
    private int PMODEsquiva;
    private int PFolego;
    private int PMODFolego;
    private int PFurtividades;
    private int PMODFurtividades;
    private int PPercepcaoArcana;
    private int PMODPercepcaoArcana;
    private int PPercepcaoSensorial;
    private int PMODPercepcaoSensorial;
    private int PPersuasaoAniamal;
    private int PMODPersuasaoAniamal;
    private int PPrimeirosSocorros;
    private int PMODPrimeirosSocorros;
    private int PRelfexo;
    private int PMODRelfexo;
    private int PSegundaMao;
    private int PMODSegundaMao;

    // Start is called before the first frame update
    void Start()
    {
        Nome = PlayerPrefs.GetString ("NomePersonagem");
        Sobrenome = PlayerPrefs.GetString ("SobrenomePersonagem");
        NomeMeio = PlayerPrefs.GetString ("NomeMeioPersonagem");
        Titulo = PlayerPrefs.GetString ("TituloPersonagem");
        Altura = PlayerPrefs.GetString ("AlturaPersonagem");
        Peso = PlayerPrefs.GetString ("PesoPersonagem");
        Descricao = PlayerPrefs.GetString ("DescricaoPersonagem");
        
        Classe = PlayerPrefs.GetString("ClassePersonagem");
        Profissao = PlayerPrefs.GetString("ProfissaoPersonagem");
        Especie = PlayerPrefs.GetString("EspeciePersonagem");
        Origem = PlayerPrefs.GetString ("OrigemPersonagem");

        ListaAnteceentes = PlayerPrefs.GetString("AntecedentesPersonagem");

        AAleijado = PlayerPrefs.GetInt ("AAleijado");
        ACovarde = PlayerPrefs.GetInt ("ACovarde");
        AHemofobico = PlayerPrefs.GetInt ("AHemofobico");
        AAnalfabeto = PlayerPrefs.GetInt ("AAnalfabeto");
        AAnsioso = PlayerPrefs.GetInt ("AAnsioso");
        APobre = PlayerPrefs.GetInt ("APobre");
        AMagifobico = PlayerPrefs.GetInt ("AMagifobico");
        AImpulsivo = PlayerPrefs.GetInt ("AImpulsivio");
        APapas = PlayerPrefs.GetInt ("APapas");
        AViciado = PlayerPrefs.GetInt ("AViciado");
        AAtrapalhado = PlayerPrefs.GetInt ("AAtrapalhado");
        ANanismo = PlayerPrefs.GetInt ("ANanismo");
        AGigantismo = PlayerPrefs.GetInt ("AGigantismo");
        ANormal = PlayerPrefs.GetInt ("ANormal");
        ATrombadinha = PlayerPrefs.GetInt ("ATrombadinha");
        AFazenda = PlayerPrefs.GetInt ("AFazenda");
        AAtleta = PlayerPrefs.GetInt ("AAtleta");
        AEstudado = PlayerPrefs.GetInt ("AEstudado");
        ACircense = PlayerPrefs.GetInt ("ACirsense");
        AColetor = PlayerPrefs.GetInt ("AColetor");
        ANobre = PlayerPrefs.GetInt ("ANobre");
        ARico = PlayerPrefs.GetInt ("ARico");
        AAmbidestro = PlayerPrefs.GetInt ("AAmbidestro");
        AGenio = PlayerPrefs.GetInt ("AGenio");
        AExpoente = PlayerPrefs.GetInt ("AExpoente");
        AEspecial = PlayerPrefs.GetInt ("AEspecial");

        Constituicao = PlayerPrefs.GetInt("Constituicao");
        Destreza = PlayerPrefs.GetInt("Destreza");
        Forca = PlayerPrefs.GetInt("Forca");
        Inteligencia = PlayerPrefs.GetInt("Inteligencia");
        Magia = PlayerPrefs.GetInt("Magia");
        Memoria = PlayerPrefs.GetInt("Memoria");
        Sensibilidade = PlayerPrefs.GetInt("Sensibilidade");
        Velocidade = PlayerPrefs.GetInt("Velocidade");

        VidaMax = PlayerPrefs.GetInt("VidaMax");
        ManaMax = PlayerPrefs.GetInt("ManaMax");
        SaniMax = PlayerPrefs.GetInt("SaniMax");
        VidaAtual = PlayerPrefs.GetInt("VidaAtual");
        ManaAtual = PlayerPrefs.GetInt("ManaAtual");
        SaniAtual = PlayerPrefs.GetInt("SaniAtual");

        PAcrobacia = PlayerPrefs.GetInt("Acrobacia");
        PMODAcrobacia = PlayerPrefs.GetInt("MODAcrobacia");
        PArcanismo = PlayerPrefs.GetInt("Arcanismo");
        PMODArcanismo = PlayerPrefs.GetInt("MODArcanismo");
        PArmasArremesso = PlayerPrefs.GetInt("ArmasArremesso");
        PMODArmasArremesso = PlayerPrefs.GetInt("MODArmasArremesso");
        PArmasCorpoCorpo = PlayerPrefs.GetInt("ArmasCorpoCorpo");
        PMODArmasCorpoCorpo = PlayerPrefs.GetInt("MODArmasCorpoCorpo");
        PLongoAlcance = PlayerPrefs.GetInt("ArmasLongoAlcance");
        PMODLongoAlcance = PlayerPrefs.GetInt("MODArmasLongoAlcance");
        PArmasPrecisao = PlayerPrefs.GetInt("ArmasPrecisao");
        PMODArmasPrecisao = PlayerPrefs.GetInt("MODArmasPrecisao");
        PArtesMarciais = PlayerPrefs.GetInt("ArtesMarciais");
        PMODArtesMarciais = PlayerPrefs.GetInt("MODArtesMarciais");
        PAtletismo = PlayerPrefs.GetInt("Atletismo");
        PMODAtletismo = PlayerPrefs.GetInt("MODAtletismo");
        PBloqueio = PlayerPrefs.GetInt("Bloqueio");
        PMODBloqueio = PlayerPrefs.GetInt("MODBloqueio");
        PCanalizadores = PlayerPrefs.GetInt("Canalizadores");
        PMODCanalizadores = PlayerPrefs.GetInt("MODCanalizadores");
        PCarisma = PlayerPrefs.GetInt("Carisma");
        PMODCarisma = PlayerPrefs.GetInt("MODCarisma");
        PConcentracao = PlayerPrefs.GetInt("Concentracao");
        PMODConcentracao = PlayerPrefs.GetInt("MODConcentracao");
        PConAlquimicos = PlayerPrefs.GetInt("ConAlquimicos");
        PMODConAlquimicos = PlayerPrefs.GetInt("MODConAlquimicos");
        PConArcanos = PlayerPrefs.GetInt("ConArcanos");
        PMODConArcanos = PlayerPrefs.GetInt("MODConArcanos");
        PConHistoricos = PlayerPrefs.GetInt("ConHistoricos");    
        PMODConHistoricos = PlayerPrefs.GetInt("MODConHistoricos");    
        PConMecanicos = PlayerPrefs.GetInt("ConMecanicos");
        PMODConMecanicos = PlayerPrefs.GetInt("MODConMecanicos");
        PConMedicinais = PlayerPrefs.GetInt("ConMedicinais");
        PMODConMedicinais = PlayerPrefs.GetInt("MODConMedicinais");
        PConNaturais = PlayerPrefs.GetInt("ConNaturais");
        PMODConNaturais = PlayerPrefs.GetInt("MODConNaturais");
        PContraAtaque = PlayerPrefs.GetInt("ContraAtaque");
        PMODContraAtaque = PlayerPrefs.GetInt("MODContraAtaque");
        PDestrezaManual = PlayerPrefs.GetInt("DestrezaManual");
        PMODDestrezaManual = PlayerPrefs.GetInt("MODDestrezaManual");
        PEqulibrio = PlayerPrefs.GetInt("Equilibrio");
        PMODEqulibrio = PlayerPrefs.GetInt("MODEquilibrio");
        PEsquiva = PlayerPrefs.GetInt("Esquiva");
        PMODEsquiva = PlayerPrefs.GetInt("MODEsquiva");
        PFolego = PlayerPrefs.GetInt("Folego");
        PMODFolego = PlayerPrefs.GetInt("MODFolego");
        PFurtividades = PlayerPrefs.GetInt("Furtividade");
        PMODFurtividades = PlayerPrefs.GetInt("MODFurtividade");
        PPercepcaoArcana = PlayerPrefs.GetInt("PercepcaoArcana");
        PMODPercepcaoArcana = PlayerPrefs.GetInt("MODPercepcaoArcana");
        PPercepcaoSensorial = PlayerPrefs.GetInt("PercepcaoSensorial");
        PMODPercepcaoSensorial = PlayerPrefs.GetInt("MODPercepcaoSensorial");
        PPersuasaoAniamal = PlayerPrefs.GetInt("PersuasaoAnimal");
        PMODPersuasaoAniamal = PlayerPrefs.GetInt("MODPersuasaoAnimal");
        PPrimeirosSocorros = PlayerPrefs.GetInt("PrimeirosSocorros");
        PMODPrimeirosSocorros = PlayerPrefs.GetInt("MODPrimeirosSocorros");
        PRelfexo = PlayerPrefs.GetInt("Reflexo");
        PMODRelfexo = PlayerPrefs.GetInt("MODReflexo");
        PSegundaMao = PlayerPrefs.GetInt("SegundaMao");
        PMODSegundaMao = PlayerPrefs.GetInt("MODSegundaMao");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
