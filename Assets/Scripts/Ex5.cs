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
        /*
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            Debug.Log(sum);
        }
        */
        foreach (int numbers in nums)
        {
            
            sum += numbers;
            
        }
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
