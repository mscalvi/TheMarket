using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class OutGameMenu : MonoBehaviour
{
    private Button BtnNewGame;
    private Button BtnNewGameConfirm;
    private Button BtnNewGameDeny;
    private Button BtnLoadGame;
    private Button BtnConfig;
    private Button BtnReturn;

    [SerializeField] RectTransform ConfirmPanel;
    [SerializeField] TextMeshProUGUI MensagePanel;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("GameLoaded");
        ConfirmPanel.localScale = new Vector3 (0, 0, 0);
    }

    public void NewGameBtn ()
    {
        if (PlayerPrefs.GetInt("GameGoing") == 0)
        {
            ConfirmPanel.localScale = new Vector3 (1, 1, 0);
            MensagePanel.text = "Tem certeza? Vai apagar o progresso salvo!";
        } else {
            SceneManager.LoadScene ("02NewGame");
        }
    }

    public void NewGameConfirmBtn ()
    {
        SceneManager.LoadScene ("02NewGame");
    }

    public void NewGameDenyBtn ()
    { 
        ConfirmPanel.localScale = new Vector3 (0, 0, 0);
    }

    public void LoadGameBtn ()
    {
        SceneManager.LoadScene ("03LoadGame");
    }

    public void ConfigBtn ()
    {
        SceneManager.LoadScene ("04Config");
    }

    public void ReturnBtn ()
    {
        SceneManager.LoadScene ("01LandingPage");
    }
}
