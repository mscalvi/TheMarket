using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Criar003Atributos : MonoBehaviour
{
    public static bool ConfirmarEscolhaAtributos;
    public static bool RolarAtributos;

    public static int Rolada3 = 0;

    [SerializeField] private TextMeshProUGUI Introducao;

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
    
    [SerializeField] private Button BtnVoltar;
    [SerializeField] private Button BtnRolar;
    [SerializeField] private Button BtnConfirmar;
    [SerializeField] private Sprite BotaoBloqueado;
    [SerializeField] private Sprite BotaoConfirmar;
    [SerializeField] private Sprite BotaoCalculando;

    // Start is called before the first frame update
    void Start()
    {
        ConfirmarEscolhaAtributos = false;
        BtnConfirmar.enabled = false;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoBloqueado;
    }

    public void Rolar ()
    {
        RolarAtributos = true;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoConfirmar;
        BtnConfirmar.enabled = true;
        Introducao.text = "Seus Atributos finais são:";
        Rolada3 += 1;
        
        if (Rolada3 <= 3)
        {
            Constituicao.text = $"Constituição: {NovoPersonagem.aConstituicao} da Espécie + {NovoPersonagem.rConstituicao} da Origem, Total {NovoPersonagem.fConstituicao}.";
            Destreza.text = $"Destreza: {NovoPersonagem.aDestreza} da Espécie + {NovoPersonagem.rDestreza} da Origem, Total {NovoPersonagem.fDestreza}.";
            Forca.text = $"Força: {NovoPersonagem.aForca} da Espécie + {NovoPersonagem.rForca} da Origem, Total {NovoPersonagem.fForca}.";
            Inteligencia.text = $"Inteligência: {NovoPersonagem.aInteligencia} da Espécie + {NovoPersonagem.rInteligencia} da Origem, Total {NovoPersonagem.fInteligencia}."; 
            Magia.text = $"Magia: {NovoPersonagem.aMagia} da Espécie + {NovoPersonagem.rMagia} da Origem, Total {NovoPersonagem.fMagia}.";
            Memoria.text = $"Memória: {NovoPersonagem.aMemoria} da Espécie + {NovoPersonagem.rMemoria} da Origem, Total {NovoPersonagem.fMemoria}.";
            Sensibilidade.text = $"Sensibilidade: {NovoPersonagem.aSensibilidade} da Espécie + {NovoPersonagem.rSensibilidade} da Origem, Total {NovoPersonagem.fSensibilidade}.";
            Velocidade.text = $"Velocidade: {NovoPersonagem.aVelocidade} da Espécie + {NovoPersonagem.rVelocidade} da Origem, Total {NovoPersonagem.fVelocidade}.";
           
            Vida.text = $"Vida: {NovoPersonagem.aVida} da Espécie + {NovoPersonagem.rVida} da Rolagem, Total {NovoPersonagem.fVida}.";
            Mana.text = $"Mana: {NovoPersonagem.aMana} da Espécie + {NovoPersonagem.rMana} da Rolagem, Total {NovoPersonagem.fMana}.";
            Sanidade.text = $"Sanidade: {NovoPersonagem.aSanidade} da Espécie + {NovoPersonagem.rSanidade} da Rolagem, Total {NovoPersonagem.fSanidade}.";
            
            Criar002Origem.ConfirmarEscolhaOrigem = true;
        } 
        if (Rolada3 == 3) {
            BtnRolar.enabled = false;
            BtnRolar.GetComponent<Image>().sprite = BotaoBloqueado;
        }
    }

    public void Retornar ()
    {
        SceneManager.LoadScene ("Criar001Especies");
    }

    public void ConfirmarEscolha ()
    {
        ConfirmarEscolhaAtributos = true;
        NovoPersonagem.CalculosCompletos = false;
        StartCoroutine ("Calculando");
    }

    IEnumerator Calculando ()
    {
        BtnConfirmar.GetComponent<Image>().sprite = BotaoCalculando;
        yield return new WaitForSeconds(3);
        if (NovoPersonagem.CalculosCompletos == true)
        {
            if (NovoPersonagem.SuperMemoria > 0)
            {
                SceneManager.LoadScene ("Criar004aMemoria");
            } else {
                SceneManager.LoadScene ("Criar004bClasse");
            }
        }
    }
}
