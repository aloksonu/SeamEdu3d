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
        _Animator.SetTrigger("Idle");
        //_Animator.Play("Idle");
        _buttonIdle.onClick.AddListener(PlayIdle);
        _buttonRun.onClick.AddListener(PlayRun);
        _buttonJump.onClick.AddListener(PlayJump);
    }
    private void OnDestroy()
    {
        _buttonIdle.onClick.RemoveAllListeners();
        _buttonIdle.onClick.RemoveAllListeners();
    }
    private void PlayIdle()
    {
        _Animator.SetTrigger("Idle");
        //_Animator.Play("Idle");
    }
    private void PlayJump()
    {
        //_Animator.SetTrigger("Jump");
        //_Animator.Play("Jump");
    }
    private void PlayRun()
    {
        _Animator.SetTrigger("Run");
        //_Animator.Play("Drunk Run Forward");
    }

}
