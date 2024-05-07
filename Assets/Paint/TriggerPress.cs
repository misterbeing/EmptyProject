using UnityEngine.InputSystem;
//using UnityEngine.InputSystem.XR;
using UnityEngine;
using PaintIn3D;

public class TriggerPress : MonoBehaviour
{
    public InputDevice xrController;
    public InputAction triggerAction;

    public ParticleSystem particleSystem;
    public CwPaintSphere cwPaintSphere;

    [Range(0,1)]
    public float range;

    private void Start()
    {
        // Get the InputDevice representing the XR controller
        xrController = InputSystem.GetDevice<InputDevice>("XRController");

        // You may need to adjust the string "XRController" to match your actual XR controller name in Input System

        // Define the trigger button action
        triggerAction = new InputAction(binding: "<XRController>/trigger", type: InputActionType.Value);
        triggerAction.Enable();
    }

    private void Update()
    {
        // Check if the trigger button is pressed
        if (triggerAction.ReadValue<float>() > 0.0f)
        {
            // Trigger button is pressed
            Debug.Log("Trigger button pressed!");
        }

        range=triggerAction.ReadValue<float>();
        cwPaintSphere.Color = new Color(cwPaintSphere.Color.r, cwPaintSphere.Color.g , cwPaintSphere.Color.b  ,range);
        particleSystem.startColor = new Color(cwPaintSphere.Color.r, cwPaintSphere.Color.g, cwPaintSphere.Color.b, range);
    }

    private void OnDisable()
    {
        // Disable the trigger action when the script is disabled or destroyed
        triggerAction.Disable();
    }
}
