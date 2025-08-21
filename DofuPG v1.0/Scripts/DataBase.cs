using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Habilidade
{
    public string nome;
    public string custo;
    public string teste;
    public string tipo;
    public string alcance;
    public string descricao;
    public bool usaElementos;
    public List<string> variacaoElemento; // [0] = Não Possui, [1] = Fogo, [2] = Terra, [3] = Ar, [4] = Água

    public string GetDescricaoPorElemento(int elemento)
    {
        if (elemento >= 1 && elemento < variacaoElemento.Count)
            return variacaoElemento[elemento];
        return variacaoElemento[0];
    }
}

[System.Serializable]
public class DadosClasse
{
    public string nome;
    public string descricaoGeral;
    public List<Habilidade> habilidades;
    public List<string> variacaoElemento; // [0] = Não Possui, [1] = Fogo, [2] = Terra, [3] = Ar, [4] = Água

    public string GetDescricaoPorElemento(int elemento)
    {
        if (elemento >= 1 && elemento < variacaoElemento.Count)
            return variacaoElemento[elemento];
        return variacaoElemento[0];
    }
}

public class DataBase : MonoBehaviour
{
    public List<DadosClasse> classes;

    void Awake()
    {
        classes = new List<DadosClasse>();

        #region Eniripsa
        DadosClasse eni = new DadosClasse();
        eni.nome = "Eniripsa";
        eni.descricaoGeral = "Pequenos vampiros, são capazes de roubar grandes quantidades de vida de seus inimigos, e redistribuí-las entre os aliados. Costumam combater utilizando varinhas mágicas. Mestres em curas e controle da vitalidade.";
        eni.variacaoElemento = new List<string>
        {
            "Fogo: especialista em curar outros alvos.",
            "Terra: capazes de curar outros alvos e a si mesmos.",
            "Ar: especialistas em curar a si mesmos, principalmente através do roubo de vida.",
            "Água: capazes de curar outros e roubar vida para si, com um crescimento progressivo de acordo com a própria vitalidade."
        }
        ;

        eni.habilidades = new List<Habilidade>();

        // Habilidade: Palavra de Cura
        Habilidade cura = new Habilidade();
        cura.nome = "Palavra de Cura";
        cura.custo = "4 PA";
        cura.teste = "Arcanismo";
        cura.tipo = "Divino";
        cura.alcance = "Alcance 4 - Alvo";
        cura.descricao = "Com a palma de sua mão, ou com seu canalizador mágico, você lança seu Wakfu através de uma esfera de energia curativa, com efeitos adicionais de acordo com o elemento. Não pode curar a si mesmo.";
        cura.usaElementos = true;
        cura.variacaoElemento = new List<string>
        {
            "Fogo: cura o alvo em FOGOd6.",
            "Terra: cura o alvo em TERRAd4.",
            "Ar: cura o alvo em ARd2.",
            "Água: cura você em 5% da sua vida máxima, e outros alvos em 10% da sua vida atual."
        };
        eni.habilidades.Add(cura);

        // Habilidade: Palavra Vampira
        Habilidade vamp = new Habilidade();
        vamp.nome = "Palavra Vampira";
        vamp.custo = "6 PA";
        vamp.teste = "Carisma";
        vamp.tipo = "Divino";
        vamp.alcance = "Alcance 1 - Alvo";
        vamp.descricao = "Com a palma de sua mão, ou com seu canalizador mágico, você encosta no alvo e rouba vida de acordo com seu elemento.";
        vamp.usaElementos = true;
        vamp.variacaoElemento = new List<string>
        {
            "Fogo: rouba FOGOd2 do alvo.",
            "Terra: rouba TERRAd4 do alvo.",
            "Ar: rouba ARd6 do alvo.",
            "Água: rouba igual a 10% da sua vida máxima."
        };
        eni.habilidades.Add(vamp);


        classes.Add(eni);

        #endregion
    }
}
