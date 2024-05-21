using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponNameController : MonoBehaviour
{
    public FireWeaponComponent FireWeaponComponent;
    public Text Text;

    // Start is called before the first frame update
    void Start()
    {
        if(FireWeaponComponent != null)
        {
            FireWeaponComponent.OnWeaponChanged += SetWeaponName;
        }
    }

    void SetWeaponName(string sWeaponName)
    {
        Text.text = sWeaponName;
    }
}
