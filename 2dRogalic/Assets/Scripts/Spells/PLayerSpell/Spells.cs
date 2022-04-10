using UnityEngine;
using UnityEngine.UI;
public class Spells : MonoBehaviour
{
    public static float fireballDMG;
    public static float lightingDMG;
    public static float darkDMG;
    public static float darkDelay;
    public static float lightingDelay;
    public static float dopHP;
    public static float isLighting = 0;
    public static float isDark = 0;
    public static float fireballMove; 
    [SerializeField] private GameObject panel;

    private void Start()
    {
        panel = GameObject.FindGameObjectWithTag("Panel");
    }
    private void Update()
    {
        if (PlayerXP.LVL == 1)
        {
            fireballDMG = 0;
            lightingDMG = 0;
            darkDMG = 0;
            darkDelay = 0;
            lightingDelay = 0;
            dopHP = 0;
            isLighting = 0;
            isDark = 0;
            fireballMove = 0;
        }
    }
    public void Fireball()
    {
        fireballDMG += 2;
        Time.timeScale = 1;
        panel.SetActive(false); 
    }
    public void Lighting()
    {
        lightingDMG += 1;
        Time.timeScale = 1;
        isLighting = 1;
        panel.SetActive(false);
    }
    public void DopHP()
    {
        dopHP += 20;
        Time.timeScale = 1; 
        panel.SetActive(false);
    }
    public void LightingDealy()
    {
        lightingDelay += 0.1f;
        Time.timeScale = 1;
        isLighting = 1;
        panel.SetActive(false);
    }
    public void FireballMove()
    {
        fireballMove += 0.05f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void Armor()
    {
        PlayerHP.armor += 1;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void DarkMagicDMG()
    {
        darkDMG += 2;
        isDark = 1;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void DarkMagicDelay()
    {
        darkDelay += 0.2f;
        isDark = 1;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
}
