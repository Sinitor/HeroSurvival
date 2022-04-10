using System.Collections;
using UnityEngine;

public class DemonSpell : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Death());
    }
    IEnumerator Death()

    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
