using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{

    Item item;
    Image sltimg;

    private void Awake()
    {

        sltimg = GetComponent<Image>();

    }

    public bool isnonimg()
    {

        if (item == null) return true;
        return false;

    }

    public void trnsfmImg(Item newItem)
    {

        item = newItem;
        sltimg.sprite = item.sprite;
        inportimg(sltimg);

    }

    public void inportimg(Image newItem)
    {

        sltimg.sprite = newItem.sprite;

    }

}
