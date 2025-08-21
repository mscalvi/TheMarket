using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Criar004aMemoria : MonoBehaviour
{
    [SerializeField] private Button BtnVoltar;
    [SerializeField] private Button BtnConfirmar;
    [SerializeField] private Sprite BotaoBloqueado;
    [SerializeField] private Sprite BotaoConfirmar;
    [SerializeField] private Sprite BotaoCalculando;

    public static bool ConfirmarEscolhaMemorias;

    private int ConhecimentosTotais;
    private int PontosFaltandoTotal;
    [SerializeField] private TextMeshProUGUI PontosDistribuir;
    [SerializeField] private TextMeshProUGUI PontosFaltando;

    private int ConAlq = 1;
    private int ConArc = 1;
    private int ConHis = 1;
    private int ConMec = 1;
    private int ConMed = 1;
    private int ConNat = 1;

    [SerializeField] private TextMeshProUGUI ConAlqTexto;
    [SerializeField] private TextMeshProUGUI ConArcTexto;
    [SerializeField] private TextMeshProUGUI ConHisTexto;
    [SerializeField] private TextMeshProUGUI ConMecTexto;
    [SerializeField] private TextMeshProUGUI ConMedTexto;
    [SerializeField] private TextMeshProUGUI ConNatTexto;
    
    [SerializeField] private Button btnConAlqD;
    [SerializeField] private Button btnConArcD;
    [SerializeField] private Button btnConHisD;
    [SerializeField] private Button btnConMecD;
    [SerializeField] private Button btnConMedD;
    [SerializeField] private Button btnConNatD;
    [SerializeField] private Button btnConAlqU;
    [SerializeField] private Button btnConArcU;
    [SerializeField] private Button btnConHisU;
    [SerializeField] private Button btnConMecU;
    [SerializeField] private Button btnConMedU;
    [SerializeField] private Button btnConNatU;

    // Start is called before the first frame update
    void Start()
    {
        ConhecimentosTotais = ConArc + ConAlq + ConHis + ConMec + ConMed + ConNat - 6;
        PontosDistribuir.text = "Você tem " + NovoPersonagem.SuperMemoria + " pontos para distribuir.";
        PontosFaltandoTotal = NovoPersonagem.SuperMemoria - ConhecimentosTotais;
        PontosFaltando.text = "Faltam " + PontosFaltandoTotal;
    }

    // Update is called once per frame
    void Update()
    {
        ConhecimentosTotais = ConArc + ConAlq + ConHis + ConMec + ConMed + ConNat - 6;
        if (ConhecimentosTotais < NovoPersonagem.SuperMemoria)
        {
            BtnConfirmar.enabled = false;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoBloqueado;
        } else if (ConhecimentosTotais > NovoPersonagem.SuperMemoria){
            BtnConfirmar.enabled = false;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoBloqueado;
        }
        else {
            BtnConfirmar.enabled = true;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoConfirmar;
        }
        PontosDistribuir.text = "Você tem " + NovoPersonagem.SuperMemoria + " pontos para distribuir.";
        PontosFaltandoTotal = NovoPersonagem.SuperMemoria - ConhecimentosTotais;
        PontosFaltando.text = "Faltam " + PontosFaltandoTotal;

        if (ConAlq == 1){btnConAlqD.enabled = false;} else {btnConAlqD.enabled = true;}
        if (ConAlq == 3){btnConAlqU.enabled = false;} else {btnConAlqU.enabled = true;}
        if (ConArc == 1){btnConArcD.enabled = false;} else {btnConArcD.enabled = true;}
        if (ConArc == 3){btnConArcU.enabled = false;} else {btnConArcU.enabled = true;}
        if (ConHis == 1){btnConHisD.enabled = false;} else {btnConHisD.enabled = true;}
        if (ConHis == 3){btnConHisU.enabled = false;} else {btnConHisU.enabled = true;}
        if (ConMec == 1){btnConMecD.enabled = false;} else {btnConMecD.enabled = true;}
        if (ConMec == 3){btnConMecU.enabled = false;} else {btnConMecU.enabled = true;}
        if (ConMed == 1){btnConMedD.enabled = false;} else {btnConMedD.enabled = true;}
        if (ConMed == 3){btnConMedU.enabled = false;} else {btnConMedU.enabled = true;}
        if (ConNat == 1){btnConNatD.enabled = false;} else {btnConNatD.enabled = true;}
        if (ConNat == 3){btnConNatU.enabled = false;} else {btnConNatU.enabled = true;}
    }

    public void ConAlqU ()
    {
        ConAlq += 1;
        ConAlqTexto.text = ConAlq.ToString();
    }
    public void ConAlqD ()
    {
        ConAlq -= 1;
        ConAlqTexto.text = ConAlq.ToString();
    }

    public void ConArcU ()
    {
        ConArc += 1;
        ConArcTexto.text = ConArc.ToString();
    }
    public void ConArcD ()
    {
        ConArc -= 1;
        ConArcTexto.text = ConArc.ToString();
    }

    public void ConHisU ()
    {
        ConHis += 1;
        ConHisTexto.text = ConHis.ToString();
    }
    public void ConHisD ()
    {
        ConHis -= 1;
        ConHisTexto.text = ConHis.ToString();
    }

    public void ConMecU ()
    {
        ConMec += 1;
        ConMecTexto.text = ConMec.ToString();
    }
    public void ConMecD ()
    {
        ConMec -= 1;
        ConMecTexto.text = ConMec.ToString();
    }

    public void ConMedU ()
    {
        ConMed += 1;
        ConMedTexto.text = ConMed.ToString();
    }
    public void ConMedD ()
    {
        ConMed -= 1;
        ConMedTexto.text = ConMed.ToString();
    }

    public void ConNatU ()
    {
        ConNat += 1;
        ConNatTexto.text = ConNat.ToString();
    }
    public void ConNatD ()
    {
        ConNat -= 1;
        ConNatTexto.text = ConNat.ToString();
    }

    public void Retornar ()
    {
        SceneManager.LoadScene ("Criar001Especies");
    }

    public void ConfirmarEscolha ()
    {
        ConfirmarEscolhaMemorias = true;
        PlayerPrefs.SetInt("ConAlquimicos", ConAlq);
        PlayerPrefs.SetInt("ConArcanos", ConArc);
        PlayerPrefs.SetInt("ConHistoricos", ConHis);    
        PlayerPrefs.SetInt("ConMecanicos", ConMec);
        PlayerPrefs.SetInt("ConMedicinais", ConMed);
        PlayerPrefs.SetInt("ConNaturais", ConNat);
        SceneManager.LoadScene ("Criar004bClasse");
    }
}
