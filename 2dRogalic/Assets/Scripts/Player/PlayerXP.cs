using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerXP : MonoBehaviour
{
    public static float XP;
    public float maxXP;
    [SerializeField] Slider XPSlider;
    public Image panelLvl;
    public TextMeshProUGUI LVLText;
    public static float LVL = 1;
    private void Start()
    {
        maxXP = 100;
        XPSlider.maxValue = maxXP;
        if (LVL == 1)
        {
            maxXP = 100;
            XP = 0;
        }
    }
    private void Update()
    {
        if (XPSlider.value >= maxXP - 10f)
        {
            panelLvl.gameObject.SetActive(true);
            LVL++;
            SpellsPanel.isRepeat = true;
            NecrPanel.isRepeat = true;
            MonkPanel.isRepeat = true;
            Time.timeScale = 0;
            PlayerHP.HP = PlayerHP.maxHP;
            XP = 0;
            maxXP += 100;
            XPSlider.maxValue = maxXP;
        }
        LVLText.text = "LVL " + LVL;
    }
    private void OnGUI()
    {
        float t = Time.deltaTime / 0.1f;
        XPSlider.value = Mathf.Lerp(XPSlider.value, XP, t);
    }
}
