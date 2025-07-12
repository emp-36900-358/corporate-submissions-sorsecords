using System;
using UnityEngine;

[Serializable]
public class Item
{

    public enum Type{plant, yakusou, masic_Book, poisuned_shroom, poisuned_apple, fish, spr_e, key,
                     houki, houki1, CAD, masiclotA, masiclodB, shikenkan, shikenkan1, frasco1, frasco2};


    public Type type;
    public Sprite sprite;
    public int usetime;

}
