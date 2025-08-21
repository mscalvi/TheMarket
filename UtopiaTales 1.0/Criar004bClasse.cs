using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Criar004bClasse : MonoBehaviour
{
    public static bool ConfirmarEscolhaClasse;
    private string ClassePersonagem;
    
    [SerializeField] private Button BtnConfirmar;
    [SerializeField] private Sprite BotaoBloqueado;
    [SerializeField] private Sprite BotaoConfirmar;
    [SerializeField] private Sprite BotaoCalculando;

    [SerializeField] private TextMeshProUGUI NomeClasse;
    [SerializeField] private TextMeshProUGUI DescClasse;

    // Start is called before the first frame update
    void Start()
    {
        ConfirmarEscolhaClasse = false;

        NomeClasse.enabled = false;
        DescClasse.enabled = false;

        BtnConfirmar.enabled = false;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoBloqueado;
    }

    public void Soldados () 
    {
        LiberarPainel ();
        NomeClasse.text = "Soldado";
        ClassePersonagem = "Aprendiz de Soldado";
        DescClasse.text = "Os Soldados são aqueles treinados no combate direto que não optaram pelo uso da magia. Podem ter aprendido a brigar na rua, ou treinado longas horas em sítios militares, e acabaram por ter o domínio de algum tipo de arma.\n\nAs habilidades dos Soldados vão desde o uso de armamentos com precisão até o posicionamento estratégico durante um combate, e acabam por seguir três vertentes: os Mestres de Armas, que são aqueles que se especializaram no combate corpo-a-corpo, regrado, tenho profundo conhecimento de um equipamento em específico. Os Mestres de Combate são aqueles que preferiram se tornar máquinas de improviso, lidando com o território e o equipamento que tiverem ao alcance. E os Mestres Arqueiros são aqueles especializados no combate de longa distância, se tornando mortais com um arco ou besta.";
    }

    public void Trapaceiros () 
    {
        LiberarPainel ();
        NomeClasse.text = "Trapaceiro";
        ClassePersonagem = "Aprendiz de Trapaceiro";
        DescClasse.text = "Os Trapaceiros são conhecidos por nunca aparentarem o perigo que realmente apresentam. Demonstram sua verdadeira habilidade ao fingirem algo, quer seja aumentando o que realmente são, como os Bardos, diminuindo sua presença, como os Ladinos, ou não necessitarem de armas para brigar, como os Pugilistas.";
    }


    public void Inventores () 
    {
        LiberarPainel ();
        NomeClasse.text = "Inventor";
        ClassePersonagem = "Aprendiz de Inventor";
        DescClasse.text = "Raramente vistos em combates, os Inventores preferem deixar que suas criações os representem, quer seja através de armas e poções fornecidas a seus aliados, ou autômatos e máquinas montadas em campo.\n\nOs Inventores podem se especializar em três áreas diferentes: Alquimistas, capazes de criar poções e elixires para diferentes situações, Artífices, que são capazes de criar máquinas autônomas ou projetar poderosas armas, e ainda Armadilheiros, que projetam armadilhas precisas e multifuncionais, tornando o terreno seu maior aliado.";
    }


    public void Magos () 
    {
        LiberarPainel ();
        NomeClasse.text = "Mago";
        ClassePersonagem = "Aprendiz de Mago";
        DescClasse.text = "Os Magos são caracterizados pela poderosa habilidade de controlar a magia, em pelo menos uma de suas formas e tipos. São capazes de manipular uma das nove formas da magia, tendo aprendido essa arte em uma das grandes escolas ou pelos costumes de tribos.\n\nPodem se tornar Mestres de Invocação, capazes de criar poderosos Gôlens e Elementais, Mestres da Conjuração, sendo capazes de lançar arcos de energia e bolas de fogo, ou ainda Mestres da Transformação, capazes de manipular a realidade diante dos olhos de seus oponentes, levitando objetos e teletransportando.";
    }


    private void LiberarPainel ()
    {
        BtnConfirmar.enabled = true;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoConfirmar;

        NomeClasse.enabled = true;
        DescClasse.enabled = true;
    }

    public void Retornar ()
    {
        SceneManager.LoadScene ("Criar001Especies");
    }

    public void ConfirmarEscolha ()
    {
        ConfirmarEscolhaClasse = true;
        PlayerPrefs.SetString("ClassePersonagem", ClassePersonagem);
        SceneManager.LoadScene ("Criar005Antecedentes");
    }
}
