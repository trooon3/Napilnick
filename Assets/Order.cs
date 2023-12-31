using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
    private List<Good> _goods = new List<Good>();
    public string Paylink { get; private set; }

    public Order()
    {
        int paylink = 0;

        foreach (var good in _goods)
        {
            paylink += good.Cost;
        }

        Paylink = paylink.ToString();
    }

    public void AddGoods(List<Good> goods)
    {
        _goods.AddRange(goods);
    }

    public void ShowGoods()
    {
        foreach (var good in _goods)
        {
            System.Console.WriteLine(good.Name);
        }
    }
}
