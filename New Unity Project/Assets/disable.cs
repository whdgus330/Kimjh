using UnityEngine;
using System.Collections;

public class disable : MonoBehaviour {
    public GameObject Disable;
    public void OnDisable()
    {
        Disable.SetActive(false);
    }

    void Start()
    {
        StartCoroutine(Enable());
    }

    IEnumerator Enable()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);
        }
    }
}
