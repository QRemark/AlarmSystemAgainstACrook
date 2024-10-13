using UnityEngine;

public class UserInput : MonoBehaviour
{
    private int _vertivcalMoveButton = 273;

    private string _horizontalMoveButtons = "Horizontal";

    public float HorizontalInput { get; private set; }

    public bool VerticalInput { get; private set; }

    void Update()
    {
        HorizontalInput = Input.GetAxis(_horizontalMoveButtons);

        VerticalInput = Input.GetKeyDown((KeyCode)_vertivcalMoveButton);
    }
}
