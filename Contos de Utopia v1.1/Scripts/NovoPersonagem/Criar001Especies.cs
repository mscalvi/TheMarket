using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Criar001Especies : MonoBehaviour
{
    public static bool ConfirmarEscolhaEspecie;
    public static string Especie;

    [SerializeField] private Sprite ImgAnguzas;
    [SerializeField] private Sprite ImgAnoes;
    [SerializeField] private Sprite ImgCelestiais;
    [SerializeField] private Sprite ImgElfos;
    [SerializeField] private Sprite ImgFadas;
    [SerializeField] private Sprite ImgGigantes;
    [SerializeField] private Sprite ImgGoblins;
    [SerializeField] private Sprite ImgGuyras;
    [SerializeField] private Sprite ImgHumanos;
    [SerializeField] private Sprite ImgKarumbes;
    [SerializeField] private Sprite ImgOcelots;
    [SerializeField] private Sprite ImgOrcs;
    [SerializeField] private Sprite ImgProfanos;
    [SerializeField] private Sprite ImgTejus;
    [SerializeField] private Sprite ImgTritoes;
    [SerializeField] private Sprite ImgVakames;
    [SerializeField] private Sprite ImgYttas;

    [SerializeField] private Image ImagemEspecie;
    [SerializeField] private TextMeshProUGUI NomeEspecie;
    [SerializeField] private TextMeshProUGUI AtrFortes;
    [SerializeField] private TextMeshProUGUI AtrFracos;
    [SerializeField] private TextMeshProUGUI Condicoes;
    [SerializeField] private TextMeshProUGUI DescricaoEsp;
    [SerializeField] private TextMeshProUGUI HabilidadeEsp;
    [SerializeField] private TextMeshProUGUI TextoBase1;
    [SerializeField] private TextMeshProUGUI TextoBase2;
    [SerializeField] private TextMeshProUGUI TextoBase3;
    [SerializeField] private TextMeshProUGUI TextoBase4;

    [SerializeField] private Button BtnConfirmar;
    [SerializeField] private Sprite BotaoBloqueado;
    [SerializeField] private Sprite BotaoConfirmar;
    [SerializeField] private Sprite BotaoCalculando;

    // Start is called before the first frame update
    void Start()
    {
        ConfirmarEscolhaEspecie = false;

        ImagemEspecie.enabled = false;
        NomeEspecie.enabled = false;
        AtrFortes.enabled = false;
        AtrFracos.enabled = false;
        Condicoes.enabled = false;
        DescricaoEsp.enabled = false;
        HabilidadeEsp.enabled = false;
        TextoBase1.enabled = false;
        TextoBase2.enabled = false;
        TextoBase3.enabled = false;
        TextoBase4.enabled = false;

        BtnConfirmar.enabled = false;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoBloqueado;
    }

    public void Anguzas ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Anguzas";
            Especie = "Anguza";
        AtrFortes.text = "Constituição e Sensibilidade.";
            NovoPersonagem.AtrForte1 = 1;
            NovoPersonagem.AtrForte2 = 7;
        AtrFracos.text = "Força, Inteligência e Memória.";
            NovoPersonagem.AtrFraco1 = 3;
            NovoPersonagem.AtrFraco2 = 4;
            NovoPersonagem.AtrFraco3 = 6;
        Condicoes.text = "50 de Vida, 35 de Mana e 50 de Sanidade.";
        DescricaoEsp.text = "Uma espécie de homens-rato, naturalmente resistente. Possuem um rabo flexível e forte, e bigodes que auxiliam em uma percepção aguçada.";
        HabilidadeEsp.text = "São capazes de utilizar o rabo como um terceiro braços, que não possui dado mas pode se enrolar com força.";

        ImagemEspecie.sprite = ImgAnguzas;
    }

    public void Anoes ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Anões";
            Especie = "Anão";
        AtrFortes.text = "Constituição e Destreza";
            NovoPersonagem.AtrForte1 = 1;
            NovoPersonagem.AtrForte2 = 2;
        AtrFracos.text = "Memória, Sensibilidade e Velocidade";
            NovoPersonagem.AtrFraco1 = 6;
            NovoPersonagem.AtrFraco2 = 7;
            NovoPersonagem.AtrFraco3 = 8;
        Condicoes.text = "50 de Vida, 35 de Mana, 20 de Sanidade.";
        DescricaoEsp.text = "Baixos e corpoulentos, os anões demonstram grande habilidade no manuseio de peças delicadas, e apesar dos dedos grossos e do jeito brutamontes, são responsáveis pelas maiores obras de joalheria.";
        HabilidadeEsp.text = "São capazes de realizar uma ação extra ao se concentrarem no trabalho.";

        ImagemEspecie.sprite = ImgAnoes;
    }

    public void Celestiais ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Celestiais";
            Especie = "Celestial";
        AtrFortes.text = "Força e Memória";
            NovoPersonagem.AtrForte1 = 3;
            NovoPersonagem.AtrForte2 = 6;
        AtrFracos.text = "Destreza, Inteligência e Magia";
            NovoPersonagem.AtrFraco1 = 2;
            NovoPersonagem.AtrFraco2 = 4;
            NovoPersonagem.AtrFraco3 = 5;
        Condicoes.text = " de Vida,  de Mana,  de Sanidade.";
        DescricaoEsp.text = "Fisicamente semelhante aos humanos, os Celestiais possuem um comportamento completamente diferente do deles. Costumam ser rígidos e formais, e ao adotarem uma postura ainda mais séria seus olhos ficam dourados e opacos, revelando o que realmente são.";
        HabilidadeEsp.text = "Quando os olhos de um Celestial se tornam dourados ele recebe um grande bônus de Proficiência, focando naquilo que é sua maior habilidade.";

        ImagemEspecie.sprite = ImgCelestiais;
    }

    public void Elfos ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Elfos";
            Especie = "Elfo";
        AtrFortes.text = "Destreza e Inteligência";
            NovoPersonagem.AtrForte1 = 2;
            NovoPersonagem.AtrForte2 = 4;
        AtrFracos.text = "Constituição, Força e Magia";
            NovoPersonagem.AtrFraco1 = 1;
            NovoPersonagem.AtrFraco2 = 3;
            NovoPersonagem.AtrFraco3 = 5;
        Condicoes.text = "20 de Vida, 20 de Mana, e 35 de Sanidade.";
        DescricaoEsp.text = "Altos e esguios, os Elfos possuem as orelhas pontudas e os olhos afiados, mas o que mais costuma se destacar no longo prazo é sua habilidade manual, ágil e precisa. Costumam ser um povo isolado, no interior de florestas e matas, tendo pouco explorado da magia. Apesar de seu porte físico ágil, são bastante frágeis.";
        HabilidadeEsp.text = "Os Elfos podem saltar entre lugares altos sem hesitar, pultando entre telhados ou galhos como se estivessem no chão, e caso caiam ou saltem de grandes alturas, costumam se equilibrar com facilidade.";

        ImagemEspecie.sprite = ImgElfos;
    }

    public void Fadas ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Fadas";
            Especie = "Fada";
        AtrFortes.text = "Magia e Velocidade";
            NovoPersonagem.AtrForte1 = 5;
            NovoPersonagem.AtrForte2 = 8;
        AtrFracos.text = "Destreza, Força e Memória";
            NovoPersonagem.AtrFraco1 = 2;
            NovoPersonagem.AtrFraco2 = 3;
            NovoPersonagem.AtrFraco3 = 6;
        Condicoes.text = "35 de Vida, 50 de Mana, 35 de Sanidade.";
        DescricaoEsp.text = "Pequeninas, as Fadas possuem grande vantagem de deslocamento, uma vez que são bastante rápidas e ainda podem voar. São coloridas, e suas asas em formato de X cintílam ao bater. Costumam crescer em ambientes repletos de magia, de forma a compreenderem facilmente seu uso.";
        HabilidadeEsp.text = "As Fadas são capazes de voar rapidamente, e por longos períodos de tempo. Enquanto voam são mais difíceis de serem atingidas, mas podem acabar tendo dificuldades para se defender.";

        ImagemEspecie.sprite = ImgFadas;
    }

    public void Gigantes ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Gigantes";
            Especie = "Gigante";
        AtrFortes.text = "Força e Memória";
            NovoPersonagem.AtrForte1 = 3;
            NovoPersonagem.AtrForte2 = 6;
        AtrFracos.text = "Destreza, Magia e Sensibilidade";
            NovoPersonagem.AtrFraco1 = 2;
            NovoPersonagem.AtrFraco2 = 5;
            NovoPersonagem.AtrFraco3 = 7;
        Condicoes.text = "35 de Vida, 20 de Mana, 20 de Sanidade.";
        DescricaoEsp.text = "A mais alta das espécies de Utopia, e entre as maiores de todos os Planos, os Gigantes chegam a atingir 3,50m de altura, apesar de terem em média 3,20m. São fortes e rápidos, mas se destacam pelo conhecimento aguçado e formidável memória.";
        HabilidadeEsp.text = "Os longos braços e pernas dos Gigantes possibilitam que eles utilizem qualquer arma de combate Corpo-a-Corpo como se elas tivessem um alcance maior.";

        ImagemEspecie.sprite = ImgGigantes;
    }

    public void Goblins ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Goblins";
            Especie = "Goblin";
        AtrFortes.text = "Destreza e Inteligência";
            NovoPersonagem.AtrForte1 = 2;
            NovoPersonagem.AtrForte2 = 4;
        AtrFracos.text = "Constituição, Força e Sensibilidade";
            NovoPersonagem.AtrFraco1 = 1;
            NovoPersonagem.AtrFraco2 = 3;
            NovoPersonagem.AtrFraco3 = 7;
        Condicoes.text = "20 de Vida, 35 de Mana, 20 de Sanidade.";
        DescricaoEsp.text = "Pequenos e espertos, os Goblins são gênios da engenharia e robótica, mas apesar de toda a inteligência, são geralmente impulsivos e bastante propensos a testes pouco planejados. Possuem os braços mais compridos do que o torso, dados alongados, orelhas pontudas e olhos bem abertos, e o tom de pele é geralmente verde-musgo. Medem em torno de 1 metro de altura, pesando pouco mais de 20Kg.";
        HabilidadeEsp.text = "Os Goblins possuem uma sorte sem igual, ou pode ser fruto de sua astúcia avantajada, e acabam conseguindo mais Acertos Críticos do que as outras espécies.";

        ImagemEspecie.sprite = ImgGoblins;
    }

    public void Guyras ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Guyras";
            Especie = "Guyra";
        AtrFortes.text = "Inteligência e Velocidade";
            NovoPersonagem.AtrForte1 = 4;
            NovoPersonagem.AtrForte2 = 8;
        AtrFracos.text = "Destreza, Força e Magia";
            NovoPersonagem.AtrFraco1 = 2;
            NovoPersonagem.AtrFraco2 = 3;
            NovoPersonagem.AtrFraco3 = 5;
        Condicoes.text = "35 de Vida, 20 de Mana, 35 de Sanidade.";
        DescricaoEsp.text = "Dotados de largas asas, os Guyras são uma espécie de aves antropomórficas, seguindo linhagens de diferentes espécies. As asas dos Guyras saem de suas costas, e possuem uma envergadura maior do que a altura deles, permitindo um voo longo e estável, ou que planem de forma acelerada. São bastante velozes no ar.";
        HabilidadeEsp.text = "Os Guyras possuem asas fortes, e são capazes de voar por longes períodos, atingindo grandes alturas. Possuem maior mobilidade no ar, mas ficam sem uma boa base para se defender.";

        ImagemEspecie.sprite = ImgGuyras;
    }

    public void Humanos ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Humanos";
            Especie = "Humano";
        AtrFortes.text = "Magia e Sensibilidade";
            NovoPersonagem.AtrForte1 = 5;
            NovoPersonagem.AtrForte2 = 7;
        AtrFracos.text = "Constituição, Memória e Velocidade";
            NovoPersonagem.AtrFraco1 = 1;
            NovoPersonagem.AtrFraco2 = 6;
            NovoPersonagem.AtrFraco3 = 7;
        Condicoes.text = "20 de Vida, 50 de Mana, 50 de Sanidade.";
        DescricaoEsp.text = "Rapidamente se tornaram a mais populosa de Utopia, com uma alta taxa de reprodução, e uma sede constante de poder e controle, os humanos acabaram por dominar várias regiõe. Possuem grande habilidade de adaptação, principalmente ao risco e ao impossível, e costumam aceitar situações novas sem grandes dificuldades, dando espaço ao pensamento criativo e a resolução de problemas.";
        HabilidadeEsp.text = "Os humanos se abalam bastante com os acontecimentos catastróficos, mas são igualmente capazes de se estabilizar, recuperando sua Sanidade com um bom descanso.";

        ImagemEspecie.sprite = ImgHumanos;
    }

    public void Karumbes ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Karumbes";
            Especie = "Karumbe";
        AtrFortes.text = "Inteligência e Memória";
            NovoPersonagem.AtrForte1 = 4;
            NovoPersonagem.AtrForte2 = 6;
        AtrFracos.text = "Teste";
            NovoPersonagem.AtrFraco1 = 2;
            NovoPersonagem.AtrFraco2 = 7;
            NovoPersonagem.AtrFraco3 = 8;
        Condicoes.text = "35 de Vida, 35 de Mana, 20 de Sanidade.";
        DescricaoEsp.text = "Os Karumbes são enormes, ou pelo menos dão a sensação de ser. Apesar de nem sempre terem uma grande estatura, em torno dos 1,70m, os Karumbes possuem enormes cascos nas costas, o que os torna pesados e largos, chegando aos 300Kg. São homens-tartaruga, e são uma das mais sábias espécies habitando Utopia.";
        HabilidadeEsp.text = "O casco dos Karumbes é extremamente resistente, e pode aguentar muito mais golpes e pressão do que qualquer outra espécie.";

        ImagemEspecie.sprite = ImgKarumbes;
    }

    public void Ocelots ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Ocelots";
            Especie = "Ocelot";
        AtrFortes.text = "Destreza e Velocidade";
            NovoPersonagem.AtrForte1 = 2;
            NovoPersonagem.AtrForte2 = 8;
        AtrFracos.text = "Força, Magia e Memória";
            NovoPersonagem.AtrFraco1 = 3;
            NovoPersonagem.AtrFraco2 = 5;
            NovoPersonagem.AtrFraco3 = 6;
        Condicoes.text = "35 de Vida, 50 de Mana, 35 de Sanidade.";
        DescricaoEsp.text = "Os Ocelots são híbridos de felinos e humanos, sendo uma espécie original de Ailâmina. São rápidos e habilidosos, tendo grande delicadeza e precisão no uso de suas garras.";
        HabilidadeEsp.text = "Os Ocelots possuem garras retráteis, que quando devidamente afiadas podem facilmente ultrapassar a eficiência de uma lâmina.";

        ImagemEspecie.sprite = ImgOcelots;
    }

    public void Orcs ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Orcs";
            Especie = "Orc";
        AtrFortes.text = "Constituição e Força";
            NovoPersonagem.AtrForte1 = 1;
            NovoPersonagem.AtrForte2 = 3;
        AtrFracos.text = "Destreza, Inteligência e Magia";
            NovoPersonagem.AtrFraco1 = 2;
            NovoPersonagem.AtrFraco2 = 5;
            NovoPersonagem.AtrFraco3 = 6;
        Condicoes.text = "50 de Vida, 20 de Mana, 35 de Sanidade.";
        DescricaoEsp.text = "Muitas são as raças dos Orcs, e a maioria delas tem tendências violentas. Não possuem paciência o suficiente para praticar a delicadeza, de forma que a maioria deles é bruta, mas possuem uma maestria desigual com lâminas e clavas. Possuem a pele resistente, semelhante ao couro dos Vakames.";
        HabilidadeEsp.text = "A pele dos Orcs é resistente o suficiente para diminuir o deslizar de uma lâmina, e apenas armas realmente afiadas conseguem ferí-los.";

        ImagemEspecie.sprite = ImgOrcs;
    }

    public void Profanos ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Profanos";
            Especie = "Profano";
        AtrFortes.text = "Magia e Sensibilidade";
            NovoPersonagem.AtrForte1 = 5;
            NovoPersonagem.AtrForte2 = 7;
        AtrFracos.text = "Constituição, Força e Velocidade";
            NovoPersonagem.AtrFraco1 = 1;
            NovoPersonagem.AtrFraco2 = 2;
            NovoPersonagem.AtrFraco3 = 8;
        Condicoes.text = "20 de Vida, 50 de Mana, 50 de Sanidade.";
        DescricaoEsp.text = "Os Profanos são uma espécie de granhe habilidade. Possuem uma cauda fina e alongada, bastante flexível, mas que não possui a firmeza da cauda dos Anguzas, de forma que não pode ser utilizada para segurar objetos, e possuem também pequenos chifres retorcidos na cabeça, olhos escurecidos e a pele arroxeada.";
        HabilidadeEsp.text = "Os Profanos são capazes de enxergar perfeitamente no escuro, inclusive vendo cores e escritos, e se tornando ainda mais atenciosos na escuridão.";

        ImagemEspecie.sprite = ImgProfanos;
    }

    public void Tejus ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Tejus";
            Especie = "Teju";
        AtrFortes.text = "Constituição e Sensibilidade";
            NovoPersonagem.AtrForte1 = 1;
            NovoPersonagem.AtrForte2 = 7;
        AtrFracos.text = "Inteligência, Magia e Velocidade";
            NovoPersonagem.AtrFraco1 = 4;
            NovoPersonagem.AtrFraco2 = 5;
            NovoPersonagem.AtrFraco3 = 8;
        Condicoes.text = "50 de Vida, 20 de Mana, 50 de Sanidade.";
        DescricaoEsp.text = "Versões antropomórficas de lagartos e salamandras, os Tejus são uma espécie de sangue frio, literal e figurativamente. São geralmente calmos, e costumam dizer que jogam o jogo longo, planejando estratégias de longa duração.";
        HabilidadeEsp.text = "Os Tejus produzem um gás natural em suas mandíbulas, e podem liberá-lo com uma baforada. Esse gás é extremamente inflamável, e pode queimar rapidamente em contato com fontes de calor, podendo até mesmo machucar o Teju.";

        ImagemEspecie.sprite = ImgTejus;
    }

    public void Tritoes ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Tritões";
            Especie = "Tritão";
        AtrFortes.text = "Destreza e Velocidade";
            NovoPersonagem.AtrForte1 = 2;
            NovoPersonagem.AtrForte2 = 8;
        AtrFracos.text = "Inteligência, Magia e Sensibilidade";
            NovoPersonagem.AtrFraco1 = 4;
            NovoPersonagem.AtrFraco2 = 5;
            NovoPersonagem.AtrFraco3 = 7;
        Condicoes.text = "35 de Vida, 20 de Mana, 20 de Sanidade.";
        DescricaoEsp.text = "Habitantes dos mares, os Tritões são um povo de pele variando entre o azul e o verde, com raros casos de peles cor-de-rosa. São capazes de respirar tanto embaixo d’água quanto fora dela, mas são bem mais velozes quando se encontram dentro do mar. Possuem guelras e nadadeiras, e membranas retráteis nos dedos das mãos e dos pés.";
        HabilidadeEsp.text = "Os Tritões possuem grande afinidade com ambientes aquáticos, podendo respirar embaixo d'água, e recuperando o dobro de Vida ao descansarem submersos.";

        ImagemEspecie.sprite = ImgTritoes;
    }

    public void Vakames ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Vakames";
            Especie = "Vakame";
        AtrFortes.text = "Força e Inteligência";
            NovoPersonagem.AtrForte1 = 3;
            NovoPersonagem.AtrForte2 = 4;
        AtrFracos.text = "Destreza, Memória e Sensibilidade";
            NovoPersonagem.AtrFraco1 = 2;
            NovoPersonagem.AtrFraco2 = 6;
            NovoPersonagem.AtrFraco3 = 7;
        Condicoes.text = "35 de Vida, 35 de Mana, 20 de Sanidade.";
        DescricaoEsp.text = "Os Vakames são versões antropomórficas dos touros e bisões. São robustos, resistentes e fortes, e dotados de uma alta inteligência. Diferentes raças de Vakames possuem diferentes formações de chifres, variando em número, posição e tamanho, mas todas os possuem. Seu corpo é coberto por uma baixa pelugem, e os pés são duros cascos, de forma que não usam sapatos para protegê-los.";
        HabilidadeEsp.text = "Os Vakames são capazes de se movimentar em grandes impulsos, removendo o que estiver em seu caminho com fortes cabeçadas.";

        ImagemEspecie.sprite = ImgVakames;
    }

    public void Yttas ()
    {  
        LiberarPainel ();

        NomeEspecie.text = "Yttas";
            Especie = "Ytta";
        AtrFortes.text = "Magia e Memória";
            NovoPersonagem.AtrForte1 = 5;
            NovoPersonagem.AtrForte2 = 6;
        AtrFracos.text = "Constituição, Destreza e Força";
            NovoPersonagem.AtrFraco1 = 1;
            NovoPersonagem.AtrFraco2 = 2;
            NovoPersonagem.AtrFraco3 = 3;
        Condicoes.text = "20 de Vida, 50 de Mana, 35 de Sanidade.";
        DescricaoEsp.text = "Possuem a pele bastante clara, quase transparente, em tons azulados e arroxeados, os membros grossos e a testa enorme, formando uma ponta em sua cabeça, com cabelos compridos e grossos. São, normalmente, fracos e lentos, mas compensam com movimentos precisos e inteligentes.";
        HabilidadeEsp.text = "Os Yttas são capazes de sentir a magia mesmo sem serem usuários da mesma, e podem detectar informações de tipos de magia que não dominam.";

        ImagemEspecie.sprite = ImgYttas;
    }

    private void LiberarPainel ()
    {
        BtnConfirmar.enabled = true;
        BtnConfirmar.GetComponent<Image>().sprite = BotaoConfirmar;

        ImagemEspecie.enabled = true;
        NomeEspecie.enabled = true;
        AtrFortes.enabled = true;
        AtrFracos.enabled = true;
        Condicoes.enabled = true;
        DescricaoEsp.enabled = true;
        HabilidadeEsp.enabled = true;
        TextoBase1.enabled = true;
        TextoBase2.enabled = true;
        TextoBase3.enabled = true;
        TextoBase4.enabled = true;
    }

    public void Retornar ()
    {
        SceneManager.LoadScene ("MenuInicial");
    }

    public void ConfirmarEscolha ()
    {
        ConfirmarEscolhaEspecie = true;
        PlayerPrefs.SetString ("EspeciePersonagem", Especie);
        SceneManager.LoadScene ("Criar002Origem");
    }
}
