using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class Counter : MonoBehaviour
{
    public int counterNumber = 0;

    public TextMeshProUGUI counterText;

    public bool allowCounting = true;

    public BooListCreator creator;

    public Timer timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

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

    public void AllowCountingScript()
    {
        allowCounting = false;
    }
}
