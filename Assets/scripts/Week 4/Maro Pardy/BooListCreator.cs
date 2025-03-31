using System.Collections.Generic;
using UnityEngine;

public class BooListCreator : MonoBehaviour
{
    public List<Boo> boos = new List<Boo>();
    public GameObject booPrefab;
    public int randomBooAmount;
    public Counter counterScript;
    public GameObject winScreen;
    public GameObject loseScreen;
    public AudioSource winAudio;
    public AudioSource loseAudio;


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
        loseScreen.SetActive(false);
        winScreen.SetActive(false);
        RandomBooCreator();
    }

    void Update()
    {
        CheckPlayerAnswer();
    }

    public void RandomBooCreator()
    {
        randomBooAmount = Random.Range(10, 20);

        for (int i = 0; i < randomBooAmount; i++)
        {
            GameObject go = Instantiate(booPrefab);
            boos.Add(go.GetComponent<Boo>());
        }
    }

    public void CheckPlayerAnswer()
    {
        if (counterScript.allowCounting == false)
        {
            {
                if (randomBooAmount == counterScript.counterNumber)
                {
                    winScreen.SetActive(true);
                    Debug.Log("you win!");
                    winAudio.Play();
                }
                else
                {
                    loseScreen.SetActive(true);
                    Debug.Log("You lose.....");
                    loseAudio.Play();
                }
            }
        }
    }
}
