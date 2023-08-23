using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinthCaliberBullet :  Bullet
{
    private const int _speed = 50;

    private void OnEnable()
    {
        StartCoroutine(LifieRoutine());
    }

    private void OnDisable()
    {
        StopCoroutine(LifieRoutine());
    }

    private IEnumerator LifieRoutine()
    {
        yield return new WaitForSecondsRealtime(3);
        Disable();
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime *_speed);
    }
}
