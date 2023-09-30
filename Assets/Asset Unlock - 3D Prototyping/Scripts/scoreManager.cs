using UnityEngine;
using TMPro;

public class DisplayVariable : MonoBehaviour
{
    public int myValue = 42; // Example variable
    private TextMeshProUGUI textMeshProComponent;

    void Start()
    {
        textMeshProComponent = GetComponent<TextMeshProUGUI>();
        UpdateText();
    }

    void UpdateText()
    {
        if (textMeshProComponent != null)
        {
            textMeshProComponent.text = "My Value: " + myValue.ToString();
        }
    }
}