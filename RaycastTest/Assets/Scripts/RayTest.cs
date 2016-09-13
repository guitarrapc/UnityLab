using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;

public class RayTest : MonoBehaviour
{
    void Update()
    {
        RaycastHit hit;
        var downRay = new Ray(gameObject.transform.position, new Vector3(0, -1, 0));
        if (Physics.Raycast(downRay, out hit, float.PositiveInfinity))
        {
            var heading = new Vector3(0, hit.transform.position.y, 0) - new Vector3(0, gameObject.transform.position.y, 0);
            Debug.DrawRay(gameObject.transform.position, heading, Color.red);
        }
    }
}
