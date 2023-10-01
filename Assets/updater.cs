using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updater : MonoBehaviour
{
    public Sprite image1;
    void Update()
    {
        if (moneyTracker.companyTwo >= 3) {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = image1;
        }
    }
}
