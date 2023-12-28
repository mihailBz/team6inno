using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritechanger : MonoBehaviour
{
    public Sprite image1;
    // Update is called once per frame
    void Update()
    {
        if (moneyTracker.companyTwo == 3 && earthxstock.earthxValue == 10000)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = image1;
            earthxstock.earthxValue -= 2000;
            moneyTracker.stockvalue -= (2000 * moneyTracker.companyTwo);
            earthxstock.UpdateText();
            moneyTracker.UpdateText();
        }
    }
}
