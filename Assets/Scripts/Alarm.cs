using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(AudioSource))]
public class Alarm : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    [SerializeField] private Collider2D _targetZone;
    [SerializeField] private Collider2D _player;

    private float _maxVolume = 1.0f;
    private float _changeVolumeSpeed = 0.1f;
    private float _targetVolume = 0f;

    private bool _isPlaying = false;

    private void Update()
    {
        CheckZone();
        ChangeVolume();
    }

    private void CheckZone()
    {
        if (_targetZone.IsTouching(_player))
        {
            if (_isPlaying == false)
            {
                _sound.Play();
                _isPlaying = true;
            }

            _targetVolume = _maxVolume;
        }
        else
        {
            _targetVolume = 0f;
            _isPlaying = false;
        }
    }

    private void ChangeVolume()
    {
        _sound.volume = Mathf.MoveTowards(_sound.volume, _targetVolume,
            _changeVolumeSpeed * Time.deltaTime);
    }
}
