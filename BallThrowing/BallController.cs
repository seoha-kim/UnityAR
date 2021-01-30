using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : BoxController
{
    private Vector2 _inputPositionPivot;

    protected override void OnPut(Vector3 pos)
    {
        var rigidbody = HoldingObject.GetComponent<Rigidbody>();
        rigidbody.useGravity = true;
        var direction = mainCamera.transform.TransformDirection(Vector3.forward).normalized;
        var delta = (pos.y - _inputPositionPivot.y) * 100f / Screen.height;
        rigidbody.AddForce((direction + Vector3.up) * 4.5f * delta);
        HoldingObject.transform.SetParent(null);
        _inputPositionPivot.y = pos.y;
    }

    protected override void OnHold()
    {
        _inputPositionPivot = InputPosition;
    }
}
