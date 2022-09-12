using UnityEngine;

[CreateAssetMenu(menuName = "Items/Food", fileName = "Food", order = 1)]
public class Food : Item
{
    [Header("Food info")]
    [SerializeField] private float _hungerPoints;
}
