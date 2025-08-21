using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class RolarDados : MonoBehaviour
{
    private int RoladaTotal;
    private int DadosRolados;
    private int Modificador;
    private int ValorRolado;

    private string ProficienciaRolar;

    [SerializeField] private TextMeshProUGUI TextoResultadoRolada;
    [SerializeField] private TextMeshProUGUI ProficienciaRolada;
    [SerializeField] private Image QuadroRolada;
    [SerializeField] private Button TelaEspera;
    [SerializeField] private TextMeshProUGUI TelaEsperaTexto;
    [SerializeField] private TextMeshProUGUI DadosRoladosTexto;

    private List <int> NumerosRolados = new List <int>();

    [SerializeField] private Button btnAcrobacia;
    [SerializeField] private Button btnArcanismo;
    [SerializeField] private Button btnArmasCac;
    [SerializeField] private Button btnArmasArremesso;
    [SerializeField] private Button btnArmasLongoAlcance;
    [SerializeField] private Button btnArmasPrecisao;
    [SerializeField] private Button btnArtesMarciais;
    [SerializeField] private Button btnAtletismo;
    [SerializeField] private Button btnBloqueio;
    [SerializeField] private Button btnCanalizadores;
    [SerializeField] private Button btnCarisma;
    [SerializeField] private Button btnConcentracao;
    [SerializeField] private Button btnConAlq;
    [SerializeField] private Button btnConArc;
    [SerializeField] private Button btnConHis;
    [SerializeField] private Button btnConMec;
    [SerializeField] private Button btnConMed;
    [SerializeField] private Button btnConNat;
    [SerializeField] private Button btnContraAtaque;
    [SerializeField] private Button btnDestrezaManual;
    [SerializeField] private Button btnEquilibrio;
    [SerializeField] private Button btnEsquiva;
    [SerializeField] private Button btnFolego;
    [SerializeField] private Button btnFurtividade;
    [SerializeField] private Button btnPercepcaoArcana;
    [SerializeField] private Button btnPercepcaoSensorial;
    [SerializeField] private Button btnPersuasaoAnimal;
    [SerializeField] private Button btnPrimeirosSocorros;
    [SerializeField] private Button btnReflexo;
    [SerializeField] private Button btnSegundaMao;

    // Start is called before the first frame update
    void Start()
    {
        QuadroRolada.enabled = false;
        TextoResultadoRolada.enabled = false;
        ProficienciaRolada.enabled = false;
        TelaEspera.enabled = false;
        TelaEsperaTexto.enabled = false;
        DadosRoladosTexto.enabled = false;
    }

    public void RolarDadosAcrobacia ()
    {
        RolandoDados();
        ProficienciaRolar = "Acrobacia";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("Acrobacia");
        Modificador = PlayerPrefs.GetInt ("MODAcrobacia");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosArcanismo ()
    {
        RolandoDados();
        ProficienciaRolar = "Arcanismo";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("Arcanismo");
        Modificador = PlayerPrefs.GetInt ("MODArcanismo");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosArmasCaC ()
    {
        RolandoDados();
        ProficienciaRolar = "Armas Corpo a Corpo";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("ArmasCorpoCorpo");
        Modificador = PlayerPrefs.GetInt ("MODArmasCorpoCorpo");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosArremesso ()
    {
        RolandoDados();
        ProficienciaRolar = "Armas de Arremesso";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("ArmasArremesso");
        Modificador = PlayerPrefs.GetInt ("MODArmasArremesso");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosArmasLongoAlcance ()
    {
        RolandoDados();
        ProficienciaRolar = "Armas de Longo Alcance";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("ArmasLongoAlcance");
        Modificador = PlayerPrefs.GetInt ("MODArmasLongoAlcance");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosArmasPrecisão ()
    {
        RolandoDados();
        ProficienciaRolar = "Armas de Precisão";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("ArmasPrecisao");
        Modificador = PlayerPrefs.GetInt ("MODArmasPrecisao");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosArtesMarciais ()
    {
        RolandoDados();
        ProficienciaRolar = "Artes Marciais";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("ArtesMarciais");
        Modificador = PlayerPrefs.GetInt ("MODArtesMarciais");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosAtletismo ()
    {
        RolandoDados();
        ProficienciaRolar = "Atletismo";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("Atletismo");
        Modificador = PlayerPrefs.GetInt ("MODAtletismo");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosBloqueio ()
    {
        RolandoDados();
        ProficienciaRolar = "Bloqueio";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("Bloqueio");
        Modificador = PlayerPrefs.GetInt ("MODBloqueio");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosCanalizadores ()
    {
        RolandoDados();
        ProficienciaRolar = "Canalizadores";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("Canalizadores");
        Modificador = PlayerPrefs.GetInt ("MODCanalizadores");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosCarisma ()
    {
        RolandoDados();
        ProficienciaRolar = "Carisma";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("Carisma");
        Modificador = PlayerPrefs.GetInt ("MODCarisma");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosConcentracao ()
    {
        RolandoDados();
        ProficienciaRolar = "Concentração";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("Concentracao");
        Modificador = PlayerPrefs.GetInt ("MODConcentracao");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosConAlquimicos ()
    {
        RolandoDados();
        ProficienciaRolar = "Conhecimentos Alquímicos";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("ConAlquimicos");
        Modificador = PlayerPrefs.GetInt ("MODConAlquimicos");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosConArcanos ()
    {
        RolandoDados();
        ProficienciaRolar = "Conhecimentos Arcanos";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("ConArcanos");
        Modificador = PlayerPrefs.GetInt ("MODConArcanos");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosConHistoricos ()
    {
        RolandoDados();
        ProficienciaRolar = "Conhecimentos Históricos";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("ConHistoricos");
        Modificador = PlayerPrefs.GetInt ("MODConHistoricos");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosConMecanicos ()
    {
        RolandoDados();
        ProficienciaRolar = "Conhecimentos Mecânicos";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("ConMecanicos");
        Modificador = PlayerPrefs.GetInt ("MODConMecanicos");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosConMedicinais ()
    {
        RolandoDados();
        ProficienciaRolar = "Conhecimentos Medicinais";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("ConMedicinais");
        Modificador = PlayerPrefs.GetInt ("MODConMedicinais");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosConNaturais ()
    {
        RolandoDados();
        ProficienciaRolar = "Conhecimentos Naturais";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("ConNaturais");
        Modificador = PlayerPrefs.GetInt ("MODConNaturais");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosContraAtaque ()
    {
        RolandoDados();
        ProficienciaRolar = "Contra-Ataque";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("ContraAtaque");
        Modificador = PlayerPrefs.GetInt ("MODContraAtaque");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosDestrezaManual ()
    {
        RolandoDados();
        ProficienciaRolar = "Destreza Manual";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("DestrezaManual");
        Modificador = PlayerPrefs.GetInt ("MODDestrezaManual");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }

    public void RolarDadosEquilibrio ()
    {
        RolandoDados();
        ProficienciaRolar = "Equilíbrio";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("Equilibrio");
        Modificador = PlayerPrefs.GetInt ("MODEquilibrio");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }


    public void RolarDadosEsquiva ()
    {
        RolandoDados();
        ProficienciaRolar = "Esquiva";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("Esquiva");
        Modificador = PlayerPrefs.GetInt ("MODEsquiva");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }


    public void RolarDadosFolego ()
    {
        RolandoDados();
        ProficienciaRolar = "Fôlego";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("Folego");
        Modificador = PlayerPrefs.GetInt ("MODFolego");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }


    public void RolarDadosFurtividade ()
    {
        RolandoDados();
        ProficienciaRolar = "Furtividade";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("Furtividade");
        Modificador = PlayerPrefs.GetInt ("MODFurtividade");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }


    public void RolarDadosPercepcaoArcana ()
    {
        RolandoDados();
        ProficienciaRolar = "Percepção Arcana";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("PercepcaoArcana");
        Modificador = PlayerPrefs.GetInt ("MODPercepcaoArcana");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }


    public void RolarDadosPercepcaoSensorial ()
    {
        RolandoDados();
        ProficienciaRolar = "Percepção Sensorial";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("PercepcaoSensorial");
        Modificador = PlayerPrefs.GetInt ("MODPercepcaoSensorial");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }


    public void RolarDadosPersuasaoAnimal ()
    {
        RolandoDados();
        ProficienciaRolar = "Persuasão Animal";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("PersuasaoAnimal");
        Modificador = PlayerPrefs.GetInt ("MODPersuasaoAnimal");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }


    public void RolarDadosPrimeirosSocorros ()
    {
        RolandoDados();
        ProficienciaRolar = "Primeiros Socorros";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("PrimeirosSocorros");
        Modificador = PlayerPrefs.GetInt ("MODPrimeirosSocorros");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }


    public void RolarDadosReflexo ()
    {
        RolandoDados();
        ProficienciaRolar = "Reflexo";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("Reflexo");
        Modificador = PlayerPrefs.GetInt ("MODReflexo");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }


    public void RolarDadosSegundaMao ()
    {
        RolandoDados();
        ProficienciaRolar = "Segunda Mão";
        RoladaTotal = 0;
        DadosRolados = PlayerPrefs.GetInt ("SegundaMao");
        Modificador = PlayerPrefs.GetInt ("MODSegundaMao");
        for (int i = 0; i < DadosRolados; i++) 
        {
            ValorRolado = Random.Range (1, 7);
            NumerosRolados.Add (ValorRolado);
            RoladaTotal += ValorRolado;
        }
        RoladaTotal += Modificador;
        ResultadoSaiu ();
    }


    private void RolandoDados ()
    {
        QuadroRolada.enabled = true;
        TextoResultadoRolada.enabled = true;
        ProficienciaRolada.enabled = true;

        btnAcrobacia.enabled = false;
        btnArcanismo.enabled = false;
        btnArmasCac.enabled = false;
        btnArmasArremesso.enabled = false;
        btnArmasLongoAlcance.enabled = false;
        btnArmasPrecisao.enabled = false;
        btnArtesMarciais.enabled = false;
        btnAtletismo.enabled = false;
        btnBloqueio.enabled = false;
        btnCanalizadores.enabled = false;
        btnCarisma.enabled = false;
        btnConcentracao.enabled = false;
        btnConAlq.enabled = false;
        btnConArc.enabled = false;
        btnConHis.enabled = false;
        btnConMec.enabled = false;
        btnConMed.enabled = false;
        btnConNat.enabled = false;
        btnContraAtaque.enabled = false;
        btnDestrezaManual.enabled = false;
        btnEquilibrio.enabled = false;
        btnEsquiva.enabled = false;
        btnFolego.enabled = false;
        btnFurtividade.enabled = false;
        btnPercepcaoArcana.enabled = false;
        btnPercepcaoSensorial.enabled = false;
        btnPersuasaoAnimal.enabled = false;
        btnPrimeirosSocorros.enabled = false;
        btnReflexo.enabled = false;
        btnSegundaMao.enabled = false;
    }

    public void ResultadoSaiu ()
    {
        DadosRoladosTexto.text = " ";
        ProficienciaRolada.text = ProficienciaRolar;
        DadosRoladosTexto.enabled = true;
        foreach (var item in NumerosRolados)
        {
            DadosRoladosTexto.text += item.ToString() + "   ";
        }
        TextoResultadoRolada.text = RoladaTotal.ToString();
        TelaEsperaTexto.enabled = true;
        TelaEsperaTexto.text = "Voltar";
        TelaEspera.enabled = true;
    }

    public void TempoEspera ()
    {
        btnAcrobacia.enabled = true;
        btnArcanismo.enabled = true;
        btnArmasCac.enabled = true;
        btnArmasArremesso.enabled = true;
        btnArmasLongoAlcance.enabled = true;
        btnArmasPrecisao.enabled = true;
        btnArtesMarciais.enabled = true;
        btnAtletismo.enabled = true;
        btnBloqueio.enabled = true;
        btnCanalizadores.enabled = true;
        btnCarisma.enabled = true;
        btnConcentracao.enabled = true;
        btnConAlq.enabled = true;
        btnConArc.enabled = true;
        btnConHis.enabled = true;
        btnConMec.enabled = true;
        btnConMed.enabled = true;
        btnConNat.enabled = true;
        btnContraAtaque.enabled = true;
        btnDestrezaManual.enabled = true;
        btnEquilibrio.enabled = true;
        btnEsquiva.enabled = true;
        btnFolego.enabled = true;
        btnFurtividade.enabled = true;
        btnPercepcaoArcana.enabled = true;
        btnPercepcaoSensorial.enabled = true;
        btnPersuasaoAnimal.enabled = true;
        btnPrimeirosSocorros.enabled = true;
        btnReflexo.enabled = true;
        btnSegundaMao.enabled = true;

        NumerosRolados.Clear();
        QuadroRolada.enabled = false;
        TextoResultadoRolada.enabled = false;
        ProficienciaRolada.enabled = false;
        TelaEspera.enabled = false;
        TelaEsperaTexto.enabled = false;
        DadosRoladosTexto.enabled = false;
    }
}
