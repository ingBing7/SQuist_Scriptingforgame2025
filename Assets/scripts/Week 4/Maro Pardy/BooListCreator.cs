using System.Collections.Generic;
using UnityEngine;

public class BooListCreator : MonoBehaviour
{
    public List<Boo> boos = new List<Boo>();
    public GameObject booPrefab;
    private float randomBooAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*
    void Start()
    {
        randomBooAmount = Random.Range(20f, 40f);
        boos = FindObjectsByType<Boo>(FindObjectsSortMode.None).ToList();
        GameObject go = Instantiate(booPrefab);
        boos.Add(go.GetComponent<Boo>());
    }
    this shit dont work.
    */
    // Update is called once per frame
    
    void Start()
    {
        randomBooAmount = Random.Range(20f, 30f);

        for (int i = 0; i < randomBooAmount; i++)
        {
            GameObject go = Instantiate(booPrefab);
            boos.Add(go.GetComponent<Boo>());
        }
    }

    // im so smart B) for loops foreva

    void Update()
    {
        
    }
}
