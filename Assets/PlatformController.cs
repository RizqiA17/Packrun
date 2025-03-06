using UnityEngine;
using UtilitiesPack;

public class PlatformController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Utilities.SmoothTransitionFloat(transform.position.x, transform.position.x - 10), 0, 0);
    }
}
