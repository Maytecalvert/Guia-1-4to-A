using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueOrientacionSos : MonoBehaviour
{
    // 1. Declaración de variables
    public string nombreDeAlumno;
    public int queAño;
    public string queOrientacion;


    // Start is called before the first frame update
    void Start()
    {
        // 2. ingreso y validación de los datos
        if (nombreDeAlumno == "")
        {
            Debug.Log("Nombre no valido");
            return;
        
        }
        if (queAño < 1 || queAño > 5)
        {
            Debug.Log("Error, no dentro del rango");
            return;
        }
        if (queAño < 3)
        {
            Debug.Log("No sos de ciclo superior");
            return;
        }

        if (queOrientacion == "T" || queOrientacion =="G" || queOrientacion == "M" || queOrientacion =="H")
        {
            Debug.Log("Muchas gracias " + nombreDeAlumno + "!");
        } 
        else
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
