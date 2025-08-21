using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class NovoPersonagem : MonoBehaviour
{
    public static string Origem;
    public static int EspecieNum;
    public static int AtrForte1;
    public static int AtrForte2;
    public static int AtrFraco1;
    public static int AtrFraco2;
    public static int AtrFraco3;
    public static int AtrExtraD;
    public static int AtrExtraU;

    public static int aConstituicao;
    public static int aDestreza;
    public static int aForca;
    public static int aInteligencia;
    public static int aMagia;
    public static int aMemoria;
    public static int aSensibilidade;
    public static int aVelocidade;

    public static int rConstituicao;
    public static int rDestreza;
    public static int rForca;
    public static int rInteligencia;
    public static int rMagia;
    public static int rMemoria;
    public static int rSensibilidade;
    public static int rVelocidade;

    public static int fConstituicao;
    public static int fDestreza;
    public static int fForca;
    public static int fInteligencia;
    public static int fMagia;
    public static int fMemoria;
    public static int fSensibilidade;
    public static int fVelocidade;

    public static int aVida;
    public static int rVida;
    public static int fVida;
    public static int aMana;
    public static int rMana;
    public static int fMana;
    public static int aSanidade;
    public static int rSanidade;
    public static int fSanidade;

    private int SuperStatus;
    public static int SuperMemoria;
    public static bool CalculosCompletos;

    public static int DinheiroInicial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Criar001Especies.ConfirmarEscolhaEspecie == true)
        {
            if (AtrForte1 == 1 || AtrForte2 == 1){aConstituicao = 13;}
                else if (AtrFraco1 == 1 || AtrFraco2 == 1 || AtrFraco3 == 1){aConstituicao = 3;}
                else {aConstituicao = 8;}
            
            if (AtrForte1 == 2 || AtrForte2 == 2){aDestreza = 13;}
                else if (AtrFraco1 == 2 || AtrFraco2 == 2 || AtrFraco3 == 2){aDestreza = 3;}
                else {aDestreza = 8;}
           
            if (AtrForte1 == 3 || AtrForte2 == 3){aForca = 13;}
                if (AtrFraco1 == 3 || AtrFraco2 == 3 || AtrFraco3 == 3){aForca = 3;}
                else {aForca = 8;}
            
            if (AtrForte1 == 4 || AtrForte2 == 4){aInteligencia = 13;}
                if (AtrFraco1 == 4 || AtrFraco2 == 4 || AtrFraco3 == 4){aInteligencia = 3;}
                else {aInteligencia = 8;}
            
            if (AtrForte1 == 5 || AtrForte2 == 5){aMagia = 13;}
                if (AtrFraco1 == 5 || AtrFraco2 == 5 || AtrFraco3 == 5){aMagia = 3;}
                else {aMagia = 8;}
            
            if (AtrForte1 == 6 || AtrForte2 == 6){aMemoria = 13;}
                if (AtrFraco1 == 6 || AtrFraco2 == 6 || AtrFraco3 == 6){aMemoria = 3;}
                else {aMemoria = 8;}
            
            if (AtrForte1 == 7 || AtrForte2 == 7){aSensibilidade = 13;}
                if (AtrFraco1 == 7 || AtrFraco2 == 7 || AtrFraco3 == 7){aSensibilidade = 3;} 
                else {aSensibilidade = 8;}          
            
            if (AtrForte1 == 8 || AtrForte2 == 8){aVelocidade = 13;}
                if (AtrFraco1 == 8 || AtrFraco2 == 8 || AtrFraco3 == 8){aVelocidade = 3;}
                else {aVelocidade = 8;}

            if (aConstituicao == 3){aVida = 20;}
                else if (aConstituicao == 8){aVida = 35;}
                else {aVida = 50;}

            if (aMagia == 3){aMana = 20;}
                else if (aMagia == 8){aMana = 35;}
                else {aMana = 50;}

            if (aSensibilidade == 3){aSanidade = 20;}
                else if (aSensibilidade == 8){aSanidade = 35;}
                else {aSanidade = 50;}

            Criar001Especies.ConfirmarEscolhaEspecie = false;
        }

        if (Criar002Origem.ConfirmarEscolhaOrigem == true)
        {
            if (Criar003Atributos.Rolada3 <= 3)
            {
            rConstituicao = Random.Range(1,5);
            if (AtrExtraU == 1) {rConstituicao += 1;}
            if (AtrExtraD == 1) {rConstituicao -= 1;}
            fConstituicao = aConstituicao + rConstituicao;
            
            rDestreza = Random.Range(1,5);
            if (AtrExtraU == 2) {rDestreza += 1;}
            if (AtrExtraD == 2) {rDestreza -= 1;}
            fDestreza = aDestreza + rDestreza;
            
            rForca = Random.Range(1,5);
            if (AtrExtraU == 3) {rForca += 1;}
            if (AtrExtraD == 3) {rForca -= 1;}
            fForca = aForca + rForca;
            
            rInteligencia = Random.Range(1,5);
            if (AtrExtraU == 4) {rInteligencia += 1;}
            if (AtrExtraD == 4) {rInteligencia -= 1;}
            fInteligencia = aInteligencia + rInteligencia;
            
            rMagia = Random.Range(1,5);
            if (AtrExtraU == 5) {rMagia += 1;}
            if (AtrExtraD == 5) {rMagia -= 1;}
            fMagia = aMagia + rMagia;
            
            rMemoria = Random.Range(1,5);
            if (AtrExtraU == 6) {rMemoria += 1;}
            if (AtrExtraD == 6) {rMemoria -= 1;}
            fMemoria = aMemoria + rMemoria;
            
            rSensibilidade = Random.Range(1,5);
            if (AtrExtraU == 7) {rSensibilidade += 1;}
            if (AtrExtraD == 7) {rSensibilidade -= 1;}
            fSensibilidade = aSensibilidade + rSensibilidade;
            
            rVelocidade = Random.Range(1,5);
            if (AtrExtraU == 8) {rVelocidade += 1;}
            if (AtrExtraD == 8) {rVelocidade -= 1;}
            fVelocidade = aVelocidade + rVelocidade;
            
            rVida = Random.Range(1,11);
            fVida = aVida + rVida;
            
            rMana = Random.Range(1,11);
            fMana = aMana + rMana;
            
            rSanidade = Random.Range(1,11);
            fSanidade = aSanidade + rSanidade;

            PlayerPrefs.SetString ("OrigemPersonagem", Origem);

            Criar002Origem.ConfirmarEscolhaOrigem = false;
            }
        }

        if (Criar003Atributos.ConfirmarEscolhaAtributos == true)
        {
            PlayerPrefs.SetInt("Constituicao", fConstituicao);
            PlayerPrefs.SetInt("Destreza", fDestreza);
            PlayerPrefs.SetInt("Forca", fForca);
            PlayerPrefs.SetInt("Inteligencia", fInteligencia);
            PlayerPrefs.SetInt("Magia", fMagia);
            PlayerPrefs.SetInt("Memoria", fMemoria);
            PlayerPrefs.SetInt("Sensibilidade", fSensibilidade);
            PlayerPrefs.SetInt("Velocidade", fVelocidade);

            PlayerPrefs.SetInt("VidaMax", fVida);
            PlayerPrefs.SetInt("ManaMax", fMana);
            PlayerPrefs.SetInt("SaniMax", fSanidade);

            PlayerPrefs.SetInt("VidaAtual", fVida);
            PlayerPrefs.SetInt("ManaAtual", fMana);
            PlayerPrefs.SetInt("SaniAtual", fSanidade);

            if (fConstituicao <= 9)
            {
                PlayerPrefs.SetInt("ContraAtaque", 1);
                PlayerPrefs.SetInt("Folego", 1);
                PlayerPrefs.SetInt("PrimeirosSocorros", 1);
            } else {
                PlayerPrefs.SetInt("ContraAtaque", 2);
                PlayerPrefs.SetInt("Folego", 2);
                PlayerPrefs.SetInt("PrimeirosSocorros", 2);
            }
            if (fConstituicao >= 16)
            {
                SuperStatus = Random.Range (1, 4);
                if (SuperStatus == 1) {PlayerPrefs.SetInt("ContraAtaque", 3);}
                if (SuperStatus == 2) {PlayerPrefs.SetInt("Folego", 3);}
                if (SuperStatus == 3) {PlayerPrefs.SetInt("DestrezaManual", 3);}
            }

            if (fDestreza <= 9)
            {
                PlayerPrefs.SetInt("ArmasLongoAlcance", 1);
                PlayerPrefs.SetInt("ArmasPrecisao", 1);
                PlayerPrefs.SetInt("DestrezaManual", 1);
                PlayerPrefs.SetInt("Furtividade", 1);
            } else {
                PlayerPrefs.SetInt("ArmasLongoAlcance", 2);
                PlayerPrefs.SetInt("ArmasPrecisao", 2);
                PlayerPrefs.SetInt("DestrezaManual", 2);
                PlayerPrefs.SetInt("Furtividade", 2);
            }
            if (fDestreza >= 16)
            {
                SuperStatus = Random.Range (1, 5);
                if (SuperStatus == 1) {PlayerPrefs.SetInt("ArmasLongoAlcance", 3);}
                if (SuperStatus == 2) {PlayerPrefs.SetInt("ArmasPrecisao", 3);}
                if (SuperStatus == 3) {PlayerPrefs.SetInt("DestrezaManual", 3);}
                if (SuperStatus == 4) {PlayerPrefs.SetInt("Furtividade", 3);}
            }

            if (fForca <= 9)
            {
                PlayerPrefs.SetInt("ArmasArremesso", 1);
                PlayerPrefs.SetInt("ArmasCorpoCorpo", 1);
                PlayerPrefs.SetInt("Bloqueio", 1);
                PlayerPrefs.SetInt("Atletismo", 1);
            } else {
                PlayerPrefs.SetInt("ArmasArremesso", 2);
                PlayerPrefs.SetInt("ArmasCorpoCorpo", 2);
                PlayerPrefs.SetInt("Bloqueio", 2);
                PlayerPrefs.SetInt("Atletismo", 2);
            }
            if (fForca >= 16)
            {
                SuperStatus = Random.Range (1, 5);
                if (SuperStatus == 1) {PlayerPrefs.SetInt("ArmasArremesso", 3);}
                if (SuperStatus == 2) {PlayerPrefs.SetInt("ArmasCorpoCorpo", 3);}
                if (SuperStatus == 3) {PlayerPrefs.SetInt("Bloqueio", 3);}
                if (SuperStatus == 4) {PlayerPrefs.SetInt("Atletismo", 3);}
            }

            if (fInteligencia <= 9)
            {
                PlayerPrefs.SetInt("SegundaMao", 1);
                PlayerPrefs.SetInt("Concentracao", 1);
                PlayerPrefs.SetInt("Reflexo", 1);
            } else {
                PlayerPrefs.SetInt("SegundaMao", 2);
                PlayerPrefs.SetInt("Concentracao", 2);
                PlayerPrefs.SetInt("Reflexo", 2);
            }
            if (fInteligencia >= 16)
            {
                SuperStatus = Random.Range (1, 4);
                if (SuperStatus == 1) {PlayerPrefs.SetInt("SegundaMao", 3);}
                if (SuperStatus == 2) {PlayerPrefs.SetInt("Concentracao", 3);}
                if (SuperStatus == 3) {PlayerPrefs.SetInt("Reflexo", 3);}
            }

            if (fMagia <= 9)
            {
                PlayerPrefs.SetInt("Canalizadores", 1);
                PlayerPrefs.SetInt("Arcanismo", 1);
                PlayerPrefs.SetInt("PercepcaoArcana", 1);
            } else {
                PlayerPrefs.SetInt("Canalizadores", 2);
                PlayerPrefs.SetInt("Arcanismo", 2);
                PlayerPrefs.SetInt("PercepcaoArcana", 2);
            }
            if (fMagia >= 16)
            {
                SuperStatus = Random.Range (1, 4);
                if (SuperStatus == 1) {PlayerPrefs.SetInt("Canalizadores", 3);}
                if (SuperStatus == 2) {PlayerPrefs.SetInt("Arcanismo", 3);}
                if (SuperStatus == 3) {PlayerPrefs.SetInt("PercepcaoArcana", 3);}
            }

            if (fSensibilidade <= 9)
            {
                PlayerPrefs.SetInt("Carisma", 1);
                PlayerPrefs.SetInt("PercepcaoSensorial", 1);
                PlayerPrefs.SetInt("PersuasaoAnimal", 1);
            } else {
                PlayerPrefs.SetInt("Carisma", 2);
                PlayerPrefs.SetInt("PercepcaoSensorial", 2);
                PlayerPrefs.SetInt("PersuasaoAnimal", 2);
            }
            if (fSensibilidade >= 16)
            {
                SuperStatus = Random.Range (1, 4);
                if (SuperStatus == 1) {PlayerPrefs.SetInt("Carisma", 3);}
                if (SuperStatus == 2) {PlayerPrefs.SetInt("PercepcaoSensorial", 3);}
                if (SuperStatus == 3) {PlayerPrefs.SetInt("PersuasaoAnimal", 3);}
            }

            if (fVelocidade <= 9)
            {
                PlayerPrefs.SetInt("ArtesMarciais", 1);
                PlayerPrefs.SetInt("Esquiva", 1);
                PlayerPrefs.SetInt("Acrobacia", 1);
                PlayerPrefs.SetInt("Equilibrio", 1);
            } else {
                PlayerPrefs.SetInt("ArtesMarciais", 2);
                PlayerPrefs.SetInt("Esquiva", 2);
                PlayerPrefs.SetInt("Acrobacia", 2);
                PlayerPrefs.SetInt("Equilibrio", 2);
            }
            if (fVelocidade >= 16)
            {
                SuperStatus = Random.Range (1, 5);
                if (SuperStatus == 1) {PlayerPrefs.SetInt("ArtesMarciais", 3);}
                if (SuperStatus == 2) {PlayerPrefs.SetInt("Esquiva", 3);}
                if (SuperStatus == 3) {PlayerPrefs.SetInt("Acrobacia", 3);}
                if (SuperStatus == 4) {PlayerPrefs.SetInt("Equilibrio", 3);}
            }

            if (fMemoria <= 8)
            {
                PlayerPrefs.SetInt("ConAlquimicos", 1);
                PlayerPrefs.SetInt("ConArcanos", 1);
                PlayerPrefs.SetInt("ConHistoricos", 1);    
                PlayerPrefs.SetInt("ConMecanicos", 1);
                PlayerPrefs.SetInt("ConMedicinais", 1);
                PlayerPrefs.SetInt("ConNaturais", 1);
            } else {
                if (fMemoria <= 10){SuperMemoria = 2;} 
                else if (fMemoria > 14){SuperMemoria = 4;} 
                else {SuperMemoria = 3;}
            }

            CalculosCompletos = true;

            Criar003Atributos.ConfirmarEscolhaAtributos = false;
        }
    }


    public void Retornar ()
    {
        SceneManager.LoadScene ("MenuInicial");
    }
}
