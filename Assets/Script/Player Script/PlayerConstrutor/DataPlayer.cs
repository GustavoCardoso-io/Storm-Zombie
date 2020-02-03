using UnityEngine;
using UnityEngine.UI;

namespace PlayerControler
{
    public class DataPlayer : MonoBehaviour
    {
        public Player player = null;
        public Text ScorePointPlayer = null;
        public Transform lifeBar = null;
        public float sizeXBarStatus;
        public float vidaLost = 0f;
        private void Awake()
        {
            DataPlayer instance = this;
            player = new Player();
            SetScorePointPlayer();

            vidaLost = player.pontosDeVida = 5.0f;
            sizeXBarStatus = lifeBar.localScale.x;
        }

        public void SetPlayerPontos()
        {
            this.player.pontosPlayer += 100;
        }

        public void SetLifePlayer(float lostLife)
        {

            this.player.pontosDeVida -= lostLife;

        }
        public float GetLifePlayer()
        {
            return this.player.pontosDeVida;
        }
        public void SetScorePointPlayer()
        {
            ScorePointPlayer.text = player.pontosPlayer.ToString();
        }

        public void SetLifeConrollerBar()
        {
            Debug.Log(GetLifePlayer());
            sizeXBarStatus = lifeBar.localScale.x;

            sizeXBarStatus = (sizeXBarStatus * GetLifePlayer())/ vidaLost;

            lifeBar.localScale = new Vector2(sizeXBarStatus, 0.4f);
            vidaLost = GetLifePlayer();
        }
    }
}
