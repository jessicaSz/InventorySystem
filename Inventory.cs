using UnityEngine;

public class Inventory : MonoBehaviour
{
    
}

public struct Stack
{
    public Item _itemType;
    public byte _quantity; //Stack can hold only 255 items!
}
