using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroHealth : BaseHealth
{
    // Start is called before the first frame update
    void Start()
    {
        healthText.text = health.ToString();
        manaText.text = mana.ToString() + " " + "/" + " 30";
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        base.UpdateText();
    }
}
