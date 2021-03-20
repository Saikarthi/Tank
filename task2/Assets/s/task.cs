using System;
using UnityEngine;

public class task : MonoBehaviour
{
    int[] Arr = { 3, 1, 2, 4, 3 };

    int mindiffernce;
    int temp;
    int a, b, c;
    public void Start()
    {
        // to find a greatest number 
        for (int i = 0; i < Arr.Length; i++)
        {
            mindiffernce += Arr[i];
        }

        // to find left and right sum
        for (int i = 0; i < Arr.Length - 1; i++)
        {
            // left
            for (int j = 0; j <= i; j++)
            {
                a += Arr[j];

            }
            // right
            for (int z = Arr.Length - 1; z > i; z--)
            {
                b += Arr[z];
            }

            // finding |differnce|
            c = a - b;
            c = Math.Abs(c);
            // find mindiffernce
            if (c < mindiffernce)
            {
                mindiffernce = c;
            }
            a = 0;
            b = 0;

        }
        // find print mindiffernce
        Debug.Log(mindiffernce);

    }
}
