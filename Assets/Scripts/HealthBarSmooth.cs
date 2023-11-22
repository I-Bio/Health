using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmooth : MonoBehaviour
{
    [SerializeField] private Slider _bar;
    [SerializeField] private Health _health;
    [SerializeField] private float _speed;
    
    private void Update()
    {
        _bar.value = Mathf.MoveTowards(_bar.value, _health.CurrentHealth, _speed);
    }
}
