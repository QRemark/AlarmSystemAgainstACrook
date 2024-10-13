using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(AlarmSoundMaker))]
public class Alarm : MonoBehaviour
{
    [SerializeField] private Collider2D _targetZone;
    [SerializeField] private Collider2D _player;
    [SerializeField] private AlarmSoundMaker _alarmSoundMaker;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == _player)
            _alarmSoundMaker.PlayMaxVolume();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision == _player)
            _alarmSoundMaker.MakeMinVolume();
    }
}
