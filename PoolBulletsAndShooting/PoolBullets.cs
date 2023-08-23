using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBullets<T> : MonoBehaviour where T : Bullet
{
    private T prefab { get; set; }

    private int _countBullets { get; }

    private Transform container;

    private List<T> pool;


    public PoolBullets( T prefab, int _countBullets, Transform container)
    {
        this.prefab = prefab;
        this._countBullets = _countBullets;
        this.container = container;

        pool = new List<T>();

        CreatePool();
    }


    public void CreatePool()
    {
        for(int i = 0; i <= this._countBullets; i++)
        {
            CreateObject();
        }
    }


    public T CreateObject(bool IsActiveByDefault=false)
    {
        var creatBullet = GameObject.Instantiate(this.prefab, this.container);

        creatBullet.gameObject.SetActive(IsActiveByDefault);

        AddPool(creatBullet);

        return creatBullet;

    }

    private void AddPool( T objectForPool)
    {
        pool.Add(objectForPool);
    }


   public void EnableFreeBullet( int bullet )
    {
        {
            if (!pool[bullet].gameObject.activeInHierarchy)
            {
                pool[bullet].transform.position = container.position;
                pool[bullet].gameObject.SetActive(true);
            }
        }
    }

}
