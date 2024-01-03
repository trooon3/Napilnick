using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Warehouse : MonoBehaviour
{
    private Dictionary<Good, int> _goods = new Dictionary<Good, int>();

    public Dictionary<Good, int> Goods => _goods;

    public void Delive(Good good, int count)
    {
        if (_goods.ContainsKey(good))
        {
            _goods[good] += count;
        }
        else
        {
            _goods.Add(good, count);
        }
    }

    public void Unload(Good good, int count)
    {
        _goods[good] -= count;
    }

    public void ShowGoods()
    {
        foreach (var good in _goods)
        {
            System.Console.WriteLine(good.Key + " " + good.Value);
        }
    }
}
