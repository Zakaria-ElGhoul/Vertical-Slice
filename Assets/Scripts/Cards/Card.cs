using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Card : MonoBehaviour
{

    [Header("Card Atributes")]
    [Space]
    [Range(0, 100)]
    [SerializeField] private int damage;
    [Space]
    [Range(0, 100)]
    [SerializeField] private int health;
    [Space]
    [Range(0, 100)]
    [SerializeField] private int mana;

    [Header("Strings")]
    [Space]
    [SerializeField] private string cardName;
    [Space]
    [SerializeField] private string cardType;

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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        damageText.text = damage.ToString();
        healthText.text = health.ToString();
        manaText.text = mana.ToString();
        cardNameText.text = cardName;
        cardTypeText.text = cardType;
    }
}
