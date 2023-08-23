using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShooting : MonoBehaviour
{
    [SerializeField] private Bullet prefab;
    [SerializeField] private Transform containde;
    [SerializeField]  private Holder holder;

    private PoolBullets<Bullet> pool;


    void Start()
    {
        var countBullets = holder.CountBullets;
       pool = new PoolBullets<Bullet>(prefab, countBullets, containde);
    }


    void Update()
    {

        Shooting();

        holder.GunCartridgeReload();

    }


    private void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space) && holder._currentIndexBullet <= holder.CountBullets)
        {
            pool.EnableFreeBullet(holder._currentIndexBullet);
            holder._currentIndexBullet++;
        }
    }


    
}
