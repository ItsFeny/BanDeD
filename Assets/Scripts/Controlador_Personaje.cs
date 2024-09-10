using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_Personaje : MonoBehaviour
{
    //este codigo es para detectar y saltar cuando toquemos el suelo

    public Transform DetectorSuelo;  // esta variable es el cuadrito detector que le ponemos a nuestro personaje
    public bool TocandoSuelo;       // esta es la variable que me verifica si esta tocando el suelo o no 
    public float FuerzaImpulso;    //  esta es la variable que me dara la fuerza del impulso
    public float RangoSuelo;      //   esta es la variable del rango del suelo
    public LayerMask Suelo;      //    esta variable es para ponerle el tag al objeto en este caso suelo


    // codigo para mover izquiera y derecha

    public float Velocidad_Movimiento; // aqui tendre la velocidad en que me movere en el eje X
    float arriba_abajo; // variable de choque de plataforma desde abajo
    public float FuerzaMegaSalto; // esta es la fuerza de la plataforma de megasalto
    public float Velocidad_Movimiento_Movil; //variable que calcula la velocidad de movimiento del toutch



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        arriba_abajo = GetComponent<Rigidbody2D>().velocity.y; // aqui me dice que si esta subiendo no choque con la plataforma
        float ControlHorizontal = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(ControlHorizontal * Velocidad_Movimiento, GetComponent<Rigidbody2D>().velocity.y);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float screenHalf = Screen.width / 2;
            Vector3 movement = Vector2.zero;

            if (touch.position.x > screenHalf)
            {
                movement = Vector2.right;
            }
            else
            {
                movement = Vector2.left;
            }

            this.transform.position += movement * this.Velocidad_Movimiento_Movil * Time.deltaTime;
        }
    }


    private void FixedUpdate()
    {
        TocandoSuelo = Physics2D.OverlapCircle(DetectorSuelo.position,RangoSuelo,Suelo);
        
        if (TocandoSuelo && arriba_abajo <=0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            GetComponent<Rigidbody2D>().AddForce ( new Vector2(0, FuerzaImpulso));

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MegaSalto" && arriba_abajo <= 0)
        {
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, FuerzaMegaSalto));

            }
        }
    }
}
