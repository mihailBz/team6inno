using UnityEngine;
using UnityEngine.UI; // For UI elements like Button
using System.Collections; // For IEnumerator

public class CanvasSwitcherToChat : MonoBehaviour
{
    public Button yourButton; // Assign this in the inspector
    public Button correctButton; // Assign this in the inspector
    public GameObject currentCanvas; // Assign current canvas
    public GameObject nextCanvas; // Assign next canvas

    void Start()
    {
        yourButton.onClick.AddListener(() => StartCoroutine(SwitchCanvas()));
    }

    IEnumerator SwitchCanvas()
    {

        yourButton.GetComponent<Image>().color = Color.red;
        correctButton.GetComponent<Image>().color = Color.green;

        // Wait for 3 seconds
        yield return new WaitForSeconds(3);

        // Disable current canvas and enable next one
        nextCanvas.SetActive(true);
    }
}