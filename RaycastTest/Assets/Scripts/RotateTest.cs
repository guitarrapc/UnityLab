using UnityEngine;
using System.Collections;
using UniRx;

public class RotateTest : MonoBehaviour
{
    public float Angle = 60;
    public GameObject TargetGameObject;

    private void Start()
    {      
        Observable.EveryUpdate()
            .Select(_ => gameObject.transform.TransformDirection(Vector3.up)) // determine Axis Direction
            .Subscribe(axis =>
            {
                var targetPosision = TargetGameObject.transform.position;

                // Change this gameobjects direction to the target
                gameObject.transform.LookAt(targetPosision);

                // Rotate - Stable
                gameObject.transform.RotateAround(targetPosision, axis, Angle * Time.deltaTime);

                // Rotate - Randomize
                // gameObject.transform.RotateAround(targetPosision, axis, Angle * Time.deltaTime * Random.Range(1, 2));
            })
            .AddTo(this);
    }
}
