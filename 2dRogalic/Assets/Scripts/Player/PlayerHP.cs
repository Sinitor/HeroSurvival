using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public static float HP;
    public static float maxHP = 150;
    public static float armor = 2;
    [SerializeField] Slider HPSlider;
    private void Start()
    { 
        HP = maxHP;
        HPSlider.maxValue = maxHP; 
    }
    private void Update()
    {
        maxHP += Spells.dopHP;
    }
    private void OnGUI()
    {
        float t = Time.deltaTime / 0.1f;
        HPSlider.value = Mathf.Lerp(HPSlider.value, HP, t);
    }
}
