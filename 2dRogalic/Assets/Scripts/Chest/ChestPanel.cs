using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestPanel : MonoBehaviour
{
    public Vector3 vec;
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
        panel = GameObject.FindGameObjectsWithTag("Chest");
        int limit = 1;
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
        prefabs = new List<GameObject>(Resources.LoadAll<GameObject>("Chest"));
        int count = prefabs.Count;
        if (count == 0)
        {
            return;
        }
        int i = Random.Range(0, count - 1);
        GameObject go = prefabs[i];
        prefabs.Remove(go);
        Instantiate(go, vec, Quaternion.identity, can.transform);
    } 
}
