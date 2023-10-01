using UnityEngine;
using TMPro;

public class astrolinkStock : MonoBehaviour
{
    public static int astrolinkValue = 10000;

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
            textMeshProComponent.text = "Astrolink\n";
            textMeshProComponent.text += "Stock Price: $" + astrolinkValue.ToString();
        }
    }
}