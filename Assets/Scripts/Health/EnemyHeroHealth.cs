using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHeroHealth : BaseHealth
{
    // Start is called before the first frame update
    void Start()
    {
        healthText.text = health.ToString();
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
        base.UpdateText();
    }
}
