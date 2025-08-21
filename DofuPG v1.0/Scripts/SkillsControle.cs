using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillsControle : MonoBehaviour
{
    int clsSelecionada = -1; // -1 = nenhuma selecionada
    int sklaSelecionada = -1;
    int sklpSelecionada = -1;
    int eleSelecionada = -1;
    public TextMeshProUGUI TxtSkillName;
    public TextMeshProUGUI TxtSkillCost;
    public TextMeshProUGUI TxtSkillTest;
    public TextMeshProUGUI TxtSkillType;
    public TextMeshProUGUI TxtSkillRange;
    public TextMeshProUGUI TxtSkillDescricao;
    public TextMeshProUGUI TxtSkillVariation;
    public GameObject painelDescricao;
    public GameObject painelVariacao;
    public Toggle upgrade;
    public DataBase db;
    private List<DadosClasse> dadosClasses;


    // Start is called before the first frame update
    void Start()
    {
        AtualizarTela();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SelecionarClasse (int idClasse)
    { 
        clsSelecionada = idClasse;
        sklaSelecionada = -1;
        sklpSelecionada = -1;
        eleSelecionada = -1;
        AtualizarTela();
    }

    public void SelecionarPassiva (int idSkill)
    { 
        sklpSelecionada = idSkill;
        eleSelecionada = -1;
        AtualizarTela();
    }

    public void SelecionarAtiva (int idSkill)
    { 
        sklaSelecionada = idSkill;
        eleSelecionada = -1;
        AtualizarTela();
    }

    public void SelecionarElemento (int idElemento)
    { 
        eleSelecionada = idElemento;
        AtualizarTela();
    }

    void AtualizarTela()
    {
        if (clsSelecionada < 0)
        {
            painelDescricao.SetActive(false);
            return;
        } 
        else 
        {
            painelDescricao.SetActive(true);
        }

        if (sklpSelecionada < 0 && sklaSelecionada < 0)
        {
            // Mostrar descrição geral da classe
            TxtSkillCost.text = "";
            TxtSkillTest.text = "";
            TxtSkillType.text = "";
            TxtSkillRange.text = "";
            upgrade.gameObject.SetActive(false);

            painelVariacao.SetActive(true); 
            TxtSkillName.text = db.classes[clsSelecionada].nome;
            TxtSkillDescricao.text = db.classes[clsSelecionada].descricaoGeral;
            TxtSkillVariation.text = db.classes[clsSelecionada].GetDescricaoPorElemento(eleSelecionada);
        } 
        else 
        {
            var habilidadeMostrada = db.classes[clsSelecionada].habilidades[0];
            if (sklpSelecionada < 0){
                habilidadeMostrada = db.classes[clsSelecionada].habilidades[sklaSelecionada];
            } else {
                habilidadeMostrada = db.classes[clsSelecionada].habilidades[sklpSelecionada];
            }
            painelVariacao.SetActive(habilidadeMostrada.usaElementos);
            
            TxtSkillName.text = habilidadeMostrada.nome;
            TxtSkillCost.text = habilidadeMostrada.custo;
            TxtSkillTest.text = habilidadeMostrada.teste;
            TxtSkillType.text = habilidadeMostrada.tipo;
            TxtSkillRange.text = habilidadeMostrada.alcance;
            TxtSkillDescricao.text = habilidadeMostrada.descricao;
            TxtSkillVariation.text = habilidadeMostrada.GetDescricaoPorElemento(eleSelecionada);

        }
    }
}
