using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simulacro : MonoBehaviour
{

    public string nombre;
    public int año;
    public string orientacion;

    // Start is called before the first frame update
    void Start()
    {
        if (nombre == null)
        {
            Debug.Log("Debe ingresar un nombre");

        }
        else if (año > 5)
        {
            Debug.Log("No es posible encontrar ese curso");

        }

        else if (año < 3)
        {
            Debug.Log("Usted sigue en siclo basico");
        }

        else if (año < 0)
        {
            Debug.Log("El numero no es valido");
        }

        else if (orientacion != "D" && orientacion != "T" && orientacion != "M" && orientacion != "H" && orientacion != "G")
        {
            Debug.Log("No se econtro tu curso");
        }
         else
        {
            Debug.Log("Hola " + nombre);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
