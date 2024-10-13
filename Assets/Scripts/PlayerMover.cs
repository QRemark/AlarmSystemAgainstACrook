using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(UserInput))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private UserInput _userInput;

    [SerializeField] private float _moveSpeed = 3.0f;
    [SerializeField] private float _jumpForce = 3.0f;

    private Rigidbody2D _playerRigidbody;

    private void Awake()
    {
        GetComponents();
    }

    private void Update()
    {
        ChangePositionX();
        ChangePositionY();
    }

    private void GetComponents()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        _userInput = GetComponent<UserInput>();
    }

    private void ChangePositionX()
    {
        Vector2 velocity = _playerRigidbody.velocity;
        velocity.x = _userInput.HorizontalInput * _moveSpeed;
        _playerRigidbody.velocity = velocity;
    }

    private void ChangePositionY() 
    {
        if (_userInput.VerticalInput)
            _playerRigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }
}
