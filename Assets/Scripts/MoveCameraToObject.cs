using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MoveCameraToObject : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera camera;
    [SerializeField] private Transform targetPostiton, targetLook;
    [SerializeField] private DragMove move;

    private void OnMouseDown()
    {
        camera.Follow = targetPostiton;
        camera.LookAt = targetLook;
        move.SetUnder(transform.position);
    }
}
