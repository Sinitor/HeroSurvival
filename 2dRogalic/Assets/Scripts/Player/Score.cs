using System.Collections;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private int sec = 0;
    private int min = 0;
    private int delta = 1;
    public TextMeshProUGUI TimerText;

    private void Start()
    {
        StartCoroutine(Timer());
    } 
    IEnumerator Timer()
    {
        while (true)
        {
            if (sec == 59)
            {
                min++;
                sec = -1;
            }
            sec += delta;
            TimerText.text = min.ToString("D2") + " : " + sec.ToString("D2");
            yield return new WaitForSeconds(1);
        }
    }
    private void Update()
    {
        if (min > PlayerPrefs.GetInt("Timer"))
        {
            PlayerPrefs.SetInt("Timer", min);
        }
    }
}
