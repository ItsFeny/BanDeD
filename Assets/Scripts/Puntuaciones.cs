using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuaciones : MonoBehaviour
{
    public static Puntuaciones Puntuacion;
    public static int Distancia;
    int Record;

     Text TextoDistancia;
     Text TextoRecord;

    // Start is called before the first frame update
    void Start()
    {
        Puntuacion = this;
        Distancia = 0;
        Record = PlayerPrefs.GetInt("PuntajeMaximo",0);

        TextoDistancia = GameObject.Find("Puntos").GetComponent<Text>();
        TextoRecord = GameObject.Find("Record").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        TextoDistancia.text = " Distancia: " + Distancia;
        TextoRecord.text = " Record: " + Record;
    }

    public void VerificarPuntajeMaximo()
    {
        if (Distancia > Record)
        {
            PlayerPrefs.SetInt("PuntajeMaximo", Distancia);
        }
    }
}
