using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EventsGuide.UI
{
    public class CoinText : MonoBehaviour
    {
        public TextMeshProUGUI coinText; 
        void Start()
        {
            PlayerController.singleton.onCoinTake += OnPlayerCoinsChanget;
        }

        private void OnPlayerCoinsChanget(int newCoin) => coinText.text = newCoin.ToString();
    }
}
