using UnityEngine;

public class MoveObjectwithdirections : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    public float speed = 4f;
    public bool hasreacheddestination = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }


    /*
    // Update is called once per frame
    void Update()
    {
        Vector3 direction;

        direction = point2.transform.position - point1.transform.position;
        Debug.Log(direction);

        point1.transform.position += direction * Time.deltaTime;
    }

    private void Update()
    {
        Vector3 direction;

        direction = point2.transform.position - point1.transform.position;

        direction = direction.normalized;
        
        Debug.Log(direction);

        point1.transform.position += direction * speed * Time.deltaTime;
    }

    private void Update()
    {
        Vector3 direction;

        direction = point2.transform.position - point1.transform.position;

        direction = direction.normalized;

        Debug.Log(direction);

        Debug.Log(Vector3.Distance(point1.transform.position, point2.transform.position));

        if(Vector3.Distance(point1.transform.position, point2.transform.position) < .1f)
        {
            point1.transform.position = point2.transform.position;
        }
        else
        {
            point1.transform.position += direction * speed * Time.deltaTime;
        }
    }*/

    private void Update()
    {
        if (hasreacheddestination == false)
        {
            Vector3 direction;

            direction = point2.transform.position - point1.transform.position;

            direction = direction.normalized;

            Debug.Log(direction);

            Debug.Log(Vector3.Distance(point1.transform.position, point2.transform.position));

            if (Vector3.Distance(point1.transform.position, point2.transform.position) < .1f)
            {
                point1.transform.position = point2.transform.position;
                hasreacheddestination = true;
            }
            else
            {
                point1.transform.position += direction * speed * Time.deltaTime;
            }
        }

    }
}
