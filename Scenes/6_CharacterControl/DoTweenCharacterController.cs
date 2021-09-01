using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenCharacterController : CharacterController
{
    protected override void Rotate()
    {
        var direction = Destination.position - transform.position;
        direction.y = 0;

        transform.DORotateQuaternion(Quaternion.LookRotation(direction), 0.5f);
    }

    protected override void MoveTo(Vector3 target)
    {
        const float speed = 0.5f; // 1초에 0.5m 이동
        // speed = distance / time
        // time = distance / speed
        var distance = Vector3.Distance(transform.position, target);
        transform.DOMove(target, distance / speed);
    }
}
