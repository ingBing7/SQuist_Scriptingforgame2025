using UnityEngine;

public class Script4 : MonoBehaviour
{
    public Vector3 startingPosition;
    public Vector3 moveDirection;

    // No fun names with this one...

    void Start()
    {
        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += moveDirection * Time.deltaTime;
    }
}
