using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class MagazineTextController : MonoBehaviour
{
    public FireWeaponComponent FireWeaponComponent;
    public Text Text;

    private int _magazineSize;

    // Start is called before the first frame update
    void Start()
    {
        if(FireWeaponComponent != null)
        {
            FireWeaponComponent.OnWeaponChanged += SetMagazineSize;
            FireWeaponComponent.OnFireWeapon += ChangeMagazineAmount;
            FireWeaponComponent.OnReloadStateChanged += OnWeaponReload;
        }
    }

    void SetMagazineSize(string sWeaponName, int iMagazieSize)
    {
        _magazineSize = iMagazieSize;
        ResetMagazineAmount();
    }

    void ChangeMagazineAmount(int iCurrentMagazine)
    {
        Text.text = iCurrentMagazine + " / " + _magazineSize;
    }

    void OnWeaponReload(bool bShowText)
    {
        if (!bShowText)
            ResetMagazineAmount();
    }

    void ResetMagazineAmount()
    {
        ChangeMagazineAmount(_magazineSize);
    }
}
