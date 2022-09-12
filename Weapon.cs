using UnityEngine;

[CreateAssetMenu(menuName = "Items/Weapon", fileName = "Weapon", order = 1)]
public class Weapon : Item
{
    [Header("Weapon info")]
    [SerializeField] private float _attackPoints;
}
