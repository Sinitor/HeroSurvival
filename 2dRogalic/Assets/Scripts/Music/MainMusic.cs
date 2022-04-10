using UnityEngine;

public class MainMusic : MonoBehaviour
{
    [SerializeField] private AudioSource mainMusic;
    private void Update()
    {
        if (PlayerHP.HP <= 0)
        {
            mainMusic.Pause();
        }
    }
}
