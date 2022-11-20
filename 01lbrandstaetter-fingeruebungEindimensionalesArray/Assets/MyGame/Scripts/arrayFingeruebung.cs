using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayFingeruebung : MonoBehaviour
{
    [SerializeField] int[] array1 = new int[4];
    [SerializeField] int[] array2 = new int[4];
    [SerializeField] int[] array3 = new int[7] {31,32,33,34,35,36,37};
    [SerializeField] string[] array4 = new string[10] {"array4","array4","array4","array4","array4", "array4","array4","array4","array4","array4"};

    [SerializeField] GameObject[] arrayColoredImagesRed;
    [SerializeField] string longString;


    void Start()
    {
        arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");

        Debug.Log(arrayColoredImagesRed[0].name);
        Debug.Log(array1[0]);
        Debug.Log(array4[0]);

        Debug.Log(arrayColoredImagesRed[arrayColoredImagesRed.Length - 1].name);
        Debug.Log(array1[array1.Length - 1]);
        Debug.Log(array4[array4.Length - 1]);

        Werte();

        for (int i = 0; i < array3.Length; i++)
        {
            Debug.Log(array3[i]);
        }
        for (int i = 0; i < array1.Length; i++)
        {
            longString = longString + array1[i] + " ";
        }
        Debug.Log(longString);

        array1[3] = 3;
        Debug.Log(array1[3]);

        array2[2] = 203;
        Debug.Log(array2[2]);

        array3[5] = 333;
        Debug.Log(array3[5]);

        array4[2] = "heute";
        Debug.Log(array4[2]);

        arrayColoredImagesRed[3].GetComponent<SpriteRenderer>().color = Color.green;
    }
        void Werte()
   {
        Debug.Log(array1[0] + " " + array1[1] + " " + array1[2] + " " + array1[3]);
   }
}
