using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActive : MonoBehaviour
{
  
    public GameObject Panel;
    public GameObject PanelTutorial;
    public GameObject panelCredits;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(true);
        PanelTutorial.SetActive(false);
        panelCredits.SetActive(false);
    }

    public void btnTutorial()
    {
        PanelTutorial.SetActive(true);
        Panel.SetActive(false);
    }
    public void btnTutorialBack()
    {
        PanelTutorial.SetActive(false);
        Panel.SetActive(true);
    }

    public void btnCredits()
    {
        panelCredits.SetActive(true);
        Panel.SetActive(false);
    }
    public void btnCreditsBack()
    {
        panelCredits.SetActive(false);
        Panel.SetActive(true);
    }


    
}
