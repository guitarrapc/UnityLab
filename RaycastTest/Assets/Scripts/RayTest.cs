using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class RayTest : MonoBehaviour
{
    void Start()
    {
        RaycastHit hit;

        Observable.EveryUpdate()
            .Select(_ => new Ray(gameObject.transform.position, new Vector3(0, -1, 0)))
            .Subscribe(ray =>
            {
                if (!Physics.Raycast(ray, out hit, float.PositiveInfinity)) return;
                var heading = new Vector3(0, hit.transform.position.y, 0) - new Vector3(0, gameObject.transform.position.y, 0);
                Debug.DrawRay(gameObject.transform.position, heading, Color.red);
            })
            .AddTo(this);
    }
}
