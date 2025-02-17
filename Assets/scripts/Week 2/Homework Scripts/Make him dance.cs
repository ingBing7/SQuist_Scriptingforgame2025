using UnityEngine;

public class Makehimdance : MonoBehaviour
{
    public Vector3 DirtBossDance;
    public GameObject DirtBoss;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            RotateDirtBoss();
        }
    }

    public void RotateDirtBoss()
    {
        DirtBoss.transform.Rotate(new Vector3(0f, 0f, -90f));
    }
}
