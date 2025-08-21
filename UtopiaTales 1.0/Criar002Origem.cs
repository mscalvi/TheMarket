using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Criar002Origem : MonoBehaviour
{
    public static bool ConfirmarEscolhaOrigem;

    [SerializeField] private Button BtnOpcao3;

    [SerializeField] private TextMeshProUGUI NomeEspecie;
    [SerializeField] private TextMeshProUGUI NomeOrigem;
    [SerializeField] private TextMeshProUGUI AtrExtraU;
    [SerializeField] private TextMeshProUGUI AtrExtraD;
    [SerializeField] private TextMeshProUGUI DescricaoEsp;
    [SerializeField] private TextMeshProUGUI HabilidadeEsp;
    [SerializeField] private TextMeshProUGUI Expoente;

    [SerializeField] private TextMeshProUGUI TextOpc1;
    [SerializeField] private TextMeshProUGUI TextOpc2;
    [SerializeField] private TextMeshProUGUI TextOpc3;

    [SerializeField] private Button BtnConfirmar;
    [SerializeField] private Sprite BotaoBloqueado;
    [SerializeField] private Sprite BotaoConfirmar;
    [SerializeField] private Sprite BotaoCalculando;

    // Start is called before the first frame update
    void Start()
    {
        ConfirmarEscolhaOrigem = false;

        NomeOrigem.enabled = false;
        AtrExtraU.enabled = false;
        AtrExtraD.enabled = false;
        DescricaoEsp.enabled = false;
        HabilidadeEsp.enabled = false;
        Expoente.enabled = false;

        BtnConfirmar.enabled = false;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoBloqueado;

        switch (Criar001Especies.Especie)
        {
            case "Anguza":
                NomeEspecie.text = "Anguzas...";
                TextOpc1.text = "dos Presas Curtas";
                TextOpc2.text = "dos Rabos Fortes";

                TextOpc3.enabled = false;
                BtnOpcao3.enabled = false;
                BtnOpcao3.image.color = new Color(65, 52, 52, 0);

                break;

            case "Anão":
                NomeEspecie.text = "Anões...";
                TextOpc1.text = "das Cordilheiras de Areia";
                TextOpc2.text = "das Cavernas Cintilantes";
                TextOpc3.text = "dos Picos de Mármore";

                break;

            case "Celestial":
                NomeEspecie.text = "Celestiais...";
                TextOpc1.text = "da Linhagem de Morpton";
                TextOpc2.text = "da Linhagem de Absolon";

                TextOpc3.enabled = false;
                BtnOpcao3.enabled = false;
                BtnOpcao3.image.color = new Color(65, 52, 52, 0);

                break;

            case "Elfo":
                NomeEspecie.text = "Elfos...";
                TextOpc1.text = "da Floresta de Prata";
                TextOpc2.text = "das Florestas Escuras";
                TextOpc3.text = "dos Pântanos Vivos";

                break;

            case "Fada":
                NomeEspecie.text = "Fadas...";
                TextOpc1.text = "da Árvores de Moa";
                TextOpc2.text = "da Árvore de Geneva";
                TextOpc3.text = "do Cacto de Teridon";

                break;

            case "Gigante":
                NomeEspecie.text = "Gigantes...";
                TextOpc1.text = "das Profundezas";
                TextOpc2.text = "das Planíceis";
                TextOpc3.text = "de Mem-Temporála";

                break;

            case "Goblin":
                NomeEspecie.text = "Goblins...";
                TextOpc1.text = "dos Pântanos Borbulhantes";
                TextOpc2.text = "das Florestas Venenosas";
                TextOpc3.text = "das Terras Rachadas";

                break;

            case "Guyra":
                NomeEspecie.text = "Guyras...";
                TextOpc1.text = "da Linhagem das Corujas";
                TextOpc2.text = "da Linhagem dos Corvos";

                TextOpc3.enabled = false;
                BtnOpcao3.enabled = false;
                BtnOpcao3.image.color = new Color(65, 52, 52, 0);

                break;

            case "Humano":
                NomeEspecie.text = "Humanos...";
                TextOpc1.text = "das Grandes Cidades";
                TextOpc2.text = "das Regiões Inóspitas";
                TextOpc3.text = "das Termais";

                break;

            case "Karumbe":
                NomeEspecie.text = "Karumbes...";
                TextOpc1.text = "do Casco Perigoso";
                TextOpc2.text = "do Casco Cravejado";


                TextOpc3.enabled = false;
                BtnOpcao3.enabled = false;
                BtnOpcao3.image.color = new Color(65, 52, 52, 0);

                break;

            case "Ocelot":
                NomeEspecie.text = "Ocelos...";
                TextOpc1.text = "da Linhagem das Panteras";
                TextOpc2.text = "da Linhagem dos Leões";

                TextOpc3.enabled = false;
                BtnOpcao3.enabled = false;
                BtnOpcao3.image.color = new Color(65, 52, 52, 0);

                break;

            case "Orc":
                NomeEspecie.text = "Orcs...";
                TextOpc1.text = "dos Campos Áridos";
                TextOpc2.text = "da Baía Hostil";
                TextOpc3.text = "da Cordilheira Vermelha";

                break;

            case "Profano":
                NomeEspecie.text = "Profanos...";
                TextOpc1.text = "da Linhagem de Grixalan";
                TextOpc2.text = "da Linhagem de Asmolan";

                TextOpc3.enabled = false;
                BtnOpcao3.enabled = false;
                BtnOpcao3.image.color = new Color(65, 52, 52, 0);

                break;

            case "Teju":
                NomeEspecie.text = "Tejus...";
                TextOpc1.text = "dos Línguas de Fogo";
                TextOpc2.text = "dos Olhos de Vidro";

                TextOpc3.enabled = false;
                BtnOpcao3.enabled = false;
                BtnOpcao3.image.color = new Color(65, 52, 52, 0);

                break;

            case "Tritão":
                NomeEspecie.text = "Tritões...";
                TextOpc1.text = "das Águas Profundas";
                TextOpc2.text = "do Oceano Tempestuoso";
                TextOpc3.text = "do Litoral Paradisíaco";

                break;

            case "Vakame":
                NomeEspecie.text = "Vakames...";
                TextOpc1.text = "dos Chifres Curtos";
                TextOpc2.text = "dos Chifres Trançados";

                TextOpc3.enabled = false;
                BtnOpcao3.enabled = false;
                BtnOpcao3.image.color = new Color(65, 52, 52, 0);

                break;

            case "Ytta":
                NomeEspecie.text = "Yttas...";
                TextOpc1.text = "de Felivel";
                TextOpc2.text = "de Aagorio";
                TextOpc3.text = "de Nnetaro";

                break;
        }
    }

    public void Opcao1 ()
    {
        LiberarPainel ();
        switch (Criar001Especies.Especie)
        {
            case "Anguza":
                NomeOrigem.text = "... dos Presas Curtas";
                    NovoPersonagem.Origem = "das Presas Curtas";
                 AtrExtraU.text = "Bônus: Destreza";
                    NovoPersonagem.AtrExtraU = 2;
                 AtrExtraD.text = "Penalidade: Força";
                    NovoPersonagem.AtrExtraD = 3;
                DescricaoEsp.text = "As Cordilheiras de Areia são uma região de difícil acesso, mas que podem ser recompensantes. Cheia de lagos naturais e gêiseres, as cordilheiras possuem diversas áreas que podem servir perfeitamente para o assentamento de tribos, que conseguem lucrar muito explorando seus ricos estoques minerais. Alguns são capazes de entender que nesse território a delicadeza é muito mais valiosa que a força bruta.";
                HabilidadeEsp.text = "Você pode utilizar seu atributo Destreza ao causar dano com Armas Corpo-a-Corpo que normalmente utilizam o atributo Força.";
                break;

            case "Anão":
                NomeOrigem.text = "... das Cordilheiras de Areia";
                    NovoPersonagem.Origem = "das Cordilheiras de Areia";
                 AtrExtraU.text = "Bônus: Destreza";
                    NovoPersonagem.AtrExtraU = 2;
                 AtrExtraD.text = "Penalidade: Força";
                    NovoPersonagem.AtrExtraD = 3;
                DescricaoEsp.text = "As Cordilheiras de Areia são uma região de difícil acesso, mas que podem ser recompensantes. Cheia de lagos naturais e gêiseres, as cordilheiras possuem diversas áreas que podem servir perfeitamente para o assentamento de tribos, que conseguem lucrar muito explorando seus ricos estoques minerais. Alguns são capazes de entender que nesse território a delicadeza é muito mais valiosa que a força bruta.";
                HabilidadeEsp.text = "Você pode utilizar seu atributo Destreza ao causar dano com Armas Corpo-a-Corpo que normalmente utilizam o atributo Força.";
                break;

            case "Celestial":
                NomeOrigem.text = "... da Linhagem de Morpton";
                    NovoPersonagem.Origem = "da Linhagem de Morpton";
                 AtrExtraU.text = "Bônus: Sensibilidade";
                    NovoPersonagem.AtrExtraU = 7;
                 AtrExtraD.text = "Penalidade: Destreza";
                    NovoPersonagem.AtrExtraD = 2;
                DescricaoEsp.text = "Morpton percebeu a falta de conexão entre os Celestiais, tanto entre si quanto com outras espécies, e passou a pregar a união e a inclusão de sua espécie. Aqueles que seguem sua linhagem possuem uma maior sensibilidade do que os outros membros de sua espécie, mas podem acabar sendo obstinados demais.";
                HabilidadeEsp.text = "Conforme seus olhos se tornam dourados você é capaz de libertar uma poderosa aura apaziguadora, que irá conter os movimentos de todos ao seu redor.";
                break;

            case "Elfo":
                NomeOrigem.text = "... da Floresta de Prata";
                    NovoPersonagem.Origem = "da Floresta de Prata";
                 AtrExtraU.text = "Bônus: Sensibilidade";
                    NovoPersonagem.AtrExtraU = 7;
                 AtrExtraD.text = "Penalidade: Magia";
                    NovoPersonagem.AtrExtraD = 5;
                DescricaoEsp.text = "A Floresta de Prata recebe esse nome pela grande quantidade de Trepadeiras Árticas, que se enrolam pelos troncos das árvores da floresta nevada, dando um tom branco-brilhante a sua vegetação. Além de um toque mortal. Os Elfos da Floresta de Prata precisam de concentração o tempo todo para não se machucarem, e costumam encontrar pedaços pequenos de vegetação não tomada pelas vinhas em meio ao caos branco.";
                HabilidadeEsp.text = "Você possui uma altíssima chance de Acerto Crítico no seu primeiro contato com um oponente.";
                break;

            case "Fada":
                NomeOrigem.text = "... da Árvore de Moa";
                    NovoPersonagem.Origem = "da Árvore de Mora";
                AtrExtraU.text = "Bônus: Magia";
                    NovoPersonagem.AtrExtraU = 5;
                AtrExtraD.text = "Penalidade: Constituição";
                    NovoPersonagem.AtrExtraD = 1;
                DescricaoEsp.text = "A Árvore de Moa abriga uma enorme quantidade de Fadas, que cedem parte de sua vida para cultivar e cuidar de seu lar. Servindo ao longo de séculos como abrigo, a Árvore se tornou uma grande portadora de magia, e algumas de suas Fadas acabam sendo verdadeiros receptáculos.";
                HabilidadeEsp.text = "Você pode usar seu próprio corpo como uma Arma do tipo Canalizador, de dano igual a sua Magia.";
                break;

            case "Gigante":
                NomeOrigem.text = "... das Profundezas";
                    NovoPersonagem.Origem = "das Profundezas";
                 AtrExtraU.text = "Bônus: Força";
                    NovoPersonagem.AtrExtraU = 3;
                 AtrExtraD.text = "Penalidade: Velocidade";
                    NovoPersonagem.AtrExtraD = 8;
                DescricaoEsp.text = "Alguns Gigantes adquiriram o hábito de montar fortalezas em cavernas e complexos subterrâneos, apesar de terem que cavar mais alto do que os Anões jamais precisariam, os grandes pátios subterrâneos dos Gigantes são considerados maravilhas da espeleologia. As Profundezas é o nome do maior conjunto de átrios subterrâneos escavados e arquitetados pelos Gigantes, abrigando uma cidade inteira abaixo da superfície.";
                HabilidadeEsp.text = "– Você se acostumou com ocasionais deslizamentos nos túneis em construção das Profundezas, e agora tem reflexos melhores para se defender.";
                break;

            case "Goblin":
                NomeOrigem.text = "... dos Pântanos Borbulhantes";
                    NovoPersonagem.Origem = "dos Pântanos Borbulhantes";
                 AtrExtraU.text = "Bônus: Velocidade";
                    NovoPersonagem.AtrExtraU = 8;
                 AtrExtraD.text = "Penalidade: Constituição";
                    NovoPersonagem.AtrExtraD = 1;
                DescricaoEsp.text = "Os Pântanos Borbulhantes são um local perigoso, tóxico por natureza, mas cheios de recursos. Adoradores das aventuras e possibilidades do local, os Goblins se estabeleceram na área a bastante tempo, e o pântano se estabeleceu em alguns deles...";
                HabilidadeEsp.text = "Você é capaz de cuspir uma saliva tóxica, liberando uma toxina levemente corrosiva.";
                break;

            case "Guyra":
                NomeOrigem.text = "... da Linhagem das Corujas";
                    NovoPersonagem.Origem = "da Linhagem das Corujas";
                 AtrExtraU.text = "Bônus: Sensibilidade";
                    NovoPersonagem.AtrExtraU = 7;
                 AtrExtraD.text = "Penalidade: Velocidade";
                    NovoPersonagem.AtrExtraD = 8;
                DescricaoEsp.text = "Os Guyras da linhagem das corujas possuem uma característica única entre sua espécie, sendo capazes de girar a cabeça mais de 360°, o que da a eles uma vantagem grande em sua visão periférica. Alguns Guyras dessa raça treinam para poder fazer isso rápido, podendo reagir com grande velocidade à eventos adversos.";
                HabilidadeEsp.text = "Você não pode ser facilmente surpreendido, e sempre é o primeiro a saber quando algo vai acontecer em seu entorno.";
                break;

            case "Humano":
                NomeOrigem.text = "... das Grandes Cidades";
                    NovoPersonagem.Origem = "das Grandes Cidades";
                 AtrExtraU.text = "Bônus: Inteligência";
                    NovoPersonagem.AtrExtraU = 4;
                 AtrExtraD.text = "Penalidade: Memória";
                    NovoPersonagem.AtrExtraD = 6;
                DescricaoEsp.text = "As maiores cidades do Plano são, sem dúvidas, majoritariamente humanas. Apesar de ser raro alguma cidade atingir um tamanho absurdo sem que haja várias espécies coexistindo ali, a mais comum é sempre a humana. Os Humanos das Grandes Cidades conhecem a multidão como ninguém, e sabem conviver com ela, sem temer os seus males. Alguns chegam até mesmo a desenvolver um sexto sentido natural.";
                HabilidadeEsp.text = "– Você está acostumado a lidar com qualquer espécie, contanto que seja na lábia. ";
                break;

            case "Karumbe":
                NomeOrigem.text = "... do Casco Perigoso";
                    NovoPersonagem.Origem = "do Casco Perigoso";
                 AtrExtraU.text = "Bônus: Inteligência";
                    NovoPersonagem.AtrExtraU = 4;
                 AtrExtraD.text = "Penalidade: Velocidade";
                    NovoPersonagem.AtrExtraD = 8;
                DescricaoEsp.text = "Os Karumbes do Casco Perigoso são conhecidos por serem especialmente lentos, porém especialmente sábios. Versados em todas as formas de conhecimento e cultura, os Karumbes apenderam também sobre a própria anatomia, e alguns conseguiram aprender como esconder o próprio corpo dentro do casco, como fazer os animais selvagens dos quais eles descendem.";
                HabilidadeEsp.text = "Você é capaz de guardar seus membros dentro de seu casco, fechando-o completamente. Você não consegue se mover enquanto estiver assim, mas pode descansar normalmente.";
                break;

            case "Ocelot":
                NomeOrigem.text = "... das Linhagem das Panteras";
                    NovoPersonagem.Origem = "da Linhagem das Panteras";
                 AtrExtraU.text = "Bônus: Destreza";
                    NovoPersonagem.AtrExtraU = 2;
                 AtrExtraD.text = "Penalidade: Constituição";
                    NovoPersonagem.AtrExtraD = 1;
                DescricaoEsp.text = "A linhagem das Panteras é ágil e esperta, caçando sua presa com sabedoria e habilidade. Alguns são extremamente hábeis com armas, ou com as próprias garras.";
                HabilidadeEsp.text = "Você é capaz de utilizar a segunda mão de forma mais assustadora que a primeira. Sempre que acertar um golpe com a primeira mão receberá um bônus no teste de Segunda Mão igual ao seu nível na proficiência referente ao primeiro golpe.";
                break;

            case "Orc":
                NomeOrigem.text = "... dos Campos Áridos";
                    NovoPersonagem.Origem = "dos Campos Áridos";
                 AtrExtraU.text = "Bônus: Velocidade";
                    NovoPersonagem.AtrExtraU = 8;
                 AtrExtraD.text = "Penalidade: Memória";
                    NovoPersonagem.AtrExtraD = 6;
                DescricaoEsp.text = "Uma das regiões mais violentas do Plano, os Campos Áridos abrigam as tribos Orcs mais fortes, e lá também é possível encontrar alguns dentre os mais habilidosos.";
                HabilidadeEsp.text = "Você é capaz de utilizar a segunda mão de forma mais assustadora que a primeira. Sempre que acertar um golpe com a primeira mão receberá um bônus no teste de Segunda Mão igual ao seu nível na proficiência referente ao primeiro golpe.";
                break;

            case "Profano":
                NomeOrigem.text = "... da Linhagem de Grixalan";
                    NovoPersonagem.Origem = "da Linhagem de Grixalan";
                 AtrExtraU.text = "Bônus: Inteligência";
                    NovoPersonagem.AtrExtraU = 4;
                 AtrExtraD.text = "Penalidade: Constituição";
                    NovoPersonagem.AtrExtraD = 1;
                DescricaoEsp.text = "Grixalan é Senhor de muitas terras no Plano Profanus, tendo que deslocar grandes quantidades de recursos e pessoas para manter a segurança e o controle da região. Investindo muito em pesquisa, acabou criando uma forma de utilizar a natureza das sombras para viajar, e alguns de seus seguidores são capazes de replicar uma parte dessa técnica.";
                HabilidadeEsp.text = "Você é capaz de se teletransportar pelas sombras. Se estiver em contato com a sombra de algo, por menor que seja, poderá se teletransportar até outra sombra visível. ";
                break;

            case "Teju":
                NomeOrigem.text = "... dos Línguas de Fogo";
                    NovoPersonagem.Origem = "dos Línguas de Fogo";
                 AtrExtraU.text = "Bônus: Destreza";
                    NovoPersonagem.AtrExtraU = 2;
                 AtrExtraD.text = "Penalidade: agia";
                    NovoPersonagem.AtrExtraD = 5;
                DescricaoEsp.text = "A raça dos Línguas de Fogo se exilou nas montanhas de Ailâmina a séculos, mas redescobriram a sociedade ao se inserirem em Utopia, estabelecendo mais comunidades nesse Plano do que no seu original. Alguns membros dela desenvolveram glândulas que liberam um segundo gás, que entra em combustão quando misturado ao gás natural dos Tejus, dando a eles a habilidade de baforar chamas.";
                HabilidadeEsp.text = "Você é capaz de baforar rapidamente uma labareda, que se apaga rapidamente, mas possui uma alta temperatura. ";
                break;

            case "Tritão":
                NomeOrigem.text = "... das Águas Profundas";
                    NovoPersonagem.Origem = "das Águas Profundas";
                 AtrExtraU.text = "Bônus: Sensibilidade";
                    NovoPersonagem.AtrExtraU = 7;
                 AtrExtraD.text = "Penalidade: Memória";
                    NovoPersonagem.AtrExtraD = 5;
                DescricaoEsp.text = "As Águas Profundas são perigosas, mas os Tritões são curiosos, e alguns até desenvolveram capacidades melhores de observação, se adaptando a escuridão do fundo do mar. Apesar do perigo natural, os Tritões das Águas Profundas nunca enfrentaram uma invasão de outra espécie.";
                HabilidadeEsp.text = "– Você é capaz de enxergar no escuro, através de uma mistura de sonar com detecção de corpos quentes. Pode não ver cores e escritos, mas consegue identificar objetos e seres-vivos com facilidade maior do que quando iluminado.";
                break;

            case "Vakame":
                NomeOrigem.text = "... dos Chifres Curtos";
                    NovoPersonagem.Origem = "dos Chifres Curtos";
                 AtrExtraU.text = "Bônus: Constituição";
                    NovoPersonagem.AtrExtraU = 1;
                 AtrExtraD.text = "Penalidade: Inteligência";
                    NovoPersonagem.AtrExtraD = 4;
                DescricaoEsp.text = "O povo dos Chifres Curtos possui na cabeça duas protuberâncias pequenas, mas bastante pontudas, ligeiramente encaracoladas. Possuem uma densa pelugem, e cascos ainda mais fortes do que o normal, sendo que alguns membros da espécie consegue bloquear golpes de espada com as próprias mãos.";
                HabilidadeEsp.text = "Você recebe dano a menos de qualquer golpe físico ou elemental que receber em seu corpo.";
                break;

            case "Ytta":
                NomeOrigem.text = "... de Felivel";
                    NovoPersonagem.Origem = "de Felivel";
                 AtrExtraU.text = "Bônus: Sensibilidade";
                    NovoPersonagem.AtrExtraU = 7;
                 AtrExtraD.text = "Penalidade: Destreza";
                    NovoPersonagem.AtrExtraD = 2;
                DescricaoEsp.text = "Felivel é uma colônia isolada nos pés das montanhas nortenhas, onde se preza pelo contato com a natureza e absorção da magia natural do Plano. Alguns Yttas conseguem sentir essa magia mesmo sem tentar.";
                HabilidadeEsp.text = "Você recupera o dobro de Pontos de Mana durante um descanso, independentemente do tipo.";
                break;
        }
    }

    public void Opcao2 ()
    {
        LiberarPainel ();
        switch (Criar001Especies.Especie)
        {
            case "Anguza":

                NomeOrigem.text = "... dos Rabos Fortes";
                    NovoPersonagem.Origem = "do Rabo forte";
                 AtrExtraU.text = "Bônus: Velocidade";
                    NovoPersonagem.AtrExtraU = 8;
                 AtrExtraD.text = "Penalidade: Sensibilidade";
                    NovoPersonagem.AtrExtraD = 7;
                DescricaoEsp.text = "A tribo do Rabo Forte possui a cauda ligeiramente mais grossa que os outros da espécie, e acabam se tornando mais rápido e estáveis por isso. Alguns são capazes de utilizá-lo de forma muito eficiente em combate.";
                HabilidadeEsp.text = "Você é capaz de utilizar sua cauda como uma clava especial, de alcance aprimorado.";
               break;

            case "Anão":

                NomeOrigem.text = "... das Cavernas Cintilantes";
                    NovoPersonagem.Origem = "das Cavernas Cintilantes";
                 AtrExtraU.text = "Bônus: Inteligência";
                    NovoPersonagem.AtrExtraU = 4;
                 AtrExtraD.text = "Penalidade: Velocidade";
                    NovoPersonagem.AtrExtraD = 8;
                DescricaoEsp.text = "Inquestionavelmente o melhor lugar para se conseguir dinheiro com gemas, se você aguentar a pressão e o perigo. Qualquer passo em falso dentro das cavernas pode ser seu último. Alguns repararam que a delicadeza está bastante ligada ao lucro também.";
                HabilidadeEsp.text = "Você é capaz de transformar uma Gema em duas de menor raridade, e vice-versa. ";
                break;
               
            case "Celestial":

                NomeOrigem.text = "... da Linhagem de Absolon";
                    NovoPersonagem.Origem = "da Linhagem de Absolon";
                 AtrExtraU.text = "Bônus: Destreza";
                    NovoPersonagem.AtrExtraU = 2;
                 AtrExtraD.text = "Penalidade: Magia";
                    NovoPersonagem.AtrExtraD = 5;
                DescricaoEsp.text = "Absolon foi um dos Celestiais a chegar mais perto da presença da Luz, e herdou dela um traço de sua existência, se tornando capaz de criar asas de luz em suas costas, ganhando força e velocidade brevemente. Seus seguidores se tornaram grandes combatentes, impressionados pelos movimentos dele. Apesar da técnica ser perdida, alguns Celestiais conseguem executar movimentos de forma intuitiva, sem recorrer a memória e aos estudos.";
                HabilidadeEsp.text = "Você usa o espectro de suas asas para pegar impulso, se movimentando e atacando em conjunto. ";
                break;
               
            case "Elfo":

                NomeOrigem.text = "... das Florestas Escuras";
                    NovoPersonagem.Origem = "das Florestas Escuras";
                 AtrExtraU.text = "Bônus: Velocidade";
                    NovoPersonagem.AtrExtraU = 8;
                 AtrExtraD.text = "Penalidade: Inteligência";
                    NovoPersonagem.AtrExtraD = 4;
                DescricaoEsp.text = "As Florestas Escuras são regiões perigosas, habitadas por insetos gigantes e criaturas peçonhentas. Os Elfos que a habitam são velozes, e acabam agindo de forma mais instintiva do que os outros membros de sua espécie.";
                HabilidadeEsp.text = "Você é capaz de se camuflar completamente nas sombras, ficando praticamente invisível e irrastreável por meios não-mágicos, e pode permanecer assim mesmo que a luz se acenda, contanto que não se mexa. ";
                break;
               
            case "Fada":

                NomeOrigem.text = "... da Árvore de Geneva";
                    NovoPersonagem.Origem = "da Árvore de Geneva";
                 AtrExtraU.text = "Bônus: Inteligência";
                    NovoPersonagem.AtrExtraU = 4;
                 AtrExtraD.text = "Penalidade: Força";
                    NovoPersonagem.AtrExtraD = 3;
                DescricaoEsp.text = "A mais curiosa das árvores das Fadas, a Árvore de Geneva abriga a maior diversidade de raças de Fadas, com uma grande variação de cores e características. São naturais de Geneva as mais fortes usuárias de magia entre as Fadas, e talvez dentre todas as espécies, sendo capazes de utilizar dois tipos distintos de magia, habilidade impossível para quase todas as outras espécies.";
                HabilidadeEsp.text = "– Você é capaz de utilizar duas vertentes diferentes de magia. ";
                break;
               
            case "Gigante":

                NomeOrigem.text = "... das Planícies";
                    NovoPersonagem.Origem = "das Planícies";
                 AtrExtraU.text = "Bônus: Velocidade";
                    NovoPersonagem.AtrExtraU = 8;
                 AtrExtraD.text = "Penalidade: Sensibilidade";
                    NovoPersonagem.AtrExtraD = 7;
                DescricaoEsp.text = "Acostumados ao céu aberto e aos espaços infinitos das planícies, os Gigantes da região são melhor treinados em combate, tendo enfrentado diversos oponentes ao longo da história. Sabem lidar com o terreno, cobrindo grandes espaços em pouco tempo, e resolvendo o problema sem fazer segundas perguntas.";
                HabilidadeEsp.text = "Você pode golpear após se deslocar longos espaços.";
                break;
               
            case "Goblin":

                NomeOrigem.text = "... das Florestas Venenosas";
                    NovoPersonagem.Origem = "das Florestas Venenosas";
                 AtrExtraU.text = "Bônus: Destreza";
                    NovoPersonagem.AtrExtraU = 2;
                 AtrExtraD.text = "Penalidade: Força";
                    NovoPersonagem.AtrExtraD = 3;
                DescricaoEsp.text = "A vida nas Florestas Venenosas é sempre perigosa, e os Goblins da região aprenderam a correr dos perigos que não valem a pena ser enfrentados, ou pelo menos fingir que estão correndo.";
                HabilidadeEsp.text = "Você é capaz de contra-atacar após uma esquiva.";
                break;
               
            case "Guyra":

                NomeOrigem.text = "... da Linhagem dos Corvos";
                    NovoPersonagem.Origem = "da Linhagem dos Corvos";
                 AtrExtraU.text = "Bônus: Inteligência";
                    NovoPersonagem.AtrExtraU = 4;
                 AtrExtraD.text = "Penalidade: Magia";
                    NovoPersonagem.AtrExtraD = 5;
                DescricaoEsp.text = "A linhagem dos Corvos é famosa entre os Guyras pelo conflito entre uma inteligência aguçada e o apetite bizarro. São capazes de comer qualquer coisa, e as vezes esquecem que nem sempre deveriam.";
                HabilidadeEsp.text = "Você é capaz de comer praticamente qualquer coisa, mesmo que demore para engolir e digerir";
                break;
               
            case "Humano":

                NomeOrigem.text = "... das Regiões Inóspitas";
                    NovoPersonagem.Origem = "das Regiões Inóspitas";
                 AtrExtraU.text = "Bônus: Constituição";
                    NovoPersonagem.AtrExtraU = 1;
                 AtrExtraD.text = "Penalidade: Sensibilidade";
                    NovoPersonagem.AtrExtraD = 7;
                DescricaoEsp.text = "Existem várias regiões do Plano que não deveriam ser levianamente visitadas, muito menos habitadas. Mas os humanos não se importam, ou endureceram o suficiente para não se importarem. Acostumados com a própria sobrevivência estar em risco, os humanos que habitam as regiões mais inóspitas de Utopia acabam criando maneiras rápidas de ter pequenas vantagens, e alguns são tão habilidosos que fazem milagre com o pouco que tem.";
                HabilidadeEsp.text = ": Você é capaz de alterar um item rapidamente, melhorando-o de acordo com o ambiente. ";
                break;
               
            case "Karumbe":

                NomeOrigem.text = "... do Casco Cravejado";
                    NovoPersonagem.Origem = "do Casco Cravejado";
                 AtrExtraU.text = "Bônus: Memória";
                    NovoPersonagem.AtrExtraU = 6;
                 AtrExtraD.text = "Penalidade: Constituição";
                    NovoPersonagem.AtrExtraD = 1;
                DescricaoEsp.text = "Os Karumbes do Casco Cravejado recebem esse nome pelo polimento especial que dão ao próprio casco, que já possui protuberância a mais do que os cascos dos outros membros de sua espécie. São ornamentados e belos, e as vezes pintados com obras de suas crianças.";
                HabilidadeEsp.text = "Você é capaz de utilizar seu casco como uma mochila.";
                break;
               
            case "Ocelot":

                NomeOrigem.text = "... da Linhagem dos Leões";
                    NovoPersonagem.Origem = "da Linhagem dos Leões";
                 AtrExtraU.text = "Bônus: Força";
                    NovoPersonagem.AtrExtraU = 3;
                 AtrExtraD.text = "Penalidade: Memória";
                    NovoPersonagem.AtrExtraD = 6;
                DescricaoEsp.text = "A linhagem dos Leões é forte e resistente, tendo uma presença imponente. Alguns são capazes de fazerem com que os de mente fraca se curvem contra a própria vontade.";
                HabilidadeEsp.text = "Você é capaz de soltar um poderoso rugido, que atordoará todos a sua volta.";
                break;
               
            case "Orc":

                NomeOrigem.text = "... da Baía Hostil";
                    NovoPersonagem.Origem = "da Baía Hostil";
                 AtrExtraU.text = "Bônus: Sensibilidade";
                    NovoPersonagem.AtrExtraU = 7;
                 AtrExtraD.text = "Penalidade: Constituição";
                    NovoPersonagem.AtrExtraD = 1;
                DescricaoEsp.text = "A Baía Hostil é naturalmente selvagem, mas as tribos Orcs a domam para si. Palco de muitas guerras e invasões no passado, os Orcs da região aprenderam a ser vigilantes, e sempre estarem prontos para o pior.";
                HabilidadeEsp.text = "Você se sente mais confiante enquanto estiver com uma arma em mãos.";
                break;
               
            case "Profano":

                NomeOrigem.text = "... da Linhagem de Asmolan";
                    NovoPersonagem.Origem = "da Linhagem de Asmolan";
                 AtrExtraU.text = "Bônus: Destreza";
                    NovoPersonagem.AtrExtraU = 2;
                 AtrExtraD.text = "Penalidade: Memória";
                    NovoPersonagem.AtrExtraD = 6;
                DescricaoEsp.text = "Asmolan foi um Senhor poderoso, antes de ser deposto e exilado em uma guerra civil. Ele descobriu uma forma de esconder objetos no escuro, escondendo seus pertences e riquezas nas sombras.";
                HabilidadeEsp.text = "Você é capaz de acessar uma área oculta do mundo, um espaço nas sombras, onde consegue guardar objetos. ";
                break;
               
            case "Teju":

                NomeOrigem.text = "... dos Olhos de Vidro";
                    NovoPersonagem.Origem = "dos Olhos de Vidro";
                 AtrExtraU.text = "Bônus: Destreza";
                    NovoPersonagem.AtrExtraU = 2;
                 AtrExtraD.text = "Penalidade: Sensibilidade";
                    NovoPersonagem.AtrExtraD = 7;
                DescricaoEsp.text = "Os Olhos de Vidro são a mais calma e lenta das raças dos Tejus, se movendo raramente, e apenas quando necessário, podendo passar horas parados. Alguns membros possuem a glândula de seu gás diferente do reste da espécie.";
                HabilidadeEsp.text = "O gás que você expira possui dois modos, que você consegue controlar livremente. O primeiro é o normal, inflamável, e o segundo é um efeito atordoante, que passa a sensação de resfriamento. ";
                break;
               
            case "Tritão":

                NomeOrigem.text = "... do Oceano Tempestuoso";
                    NovoPersonagem.Origem = "do Oceano Tempestuoso";
                 AtrExtraU.text = "Bônus: Destreza";
                    NovoPersonagem.AtrExtraU = 2;
                 AtrExtraD.text = "Penalidade: Memória";
                    NovoPersonagem.AtrExtraD = 6;
                DescricaoEsp.text = "A região do Oceano Tempestuoso faz jus ao seu nome, e inúmeros são os relatos de embarcações que desapareceram em meio as fortes ondas. Mas não só as ondas as culpadas. Os Tritões do Oceano Tempestuoso são habilidosos combatentes, que afundam os inimigos com um elaborado trabalho em equipe, e por vezes a ajudinha extra de serem capazes de transformar água em projéteis.";
                HabilidadeEsp.text = "Você é capaz de utilizar água como um projétil, atirando-a com o estalar dos dedos";
                break;
               
            case "Vakame":

                NomeOrigem.text = "... dos Chifres Trançados";
                    NovoPersonagem.Origem = "dos Chifres Trançados";
                 AtrExtraU.text = "Bônus: Destreza";
                    NovoPersonagem.AtrExtraU = 2;
                 AtrExtraD.text = "Penalidade: Sensibilidade";
                    NovoPersonagem.AtrExtraD = 7;
                DescricaoEsp.text = "O povo do Chifre Trançado é considerado peculiar, sendo uma das poucas raças de Vakames capazes de removerem os próprios chifres, que possuem uma estabilidade frágil, e se desintegram rapidamente após serem destacados. Alguns, entretanto, possuem chifres capazes de durarem por bastante tempo, contanto que não sofram impactos violentos.";
                HabilidadeEsp.text = "Você é capaz de balançar a cabeça e projetar seu chifre, jogando-o como um dardo de batalha. ";
                break;
               
            case "Ytta":

                NomeOrigem.text = "... de Aagoria";
                    NovoPersonagem.Origem = "de Aagoria";
                 AtrExtraU.text = "Bônus: Magia";
                    NovoPersonagem.AtrExtraU = 5;
                 AtrExtraD.text = "Penalidade: Força";
                    NovoPersonagem.AtrExtraD = 3;
                DescricaoEsp.text = "A colônia de Aagorio é próxima a Árvore de Geneva, e não se sabe se as Fadas aprenderam com os Yttas ou os Yttas com as Fadas, ou se ocorreu naturalmente para ambos, mas alguns dos Yttas de Aagorio são tão capazes quanto a espécie pequenina de controlar a magia, tendo inclusive a habilidade de manipular dois tipos dela.";
                HabilidadeEsp.text = "Você é capaz de utilizar duas vertentes diferentes de magia. ";
                break;
        }
    }

    public void Opcao3 ()
    {
        LiberarPainel ();
        switch (Criar001Especies.Especie)
        {
            case "Anão":
                NomeOrigem.text = "... dos Picos de Mármore";
                    NovoPersonagem.Origem = "dos Picos de Mármore";
                 AtrExtraU.text = "Bônus: Força";
                    NovoPersonagem.AtrExtraU = 3;
                 AtrExtraD.text = "Penalidade: Constituição";
                    NovoPersonagem.AtrExtraD = 1;
                DescricaoEsp.text = "Os Picos de Mármore são uma alta cordilheira, cujos picos ficam permanentemente enevoados, dando um tom branco-mármore. São um lugar perigoso, mas uma verdadeira fortaleza natural. Não é um lugar agradável para gente fraca, e um lugar onde a delicadeza não tem vantagem sobre a pura força bruta.";
                HabilidadeEsp.text = "Você pode utilizar seu atributo Força ao causar dano com Armas Corpo-a-Corpo que normalmente utilizam o atributo Destreza.";
                break;

            case "Elfo":
                NomeOrigem.text = "... dos Pântanos Vivos";
                    NovoPersonagem.Origem = "dos Pântanos Vivos";
                 AtrExtraU.text = "Bônus: Inteligência";
                    NovoPersonagem.AtrExtraU = 4;
                 AtrExtraD.text = "Penalidade: Constituição";
                    NovoPersonagem.AtrExtraD = 1;
                DescricaoEsp.text = "Os Pântanos Vivos escondem uma enorme variedade de espécies de fauna e flora, e a grande maioria deles sabe se defender muito bem. Em meio as poucas regiões de árvores altas da área pantanosa, os Élfos construíram verdadeiras fortalezas verticais, unidos da proteção natural fornecida pela natureza. São grandes conhecedores da fauna e flora local, e alguns sabem utilizá-la de forma especial.";
                HabilidadeEsp.text = "Você sabe aumentar a durabilidade e potência de um veneno com maestria. ";
                break;
                
            case "Fada":
                NomeOrigem.text = "... do Cacto de Teridon";
                    NovoPersonagem.Origem = "do Cacto de Teridon";
                 AtrExtraU.text = "Bônus: Sensibilidade";
                    NovoPersonagem.AtrExtraU = 7;
                 AtrExtraD.text = "Penalidade: Velocidade";
                    NovoPersonagem.AtrExtraD = 8;
                DescricaoEsp.text = "O Cacto de Teridon é provavelmente a maior planta em uma região árida de todos os Planos, e suas moradoras se orgulham muito disso, e o defendem de qualquer invasor. Mentirosas por necessidade, as Fadas de Teridon enganam seus adversários com truques mágicos e ilusões de ótica, protegendo o Cacto e seus segredos.";
                HabilidadeEsp.text = "Você é capaz de causar alucinações em um alvo ao tocá-lo. ";
                break;
                
            case "Gigante":
                NomeOrigem.text = "... de Mem-Temporália";
                    NovoPersonagem.Origem = "de Mem-Temporália";
                 AtrExtraU.text = "Bônus: Constituição";
                    NovoPersonagem.AtrExtraU = 1;
                 AtrExtraD.text = "Penalidade: Inteligência";
                    NovoPersonagem.AtrExtraD = 4;
                DescricaoEsp.text = "A maior cidade de construção Gigante na superfície de Utopia, Mem-Tamporála guarda segredos de muitas espécies, conquistados na amizade ou na violência. Os Gigantes de lá são calejados, acostumados com as extensas construções e horas de trabalho, e sempre prontos para resolver os problemas da metrópole urbana.";
                HabilidadeEsp.text = "– Você recebe 20% de dano físico a menos. ";
                break;
                
            case "Goblin":
                NomeOrigem.text = "... das Terras Rachadas";
                    NovoPersonagem.Origem = "das Terras Rachadas";
                 AtrExtraU.text = "Bônus: Inteligência";
                    NovoPersonagem.AtrExtraU = 4;
                 AtrExtraD.text = "Penalidade: Velocidade";
                    NovoPersonagem.AtrExtraD = 8;
                DescricaoEsp.text = "As Terras Rachadas são uma região árida, onde valas gigantes se formaram no chão, e o Goblins cavaram inúmeras tocas por elas, construindo pontes, escadas e escorregadores, transformando a região em um parque de diversões para espécies aventureiras. Alguns Goblins da região são capazes de se esconder, mudando a cor da pele para combinar com os tons amarelados e dourados do deserto, apesar do motivo ser desconhecido.";
                HabilidadeEsp.text = "Você é capaz de se camuflar rapidamente, mudando a cor de sua pele para combinar com o ambiente a sua volta. ";
                break;
                
            case "Humano":
                NomeOrigem.text = "... das Termais";
                    NovoPersonagem.Origem = "das Termais";
                 AtrExtraU.text = "Bônus: Sensibilidade";
                    NovoPersonagem.AtrExtraU = 7;
                 AtrExtraD.text = "Penalidade: Força";
                    NovoPersonagem.AtrExtraD = 3;
                DescricaoEsp.text = "As Termais são uma região com um alto índice fluvial e de nascentes de água quente. Os habitantes daquela região estão acostumados com uma vegetação ampla e uma fauna viva e ativa. Acostumados com a vida saudável da natureza, os Humanos das Termais sofrem em ambientes hostis de outro tipo, mas podem ser rapidamente capazes de reconhecer semelhanças entre recursos naturais.";
                HabilidadeEsp.text = "Você é capaz de lidar com poucos recursos e ter o mesmo resultado. ";
                break;
                
            case "Orc":
                NomeOrigem.text = "... da Cordilheira Vermelha";
                    NovoPersonagem.Origem = "da Cordilheira Vermelha";
                 AtrExtraU.text = "Bônus: Força";
                    NovoPersonagem.AtrExtraU = 3;
                 AtrExtraD.text = "Penalidade: Velocidade";
                    NovoPersonagem.AtrExtraD = 8;
                DescricaoEsp.text = "A pele dos Orcs da região costuma ser vermelha, entre o carmim e o vermelho-sangue. Apesar do nome da região ser devido ao solo, dizem que foi a loucura dos Orcs que o deixou assim.";
                HabilidadeEsp.text = "Você se torna mais forte a cada vez que sua sanidade diminui.";
                break;
                
            case "Tritão":

                NomeOrigem.text = "... do Litoral Paradisíaco";
                    NovoPersonagem.Origem = "do Litoral Paradisíaco";
                 AtrExtraU.text = "Bônus: Memória";
                    NovoPersonagem.AtrExtraU = 6;
                 AtrExtraD.text = "Penalidade: Força";
                    NovoPersonagem.AtrExtraD = 3;
                DescricaoEsp.text = "O Litoral Paradisíaco é o oposto dos habitats normais dos Tritões, sendo uma região de fauna e flora variável e agradável, com tons vivos e exuberantes. Os Tritões da região estudam bastante de biologia, e alguns aprenderam a usar a própria natureza do local para mudarem sua fisionomia, sendo capazes alterar a cor de sua pele livremente.";
                HabilidadeEsp.text = "Você é capaz de trocar o tom de sua pele em poucos segundos, podendo variar entre qualquer tom de azul, verde, roxo ou rosa.";
                break;
                
            case "Ytta":

                NomeOrigem.text = "... de Nnetaro";
                    NovoPersonagem.Origem = "de Nnetaro";
                 AtrExtraU.text = "Bônus: Velocidade";
                    NovoPersonagem.AtrExtraU = 8;
                 AtrExtraD.text = "Penalidade: Constituição";
                    NovoPersonagem.AtrExtraD = 1;
                DescricaoEsp.text = "Nnetaro é a mais secreta colônia de Yttas, e a presença de outras espécies é completamente proibida. Lá eles aprendem uma arte a muito esquecida pelos outros de sua espécie, a projeção astral. Todos os Yttas que aprendem a técnica passam a deixar uma parte de sua consciência em Nnetaro, na Sala dos Sábios, e podem retornar a ela brevemente em momentos críticos, para fugas ou esclarecimentos.";
                HabilidadeEsp.text = " Uma vez a cada Descanso Completo você é capaz de voltar para Nnetaro instantaneamente, já que parte de sua consciência nunca saiu de lá. ";
                break;
        }
    }

    private void LiberarPainel ()
    {
        BtnConfirmar.enabled = true;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoConfirmar;

        NomeOrigem.enabled = true;
        AtrExtraU.enabled = true;
        AtrExtraD.enabled = true;
        DescricaoEsp.enabled = true;
        HabilidadeEsp.enabled = true;
        Expoente.enabled = true;
    }

    public void Retornar ()
    {
        SceneManager.LoadScene ("Criar001Especies");
    }

    public void ConfirmarEscolha ()
    {
        ConfirmarEscolhaOrigem = true;
        SceneManager.LoadScene ("Criar003Atributos");
    }
}
