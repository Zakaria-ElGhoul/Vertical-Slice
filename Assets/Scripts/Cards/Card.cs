using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Card : MonoBehaviour
{
    public CardData card;

    [Header("Text Mesh Pro")]
    [Space]
    [SerializeField] private TMP_Text damageText;
    [Space]
    [SerializeField] private TMP_Text healthText;
    [Space]
    [SerializeField] private TMP_Text manaText;
    [Space]
    [SerializeField] private TMP_Text cardNameText;
    [Space]
    [SerializeField] private TMP_Text cardTypeText;
    [Space]
    [SerializeField] private int damage;

    void Start()
    {
        damageText.text = card.attack.ToString();
        healthText.text = card.health.ToString();
        manaText.text = card.mana.ToString();

        cardNameText.text = card.name;
        cardTypeText.text = card.description;
        damage = card.attack;
    }
}
