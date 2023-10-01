using UnityEngine;
using TMPro;

public class accelerationstock : MonoBehaviour
{
    public static int accelerationValue = 10000;

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
            textMeshProComponent.text = "Acceleration\n";
            textMeshProComponent.text += "Stock Price: $" + accelerationValue.ToString();
        }
    }
}

