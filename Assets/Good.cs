using UnityEngine;

public class Good : MonoBehaviour
{
    public string Name { get; private set; }
    public int Cost { get; private set; }

    public Good(string name, int cost)
    {
        Name = name;
        Cost = cost;
    }
}
