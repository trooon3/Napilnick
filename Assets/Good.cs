using UnityEngine;

public class Good : MonoBehaviour
{
    public string Name { get; private set; }

    public Good(string name)
    {
        Name = name;
    }
}
