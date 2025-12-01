using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
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
        OnDamaged?.Invoke();
        Debug.Log(_currentHealth);
    }

    public void heal(int amount)
    {
        _currentHealth = Mathf.Min(_maxHealth, _currentHealth + amount);
    }

    public void killPlayer()
    {
        Damage(_currentHealth);
        OnDeath?.Invoke();
    }


}
