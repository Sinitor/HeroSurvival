using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Skin : MonoBehaviour
{
    public Image BlackPanelMage;
    public Image BlackPanelMonk;
    public Image BlackPanelNecr;
    public Image PlayerPanel;
    public GameObject NecrText;
    public GameObject MageText;
    public void Play()
    {
        if (BlackPanelMonk.isActiveAndEnabled != enabled && BlackPanelMage.isActiveAndEnabled == enabled && BlackPanelNecr.isActiveAndEnabled == enabled)
        {
            SceneManager.LoadScene(1);
        }
        if (BlackPanelMage.isActiveAndEnabled != enabled && BlackPanelNecr.isActiveAndEnabled == enabled && BlackPanelMonk.isActiveAndEnabled == enabled)
        {
            SceneManager.LoadScene(2);
        }
        if (BlackPanelNecr.isActiveAndEnabled != enabled && BlackPanelMage.isActiveAndEnabled == enabled && BlackPanelMonk.isActiveAndEnabled == enabled)
        {
            SceneManager.LoadScene(3);
        } 
    }
    public void SkinMonk()
    {
        BlackPanelMonk.gameObject.SetActive(false);
        BlackPanelMage.gameObject.SetActive(true);
        BlackPanelNecr.gameObject.SetActive(true);
    }
    public void SkinMage()
    {
        if (PlayerPrefs.GetInt("Timer") >= 5)
        {
            BlackPanelMage.gameObject.SetActive(false);
            BlackPanelNecr.gameObject.SetActive(true);
            BlackPanelMonk.gameObject.SetActive(true);
        }
    }
    public void SkinNecromancer()
    {
        if (PlayerPrefs.GetInt("Timer") >= 10)
        {
            Destroy(NecrText);
            BlackPanelNecr.gameObject.SetActive(false);
            BlackPanelMage.gameObject.SetActive(true);
            BlackPanelMonk.gameObject.SetActive(true);
        }
    }
}
