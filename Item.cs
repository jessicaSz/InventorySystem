using UnityEngine;

public class Item : ScriptableObject
{
    [Header("General")]

    [SerializeField] private string _itemName;
    [SerializeField] private Sprite _icon;
    [SerializeField] private float _buyPrice;
    [SerializeField] private float _sellPrice;
    [SerializeField] private bool _isQuestItem;
}









