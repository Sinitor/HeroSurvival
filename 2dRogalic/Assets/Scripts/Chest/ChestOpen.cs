using UnityEngine;
using UnityEngine.UI;

public class ChestOpen : MonoBehaviour
{
    public Image panel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Chests")
        {
            Time.timeScale = 0;
            panel.gameObject.SetActive(true);
            ChestPanel.isRepeat = true;
        }
    }
}
