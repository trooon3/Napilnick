using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Cart : MonoBehaviour
{
    private Order _order;
    private Warehouse _warehouse;
    
    public void Add(Good good, int count)
    {
        for (int i = 0; i < count; i++)
        {
            if (_warehouse.Goods.ContainsKey(good) && _warehouse.Goods[good] >= count)
            {
                _warehouse.Unload(good, count);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        _order.AddGoods(good, count);
    }

    public void ShowOrder()
    {
        _order.ShowGoods();
    }

    public Order GetOrder()
    {
        return _order;
    }
}
