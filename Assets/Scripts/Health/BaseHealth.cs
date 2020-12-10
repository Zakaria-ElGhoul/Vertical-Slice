using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.PlayerLoop;

public class BaseHealth : MonoBehaviour
{
    public int health = 30;
    public int mana= 0;
    public TMP_Text healthText;
    public TMP_Text manaText;

    void Start()
    {
        healthText.text = health.ToString();
    }

    // Update is called once per frame
    public virtual void TakeDamage(int amount)
    {
        health -= amount;
        UpdateText();
    }

    public virtual void UpdateText()
    {
        healthText.text = health.ToString();
        manaText.text = mana.ToString() + "" + "/" + "30";
    }
}
