using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CardData : ScriptableObject
{
    [Header("Card names and descriptions ")]
    public new string name;
    public string description;

    [Header("Sprites")]
    public Sprite artwork;

    [Header("Stats")]
    [Range(1,100)] public int mana;
    [Range(1, 100)] public int attack;
    [Range(1, 100)] public int health;
}
