using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 100; i >= 0; i -= 2)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
