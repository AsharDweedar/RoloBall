using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    private int wallet;
    public Text countTxt;

    void Start()
    {
        wallet = 0;
        SetTxt();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            wallet += 1;
            SetTxt();
        }
        
    }

    private void SetTxt()
    {
        countTxt.text = "Coins : " + wallet.ToString();
    }
}
