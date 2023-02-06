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
        while (start <= end)
        {
            if (start % 5 == 0)
            {
                Debug.Log(start);
            }
            
            start++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
