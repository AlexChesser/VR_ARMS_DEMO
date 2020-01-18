using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRIK : MonoBehaviour
{
    private Animator animator;
    private float IKWeight = 1.0f;
    [SerializeField] private Transform IKTarget_Head;
    [SerializeField] private Transform IKTarget_LH;
    [SerializeField] private Transform IKTarget_RH;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        animator.SetLookAtWeight(IKWeight);
        animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, IKWeight);
        animator.SetIKPositionWeight(AvatarIKGoal.RightHand, IKWeight);
        animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, IKWeight);
        animator.SetIKRotationWeight(AvatarIKGoal.RightHand, IKWeight);

        animator.SetLookAtPosition(IKTarget_Head.position);
        animator.SetIKPosition(AvatarIKGoal.LeftHand, IKTarget_LH.position);
        animator.SetIKPosition(AvatarIKGoal.RightHand, IKTarget_RH.position);
        animator.SetIKRotation(AvatarIKGoal.LeftHand, IKTarget_LH.rotation);
        animator.SetIKRotation(AvatarIKGoal.RightHand, IKTarget_RH.rotation);
    }
}
