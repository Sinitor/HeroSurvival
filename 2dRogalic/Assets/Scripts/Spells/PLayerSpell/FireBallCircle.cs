using UnityEngine;
public class FireBallCircle : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, 1.1f + Spells.fireballMove + Time.deltaTime);
    }
}
