using UnityEngine;
using UnityEngine.UI;

namespace PlayerControler
{
    public class DataPlayer : MonoBehaviour
    {
        public Text ScorePointPlayer = null;
        public Player player = null;

        private void Awake()
        {
            DataPlayer instance = this;
            player = new Player();
            SetScorePointPlayer();
        }

        public void SetPlayerPontos()
        {
            this.player.pontosPlayer += 100;
        }
        
        public void SetScorePointPlayer()
        {
            ScorePointPlayer.text = player.pontosPlayer.ToString();
        }
    }
}
