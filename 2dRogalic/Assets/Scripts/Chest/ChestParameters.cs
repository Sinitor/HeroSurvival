using UnityEngine;
using UnityEngine.UI;

public class ChestParameters : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    public static float bootsLVL;
    public static float armorLVL;
    public static float ringLVL;
    public static float hoodLVL;
    void Start()
    {
        panel = GameObject.FindGameObjectWithTag("Panel");
    }
    private void Update()
    {
        if (PlayerXP.LVL == 1)
        {
            bootsLVL = 0;
            armorLVL = 0;
            ringLVL = 0;
            hoodLVL = 0;
        }
    }
    public void BootsLVL1()
    {
        bootsLVL += 0.1f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void BootsLVL2()
    {
        bootsLVL += 0.2f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void BootsLVL3()
    {
        bootsLVL += 0.3f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void BootsLVL4()
    {
        bootsLVL += 0.4f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void ArmorLVL1()
    {
        armorLVL += 0.2f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void ArmorLVL2()
    {
        armorLVL += 0.3f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void ArmorLVL3()
    {
        armorLVL += 0.4f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void ArmorLVL4()
    {
        armorLVL += 0.5f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void RingLVL1()
    {
        ringLVL += 0.2f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void RingLVL2()
    {
        ringLVL += 0.3f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void RingLVL3()
    {
        ringLVL += 0.4f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void RingLVL4()
    {
        ringLVL += 0.5f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void HoodLVL1()
    {
        hoodLVL += 0.2f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void HoodLVL2()
    {
        hoodLVL += 0.3f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void HoodLVL3()
    {
        hoodLVL += 0.4f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
    public void HoodLVL4()
    {
        hoodLVL += 0.5f;
        Time.timeScale = 1;
        panel.SetActive(false);
    }
}
