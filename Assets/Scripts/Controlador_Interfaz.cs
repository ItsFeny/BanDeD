using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_Interfaz : MonoBehaviour
{

    public GameObject PanelMenu;
    public GameObject PanelCreditos;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarMainMenu()
    {
        PanelMenu.SetActive(true);
        PanelCreditos.SetActive(false);
    }

    public void DesactivarMainMenu()
    {
        PanelMenu.SetActive(false);
    }

    public void ActivarPanelCreditos()
    {
        PanelCreditos.SetActive(true);
        PanelMenu.SetActive(false);
    }

    public void DesactivarPanelCreditos()
    {
        PanelCreditos.SetActive(false);
        PanelMenu.SetActive(true);
    }
}
