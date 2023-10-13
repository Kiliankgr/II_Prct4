using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pract4_Ej1 : MonoBehaviour
{
    GameObject [] esferas1;
    GameObject [] esferas2;
    // Start is called before the first frame update
    void Start()
    {
        esferas = GameObject.FindGameObjectsWithTag("GrpEsf1");
        esferas2 = GameObject.FindGameObjectsWithTag("GrpEsf2");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        //Primer grupo cambiamos el color
        
        foreach (GameObject esf in esferas1)
        {
             Material m = esf.GetComponent<Renderer>().material;
        
            //rgba
            m.color = new Color(Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), 1.0f);
        }

        //Segundo grupo cambiamos su posicion a la del cilindro
        foreach (GameObject esf in esferas2)
        {
             esf.GameObject.transform.position
        
            
        }

    }
}
