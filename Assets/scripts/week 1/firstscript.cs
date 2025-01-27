using UnityEngine;

public class firstscript : MonoBehaviour
{

    public Vector3 moveDirection;

    public Vector3 startingPosition;

    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created.
    void Start()
    {
        Debug.Log("Hello World");

        //this in reference to the pbject THIS script is on, get reference to this TRANSFORM component
        //and get reference to the transform's POSITION, and SET it (=) to Vector3.zero (which means 0,0,0).
        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += moveDirection * speed * Time.deltaTime;
        Debug.Log("Ingrid's really cool and awesome!!!!!!!!");
    }
}
 