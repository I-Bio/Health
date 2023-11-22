using TMPro;
using UnityEngine;

public class HealthView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _maxHealth;
    [SerializeField] private TextMeshProUGUI _currentHealth;
    [SerializeField] private Health _health;
    
    private void OnEnable()
    {
        _health.Changed += OnChanged;
    }

    private void OnDisable()
    {
        _health.Changed -= OnChanged;
    }

    private void OnChanged()
    {
        _maxHealth.SetText(_health.MaxHealth.ToString());
        _currentHealth.SetText(_health.CurrentHealth.ToString());
    }
}
