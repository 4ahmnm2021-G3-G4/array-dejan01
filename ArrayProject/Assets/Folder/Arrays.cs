using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    string[] array1 = new string[] {"HuachtsHer", "Oder?", "4a", "GutnMuagn"};
    float[] array2 = new float[] {0.1f, 4.2f, 7.2f, 1.1f};
    //added one number in order to show the difference in lenght between array1 (=a1), a2 and a3
    int[] array3 = {1, 2, 3, 4, 5};
    GameObject[] array4 = new GameObject[2];

    // Durlaufen der ARRAYS und Debug Message in Console
    void Start()
    {
        foreach(string array1 in array1)
        {
            Debug.Log("Array1 is " + array1);
        }
        foreach(float array2 in array2)
        {
            Debug.Log("Array2 is " + array2);
        }
         foreach(int array3 in array3)
        {
            Debug.Log("Array3 is " + array3);
        }

        Debug.Log("Array1 Length is " + array1.Length);
        Debug.Log("Array2 Length is " + array2.Length);
        Debug.Log("Array3 Length is " + array3.Length);
    }

    
}

/* 1) Durchlaufen ausgeben der Werte
2) Länge des Arrays ausgeben als debug
3) 2 Werte Direkt ändern
4) GameObjects Images anlegen, Tag vergeben, zuweisem und Farbe ändern*/