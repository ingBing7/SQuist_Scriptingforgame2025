using UnityEngine;

public class Mammal : Animal
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected virtual void Start()
    {
        bType = BloodType.WarmBlooded;
    }

    public override void Eat(int energyGained)
    {
        Debug.Log("Chomp chomp chomp chomp");
        base.Eat(energyGained);
    }

    public virtual void GiveBirth()
    {
        Debug.Log("Giving birth to mammal");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
