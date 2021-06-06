using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    string[] array1 = new string[] {"HuachtsHer", "Oder?", "4a", "GutnMuagn"};
    float[] array2 = new float[] {0.1f, 4.2f, 7.2f, 1.1f};
    int[] array3 = {1, 2, 3, 4};
    GameObject[] array4 = new GameObject[2];

    // Start is called before the first frame update
    void Start()
    {
        foreach(string array1 in array1)
        {
            Debug.Log("Array1 is" + array1);
        }
        foreach(float array2 in array2)
        {
            Debug.Log("Array2 is" + array2);
        }
    }

    
}

/* 1) Durchlaufen ausgeben der Werte
2) Länge des Arrays ausgeben als debug
3) 2 Werte Direkt ändern
4) GameObjects Images anlegen, Tag vergeben, zuweisem und Farbe ändern*/