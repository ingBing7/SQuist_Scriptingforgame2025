using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class Counter : MonoBehaviour
{
    public int counterNumber = 0;

    public TextMeshProUGUI counterText;

    public bool allowCounting = true;

    public BooListCreator creator;

    public GameObject winScreen;

    public GameObject loseScreen;

    public Timer timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        loseScreen.GetComponent<MeshRenderer>().enabled = false;
        winScreen.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (allowCounting == true)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                CountDown();
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                CountUp();
            }
        }

        if(counterNumber == 0)
        {
            WinScreen();
        }

        if (counterNumber == 0)
        {
            LoseScreen();
        }
    }

    void CountUp()
    {
        counterNumber++;
        UpdateCounterUI();
    }

    void CountDown()
    {
        counterNumber--;

        if(counterNumber < 0)
        {
            counterNumber = 0;
        }

        UpdateCounterUI();
    }

    void UpdateCounterUI()
    {
        counterText.text = counterNumber.ToString();
    }

    void WinScreen()
    {
        winScreen.GetComponent<MeshRenderer>().enabled = true; 
    }

    void LoseScreen()
    {
        loseScreen.GetComponent<MeshRenderer>().enabled = true; 
    }

    public void AllowCountingScript()
    {
        allowCounting = false;
    }
}
