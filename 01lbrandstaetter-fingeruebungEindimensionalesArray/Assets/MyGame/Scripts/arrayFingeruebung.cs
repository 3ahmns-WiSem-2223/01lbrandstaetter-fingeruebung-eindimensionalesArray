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

    int[] array5 = new int[51];
        for (int i = 0; i<array5.Length; i++)
        {
            if (i % 2 == 0)
            {
                array5[i] = i + 20;
            }

        }

        int[] array6 = new int[501];
    for (int i = 0; i < array6.Length; i++)
    {
    if (i % 2 == 0)
    {
        array6[i] = i;
    }

    }

    int[] array7 = new int[501];
    for (int i = 0; i < array7.Length; i++)
    {
    if (i % 2 == 1)
         {
        array7[i] = i;
         }

    }

    string[] array8 = new string[101];
    for (int i = 0; i < array8.Length; i++)
    {
    if (i % 2 == 0)
    {
        array8[i] = "a";
        }  

    else if (i % 2 == 1)
        {
        array8[i] = "b";
        }
    }

       int[] array9 = new int[1001];
    for (int i = 0; i < array9.Length; i++)
        {
            array9[i] = Random.Range(0, 1000);
            Debug.Log(array9[i]);
        }

    System.Array.Sort(array9);

    for (int i = 0; i < array9.Length; i++)
        {
            Debug.Log(array9[i]);
        }



    int[] array11 = new int[1001];
    for (int i = 0; i < array11.Length; i++)
        {
            array11[i] = Random.Range(0, 1000);
            Debug.Log(array9[i]);
        }

        System.Array.Sort(array11);

            Debug.Log(array11[0] + " und " + array11[array11.Length - 1]);



    int[] array12 = new int[1001];
    for (int i = 0; i < array12.Length; i++)
        {
            array12[i] = Random.Range(0, 1000);
        }

    int randomNumber = Random.Range(0, 1000);

        Debug.Log(System.Array.IndexOf(array12, randomNumber));

    }
}
