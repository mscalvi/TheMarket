using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.EventSystems;

public class ControleCondicoes : MonoBehaviour
{
    [SerializeField] private Image BarraVida;
    [SerializeField] private Image BarraMana;
    [SerializeField] private Image BarraSanidade;

    [SerializeField] private float VidaTotal;
    [SerializeField] private float ManaTotal;
    [SerializeField] private float SanidadeTotal;

    [SerializeField] private float VidaAtual;
    [SerializeField] private float ManaAtual;
    [SerializeField] private float SaniAtual;

    [SerializeField] private float VidaAlterada;
    [SerializeField] private float ManaAlterada;
    [SerializeField] private float SaniAlterada;

    private int VidaAtt;
    private int ManaAtt;
    private int SaniAtt;

    [SerializeField] private TextMeshProUGUI VidaAtualTexto;
    [SerializeField] private TextMeshProUGUI ManaAtualTexto;
    [SerializeField] private TextMeshProUGUI SaniAtualTexto;
    
    [SerializeField] private TextMeshProUGUI VidaAlteradaTexto;
    [SerializeField] private TextMeshProUGUI ManaAlteradaTexto;
    [SerializeField] private TextMeshProUGUI SaniAlteradaTexto;

    [SerializeField] private Button btnPerderVida;
    [SerializeField] private Button btnGanharVida;
    [SerializeField] private Button btnPerderMana;
    [SerializeField] private Button btnGanharMana;
    [SerializeField] private Button btnPerderSani;
    [SerializeField] private Button btnGanharSani;

    private bool PerderVidaAtivo;
    private bool GanharVidaAtivo;
    private bool PerderManaAtivo;
    private bool GanharManaAtivo;
    private bool PerderSaniAtivo;
    private bool GanharSaniAtivo;

    private float intervaloModificacao = 0.5f;
    private float tempoDecorrido = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        VidaTotal = PlayerPrefs.GetInt("VidaMax");
        ManaTotal = PlayerPrefs.GetInt("ManaMax");
        SanidadeTotal = PlayerPrefs.GetInt("SaniMax");
        
        VidaAtual = PlayerPrefs.GetInt("VidaAtual");
        ManaAtual = PlayerPrefs.GetInt("ManaAtual");
        SaniAtual = PlayerPrefs.GetInt("SaniAtual");

        if (VidaAtual > VidaTotal){
            VidaAtual = VidaTotal;
        }
        if (VidaAtual == VidaTotal){
            VidaAtualTexto.text = "Completo";
        } else if (VidaAtual == 0) {
            VidaAtualTexto.text = "Desmaiado";
        } else {
            VidaAtualTexto.text = VidaAtual.ToString();
        }

        if (ManaAtual > ManaTotal){
            ManaAtual = ManaTotal;
        }
        if (ManaAtual == ManaTotal){
            ManaAtualTexto.text = "Completo";
        } else if (ManaAtual == 0) {
            ManaAtualTexto.text = "Sem Mana";
        } else {
            ManaAtualTexto.text = ManaAtual.ToString();
        }

        if (VidaAtual > SanidadeTotal){
            SaniAtual = SanidadeTotal;
        }
        if (SaniAtual == SanidadeTotal){
            SaniAtualTexto.text = "Completo";
        } else if (SaniAtual == 0) {
            SaniAtualTexto.text = "Exausto";
        } else {
            SaniAtualTexto.text = SaniAtual.ToString();
        }

        BarraVida.fillAmount = VidaAtual / VidaTotal;
        BarraMana.fillAmount = ManaAtual / ManaTotal;
        BarraSanidade.fillAmount = SaniAtual / SanidadeTotal;

        VidaAlterada = 0;
        ManaAlterada = 0;
        SaniAlterada = 0;
    }

    void Update()
    {
        tempoDecorrido += Time.deltaTime;

        if (tempoDecorrido >= intervaloModificacao){
        if (!Input.GetButton("Fire1") && PerderVidaAtivo && tempoDecorrido >= intervaloModificacao)
        {
            PerderVida ();
            btnPerderVida.enabled = false;
            btnGanharVida.enabled = false;
            btnPerderMana.enabled = false;
            btnGanharMana.enabled = false;
            btnPerderSani.enabled = false;
            btnGanharSani.enabled = false;
            tempoDecorrido = 0.0f;
        }
        if (!Input.GetButton("Fire1") && GanharVidaAtivo && tempoDecorrido >= intervaloModificacao)
        {
            GanharVida ();
            btnPerderVida.enabled = false;
            btnGanharVida.enabled = false;
            btnPerderMana.enabled = false;
            btnGanharMana.enabled = false;
            btnPerderSani.enabled = false;
            btnGanharSani.enabled = false;
            tempoDecorrido = 0.0f;
        }
        if (!Input.GetButton("Fire1") && PerderManaAtivo && tempoDecorrido >= intervaloModificacao)
        {
            PerderMana ();
            btnPerderVida.enabled = false;
            btnGanharVida.enabled = false;
            btnPerderMana.enabled = false;
            btnGanharMana.enabled = false;
            btnPerderSani.enabled = false;
            btnGanharSani.enabled = false;
            tempoDecorrido = 0.0f;
        }
        if (!Input.GetButton("Fire1") && GanharManaAtivo && tempoDecorrido >= intervaloModificacao)
        {
            GanharMana ();
            btnPerderVida.enabled = false;
            btnGanharVida.enabled = false;
            btnPerderMana.enabled = false;
            btnGanharMana.enabled = false;
            btnPerderSani.enabled = false;
            btnGanharSani.enabled = false;
            tempoDecorrido = 0.0f;
        }
        if (!Input.GetButton("Fire1") && PerderSaniAtivo && tempoDecorrido >= intervaloModificacao)
        {
            PerderSanidade ();
            btnPerderVida.enabled = false;
            btnGanharVida.enabled = false;
            btnPerderMana.enabled = false;
            btnGanharMana.enabled = false;
            btnPerderSani.enabled = false;
            btnGanharSani.enabled = false;
            tempoDecorrido = 0.0f;
        }
        if (!Input.GetButton("Fire1") && GanharSaniAtivo && tempoDecorrido >= intervaloModificacao)
        {
            GanharSanidade ();
            btnPerderVida.enabled = false;
            btnGanharVida.enabled = false;
            btnPerderMana.enabled = false;
            btnGanharMana.enabled = false;
            btnPerderSani.enabled = false;
            btnGanharSani.enabled = false;
            tempoDecorrido = 0.0f;
        }
        }

        if (Input.GetButton("Fire1") && (PerderVidaAtivo == true || GanharVidaAtivo == true || PerderManaAtivo == true || GanharManaAtivo == true || PerderSaniAtivo == true || GanharSaniAtivo == true))
        {
            btnPerderVida.enabled = true;
            btnGanharVida.enabled = true;
            btnPerderMana.enabled = true;
            btnGanharMana.enabled = true;
            btnPerderSani.enabled = true;
            btnGanharSani.enabled = true;
            PerderVidaAtivo = false;
            GanharVidaAtivo = false;
            PerderManaAtivo = false;
            GanharManaAtivo = false;
            PerderSaniAtivo = false;
            GanharSaniAtivo = false;
            VidaAlterada = 0;
            ManaAlterada = 0;
            SaniAlterada = 0;
        }
        
        if (!PerderVidaAtivo && !GanharVidaAtivo && !PerderManaAtivo && !GanharManaAtivo && !PerderSaniAtivo && !GanharSaniAtivo)
        {
            if(VidaAtual < VidaTotal) {btnGanharVida.enabled = true;}
            if(VidaAtual > 0){btnPerderVida.enabled = true;}
            if(ManaAtual < ManaTotal){btnGanharMana.enabled = true;}
            if(ManaAtual > 0){btnPerderMana.enabled = true;}
            if(SaniAtual < SanidadeTotal){btnGanharSani.enabled = true;}
            if(SaniAtual > 0){btnPerderSani.enabled = true;}
            VidaAlterada = 0;
            ManaAlterada = 0;
            SaniAlterada = 0;
            VidaAlteradaTexto.enabled = false;
            ManaAlteradaTexto.enabled = false;
            SaniAlteradaTexto.enabled = false;
        }
    }

    public void PerderVida ()
    {
        PerderVidaAtivo = true;
        btnGanharVida.enabled = true;
        tempoDecorrido = 0.0f;
        VidaAlteradaTexto.enabled = true;
        if (VidaAtual == 1)
        {
            VidaAlterada -= 1;
            VidaAlteradaTexto.text = VidaAlterada.ToString();
            VidaAtual -= 1;
            BarraVida.fillAmount = VidaAtual / VidaTotal;
            VidaAtt = (int)VidaAtual;
            VidaAtualTexto.text = "Desmaiado";
            btnPerderVida.enabled = false;
            PlayerPrefs.SetInt("VidaAtual", VidaAtt);
            PerderVidaAtivo = false;
        } else {
            VidaAlterada -= 1;
            VidaAlteradaTexto.text = VidaAlterada.ToString();
            VidaAtual -= 1;
            BarraVida.fillAmount = VidaAtual / VidaTotal;
            VidaAtt = (int)VidaAtual;
            VidaAtualTexto.text = VidaAtual.ToString();
            PlayerPrefs.SetInt("VidaAtual", VidaAtt);
        }
    }
    public void GanharVida ()
    {
        GanharVidaAtivo = true;
        btnPerderVida.enabled = true;
        tempoDecorrido = 0.0f;
        VidaAlteradaTexto.enabled = true;
        if (VidaAtual == VidaTotal - 1){
            VidaAlterada += 1;
            VidaAlteradaTexto.text = "+" + VidaAlterada.ToString();
            VidaAtual += 1;
            BarraVida.fillAmount = VidaAtual / VidaTotal;
            VidaAtt = (int)VidaAtual;
            VidaAtualTexto.text = "Completo";
            btnGanharVida.enabled = false;
            PlayerPrefs.SetInt("VidaAtual", VidaAtt);
            GanharVidaAtivo = false;
        } else {
            VidaAlterada += 1;
            VidaAlteradaTexto.text = "+" + VidaAlterada.ToString();
            VidaAtual += 1;
            BarraVida.fillAmount = VidaAtual / VidaTotal;
            VidaAtt = (int)VidaAtual;
            VidaAtualTexto.text = VidaAtual.ToString();
            PlayerPrefs.SetInt("VidaAtual", VidaAtt);
        }
    }
    
    public void PerderMana ()
    {
        PerderManaAtivo = true;
        btnGanharMana.enabled = true;
        tempoDecorrido = 0.0f;
        ManaAlteradaTexto.enabled = true;
        if (ManaAtual == 1){
            ManaAlterada -=1;
            ManaAlteradaTexto.text = ManaAlterada.ToString();
            ManaAtual -= 1;
            BarraMana.fillAmount = ManaAtual / ManaTotal;
            ManaAtt = (int)ManaAtual;
            ManaAtualTexto.text = "Sem Mana";
            btnPerderMana.enabled = false;
            PlayerPrefs.SetInt("ManaAtual", ManaAtt);
            PerderManaAtivo = false;
        } else {
            ManaAlterada -=1;
            ManaAlteradaTexto.text = ManaAlterada.ToString();
            ManaAtual -= 1;
            BarraMana.fillAmount = ManaAtual / ManaTotal;
            ManaAtt = (int)ManaAtual;
            ManaAtualTexto.text = ManaAtual.ToString();
            PlayerPrefs.SetInt("ManaAtual", ManaAtt);
        }
    }
    public void GanharMana ()
    {
        GanharManaAtivo = true;
        btnPerderMana.enabled = true;
        tempoDecorrido = 0.0f;
        ManaAlteradaTexto.enabled = true;
        if (ManaAtual == ManaTotal - 1){
            ManaAlterada +=1;
            ManaAlteradaTexto.text = "+" + ManaAlterada.ToString();
            ManaAtual += 1;
            BarraMana.fillAmount = ManaAtual / ManaTotal;
            ManaAtt = (int)ManaAtual;
            ManaAtualTexto.text = "Completo";
            btnGanharMana.enabled = false;
            PlayerPrefs.SetInt("ManaAtual", ManaAtt);
            GanharManaAtivo = false;
        } else {
            ManaAlterada +=1;
            ManaAlteradaTexto.text = "+" + ManaAlterada.ToString();
            ManaAtual += 1;
            BarraMana.fillAmount = ManaAtual / ManaTotal;
            ManaAtt = (int)ManaAtual;
            ManaAtualTexto.text = ManaAtual.ToString();
            PlayerPrefs.SetInt("ManaAtual", ManaAtt);
        }
    }
    
    public void PerderSanidade ()
    {
        PerderSaniAtivo = true;
        btnGanharSani.enabled = true;
        tempoDecorrido = 0.0f;
        SaniAlteradaTexto.enabled = true;
        if (SaniAtual == 1){
            SaniAlterada -= 1;
            SaniAlteradaTexto.text = SaniAlterada.ToString();
            SaniAtual -= 1;
            BarraSanidade.fillAmount = SaniAtual / SanidadeTotal;
            SaniAtt = (int)SaniAtual;
            SaniAtualTexto.text = "Exausto";
            btnPerderSani.enabled = false;
            PlayerPrefs.SetInt("SaniAtual", SaniAtt);
            PerderSaniAtivo = false;
        } else {
            SaniAlterada -= 1;
            SaniAlteradaTexto.text = SaniAlterada.ToString();
            SaniAtual -= 1;
            BarraSanidade.fillAmount = SaniAtual / SanidadeTotal;
            SaniAtt = (int)SaniAtual;
            SaniAtualTexto.text = SaniAtual.ToString();
            PlayerPrefs.SetInt("SaniAtual", SaniAtt);
        }
    }
    public void GanharSanidade ()
    {
        GanharSaniAtivo = true;
        btnPerderSani.enabled = true;
        tempoDecorrido = 0.0f;
        SaniAlteradaTexto.enabled = true;
        if (SaniAtual == SanidadeTotal - 1){
            SaniAlterada += 1;
            SaniAlteradaTexto.text = "+" + SaniAlterada.ToString();
            SaniAtual += 1;
            BarraSanidade.fillAmount = SaniAtual / SanidadeTotal;
            SaniAtt = (int)SaniAtual;
            SaniAtualTexto.text = "Completo";
            btnGanharSani.enabled = false;
            PlayerPrefs.SetInt("SaniAtual", SaniAtt);
            GanharSaniAtivo = false;
        } else {
            SaniAlterada += 1;
            SaniAlteradaTexto.text = "+" + SaniAlterada.ToString();
            SaniAtual += 1;
            BarraSanidade.fillAmount = SaniAtual / SanidadeTotal;
            SaniAtt = (int)SaniAtual;
            SaniAtualTexto.text = SaniAtual.ToString();
            PlayerPrefs.SetInt("SaniAtual", SaniAtt);
        }
    }
}
