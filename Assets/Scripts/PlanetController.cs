using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour
{
    [SerializeField] GameObject referenceObject;
    [SerializeField] float OrbitSpeed;
    [SerializeField] float RotateSpeed;
    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    bool rotate = true;
    bool orbit = true;
    void Rotate()
    {
        if (Input.GetKeyDown(KeyCode.R))
            rotate = !rotate;
        
        if (rotate)
            transform.Rotate(transform.up * RotateSpeed * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.O))
            orbit = !orbit;

        if (orbit)
            transform.RotateAround(referenceObject.transform.position, Vector3.up, OrbitSpeed * Time.deltaTime);
    }
}
