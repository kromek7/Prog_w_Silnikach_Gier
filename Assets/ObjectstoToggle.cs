using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectstoToggle : MonoBehaviour
{
    
    public GameObject[] objectsToToggle;

    void Start()
    {
        // Randomly enable or disable each object in the array
        foreach (GameObject obj in objectsToToggle)
        {
            obj.SetActive(Random.value > 0.5f);
        }

       
    }
}