using UnityEngine;

public class HealthValueChanger : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private float _damage;
    [SerializeField] private float _healAmount;

    public void Increase()
    {
        _health.Heal(_healAmount);
    }

    public void Decrease()
    {
        _health.TakeDamage(_damage);
    }
}
