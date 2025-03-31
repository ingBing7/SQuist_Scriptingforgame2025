using UnityEngine;

public class Dog : Mammal
{
    public string dogBreed;
    public bool hasFur;

    public GameObject dogSpawn; //assume this a prefab of a dog

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
    }

    public void InstantalizeDog(string breed, bool fur)
    {
        dogBreed = breed;
        hasFur = fur;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GiveBirth();
        }
    }

    public void Bark()
    {
        Debug.Log("BARK BARK BARK BARK");
        Debug.Log("This wakes up the neighbors.");
    }

    public override void GiveBirth()
    {
        GameObject go = Instantiate(dogSpawn);

        go.GetComponent<Dog>().InstantalizeDog("Chipoo", true);
    }
}
