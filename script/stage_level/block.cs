using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    public enum BlockType
    {
        red,
        blue,
        green,
        yellow,
        purple,
        barrier,
        trans,
    };

    [SerializeField] BlockType _blockType;

    public BlockType blockType{ get{return _blockType;} }

}
