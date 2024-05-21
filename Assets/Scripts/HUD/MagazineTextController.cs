using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class MagazineTextController : MonoBehaviour
{
    public FireWeaponComponent FireWeaponComponent;
    public Text Text;

    // Start is called before the first frame update
    void Start()
    {
        if(FireWeaponComponent != null)
        {
            FireWeaponComponent.OnFireWeapon += SetMagazineSize;
            FireWeaponComponent.OnReloadStateChanged += OnWeaponReload;
        }
    }

    void SetMagazineSize(int iCurrentMagazine, int iMagazineSize)
    {
        Text.text = " " + iCurrentMagazine + " / " + iMagazineSize;
    }

    void OnWeaponReload(bool bShowText, int iMagazineSize)
    {
        if (!bShowText)
            SetMagazineSize(iMagazineSize, iMagazineSize);
    }
}
