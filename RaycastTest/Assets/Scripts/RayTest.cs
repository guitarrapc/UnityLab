using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class RayTest : MonoBehaviour
{
    public GameObject TargetGameObject;

    void Start()
    {
        RaycastHit hit;

        Observable.EveryUpdate()
            .Select(_ => new Ray(gameObject.transform.position, TargetGameObject.transform.position - gameObject.transform.position))
            .Subscribe(ray =>
            {
                //Debug.DrawRay(gameObject.transform.position, TargetGameObject.transform.position - gameObject.transform.position, Color.green);
                //Debug.DrawRay(gameObject.transform.position, TargetGameObject.transform.position, Color.green);
                if (!Physics.Raycast(ray, out hit, float.PositiveInfinity)) return;
                var heading = hit.transform.position - gameObject.transform.position;
                Debug.DrawRay(gameObject.transform.position, heading, Color.red);
            })
            .AddTo(this);
    }
}
