using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    public int[] nums;
    private int sum;
    // Start is called before the first frame update
    void Start()
    {

        foreach (int numbers in nums) //lee todo lo del array
        {

            sum += numbers; //suma todo lo que hay en el array

        }
        Debug.Log(sum); //una vez finalizado el proceso del bucle se muestra el resultado por consola. 
    }
}
   