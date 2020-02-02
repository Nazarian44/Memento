using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //[SerializeField] private float zoomSpeed = 10;
    //private Camera camera;
    //private float targetZoom;
    //private float zoomFactor = 3f;

    //void Start()
    //{
    //    camera = Camera.main;
    //    targetZoom = camera.orthographicSize;
    //}

    public void Zoom()
    {
        Camera.main.orthographicSize += 1f;
        Debug.Log("ZoomWithCollision working");
    }
    //public void zoomWithCollision()
    //{
    //    targetZoom -=  zoomFactor;
    //    targetZoom = Mathf.Clamp(targetZoom, 4.5f, 28f);
    //    camera.orthographicSize = Mathf.Lerp(camera.orthographicSize, targetZoom, Time.deltaTime * zoomSpeed);
    //}

    //private void Update()
    //{
    //    float scrollData;
    //    scrollData = Input.GetAxis("Mouse ScrollWheel");

    //    targetZoom -= scrollData * zoomFactor;
    //    targetZoom = Mathf.Clamp(targetZoom, 4.5f, 8f);
    //    camera.orthographicSize = Mathf.Lerp(camera.orthographicSize, targetZoom, Time.deltaTime * zoomSpeed);
    //}

}
