using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    //estas variable hacen referencia a los colisionadores o muros de los lados que funcionan como portales hacia el otro 
    public GameObject portal1;
    public GameObject portal2;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()


        //esta condicion me evalua que si toca un muro se teletransporte al otro
    {
        if (this.transform.position.x < portal1.transform.position.x)
        {
            this.transform.position = new Vector3(portal2.transform.position.x, this.transform.position.y,this.transform.position.z);
        }

        if (this.transform.position.x > portal2.transform.position.x)
        {
            this.transform.position = new Vector3(portal1.transform.position.x, this.transform.position.y, this.transform.position.z);
        }


    }
}
