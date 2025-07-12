using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Random;

public class itemslot : MonoBehaviour
{

    public Slot[] slots;
    public Text btntxt;
    public GameObject Panel;
    public GameObject triger, slot1, slot2, slot3, slot4, slot5, slot6, slot7, slot8;
    public bool trgcntxt = false;
    public static itemslot instance;

    Item item;
    Slot slot;
    Image slotimage;
    int cnt = 0;


    private void Awake()
    {

        slot = GetComponent<Slot>();
        slotimage = GetComponent<Image>();
        instance = this;

    }


    public void Setitem(Item item)
    {

        if (item == null)
        {
            Debug.LogError("newItem is null in Setitem");
            return;
        }

        foreach (Slot slot in slots)
        {
            if (slot.isnonimg())
            {
                slot.trnsfmImg(item);
                Debug.Log("Item set successfully in slot.");
                return;
            }
        }

        Debug.LogWarning("No available slot found for the item.");
    }

    public void OnOC_Triger()
    {

        RectTransform transform = Panel.GetComponent<RectTransform>();
        float w = transform.sizeDelta.x;
        float h = transform.sizeDelta.y;

        if (trgcntxt)
        {

            trgcntxt = false;
            triger.GetComponentInChildren<Text>().text = ">-";
            transform.sizeDelta = new Vector2(1920, 180);
            Panel.transform.localPosition = new Vector2(0, -470);
            Panel.SetActive(true);
            triger.SetActive(true);
            slot1.SetActive(true);
            slot2.SetActive(true);
            slot3.SetActive(true);
            slot4.SetActive(true);
            slot5.SetActive(true);
            slot6.SetActive(true);
            slot7.SetActive(true);
            slot8.SetActive(true);

        }

        else
        {

            trgcntxt = true;
            triger.GetComponentInChildren<Text>().text = "-<";
            transform.sizeDelta = new Vector2(208, 180);
            Panel.transform.localPosition = new Vector2(840, -270);
            Panel.SetActive(true);
            triger.SetActive(true);
            slot1.SetActive(false);
            slot2.SetActive(false);
            slot3.SetActive(false);
            slot4.SetActive(false);
            slot5.SetActive(false);
            slot6.SetActive(false);
            slot7.SetActive(false);
            slot8.SetActive(false);


        }

    }
    
    public void OnItems_Triger()
    {

        if (item == null)
        {
            Debug.LogError("item is null in OnItems_Triger");
            return;
        }

        cnt++;
        if (cnt >= item.usetime && !slot.isnonimg())
        {

            slotimage.sprite = null;

        }

        Debug.Log(cnt);

    }

    public void OnItems_Triger1()
    {

        cnt++;
        if (cnt >= item.usetime && !slot.isnonimg())
        {

            slotimage.sprite = null;

        }


    }

    public void Onitems_Triger2()
    {

        cnt++;
        if (cnt >= item.usetime && !slot.isnonimg())
        {

            slotimage.sprite = null;

        }


    }

    public void OnItems_Triger3()
    {

        cnt++;
        if (cnt >= item.usetime && !slot.isnonimg())
        {

            slotimage.sprite = null;

        }


    }

    public void Onitems_Triger4()
    {

        if (item == null)
        {
            Debug.LogError("item is null in OnItems_Triger");
            return;
        }

        cnt++;
        if (cnt >= item.usetime && !slot.isnonimg())
        {

            slotimage.sprite = null;

        }

        Debug.Log(cnt);

    }

    public void OnItems_Triger5()
    {

        if (item == null)
        {
            Debug.LogError("item is null in OnItems_Triger");
            return;
        }

        cnt++;
        if (cnt >= item.usetime && !slot.isnonimg())
        {

            slotimage.sprite = null;

        }

        Debug.Log(cnt);

    }

    public void OnItems_Triger6()
    {

        if (item == null)
        {
            Debug.LogError("item is null in OnItems_Triger");
            return;
        }

        cnt++;
        if (cnt >= item.usetime && !slot.isnonimg())
        {

            slotimage.sprite = null;

        }

        Debug.Log(cnt);

    }

    public void OnItems_Triger7()
    {

        if (item == null)
        {
            Debug.LogError("item is null in OnItems_Triger");
            return;
        }

        cnt++;
        if (cnt >= item.usetime && !slot.isnonimg())
        {

            slotimage.sprite = null;

        }

        Debug.Log(cnt);

    }

}

