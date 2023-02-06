using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    public string[] names;
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while (i < names.Length)
        {
            Debug.Log(names[i]);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
