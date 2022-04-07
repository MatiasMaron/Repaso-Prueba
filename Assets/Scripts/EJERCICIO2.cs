using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJERCICIO2 : MonoBehaviour
{

    public int precio1;
    public int precio2;
    public int precio3;
    public int dinerodisponible;
    // Start is called before the first frame update
    void Start()
    {
        int sumaprecios = precio1 + precio2 + precio3;

        if(precio1+precio2+precio3 > dinerodisponible)
        {
            Debug.Log("La suma de los precios supera el dinero disponible.");
            Debug.Log("Te falta" + (dinerodisponible - sumaprecios));
        }
        else
        {
            Debug.Log("Te alcanza");
            Debug.Log("Te sobra " + (dinerodisponible - sumaprecios));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
