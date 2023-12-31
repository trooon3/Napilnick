using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Warehouse : MonoBehaviour
{
    public List<Good> Goods = new List<Good>();

    public void Delive(Good good, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Goods.Add(good);
        }
    }

    public void Sort()
    {
        Goods.OrderBy(good => good.Name);
    }

    public void ShowGoods()
    {
        Sort();
        int Iphones11Count = 0;
        int Iphones12Count = 0;

        foreach (var good in Goods)
        {
            if (good.Name == "IPhone 11")
            {
                Iphones11Count++;
            }
            if (good.Name == "IPhone 11")
            {
                Iphones12Count++;
            }
        }
        System.Console.WriteLine("IPhone 11" + Iphones11Count);
        System.Console.WriteLine("IPhone 12" + Iphones12Count);
    }
}
