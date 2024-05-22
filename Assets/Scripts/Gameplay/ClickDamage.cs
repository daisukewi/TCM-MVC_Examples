using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HealthPresenter))]
public class ClickDamage : MonoBehaviour
{
    private HealthPresenter healthPresenter;
    [SerializeField] private LayerMask layerToClick;
    [SerializeField] private int damageValue = 10;

    private void Start()
    {
        healthPresenter = GetComponent<HealthPresenter>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 screenPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		    if (Physics2D.Raycast(screenPos, Vector2.zero))
            {
                healthPresenter?.Damage(damageValue);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            healthPresenter?.Reset();
        }
    }
}
