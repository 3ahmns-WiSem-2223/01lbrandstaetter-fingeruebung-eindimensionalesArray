using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayFingeruebung : MonoBehaviour
{
    int[] array1 = new int[4];
    int[] array2 = new int[4];
    int[] array3 = new int[7] {31,32,33,34,35,36,37};
    string[] array4 = new string[10] 
    {"array4","array4","array4","array4","array4",
     "array4","array4","array4","array4","array4"};
    
    GameObject[] arrayColoredImagesRed;
    
    
    void Start()
    {
        arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");
        
        Debug.Log(arrayColoredImagesRed[0].name);
        Debug.Log(array1[0]);
        Debug.Log(array4[0]);
        
        Debug.Log(arrayColoredImagesRed[arrayColoredImagesRed.Length - 1].name);
        Debug.Log(array1[array1.Length - 1]);
        Debug.Log(array4[array4.Length - 1]);
        
        for (int i = 0; i < array4.Length; i++) 
        {
            Debug.Log("Der Wert der Elemente [" + i + "] hat den Wert:" + array4[i];
        }
    }
}
