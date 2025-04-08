using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMoneda : MonoBehaviour
{
    // 1. Declaración de variables
    public float montoAConvertir;
    public string codigoMoneda;

    float minimoAConvertir = 1000;

    float cotizacionMoneda;
    float valorDolar= 1204.35f;
    float valorEuro= 1541.11f;
    float valorReal= 300.75f;

    float montoConvertido;


    // Start is called before the first frame update
    void Start()
    {

      // 2. ingreso y validación de los datos
       if (montoAConvertir < minimoAConvertir)
        {
            Debug.Log("El monto mínimo es $1000");
            return;

        }

        if (codigoMoneda == "D")
        {
            cotizacionMoneda = valorDolar;

        } else if (codigoMoneda == "E") 
        {
         cotizacionMoneda = valorEuro;
        } else if (codigoMoneda == "R")
        {
         cotizacionMoneda = valorReal;
        } 
        else
        {
         Debug.Log("Opción de moneda no valida");
         return;
        }

        // 3. procesamiento de los datos

         montoConvertido = montoAConvertir / cotizacionMoneda;


        // 4. salida de los datos

        Debug.Log("Monto convertido: " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
