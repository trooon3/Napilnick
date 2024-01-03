using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
    private Dictionary<Good, int> _goods = new Dictionary<Good, int>();
    public string Paylink { get; private set; }

    public Order()
    {
        Paylink = "Заказ сделан";
    }

    public void AddGoods(Good good, int count)
    {
        _goods.Add(good, count);
    }

    public void ShowGoods()
    {
        foreach (var good in _goods)
        {
            System.Console.WriteLine(good);
        }
    }
}
