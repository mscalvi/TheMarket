using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu01 : MonoBehaviour
{   
    public Image iHolder;
    public Image i001;
    public Image i002;
    public Image i003;
    public Image i004;
    public Image i005;
    public Image i006;
    public Image i007;
    public Image i008;
    public Image i009;
    public Image i010;
    public Image i011;
    public Image i012;
    public Image i013;
    public Image i014;
    public Image i015;
    public Image i016;
    public Image i017;
    public Image i018;
    public Image i019;
    public Image i020;
    public Image i021;
    public Image i022;
    public Image i023;
    public Image i024;
    public Image i025;
    public Image i026;
    public Image i027;
    public Image i028;
    public Image i029;
    public Image i030;
    public Image i031;
    public Image i032;
    public Image i033;
    public Image i034;
    public Image i035;
    public Image i036;
    public Image i037;
    public Image i038;
    public Image i039;
    public Image i040;

    public Button botao001;
    public Button botao002;
    public Button botao003;
    public Button botao004;
    public Button botao005;
    public Button botao006;
    public Button botao007;
    public Button botao008;
    public Button botao009;
    public Button botao010;
    public Button botao011;
    public Button botao012;
    public Button botao013;
    public Button botao014;
    public Button botao015;
    public Button botao016;
    public Button botao017;
    public Button botao018;
    public Button botao019;
    public Button botao020;
    public Button botao021;
    public Button botao022;
    public Button botao023;
    public Button botao024;
    public Button botao025;
    public Button botao026;
    public Button botao027;
    public Button botao028;
    public Button botao029;
    public Button botao030;
    public Button botao031;
    public Button botao032;
    public Button botao033;
    public Button botao034;
    public Button botao035;
    public Button botao036;
    public Button botao037;
    public Button botao038;
    public Button botao039;
    public Button botao040;

    public Canvas canvasBotoes001;
    public Canvas canvasBotoes002;
    public Canvas canvasBotoes003;
    public Canvas canvasBotoes004;
    public Canvas canvasBotoes005;
    public Canvas canvasRelatorio;

    public Button bSair;
    public Button bRelatorio;

    // Start is called before the first frame update
    void Start()
    {
        LimparTela ();
        iHolder.enabled = true;
        canvasBotoes001.enabled = true;
        canvasBotoes002.enabled = false;
        canvasBotoes003.enabled = false;
        canvasBotoes004.enabled = false;
        canvasBotoes005.enabled = false;
    }

    public void LimparTela ()
    {
        iHolder.enabled = false;
        i001.enabled = false;
        i002.enabled = false;
        i003.enabled = false;
        i004.enabled = false;
        i005.enabled = false;
        i006.enabled = false;
        i007.enabled = false;
        i008.enabled = false;
        i009.enabled = false;
        i010.enabled = false;
        i011.enabled = false;
        i012.enabled = false;
        i013.enabled = false;
        i014.enabled = false;
        i015.enabled = false;
        i016.enabled = false;
        i017.enabled = false;
        i018.enabled = false;
        i019.enabled = false;
        i020.enabled = false;
        i021.enabled = false;
        i022.enabled = false;
        i023.enabled = false;
        i024.enabled = false;
        i025.enabled = false;
        i026.enabled = false;
        i027.enabled = false;
        i028.enabled = false;
        i029.enabled = false;
        i030.enabled = false;
        i031.enabled = false;
        i032.enabled = false;
        i033.enabled = false;
        i034.enabled = false;
        i035.enabled = false;
        i036.enabled = false;
        i037.enabled = false;
        i038.enabled = false;
        i039.enabled = false;
        i040.enabled = false;
    }

    public void BotaoApertado001 ()
    {
        LimparTela ();
        botao001.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B1");
        i001.enabled = true;
    }
    public void BotaoApertado002 (){
        LimparTela ();
        botao002.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B2");
        i002.enabled = true;}
    public void BotaoApertado003 (){
        LimparTela ();
        botao003.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B3");
        i003.enabled = true;}
    public void BotaoApertado004 (){
        LimparTela ();
        botao004.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B4");
        i004.enabled = true;}
    public void BotaoApertado005 (){
        LimparTela ();
        botao005.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B5");
        i005.enabled = true;}
    public void BotaoApertado006 (){
        LimparTela ();
        botao006.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B6");
        i006.enabled = true;}
    public void BotaoApertado007 (){
        LimparTela ();
        botao007.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B7");
        i007.enabled = true;}
    public void BotaoApertado008 (){
        LimparTela ();
        botao008.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B8");
        i008.enabled = true;}
    public void BotaoApertado009 (){
        LimparTela ();
        botao009.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B9");
        i009.enabled = true;}
    public void BotaoApertado010 (){
        LimparTela ();
        botao010.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B10");
        i010.enabled = true;}
    public void BotaoApertado011 (){
        LimparTela ();
        botao011.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B11");
        i011.enabled = true;}
    public void BotaoApertado012 (){
        LimparTela ();
        botao012.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B12");
        i012.enabled = true;}
    public void BotaoApertado013 (){
        LimparTela ();
        botao013.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B13");
        i013.enabled = true;}
    public void BotaoApertado014 (){
        LimparTela ();
        botao014.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B14");
        i014.enabled = true;}
    public void BotaoApertado015 (){
        LimparTela ();
        botao015.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B15");
        i015.enabled = true;}
    public void BotaoApertado016 (){
        LimparTela ();
        botao016.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B16");
        i016.enabled = true;}
    public void BotaoApertado017 (){
        LimparTela ();
        botao017.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B17");
        i017.enabled = true;}
    public void BotaoApertado018 (){
        LimparTela ();
        botao018.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B18");
        i018.enabled = true;}
    public void BotaoApertado019 (){
        LimparTela ();
        botao019.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B19");
        i019.enabled = true;}
    public void BotaoApertado020 (){
        LimparTela ();
        botao020.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B20");
        i020.enabled = true;}
    public void BotaoApertado021 (){
        LimparTela ();
        botao021.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B21");
        i021.enabled = true;}
    public void BotaoApertado022 (){
        LimparTela ();
        botao022.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B22");
        i022.enabled = true;}
    public void BotaoApertado023 (){
        LimparTela ();
        botao023.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B23");
        i023.enabled = true;}
    public void BotaoApertado024 (){
        LimparTela ();
        botao024.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B24");
        i024.enabled = true;}
    public void BotaoApertado025 (){
        LimparTela ();
        botao025.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B25");
        i025.enabled = true;}
    public void BotaoApertado026 (){
        LimparTela ();
        botao026.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B26");
        i026.enabled = true;}
    public void BotaoApertado027 (){
        LimparTela ();
        botao027.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B27");
        i027.enabled = true;}
    public void BotaoApertado028 (){
        LimparTela ();
        botao028.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B28");
        i028.enabled = true;}
    public void BotaoApertado029 (){
        LimparTela ();
        botao029.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B29");
        i029.enabled = true;}
    public void BotaoApertado030 (){
        LimparTela ();
        botao030.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B30");
        i020.enabled = true;}
    public void BotaoApertado031 (){
        LimparTela ();
        botao031.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B31");
        i031.enabled = true;}
    public void BotaoApertado032 (){
        LimparTela ();
        botao032.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B32");
        i032.enabled = true;}
    public void BotaoApertado033 (){
        LimparTela ();
        botao033.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B33");
        i033.enabled = true;}
    public void BotaoApertado034 (){
        LimparTela ();
        botao034.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B34");
        i034.enabled = true;}
    public void BotaoApertado035 (){
        LimparTela ();
        botao035.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B35");
        i035.enabled = true;}
    public void BotaoApertado036 (){
        LimparTela ();
        botao036.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B36");
        i036.enabled = true;}
    public void BotaoApertado037 (){
        LimparTela ();
        botao037.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B37");
        i037.enabled = true;}
    public void BotaoApertado038 (){
        LimparTela ();
        botao038.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B38");
        i038.enabled = true;}
    public void BotaoApertado039 (){
        LimparTela ();
        botao039.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B39");
        i039.enabled = true;}
    public void BotaoApertado040 (){
        LimparTela ();
        botao040.GetComponent<Image>().color = Color.red;
        Relatorio.RelatorioDados.Add ("B40");
        i040.enabled = true;}

    
    public void LoadMenu01 ()
    {  
        LimparTela ();
        canvasBotoes001.enabled = true;
        canvasBotoes002.enabled = false;
        canvasBotoes003.enabled = false;
        canvasBotoes004.enabled = false;
        canvasBotoes005.enabled = false;
    }
    public void LoadMenu02 ()
    {
        LimparTela ();
        canvasBotoes001.enabled = false;
        canvasBotoes002.enabled = true;
        canvasBotoes003.enabled = false;
        canvasBotoes004.enabled = false;
        canvasBotoes005.enabled = false;
    }
    public void LoadMenu03 ()
    {
        LimparTela ();
        canvasBotoes001.enabled = false;
        canvasBotoes002.enabled = false;
        canvasBotoes003.enabled = true;
        canvasBotoes004.enabled = false;
        canvasBotoes005.enabled = false;
    }
    public void LoadMenu04 ()
    {
        LimparTela ();
        canvasBotoes001.enabled = false;
        canvasBotoes002.enabled = false;
        canvasBotoes003.enabled = false;
        canvasBotoes004.enabled = true;
        canvasBotoes005.enabled = false;
    }
    public void LoadMenu05 ()
    {
        LimparTela ();
        canvasBotoes001.enabled = false;
        canvasBotoes002.enabled = false;
        canvasBotoes003.enabled = false;
        canvasBotoes004.enabled = false;
        canvasBotoes005.enabled = true;
    }

    public void chamarRelatorio ()
    {
        LimparTela ();
        iHolder.enabled = true;
        canvasBotoes001.enabled = false;
        canvasBotoes002.enabled = false;
        canvasBotoes003.enabled = false;
        canvasBotoes004.enabled = false;
        canvasBotoes005.enabled = false;
        canvasRelatorio.enabled = true;
    }

    public void Sair ()
    {
        Application.Quit ();
    }
}
