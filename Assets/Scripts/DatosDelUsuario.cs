using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    [SerializeField] int edadUsuario;
    [SerializeField] float estaturaUsuario;
    [SerializeField] bool esDonante;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es "+ nombreUsuario + ", tengo " + edadUsuario + ", mido "
            + estaturaUsuario + " metros y es " + esDonante + " que soy donante de organos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
