using System.Collections;
using System.Collections.Generic;
using EasyUI.PickerWheelUI;
using UnityEngine;
using UnityEngine.UI;


public class LuckySpin : MonoBehaviour
{
    [SerializeField] private Button m_buttonSpin;
    [SerializeField] private Text m_textSpin;
    [SerializeField] private OpenGift m_openGift;
    

    [SerializeField] private PickerWheel m_pickerWheel;
    // Start is called before the first frame update
    void Start()
    {
        m_buttonSpin.onClick.AddListener(() =>
        {
            Time.timeScale = 1;
            m_buttonSpin.interactable = false;
            m_textSpin.text = "Spinning";
            
            m_pickerWheel.OnSpinStart(() =>
            {
                Debug.Log("Spin Start..");
            });
            
            m_pickerWheel.Spin();
            
            /*m_pickerWheel.OnSpinEnd( wheelPiece =>
            {
                
                Debug.Log("Spin endd: Label: "+ wheelPiece.Label);
            
            if (wheelPiece.Label.Equals("Suriken") )
            {
                Inventory.Instance.AddSuriken();
            }else if (wheelPiece.Label.Equals("Bom"))
            {
                Inventory.Instance.AddBoom();
            }
            else if(wheelPiece.Label.Equals("Boomerang"))
            {
                Inventory.Instance.AddBoomerang();
            }else if (wheelPiece.Label.Equals("Darts"))
            {
                Inventory.Instance.AddDart();
            }else if (wheelPiece.Label.Equals("Shoes"))
            {
                Inventory.Instance.AddShoes();
            }

            m_openGift.ClosePanelGift();
            });*/
            
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
