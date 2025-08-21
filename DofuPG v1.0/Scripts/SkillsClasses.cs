using UnityEngine;
using UnityEngine.UI;

public class SkillsBotao : MonoBehaviour
{
    public enum TipoBotao { Classe, Passiva, Ativa, Elemento }

    public TipoBotao tipo;
    public int id;
    public SkillsControle controlador;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(AcaoDoBotao);
    }

    void AcaoDoBotao()
    {
        switch (tipo)
        {
            case TipoBotao.Classe:
                controlador.SelecionarClasse(id);
                break;
            case TipoBotao.Passiva:
                controlador.SelecionarPassiva(id);
                break;
            case TipoBotao.Ativa:
                controlador.SelecionarAtiva(id);
                break;
            case TipoBotao.Elemento:
                controlador.SelecionarElemento(id);
                break;
        }
    }
}
