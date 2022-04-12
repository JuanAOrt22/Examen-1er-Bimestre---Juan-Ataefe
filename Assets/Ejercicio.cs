using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    public float entradasplatea, entradascampo;
    float dineroplatea, dinerocampo;
    float cantidadplatea = 16200;
    float cantidadcampo = 20400;
    float porcentajeplatea, porcentajecampo;
    float total;

    void Start()
    {
    
    if(entradascampo <= cantidadcampo && entradasplatea <= cantidadplatea)
    {

    dinerocampo = entradascampo * 1200;
    dineroplatea = entradasplatea * 2000;
    total = dinerocampo + dineroplatea;

    porcentajeplatea = (100 - ((entradasplatea / cantidadplatea) * 100));
    porcentajecampo = (100 - ((entradascampo / cantidadcampo) * 100));

    Debug.Log("Lo que se recaudo en campo es: "+ dinerocampo);
    Debug.Log("El porcentaje de vacantes es de %"+ porcentajecampo);
    if(entradascampo == cantidadcampo)
    {
        Debug.Log("Sold Out!");
    }

    Debug.Log("Lo que se recaudo en platea es: "+ dineroplatea);
    Debug.Log("El porcentaje de vacantes es de %"+ porcentajeplatea);
    if(entradasplatea == cantidadplatea)
    {
        Debug.Log("Sold Out!");
    }

    Debug.Log("Lo que se recaudo en total es: "+ total);
    if(entradascampo + entradasplatea >= ((cantidadplatea + cantidadcampo)/2))
    {
        Debug.Log("El festival fue un exito");
    }

    else
    {
       Debug.Log("Debemos mejorar la convocatoria"); 
    }

    }    

    else

    {

    Debug.Log("Hay un error en las entradas que se vendieron");

    }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
