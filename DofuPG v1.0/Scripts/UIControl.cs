using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    public GameObject painelFicha;
    public GameObject painelSkills;
    public GameObject painelMundo;
    public GameObject painelDados;               


    public void MostrarFicha()
    {
        painelFicha.SetActive(true);
        painelSkills.SetActive(false);
        painelMundo.SetActive(false);
        painelDados.SetActive(false);
    }

    public void MostrarSkills()
    {
        painelFicha.SetActive(false);
        painelSkills.SetActive(true);
        painelMundo.SetActive(false);
        painelDados.SetActive(false);
    }

    public void MostrarMundo()
    {
        painelFicha.SetActive(false);
        painelSkills.SetActive(false);
        painelMundo.SetActive(true);
        painelDados.SetActive(false);
    }

    public void MostrarDados()
    {
        painelFicha.SetActive(false);
        painelSkills.SetActive(false);
        painelMundo.SetActive(false);
        painelDados.SetActive(true);
    }
}
