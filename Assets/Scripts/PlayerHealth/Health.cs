using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int MaxHealth => _maxHealth;

    [SerializeField] private int _maxHealth = 3;
    private int _currentHealth;

    public UnityEvent OnDamaged;
    public UnityEvent OnDeath;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void Damage(int amount)
    {
        _currentHealth -= amount;
        if (_currentHealth <= 0)
        {
            OnDeath?.Invoke();
        }
        OnDamaged?.Invoke();
    }

    public void heal(int amount)
    {
        _currentHealth = Mathf.Min(_maxHealth, _currentHealth + amount);
    }

    public void killPlayer()
    {
        Damage(_currentHealth);
    }


}
