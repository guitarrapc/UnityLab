using System.Collections;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Unitylab.GizmoHelper
{
    public class RendererBoundsGizmo : MonoBehaviour
    {
        [SerializeField] private bool showCenter;
        [SerializeField] private Color color = Color.white;
        [SerializeField] private bool drawCube = true;
        [SerializeField] private bool drawSphere = false;

        /// <summary>
        /// When the game object is selected this will draw the gizmos
        /// </summary>
        /// <remarks>Only called when in the Unity editor.</remarks>
        private void OnDrawGizmosSelected()
        {
#if UNITY_EDITOR
            Gizmos.color = this.color;

            // get renderer bonding box
            var bounds = new Bounds();
            var initBound = false;
            if (this.transform.GetBoundWithChildren(ref bounds, ref initBound))
            {
                if (this.drawCube)
                {
                    Gizmos.DrawWireCube(bounds.center, bounds.size);
                }
                if (this.drawSphere)
                {
                    Gizmos.DrawWireSphere(bounds.center, Mathf.Max(Mathf.Max(bounds.extents.x, bounds.extents.y), bounds.extents.z));
                }
            }

            if (this.showCenter)
            {
                Gizmos.DrawLine(new Vector3(bounds.min.x, bounds.center.y, bounds.center.z), new Vector3(bounds.max.x, bounds.center.y, bounds.center.z));
                Gizmos.DrawLine(new Vector3(bounds.center.x, bounds.min.y, bounds.center.z), new Vector3(bounds.center.x, bounds.max.y, bounds.center.z));
                Gizmos.DrawLine(new Vector3(bounds.center.x, bounds.center.y, bounds.min.z), new Vector3(bounds.center.x, bounds.center.y, bounds.max.z));
            }

            Handles.BeginGUI();
            var view = SceneView.currentDrawingSceneView;
            var pos = view.camera.WorldToScreenPoint(bounds.center);
            var size = GUI.skin.label.CalcSize(new GUIContent(bounds.ToString()));
            GUI.Label(new Rect(pos.x - (size.x / 2), -pos.y + view.position.height + 4, size.x, size.y), bounds.ToString());
            Handles.EndGUI();
#endif
        }
    }
}
