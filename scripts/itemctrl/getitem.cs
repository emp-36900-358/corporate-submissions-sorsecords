using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getitem : MonoBehaviour
{

    [SerializeField]Item item; 

    public void OnThis()
    {

        gameObject.SetActive(false);
        itemslot.instance.Setitem(item);

    }

}
