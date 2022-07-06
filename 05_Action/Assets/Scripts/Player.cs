using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameObject weapon;
    GameObject shield;

    private void Awake()
    {
        weapon = GetComponentInChildren<FindWeapon>().gameObject;
        shield = GetComponentInChildren<FindShield>().gameObject;
    }

    public void ShowWeapons(bool isShow)
    {
        weapon.SetActive(isShow);
        shield.SetActive(isShow);
    }
}
