using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder :MonoBehaviour
{
    [SerializeField] private  int _countBullets;

    public int CountBullets { get => _countBullets; }

    public int _currentIndexBullet { get; set; }


    public  void GunCartridgeReload()
    {
        if (_currentIndexBullet >= CountBullets || _currentIndexBullet < CountBullets)
        {
            if (Input.GetKeyDown(KeyCode.R))
                      _currentIndexBullet = 0;
        }
    }




}
