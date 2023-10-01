using UnityEngine;
using TMPro;

public class earthxstock : MonoBehaviour
{
    public static int earthxValue = 10000;

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
            textMeshProComponent.text = "EarthX\n";
            textMeshProComponent.text += "Stock Price: $" + earthxValue.ToString();
        }
    }
}
