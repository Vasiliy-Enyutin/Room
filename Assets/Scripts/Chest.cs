using UnityEngine;

public class Chest : MonoBehaviour, IOpenable
{
    private Animator _animator;
    private readonly int _open = Animator.StringToHash("Open");
    private readonly int _close = Animator.StringToHash("Close");


    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void Open()
    {
        _animator.SetTrigger(_open);
    }

    public void Close()
    {
        _animator.SetTrigger(_close);
    }
}
