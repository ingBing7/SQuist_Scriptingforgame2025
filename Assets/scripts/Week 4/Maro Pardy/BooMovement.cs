using UnityEngine;

public class BooMovement : MonoBehaviour
{
    public Rigidbody rbody;
    public Vector3 MoveDir;
    public float Speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        ChangeDirection();
    }

    // Update is called once per frame
    void Update()
    {
        rbody.AddForce(MoveDir * Speed * Time.deltaTime);
    }

    void ChangeDirection()
    {
        MoveDir = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
    }
}
