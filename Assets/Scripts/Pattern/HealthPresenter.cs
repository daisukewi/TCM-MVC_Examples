using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// The Presenter. This listens for View changes in the user interface and the manipulates the Model (Health)
// in response. The Presenter updates the View when the Model changes.
public class HealthPresenter : MonoBehaviour
{
    [Header("Model")]
    [SerializeField] Health health;

    [Header("View")]
    [SerializeField] RectTransform healthUI;
    [SerializeField] RectTransform healthBar;
    [SerializeField] RectTransform healthValue;

    private void Start()
    {
        if (health != null)
        {
            health.HealthChanged += OnHealthChanged;
        }

        Reset();
    }

    private void OnDestroy()
    {
        if (health != null)
        {
            health.HealthChanged -= OnHealthChanged;
        }
    }

    // send damage to the model
    public void Damage(int amount)
    {
        health?.Decrement(amount);
    }

    public void Heal(int amount)
    {
        health?.Increment(amount);
    }

    // send reset to the model
    public void Reset()
    {
        health?.Restore();
    }

    public void UpdateView()
    {
        if (health == null)
            return;

        // format the data for view
        if (healthBar !=null && healthValue != null && health.MaxHealth != 0)
        {
            float newWidht = healthBar.rect.width * (health.CurrentHealth / (float)health.MaxHealth);
            healthValue.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, newWidht);
        }
    }

    // listen for model changes and update the view
    public void OnHealthChanged()
    {
        UpdateView();
    }

    void Update()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        healthUI.SetPositionAndRotation(screenPos, healthUI.rotation);
    }
}
