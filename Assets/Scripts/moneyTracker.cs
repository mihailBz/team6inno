using UnityEngine;
using TMPro;

public class moneyTracker : MonoBehaviour
{
    public static int money = 200000;
    public static int companyOne = 0;
    public static int companyTwo = 0;
    public static int companyThree = 0;
    public static int stockvalue = 0;

    private static TextMeshProUGUI textMeshProComponent;

    public void Start()
    {
        textMeshProComponent = GetComponent<TextMeshProUGUI>();
        UpdateText();
    }

    public static void UpdateText()
    {
        if (textMeshProComponent != null)
        {
            textMeshProComponent.text = "BANK\n";
            textMeshProComponent.text += "You Currently Have: $" + money.ToString() + "\n";
            textMeshProComponent.text += "AstroLink Shares: " + companyOne.ToString() + "\n";
            textMeshProComponent.text += "EarthX Shares: " + companyTwo.ToString() + "\n";
            textMeshProComponent.text += "Acceleration Shares: " + companyThree.ToString() + "\n";
            textMeshProComponent.text += "Your Value in Stocks: $" + stockvalue.ToString() + "\n";
        }
    }
}