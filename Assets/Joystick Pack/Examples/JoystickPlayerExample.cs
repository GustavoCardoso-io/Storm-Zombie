using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  PlayerControler;

public class JoystickPlayerExample : MonoBehaviour
{
    public float velocidade = 2f;
    private Rigidbody2D rb = null;
    public Animator anim;
    public DataPlayer dataPlayer;
    //private float velocidadeMaxima = 1f;
    [SerializeField] private VariableJoystick variableJoystick = null;
    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        dataPlayer =  GameObject.FindGameObjectWithTag("DataPlayer").GetComponent<DataPlayer>();
    }
    public void LateUpdate()
    {
        rb.velocity = new Vector3(variableJoystick.Horizontal * velocidade, variableJoystick.Vertical * velocidade, rb.velocity.x);
        rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * velocidade, Input.GetAxisRaw("Vertical") * velocidade, rb.velocity.x);
        if (variableJoystick.Horizontal < 0f || Input.GetAxisRaw("Horizontal") < 0f)
        {
            Vector3 temp = transform.localScale;
            temp.x = -4.0f;
            transform.localScale = temp;
        }
        else if (variableJoystick.Horizontal > 0f || Input.GetAxisRaw("Horizontal") > 0f)
        {
            Vector3 temp = transform.localScale;
            temp.x = 4.0f;
            transform.localScale = temp;
        }
        StartCoroutine(PlayerPisca());
    }
    private IEnumerator PlayerPisca()
    {
        yield return new WaitForSeconds(1f);
        anim.SetBool("Piscando", true);
        yield return new WaitForSeconds(1f);
        StopCoroutine(PlayerPisca());
        anim.SetBool("Piscando", false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enimigo")
        {
            dataPlayer.SetLifePlayer(1f);

            dataPlayer.SetLifeConrollerBar();
        }
    }
}