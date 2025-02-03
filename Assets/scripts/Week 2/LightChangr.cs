using UnityEngine;

public class LightChangr : MonoBehaviour
{
    public Light lightwewanttochange;
    public Vector3 lightmovedirection;
    public bool isItorIsntIt = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeLightColor(Color.green);
        this.gameObject.SetActive(isItorIsntIt);

        //Destroy(lightwewanttochange.gameObject); how to destroy object. idiot!!!!!!!!!
    }

    // Update is called once per frame
    void Update()
    {
      //AdjustLight();
        Debug.Log("light object adjusted");

        if(Input.GetKeyDown(KeyCode.R))
        {
            ChangeLightColor(Color.red);
        }

        if (Input.GetKeyDown(KeyCode.B)) 
        {
            ChangeLightColor(Color.blue);
        }

        if(Input.GetKeyDown(KeyCode.Y))
        {
            ChangeLightColor(Color.yellow);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            lightwewanttochange.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            lightwewanttochange.gameObject.SetActive(true);
        }
    }



    private void AdjustLight()
    {
        lightwewanttochange.transform.position += lightmovedirection * Time.deltaTime;
        lightwewanttochange.intensity += 40f * Time.deltaTime;
        lightwewanttochange.spotAngle += 10f * Time.deltaTime;
    }

    public void ChangeLightColor(Color santaclaus)
    {
        lightwewanttochange.color = santaclaus;
    }

    private void OnEnable()
    {
        //when this object is set active again from inactive, it will call the code 
        //in this function
    }

    private void OnDisable()
    {
        //when this object is disabled, run the code in here before it is disabled
        
    }

    private void Awake()
    {
        //is called before start
    }

    private void OnDestroy()
    {
        //called when object is destroyed!!!!
    }
}
