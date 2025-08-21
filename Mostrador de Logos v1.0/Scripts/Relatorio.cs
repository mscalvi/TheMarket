using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Relatorio : MonoBehaviour
{
    public Canvas canvasBotoes001;
    public Canvas canvasBotoes002;
    public Canvas canvasBotoes003;
    public Canvas canvasBotoes004;
    public Canvas canvasBotoes005;
    public Canvas canvasRelatorio;

    public TextMeshProUGUI RelatorioTexto;
    public Button bVoltar;
    public Button mRelatorio;

    public static List<string> RelatorioDados = new List<string> ();

    // Start is called before the first frame update
    void Start()
    {
        canvasRelatorio.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Voltar ()
    {
        canvasBotoes001.enabled = true;
        canvasBotoes002.enabled = false;
        canvasBotoes003.enabled = false;
        canvasBotoes004.enabled = false;
        canvasBotoes005.enabled = false;
        canvasRelatorio.enabled = false;
    }

    public void MostrarRelatorio ()
    {
        string result = "Empresas chamadas: ";
        foreach (var item in RelatorioDados)
        {
            result += item.ToString() + ", ";
        }
        RelatorioTexto.text = result;
    }
}
