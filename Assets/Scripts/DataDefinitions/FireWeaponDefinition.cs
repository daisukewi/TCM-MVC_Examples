using UnityEngine;

//This allows us to create new definitions directly by right clicking on the assets folder
[CreateAssetMenu(fileName = "New Weapon Definition", menuName = "Weapon/Add Fire Weapon Definition")]
public class FireWeaponDefinition : ScriptableObject
{
    [Tooltip("What is the name of the weapon")]
    public string Name;
    [Tooltip("Which bullet shall be spawned by this weapon")]
    public GameObject AmmunitionPrefab;
    [Tooltip("Time between shoots")]
    public float FireCooldown;
    [Tooltip("Time to reload the weapon")]
    public float ReloadTime;
    [Tooltip("Max amount of bullets that can be shooted without reloading")]
    public int ClipSize;
}
