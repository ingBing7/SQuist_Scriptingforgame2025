using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float Timeleft;

    public float startTime = 30f;

    public TextMeshProUGUI timerText;

    public bool hasTimerFinished = false;

    public Counter counterScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Timeleft = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(hasTimerFinished == false)
        {
            if (Timeleft > 0)
            {
                Timeleft -= Time.deltaTime;
                updateTimer();

            }

            else
            {
                hasTimerFinished = true;
                Timeleft = 0f;
                updateTimer();
            }
        }
    }


    void updateTimer()
    {
        if(timerText != null)
        {
            timerText.text = Mathf.CeilToInt(Timeleft).ToString();
        }

    }
}
