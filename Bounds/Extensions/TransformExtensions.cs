using UnityEngine;

namespace Unitylab
{
    public static class TransformExtentions
    {
        /// <summary>
        /// Gets the rendering bounds of the transform.
        /// </summary>
        /// <param name="transform">The game object to get the bounding box for.</param>
        /// <param name="centerBound">The bounding box reference that will </param>
        /// <param name="encapsulate">Used to determine if the first bounding box to be calculated should be encapsulated into the  argument.</param>
        /// <returns>Returns true if at least one bounding box was calculated.</returns>
        public static bool GetBoundWithChildren(this Transform transform, ref Bounds centerBound, ref bool encapsulate)
        {
            var bound = new Bounds();
            var didOne = false;

            // get 'this' bound
            var renderer = transform.gameObject.GetComponent<Renderer>();
            if (renderer != null)
            {
                bound = renderer.bounds;
                if (encapsulate)
                {
                    centerBound.Encapsulate(bound.min);
                    centerBound.Encapsulate(bound.max);
                }
                else
                {
                    centerBound.min = bound.min;
                    centerBound.max = bound.max;
                    encapsulate = true;
                }

                didOne = true;
            }

            // union with bound(s) of any/all children
            foreach (Transform child in transform)
            {
                if (GetBoundWithChildren(child, ref centerBound, ref encapsulate))
                {
                    didOne = true;
                }
            }

            return didOne;
        }
    }
}
