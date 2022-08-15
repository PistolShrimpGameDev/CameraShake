using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPound : MonoBehaviour
{
    public GameObject mainCamera;
    public CameraShake cameraShake;
    private void Start() 
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera") as GameObject;
        cameraShake = mainCamera.GetComponent<CameraShake>() as CameraShake;
    }

    public void ExecuteGroundPound()
    {
        StartCoroutine(cameraShake.Shake(0.2f,0.5f));
    }
}
