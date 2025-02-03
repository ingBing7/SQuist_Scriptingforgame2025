using UnityEngine;

public class Dirtbossing : MonoBehaviour
{
    public GameObject DirtBoss;
    public float scaleIncrease = .5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DirtBoss.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;
    }

    public void ResetDirtBoss()
    {
        DirtBoss.transform.localScale = Vector3.one;
        scaleIncrease += .5f;
    }

    public void RotateDirtBoss()
    {
        DirtBoss.transform.Rotate(new Vector3(0f, 0f, -90f));
    }
}
