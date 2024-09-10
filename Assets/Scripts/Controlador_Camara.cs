using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador_Camara : MonoBehaviour
{

    public Transform Pelota;
    float alturaplayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alturaplayer = Pelota.transform.position.y;
        float alturacamara = this.transform.position.y;
        float alturacamaraactualizada = Mathf.Lerp(alturacamara, alturaplayer, Time.deltaTime * 10);

        if (alturaplayer > alturacamara )
        {
            this.transform.position = new Vector3(this.transform.position.x, alturacamaraactualizada, this.transform.position.z);
        }

        else if (alturaplayer < alturacamaraactualizada - 5f)
        {
            Puntuaciones.Puntuacion.VerificarPuntajeMaximo();
            SceneManager.LoadScene("Mundo_1");
        }

        if (alturaplayer > Puntuaciones.Distancia)
        {
            Puntuaciones.Distancia = (int)alturaplayer;
        }
    }

}
