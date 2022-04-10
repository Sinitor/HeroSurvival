using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkPanel : MonoBehaviour
{
    public Vector3 vec;
    public Vector3 vec1;
    public Vector3 vec2;
    public GameObject can;
    public List<GameObject> prefabs = null;
    public GameObject[] panel;
    public static bool isRepeat;
    private void Start()
    {
        spawnBlock();
    }
    private void Update()
    {
        panel = GameObject.FindGameObjectsWithTag("HolyText");
        int limit = 3;
        if (panel.Length > limit)
        {
            for (int i = 0; i < limit; i++)
            {
                Destroy(panel[i]);
                if (panel.Length <= limit)
                    break;
            }
        }
        if (isRepeat == true)
        {
            spawnBlock();
            isRepeat = false;
        }
    }
    private void spawnBlock()
    {
        prefabs = new List<GameObject>(Resources.LoadAll<GameObject>("SpellsMonk"));
        int count = prefabs.Count;
        if (count == 0)
        {
            return;
        }
        int i = Random.Range(0, count - 1);
        GameObject go = prefabs[i];
        prefabs.Remove(go);
        int j = Random.Range(0, count - 1);
        GameObject go1 = prefabs[j];
        prefabs.Remove(go1);
        int l = Random.Range(0, count - 1);
        GameObject go2 = prefabs[l];
        prefabs.Remove(go2);
        Instantiate(go, vec, Quaternion.identity, can.transform);
        Instantiate(go1, vec1, Quaternion.identity, can.transform);
        Instantiate(go2, vec2, Quaternion.identity, can.transform);
    }
}
