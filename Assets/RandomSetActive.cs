using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RandomSetActive : MonoBehaviour
{

    public GameObject[] coin;
    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomCoin();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnRandomCoin()
    {
        int i = Random.Range(0, coin.Length); // This creates a random number between 0 and the total number of enemies in the array (Make sure you have added enemies to the array in the inspector)
        coin[i].SetActive(true); // Creates that random enemy
    }
}
