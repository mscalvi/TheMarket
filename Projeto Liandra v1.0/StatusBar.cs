using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatusBar : MonoBehaviour
{
    private int MenuDown;
    [SerializeField] private GameObject ExtraMenu;
    [SerializeField] private TextMeshProUGUI ButtonArrow;

    // Start is called before the first frame update
    void Start()
    {
        HideMenu ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoreOptions ()
    {
        if (MenuDown == 0)
        {
            ExtraMenu.gameObject.SetActive(true);
            ButtonArrow.text = ">";
            MenuDown = 1;
        } else {
            ExtraMenu.gameObject.SetActive(false);
            ButtonArrow.text = "V";
            MenuDown = 0;
        }
    }

    public void HideMenu ()
    {
        MenuDown = 0;
        ExtraMenu.gameObject.SetActive(false);
        Debug.Log("Menu Escondido");
    }
}
