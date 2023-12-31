using UnityEngine;

public class Shop : MonoBehaviour
{
   private Warehouse _warehouse;
   
    public Shop(Warehouse warehouse)
    {
        _warehouse = warehouse;
    }

    public Cart GetCart()
    {
        return new Cart();
    }
}
