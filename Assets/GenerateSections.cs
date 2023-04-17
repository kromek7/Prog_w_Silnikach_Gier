using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GenerateSections : MonoBehaviour
{
   //private const string SPAWN_TRIGGER = "SpawnTrigger";
   
    public GameObject player;
    [SerializeField] private GameObject startSection;
    [SerializeField] private GameObject[] section;
    [SerializeField] private int spawningZPos = 50;
    [SerializeField] private int lengthOfSection = 50;
    //[SerializeField] private bool isSpawning = false;
    //[SerializeField] private int secNumber;
    public int numberOfTilesSpawningAtStart;



    private void Start()
    {
        //secNumber = Random.Range(0, numberOfTiles);
        
        Instantiate(startSection, new Vector3(0, 0, 0), Quaternion.identity);

        for (int i = 0; i <= numberOfTilesSpawningAtStart; i++)
        {
            
           
            SpawnTile(Random.Range(0, section.Length));
            
        }


    }

    private void Update()
    {

        
        
        
    }


    public void SpawnTile(int indexTile)
    {
        
        Instantiate(section[indexTile], transform.forward * spawningZPos, transform.rotation);
        spawningZPos += lengthOfSection;
    } 
      

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnTrigger"))
        {

            SpawnTile(Random.Range(0, section.Length));
            spawningZPos -= lengthOfSection;

            Debug.Log("EnterTrigger");
        } 
     
    }
}