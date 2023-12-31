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
        var orderTest = new List<Good>();
        int goodsNeedCount = 0;
        _warehouse.Sort();

        for (int i = 0; i < count; i++)
        {
            if (good.Name == _warehouse.Goods[i].Name)
            {
                goodsNeedCount++;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

            orderTest.AddRange(_warehouse.Goods.Take(goodsNeedCount));
        }

        _order.AddGoods(orderTest);
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
