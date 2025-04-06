using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEngine;

public class CamSwitcher : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private List<CinemachineCamera> allCameras;
    [SerializeField] private CinemachineCamera defaultCam;


    private void Start()
    {
        if (defaultCam != null)
        {
            SwitchTo(defaultCam);
        }
    }

    public void SwitchTo(CinemachineCamera target)
    {
        foreach (var cam in allCameras)
        {
            cam.gameObject.SetActive(cam == target);
        }
    }
}
