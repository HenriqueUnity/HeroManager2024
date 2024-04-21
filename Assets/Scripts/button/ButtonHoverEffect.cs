using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonHoverEffect : MonoBehaviour
{
    public Button button; // Reference to the Button component
     public UnityEvent onHoverEnter; // Event to trigger on hover enter
    void Start()
    {
     button.onClick.AddListener(OnHoverEnter); // Subscribe to the OnPointerEnter event
    }

    void OnHoverEnter()
    {
        // Change button appearance to indicate hover (e.g., change color)
        button.GetComponent<Image>().color = Color.red;
    }

    void OnHoverExit()
    {
        // Reset button appearance to normal state
        button.GetComponent<Image>().color = Color.white;
    }
}
