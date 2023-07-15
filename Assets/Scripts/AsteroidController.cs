using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    Vector3 firstPosition;
    void Start()
    {
        firstPosition = transform.position;
    }

    void Update()
    {
        Lerping();
    }

    float timeElapsed = 0;
    [SerializeField] float duration;
    [SerializeField] Vector3 targetPosition;
    void Lerping()
    {
        if (timeElapsed < duration)
        {
            transform.position = Vector3.Lerp(firstPosition, targetPosition, timeElapsed / duration);
            timeElapsed += Time.deltaTime;
        }
        else if (timeElapsed < duration * 2)
        {
            transform.position = Vector3.Lerp(targetPosition, firstPosition, (timeElapsed - duration) / duration);
            timeElapsed += Time.deltaTime;
        }
        else
            timeElapsed = 0;
    }

    void OnTriggerEnter(Collider collider)
    {
        gameObject.SetActive(false);
    }
}
