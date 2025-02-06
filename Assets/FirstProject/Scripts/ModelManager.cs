using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ModelManager : MonoBehaviour
{
    [SerializeField] private Animator _Animator;
    [SerializeField] private Button _buttonIdle;
    [SerializeField] private Button _buttonRun;
    [SerializeField] private Button _buttonJump;
    // Start is called before the first frame update
    void Start()
    {
        //_Animator.SetTrigger("Idle");
        //_Animator.Play("Idle");
        _buttonIdle.onClick.AddListener(PlayIdle);
        _buttonRun.onClick.AddListener(PlayRun);
        _buttonJump.onClick.AddListener(PlayJump);
    }
    private void OnDestroy()
    {
        _buttonIdle.onClick.RemoveAllListeners();
        _buttonRun.onClick.RemoveAllListeners();
        _buttonJump.onClick.AddListener(PlayJump);
    }
    private void PlayIdle()
    {
        _Animator.Play("Idle", 0, 0);


        //_Animator.Play("Idle");
        //_Animator.CrossFade("Idle", 0.1f,0);
        //_Animator.ResetTrigger("Jump");
        //_Animator.ResetTrigger("Run");
        //_Animator.SetTrigger("Idle");
    }
    private void PlayJump()
    {
        _Animator.Play("Jump", 0, 0);

        //_Animator.Play("Jump");
        //_Animator.CrossFade("Jump", 0.1f,0);
        //_Animator.ResetTrigger("Idle");
        //_Animator.ResetTrigger("Run");
        //_Animator.SetTrigger("Jump");
    }
    private void PlayRun()
    {
        _Animator.Play("Run", 0, 0);
 

        //_Animator.Play("Run");
        //_Animator.CrossFade("Run", 0.1f, 0);
        //_Animator.ResetTrigger("Idle");
        //_Animator.ResetTrigger("Jump");
        //_Animator.SetTrigger("Run");
    }

}
