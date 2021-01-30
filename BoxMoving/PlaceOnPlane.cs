using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceOnPlane : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 0) return;
        var touch = Input.GetTouch(index: 0);
        if (touch.phase != TouchPhase.Began) return;
        var hits = new List<ARRaycastHit>();
        if (raycastManager.Raycast(touch.position, hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinBounds))
        {
            var pose = hits[0].pose;
            Instantiate(prefab, pose.position, pose.rotation);
        }
    }
}
