using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGift : MonoBehaviour
{
    //[SerializeField] private GameObject m_gameObject;
    [SerializeField] private GameObject m_panelGift;
    // Start is called before the first frame update
    private void Start()
    {
        //Instantiate(m_gameObject, m_panelGift.transform);
    }

    public void ShowPanelGift()
    {
        Time.timeScale = 0;
        m_panelGift.SetActive(true);
        
    }

    public void ClosePanelGift()
    {
        m_panelGift.SetActive(false);
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
