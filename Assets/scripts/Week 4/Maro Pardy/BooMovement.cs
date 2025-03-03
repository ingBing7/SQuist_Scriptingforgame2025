using UnityEngine;
using UnityEngine.UIElements;

public class BooMovement : MonoBehaviour
{
    public float speed = 2f;
    private float timer = 0f;
    private Vector3 targetPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeDirection();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 1f)
        {
            ChangeDirection();
            timer = 0f;
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);


    }

    void ChangeDirection()
    {
        targetPosition = new Vector3(Random.Range(-15f, 15f), transform.position.y, Random.Range(-15f, 15f));
    }

    void MeshRendererDisabled()
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

}
