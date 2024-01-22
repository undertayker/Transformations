using UnityEngine;

public class Move : MonoBehaviour
{
    private void Update()
    {
        var nextPosition = transform.position;
        nextPosition.z += 0.05f;
        transform.position = nextPosition;
    }
}
