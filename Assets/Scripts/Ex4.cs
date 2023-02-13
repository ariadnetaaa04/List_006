using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{
    public int start;
    public int end;
    // Start is called before the first frame update
    void Start()
    {
        while (start <= end) // un numero inicial y uno final
        {
            if (start % 5 == 0) //si el modulo del numero inicial es igual a 0 es multiple de 5 
            {
                Debug.Log(start);
            }
            
            start++; //suma uno para comprovar si es verdadero
        }
    }

  
}
