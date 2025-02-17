using UnityEngine;

public class ConfettiScript : MonoBehaviour
{
    public GameObject Confetti;
    public Vector3 ConfettiMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Confetti.transform.position += ConfettiMovement * Time.deltaTime;
    }
}
