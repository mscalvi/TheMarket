using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Criar005Antecedentes : MonoBehaviour
{
    public static bool ConfirmarEscolhaAntecedentes;
    
    [SerializeField] private Button BtnConfirmar;
    [SerializeField] private Sprite BotaoBloqueado;
    [SerializeField] private Sprite BotaoConfirmar;
    [SerializeField] private Sprite BotaoCalculando;
    
    private int PtsNegativos;
    private int PtsPositivos;
    private int PtsTotais;

    [SerializeField] private TextMeshProUGUI TituloAnte;
    [SerializeField] private TextMeshProUGUI DescAnte;
    [SerializeField] private TextMeshProUGUI Negativos;
    [SerializeField] private TextMeshProUGUI Positivos;
    [SerializeField] private TextMeshProUGUI Total;

    [SerializeField] private Toggle XAleijado;
    [SerializeField] private Toggle XCovarde;
    [SerializeField] private Toggle XHemofobico;
    [SerializeField] private Toggle XAnalfabeto;
    [SerializeField] private Toggle XAnsioso;
    [SerializeField] private Toggle XMagifobico;
    [SerializeField] private Toggle XPobre;
    [SerializeField] private Toggle XImpulsivo;
    [SerializeField] private Toggle XPapas;
    [SerializeField] private Toggle XViciado;
    [SerializeField] private Toggle XAtrapalhado;
    [SerializeField] private Toggle XNanismo;
    [SerializeField] private Toggle XGigantismo;

    [SerializeField] private Toggle XEspecial;
    [SerializeField] private Toggle XExpoente;
    [SerializeField] private Toggle XGenio;
    [SerializeField] private Toggle XAmbidestro;
    [SerializeField] private Toggle XRico;
    [SerializeField] private Toggle XNobre;
    [SerializeField] private Toggle XColetor;
    [SerializeField] private Toggle XCircense;
    [SerializeField] private Toggle XAtleta;
    [SerializeField] private Toggle XFazenda;
    [SerializeField] private Toggle XEstudado;
    [SerializeField] private Toggle XTrombadinha;
    [SerializeField] private Toggle XNormal;

    List<string> ListaAntecedentes = new List<string>();
    private string ListaCompleta;

    // Start is called before the first frame update
    void Start()
    {
        ConfirmarEscolhaAntecedentes = false;

        TituloAnte.enabled = false;
        DescAnte.enabled = false;

        PtsNegativos = 0;
        PtsPositivos = 0;

        Negativos.text = "Negativos: 0";
        Positivos.text = "Positivos: 0";
        Total.text = "Total: 0";

        XNormal.isOn = true;
        XNormal.enabled = false;

        BtnConfirmar.enabled = false;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoBloqueado;
        
    }

    void Update ()
    {
        Negativos.text = "Negativos: " + PtsNegativos.ToString();
        Positivos.text = "Positivos: " + PtsPositivos.ToString();

        PtsTotais = PtsPositivos - PtsNegativos;
        Total.text = "Total: " + PtsTotais.ToString();

        if (ConfirmarEscolhaAntecedentes == false)
        {
            if (PtsTotais <= 0)
            {
                if (PtsNegativos == 0 && PtsPositivos == 0)
                {
                    BtnConfirmar.enabled = false;
                    BtnConfirmar.GetComponent<Image>().sprite = BotaoBloqueado;
                }
                BtnConfirmar.enabled = true;
                BtnConfirmar.GetComponent<Image>().sprite = BotaoConfirmar;
            } else {
                BtnConfirmar.enabled = false;
                BtnConfirmar.GetComponent<Image>().sprite = BotaoBloqueado;
            }
        }

    }

    public void FAleijado () 
    {
        LiberarPainel ();
        TituloAnte.text = "Aleijado, 5";
        DescAnte.text = "Você não possui um dos braços ou pernas, sofrendo debilidades relevantes, como movimentação reduzida, capacidade de carregar peso e objetos reduzidas, ou ainda a manipulação de armas e equipamentos.";
        if (XAleijado.isOn) {
            PtsNegativos += 5;
            PlayerPrefs.SetInt ("AAleijado", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsNegativos -= 5;
            PlayerPrefs.SetInt ("AAleijado", 0);
        }
    }

    public void FCovarde () 
    {
        LiberarPainel ();
        TituloAnte.text = "Covarde, 4";
        DescAnte.text = "Você sempre foge na hora da ação e do conflito. Você não pode iniciar um combate ou se postar de forma ofensiva contra um oponente. Você sempre é o último a agir em um combate, e ao receber um golpe deverá se afastar pelo menos três metros (duas casas) do atacante.";
        if (XCovarde.isOn) {
            PtsNegativos += 4;
            PlayerPrefs.SetInt ("ACovarde", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsNegativos -= 4;
            PlayerPrefs.SetInt ("ACovarde", 0);
        }
    }

    public void  FHemofobico() 
    {
        LiberarPainel ();
        TituloAnte.text = "Hemofóbico, 4";
        DescAnte.text = "Você tem medo de sangue, principalmente do seu. Você não pode fazer testes de Primeiros Socorros. Caso sofra um ferimento você precisará passar em um teste de Concentração, dificuldade 10, para voltar a agir normalmente. O teste é refeito a cada ferimento, com dificuldade -1";
        if (XHemofobico.isOn) {
            PtsNegativos += 4;
            PlayerPrefs.SetInt ("AHemofobico", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsNegativos -= 4;
            PlayerPrefs.SetInt ("AHemofobico", 0);
        }
    }

    public void FAnalfabeto () 
    {
        LiberarPainel ();
        TituloAnte.text = "Analfabeto, 3";
        DescAnte.text = "Você não sabe ler nem escrever. Em nenhum idioma.";
        if (XAnalfabeto.isOn) {
            PtsNegativos += 3;
            PlayerPrefs.SetInt ("AAnalfabeto", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsNegativos -= 3;
            PlayerPrefs.SetInt ("AAnalfabeto", 0);
        }
    }
    
    public void FAnsioso () 
    {
        LiberarPainel ();
        TituloAnte.text = "Ansioso, 3";
        DescAnte.text = "Você não pode fazer Descansos Completos.";
        if (XAnsioso.isOn) {
            PtsNegativos += 3;
            PlayerPrefs.SetInt ("AAnsioso", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
            XViciado.isOn = false;
        } else {
            PtsNegativos -= 3;
            PlayerPrefs.SetInt ("AAnsioso", 0);
        }
    }
    
    public void FPobre () 
    {
        LiberarPainel ();
        TituloAnte.text = "Pobre, 3";
        DescAnte.text = "Você começa o jogo com um terço do dinheiro inicial normal.";
        if (XPobre.isOn) {
            PtsNegativos += 3;
            PlayerPrefs.SetInt ("APobre", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
            XRico.isOn = false;
        } else {
            PtsNegativos -= 3;
            PlayerPrefs.SetInt ("APobre", 0);
        }
    }
    
    public void FMagifobico () 
    {
        LiberarPainel ();
        TituloAnte.text = "Magifóbico, 2";
        DescAnte.text = "Você não suporta determinado tipo de magia, escolhido aleatoriamente, e morre de medo dela. Você não pode fazer ações contra um usuário desse tipo, nem mesmo aliados enquanto estiverem utilizando a magia. Você não poderá utilizar magias desse tipo, e se obtiver tal magia perderá 50% de sua Sanidade Máxima.";
        if (XMagifobico.isOn) {
            PtsNegativos += 2;
            PlayerPrefs.SetInt ("AMagifobico", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsNegativos -= 2;
            PlayerPrefs.SetInt ("AMagifobico", 0);
        }
    }
    
    public void FImpulsivo () 
    {
        LiberarPainel ();
        TituloAnte.text = "Impulsivo, 2";
        DescAnte.text = "Você toma ações sem pensar muito. Você deve gastar todo o seu dinheiro inicial, e comprar pelo menos dois itens repetidos. Você deve, obrigatoriamente, começar um combate atacando ou correndo em direção ao inimigo.";
        if (XImpulsivo.isOn) {
            PtsNegativos += 2;
            PlayerPrefs.SetInt ("AImpulsivo", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsNegativos -= 2;
            PlayerPrefs.SetInt ("AImpulsivo", 0);
        }
    }
    
    public void FPapas () 
    {
        LiberarPainel ();
        TituloAnte.text = "Sem Papas na Língua, 2";
        DescAnte.text = "Você fala o que pensa, e por vezes fala mais do que devia. Você recebe -2 em Carisma.";
        if (XPapas.isOn) {
            PtsNegativos += 2;
            PlayerPrefs.SetInt ("APapas", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsNegativos -= 2;
            PlayerPrefs.SetInt ("APapas", 0);
        }
    }
    
    public void FViciado () 
    {
        LiberarPainel ();
        TituloAnte.text = "Viciado, 2";
        DescAnte.text = "Você começa o jogo com 20x Erva de Fumo e 20% de dinheiro a menos. Você deve consumir uma Erva de Fumo, ou equivalente, em todo Descanso Completo, ou ele contará como Descanso Simples.";
        if (XViciado.isOn) {
            PtsNegativos += 2;
            PlayerPrefs.SetInt ("AViciado", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
            XAnsioso.isOn = false;
        } else {
            PtsNegativos -= 2;
            PlayerPrefs.SetInt ("AViciado", 0);
        }
    }
    
    public void FAtrapalhado () 
    {
        LiberarPainel ();
        TituloAnte.text = "Atrapalhado, 1";
        DescAnte.text = "Você é bastante atrapalhado, e sempre acaba derrubando objetos ou fazendo barulho atoa. Você recebe -3 em Furtividade.";
        if (XAtrapalhado.isOn) {
            PtsNegativos += 1;
            PlayerPrefs.SetInt ("AAtrapalhado", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsNegativos -= 1;
            PlayerPrefs.SetInt ("AAtrapalhado", 0);
        }
    }
    
    public void FNanismo () 
    {
        LiberarPainel ();
        TituloAnte.text = "Nanismo, 1";
        DescAnte.text = "Você está consideravelmente abaixo da estatura média de sua espécie. Seu personagem subtrai o dado de altura, ao invés de somá-lo.";
        if (XNanismo.isOn) {
            PtsNegativos += 1;
            PlayerPrefs.SetInt ("ANanismo", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
            XGigantismo.isOn = false;
        } else {
            PtsNegativos -= 1;
            PlayerPrefs.SetInt ("ANanismo", 0);
        }
    }
    
    public void FGigantismo () 
    {
        LiberarPainel ();
        TituloAnte.text = "Gigantismo, 1";
        DescAnte.text = "Você está consideravelmente acima da estatura média de sua espécie. Some o valor de um dado cheio a sua rolagem de altura na criação do personagem.";
        if (XGigantismo.isOn) {
            PtsNegativos += 1;
            PlayerPrefs.SetInt ("AGigantismo", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
            XNanismo.isOn = false;
        } else {
            PtsNegativos -= 1;
            PlayerPrefs.SetInt ("AGigantismo", 0);
        }
    }
    
    public void FEspecial() 
    {
        LiberarPainel ();
        TituloAnte.text = "Especial, 5";
        DescAnte.text = "Você nasceu diferente do padrão de sua espécie, e possui características únicas. Redistribua seus atributos, escolhendo dois para terem valor inicial 13, três para terem valor inicial 3, e os demais com valor inicial 8. Sua Vida inicial será proporcional a sua Constituição: 20 se for igual a 3, 35 se for de 8, e 50 se for igual ou superior a 13. Faça o mesmo para sua Mana, utilizando Magia. Para a Sanidade utilize sua Sensibilidade, se for igual a 3 serão 20 pontos, igual a 8 serão 35, e igual a 13 serão 50 pontos. Adicione 1d4 a todos os Atributos, com exceção de um, que adicionará 1d4+1, e um que adicionará 1d4-1, e depois 1d10 em cada Condição.";
        if (XEspecial.isOn) {
            PtsPositivos += 5;
            PlayerPrefs.SetInt ("AEspecial", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsPositivos -= 5;
            PlayerPrefs.SetInt ("AEspecial", 0);
        }
    }

    public void FExpoente () 
    {
        LiberarPainel ();
        TituloAnte.text = "Expoente, 5";
        DescAnte.text = "Você é um membro raro de sua espécie, um prodígio em sua sociedade, e recebe uma habilidade adicional, descrita na página da espécie.";
        if (XExpoente.isOn) {
            PtsPositivos += 5;
            PlayerPrefs.SetInt ("AExpoente", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsPositivos -= 5;
            PlayerPrefs.SetInt ("AExpoente", 0);
        }
    }

    public void FGenio () 
    {
        LiberarPainel ();
        TituloAnte.text = "Genio, 5";
        DescAnte.text = "Você é um gênio em sua Classe, e começa o jogo com uma Habilidade Exclusiva, que seja relevante a ela, podendo levar em conta sua espécie. A Habilidade é desenvolvida em conjunto com o Mestre.";
        if (XGenio.isOn) {
            PtsPositivos += 5;
            PlayerPrefs.SetInt ("AGenio", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsPositivos -= 5;
            PlayerPrefs.SetInt ("AGenio", 0);
        }
    }

    public void FAmbidestro () 
    {
        LiberarPainel ();
        TituloAnte.text = "Ambidestro, 4";
        DescAnte.text = "Você sabe usar as duas mãos com maestria. Você começa com +1 Nível na Proficiência Combate com a Segunda Mão.";
        if (XAmbidestro.isOn) {
            PtsPositivos += 4;
            PlayerPrefs.SetInt ("AAmbidestro", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsPositivos -= 4;
            PlayerPrefs.SetInt ("AAmbidestro", 0);
        }
    }

    public void FRico () 
    {
        LiberarPainel ();
        TituloAnte.text = "Rico, 4";
        DescAnte.text = "Você vem de uma família rica, ou conseguiu seu próprio dinheiro sozinho. Você começa o jogo o dobro de dinheiro que o padrão inicial.";
        if (XRico.isOn) {
            PtsPositivos += 4;
            PlayerPrefs.SetInt ("ARico", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
            XPobre.isOn = false;
        } else {
            PtsPositivos -= 4;
            PlayerPrefs.SetInt ("ARico", 0);
        }
    }

    public void FNobre () 
    {
        LiberarPainel ();
        TituloAnte.text = "Nobre, 3";
        DescAnte.text = "Você possui um título de nobreza, e é reconhecido. Você pode contar com um favor, aceitável a situação e ao contactado, a cada Descanso Completo. A situação pode ser revertida durante o jogo, e os favores podem se voltar contra você caso sejam abusivos.";
        if (XNobre.isOn) {
            PtsPositivos += 3;
            PlayerPrefs.SetInt ("ANobre", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsPositivos -= 3;
            PlayerPrefs.SetInt ("ANobre", 0);
        }
    }

    public void FColetor () 
    {
        LiberarPainel ();
        TituloAnte.text = "Coletor, 2";
        DescAnte.text = "Você se declara um colecionador, mas as pessoas só te acham meio doido. Você começa o jogo com 40 recursos Ordinários de Alquimia, de Armadilhas ou de Robótica, e 1 Recurso Específico qualquer, a sua escolha. Os recursos estão disponíveis no pré-mercado.";
        if (XColetor.isOn) {
            PtsPositivos += 2;
            PlayerPrefs.SetInt ("AColetor", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsPositivos -= 2;
            PlayerPrefs.SetInt ("AColetor", 0);
        }
    }

    public void FCircense () 
    {
        LiberarPainel ();
        TituloAnte.text = "Circense, 2";
        DescAnte.text = "Você já participou do circo, ou exerceu alguma profissão que te deu uma grande flexibilidade. Você recebe +2 em Acrobacias e +2 em Carisma.";
        if (XCircense.isOn) {
            PtsPositivos += 2;
            PlayerPrefs.SetInt ("ACircense", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsPositivos -= 2;
            PlayerPrefs.SetInt ("ACircense", 0);
        }
    }

    public void FAtleta () 
    {
        LiberarPainel ();
        TituloAnte.text = "Atleta, 2";
        DescAnte.text = "Você já se exercitou, talvez até em nível profissional. Você recebe +2 em Atletismo e +2 em Equilíbrio.";
        if (XAtleta.isOn) {
            PtsPositivos += 2;
            PlayerPrefs.SetInt ("AAtleta", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsPositivos -= 2;
            PlayerPrefs.SetInt ("AAtleta", 0);
        }
    }

    public void FFazenda () 
    {
        LiberarPainel ();
        TituloAnte.text = "Fazenda, 2";
        DescAnte.text = ". Você viveu no campo, e aprendeu a lidar com os animais. Você tem +2 em Persuasão Animal, e seus animais companheiros recebem +1 Ponto de Atributo.";
        if (XFazenda.isOn) {
            PtsPositivos += 2;
            PlayerPrefs.SetInt ("AFazenda", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsPositivos -= 2;
            PlayerPrefs.SetInt ("AFazenda", 0);
        }
    }

    public void FEstudado () 
    {
        LiberarPainel ();
        TituloAnte.text = "Estudado, 2";
        DescAnte.text = "Você já estudou a sério sobre algum conteúdo. Você tem +3 em algum Conhecimento de sua escolha.";
        if (XEstudado.isOn) {
            PtsPositivos += 2;
            PlayerPrefs.SetInt ("AEstudado", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsPositivos -= 2;
            PlayerPrefs.SetInt ("AEstudado", 0);
        }
    }

    public void FTrombadinha () 
    {
        LiberarPainel ();
        TituloAnte.text = "Trombadinha, 2";
        DescAnte.text = "Você teve uma infância difícil, e aprendeu coisas da pior maneira. Você tem +2 em Reflexo e +1 em Primeiros Socorros.";
        if (XTrombadinha.isOn) {
            PtsPositivos += 2;
            PlayerPrefs.SetInt ("ATrombadinha", 1);
            XNormal.isOn = false;
            XNormal.enabled = true;
        } else {
            PtsPositivos -= 2;
            PlayerPrefs.SetInt ("ATrombadinha", 0);
        }
    }

    public void FNormal () 
    {
        LiberarPainel ();
        if (XNormal.isOn) 
        {
            PlayerPrefs.SetInt ("ANormal", 1);
            XAleijado.isOn = false;
            XCovarde.isOn = false;
            XHemofobico.isOn = false;
            XAnalfabeto.isOn = false;
            XAnsioso.isOn = false;
            XMagifobico.isOn = false;
            XPobre.isOn = false;
            XImpulsivo.isOn = false;
            XPapas.isOn = false;
            XViciado.isOn = false;
            XAtrapalhado.isOn = false;
            XNanismo.isOn = false;
            XGigantismo.isOn = false;
            XEspecial.isOn = false;
            XExpoente.isOn = false;
            XGenio.isOn = false;
            XAmbidestro.isOn = false;
            XRico.isOn = false;
            XNobre.isOn = false;
            XColetor.isOn = false;
            XCircense.isOn = false;
            XAtleta.isOn = false;
            XFazenda.isOn = false;
            XEstudado.isOn = false;
            XTrombadinha.isOn = false;

            XNormal.enabled = false;
        } else {
            PlayerPrefs.SetInt ("ANormal", 0);
        }
            Debug.Log (PlayerPrefs.GetInt("ANormal"));
        TituloAnte.text = "Normal, 0";
        DescAnte.text = "Você sempre foi normal, nada chama atenção no seu passado. Chato, mas e daí?";
    }

    private void LiberarPainel ()
    {
        TituloAnte.enabled = true;
        DescAnte.enabled = true;
    }

    public void PreencherAntecedentes ()
    {
        if (PlayerPrefs.GetInt("AAleijado") == 1) {ListaAntecedentes.Add ("Aleijado"); }
        if (PlayerPrefs.GetInt("ACovarde") == 1) {ListaAntecedentes.Add ("Covarde"); }
        if (PlayerPrefs.GetInt("AHemofobico") == 1) {ListaAntecedentes.Add ("Hemofóbico"); }
        if (PlayerPrefs.GetInt("AAnalfabeto") == 1) {ListaAntecedentes.Add ("Analfabeto"); }
        if (PlayerPrefs.GetInt("AAnsioso") == 1) {ListaAntecedentes.Add ("Ansioso"); }
        if (PlayerPrefs.GetInt("APobre") == 1) {ListaAntecedentes.Add ("Pobre"); }
        if (PlayerPrefs.GetInt("AMagifobico") == 1) {ListaAntecedentes.Add ("Magifóbico"); }
        if (PlayerPrefs.GetInt("AImpulsivio") == 1) {ListaAntecedentes.Add ("Impulsivo"); }
        if (PlayerPrefs.GetInt("APapas") == 1) {ListaAntecedentes.Add ("Sem Papas na Língua");}
        if (PlayerPrefs.GetInt("AViciado") == 1) {ListaAntecedentes.Add ("Viciado em Erva de Fumo"); }
        if (PlayerPrefs.GetInt("AAtrapalhado") == 1) {ListaAntecedentes.Add ("Atrapalhado"); }
        if (PlayerPrefs.GetInt("ANanismo") == 1) {ListaAntecedentes.Add ("Nanismo"); }
        if (PlayerPrefs.GetInt("AGigantismo") == 1) {ListaAntecedentes.Add ("Gigantismo"); }
        if (PlayerPrefs.GetInt("ANormal") == 1) {ListaAntecedentes.Add ("Normal"); }
        if (PlayerPrefs.GetInt("ATrombadinha") == 1) {ListaAntecedentes.Add ("Má Infância"); }
        if (PlayerPrefs.GetInt("AFazenda") == 1) {ListaAntecedentes.Add ("Vida na Fazenda"); }
        if (PlayerPrefs.GetInt("AAtleta") == 1) {ListaAntecedentes.Add ("Atleta"); }
        if (PlayerPrefs.GetInt("AEstudado") == 1) {ListaAntecedentes.Add ("Estudado"); }
        if (PlayerPrefs.GetInt("ACirsense") == 1) {ListaAntecedentes.Add ("Circense"); }
        if (PlayerPrefs.GetInt("AColetor") == 1) {ListaAntecedentes.Add ("Coletor"); }
        if (PlayerPrefs.GetInt("ANobre") == 1) {ListaAntecedentes.Add ("Nobre"); }
        if (PlayerPrefs.GetInt("ARico") == 1) {ListaAntecedentes.Add ("Rico"); }
        if (PlayerPrefs.GetInt("AAmbidestro") == 1) {ListaAntecedentes.Add ("Ambidestro"); }
        if (PlayerPrefs.GetInt("AGenio") == 1) {ListaAntecedentes.Add ("Gênio"); }
        if (PlayerPrefs.GetInt("AExpoente") == 1) {ListaAntecedentes.Add ("Expoente"); }
        if (PlayerPrefs.GetInt("AEspecial") == 1) {ListaAntecedentes.Add ("Especial"); }

        for(int i=0; i<ListaAntecedentes.Count; i++)
        {
            if(i == 0)
            {
                ListaCompleta = ListaAntecedentes[i];
            } else {
                ListaCompleta = ListaCompleta + ", " + ListaAntecedentes[i];
            }
        }

        ListaCompleta = ListaCompleta + ".";

        PlayerPrefs.SetString("AntecedentesPersonagem", ListaCompleta);
    }

    public void Retornar ()
    {
        SceneManager.LoadScene ("Criar001Especies");
    }

    public void ConfirmarEscolha ()
    {
        NovoPersonagem.CalculosCompletos = false;
        ConfirmarEscolhaAntecedentes = true;
        PreencherAntecedentes ();
        SceneManager.LoadScene ("Criar006Profissao");
    }
}
