using UnityEngine;

public class UserInput : MonoBehaviour
{
    public float HorizontalInput { get; private set; }
    public bool VerticalInput { get; private set; }

    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");

        VerticalInput = Input.GetKeyDown(KeyCode.UpArrow);
    }
}
