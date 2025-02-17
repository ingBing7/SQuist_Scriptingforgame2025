using UnityEngine;

public class TimerCountingDown : MonoBehaviour
{
    public float timerCountingDown = 0f;
    public float timerMaxDuration = -3f;

    public GameObject cube;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timerCountingDown -= Time.deltaTime;

        if(timerCountingDown <= timerMaxDuration)
        {
            Debug.Log("reached end of timer!");
            cube.transform.position += Vector3.right;
            timerCountingDown = 0f;
        }
    }
}
