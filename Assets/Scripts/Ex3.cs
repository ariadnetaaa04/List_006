using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    public int countdown = 10;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = countdown; i >= 0; i--) //resta uno cada vez que se hace el bucle hasta llegar al 0
        {
            Debug.Log(i);
        }
    }

}
