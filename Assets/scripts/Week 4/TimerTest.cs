using UnityEngine;

public class TimerTest : MonoBehaviour
{
    public float timerCountingUp = 0f;
    public float timerMaxDuration = 3f;
    public bool hasFinishedTimer = false;
    public GameObject cube;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerMaxDuration = Random.Range(1, 6);
        Invoke("MoveCubeRight", timerMaxDuration);
    }

    /*
    // Update is called once per frame
    void Update()
    {
        if (hasFinishedTimer == false)
        {
            timerCountingUp += Time.deltaTime;
            //Debug.Log(timerCountingUp);

            if (timerCountingUp >= timerMaxDuration)
            {
                hasFinishedTimer = true;
                Debug.Log("reached end of timer!");
            }
        }

    }

    void Update()
    {
        timerCountingUp += Time.deltaTime;

        if (timerCountingUp >= timerMaxDuration)
        {
            Debug.Log("reached end of timer!");
            MoveCubeRight();
            timerCountingUp = 0f;
        }
    }*/

    void MoveCubeRight()
    {
        cube.transform.position += Vector3.right;
        if (cube.transform.position.x < 10)
        {
            Invoke("MoveCubeRight", timerMaxDuration);
        }
        
    }
}
